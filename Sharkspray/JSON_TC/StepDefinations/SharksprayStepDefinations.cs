
using OpenQA.Selenium;
using Sharkspray.JSON_TC.Helper;
using System;
using System.Configuration;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace Sharkspray.JSON_TC.StepDefinations
{
    [Binding]
    public class SharksprayAutomationSteps
    {
        
        protected static string path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
        
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
        }
        
        [Then(@"I select (.*) from sheet\.")]
        public void ThenISelectFromSheet_(string deformation_mode)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Clicked on the genrate constitutive mechanical model button\.")]
        public void ThenClickedOnTheGenrateConstitutiveMechanicalModelButton_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"On visualize model page click on the save chart as png button\.")]
        public void ThenOnVisualizeModelPageClickOnTheSaveChartAsPngButton_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Click on export and save model check-box and description\.")]
        public void ThenClickOnExportAndSaveModelCheck_BoxAndDescription_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Click on the save select model button and verify it\.")]
        public void ThenClickOnTheSaveSelectModelButtonAndVerifyIt_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Click on the export external data package\(\*\.ZIP\) and verify if it downloaded\.")]
        public void ThenClickOnTheExportExternalDataPackage_ZIPAndVerifyIfItDownloaded_()
        {
            ScenarioContext.Current.Pending();
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
