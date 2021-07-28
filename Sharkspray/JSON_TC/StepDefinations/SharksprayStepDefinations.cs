
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sharkspray.JSON_TC.Helper;
using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Threading;
using TechTalk.SpecFlow;

namespace Sharkspray.JSON_TC.StepDefinations
{
    [Binding]
    public class SharksprayAutomationSteps
    {
        IWebDriver webDriver;
        public static string _rootPath = AppDomain.CurrentDomain.BaseDirectory;
        public static string WebZipPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\JSON_TC\\Web_files\\Web_Zipped");
        public static string WebExtractPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\JSON_TC\\Web_files\\Web_UnZipped");
        [Given(@"I have navigated to Sharkspray Web Application\.")]
        public void GivenIHaveNavigatedToSharksprayWebApplication_()
        {
            BrowserConfig.Init();
            BrowserConfig.login();
        }
        
        [Then(@"I set (.*) and (.*) from sheet\.")]
        public void ThenISetAndFromSheet_(string adesivetype, string modelphase)
        {
            CreateDropdowns cd = new CreateDropdowns();
            cd.Setadhesivedropdowns(adesivetype, BrowserConfig.webDriver);
            cd.Setmodelphasedropdown(modelphase, BrowserConfig.webDriver);
        }
        
        [Then(@"I compare (.*),(.*) and (.*) from the sheet and upload it\.")]
        public void ThenICompareAndFromTheSheetAndUploadIt_(string dma_filename, string compression_filename, string tension_filename)
        {
            CreateDropdowns cd = new CreateDropdowns();
            cd.FileUpload(dma_filename, compression_filename, tension_filename);
            ExplicitWaiting.waitForTime(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)BrowserConfig.webDriver;
            IWebElement element = BrowserConfig.webDriver.FindElement(By.XPath(ObjectIdentifiers._generateConstitutiveModelBtn));
            js.ExecuteScript("arguments[0].scrollIntoView(true); ", element);
        }
        
        [Then(@"I select (.*) from sheet\.")]
        public void ThenISelectFromSheet_(string deformation_mode)
        {
            if (deformation_mode != "auto")
            {
                CreateDropdowns cd = new CreateDropdowns();
                cd.deformationmode(deformation_mode,BrowserConfig.webDriver);
            }
            else
            {
                //go with the default value 
            }
        }
        
        [Then(@"Clicked on the genrate constitutive mechanical model button\.")]
        public void ThenClickedOnTheGenrateConstitutiveMechanicalModelButton_()
        {
            ExplicitWaiting.waitForTime(2000);
            BrowserConfig.webDriver.FindElement(By.XPath("//div[@class='jss532 jss534 jss533 jss580 jss576']"));
            BrowserConfig.webDriver.FindElement(By.XPath(ObjectIdentifiers._generateConstitutiveModelBtn)).Click();
        }
        
        [Then(@"On visualize model page click on the save chart as png button\.")]
        public void ThenOnVisualizeModelPageClickOnTheSaveChartAsPngButton_()
        {
            //ExplicitWaiting.waitForAnElementUntilClickable(ObjectIdentifiers._saveChartBtn);
            WebDriverWait wait = new WebDriverWait(BrowserConfig.webDriver, TimeSpan.FromMinutes(2));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(ObjectIdentifiers._saveChartBtn)));
            BrowserConfig.webDriver.FindElement(By.XPath(ObjectIdentifiers._saveChartBtn)).Click();
        }
        
        [Then(@"Click on export and save model check-box and description\.")]
        public void ThenClickOnExportAndSaveModelCheck_BoxAndDescription_()
        {
            BrowserConfig.webDriver.FindElement(By.XPath(ObjectIdentifiers._modelNameSelectButton)).Click();
            IWebElement saveSelectModelelement = BrowserConfig.webDriver.FindElement(By.XPath(ObjectIdentifiers._saveSelectedModelsButton));
            HelpFunction.SaveSelectedModelsVisible(saveSelectModelelement);
            
        }
        
        [Then(@"Click on the save select model button and verify it\.")]
        public void ThenClickOnTheSaveSelectModelButtonAndVerifyIt_()
        {
            //BrowserConfig.webDriver.FindElement(By.XPath(ObjectIdentifiers._saveSelectedModelsButton)).Click();
            ExplicitWaiting.waitForTime(2000);
            //IWebElement tickElement2 = BrowserConfig.webDriver.FindElement(By.CssSelector(ObjectIdentifiers._tick));
            //String colour = tickElement2.GetAttribute("style");
            //Assert.AreEqual(colour, "fill: green;");
        }
        
        [Then(@"Click on the export external data package\(\*\.ZIP\) and verify if it downloaded\.")]
        public void ThenClickOnTheExportExternalDataPackage_ZIPAndVerifyIfItDownloaded_()
        {
            BrowserConfig.filedownloadverification();
            //HelpFunction hp = new HelpFunction();
            //hp.filedownloadverification();
        }
        
        [Then(@"Extract the downloaded file\.")]
        public void ThenExtractTheDownloadedFile_()
        {
            string WebZipPath1 = WebZipPath + @"\oca2_dma_External_ModelFiles.zip";
            bool WebZipPathverify= (System.IO.Directory.Exists(WebZipPath1) ? true : false);
            if (WebZipPathverify)
            {
               //Directory already exists
                System.IO.File.Delete(WebZipPath1);
            }
            else
            {
                Directory.CreateDirectory(WebZipPath1);
            }
            bool WebExtractPathverify= (System.IO.Directory.Exists(WebExtractPath) ? true : false);
            if (WebExtractPathverify)
            {
                //Directory already exists
                System.IO.File.Delete(WebExtractPath);
            }
            else
            {
                Directory.CreateDirectory(WebExtractPath);
            }
            ZipFile.ExtractToDirectory(WebZipPath, WebExtractPath);
        }
        
        [Then(@"Remove unnecessary lines from web_file & (.*) before comparison\.")]
        public void ThenRemoveUnnecessaryLinesFromWeb_FileBeforeComparison_(string refrenece_file,string download_file)
        {
            //CompareHashcodegenerate com = new CompareHashcodegenerate();
            //com.Hashcalulation(refrenece_file,download_file);
        }



        [Then(@"Comapre external downloaded zip file with (.*) file")]
        public void ThenComapreExternalDownloadedZipFileWithFile(string ref_filename)
        {

            
        }
    }
}
