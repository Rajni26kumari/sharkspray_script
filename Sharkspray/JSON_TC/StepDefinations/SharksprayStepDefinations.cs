
using NUnit.Framework;
using OpenQA.Selenium;
using Sharkspray.JSON_TC.Helper;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Threading;
using TechTalk.SpecFlow;

namespace Sharkspray.JSON_TC.StepDefinations
{
    [Binding]
    public class SharksprayAutomationSteps
    {
 
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
            BrowserConfig.webDriver.FindElement(By.XPath(ObjectIdentifiers._generateConstitutiveModelBtn)).Click();           
        }
        
        [Then(@"On visualize model page click on the save chart as png button\.")]
        public void ThenOnVisualizeModelPageClickOnTheSaveChartAsPngButton_()
        {
            ExplicitWaiting.waitForTime(10000);
            BrowserConfig.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            //ExplicitWaiting.waitForAnElementUntilClickable(ObjectIdentifiers._saveChartBtn);
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
            BrowserConfig.webDriver.FindElement(By.XPath(ObjectIdentifiers._saveSelectedModelsButton)).Click();
            ExplicitWaiting.waitForTime(3000);
            IWebElement tickElement2 = BrowserConfig.webDriver.FindElement(By.CssSelector(ObjectIdentifiers._tick));
            String colour = tickElement2.GetAttribute("style");
            Assert.AreEqual(colour, "fill: green;");
        }
        
        [Then(@"Click on the export external data package\(\*\.ZIP\) and verify if it downloaded\.")]
        public void ThenClickOnTheExportExternalDataPackage_ZIPAndVerifyIfItDownloaded_()
        {
            HelpFunction hp = new HelpFunction();
            hp.filedownloadverification(BrowserConfig.webDriver);
        }
        
        [Then(@"Extract the downloaded file\.")]
        public void ThenExtractTheDownloadedFile_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Comapre external downloaded zip file with (.*) file")]
        public void ThenComapreExternalDownloadedZipFileWithFile(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
