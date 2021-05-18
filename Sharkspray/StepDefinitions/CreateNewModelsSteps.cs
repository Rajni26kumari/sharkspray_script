using OpenQA.Selenium;
using Sharkspray.Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Sharkspray.StepDefinitions
{
    [Binding]
    
    public sealed class CreateNewModelsSteps
    {
        
        [Given(@"Go to url\.")]
        public void GivenGoToUrl_()
        {
            BrowserConfig.Init(); 
        }

        [When(@"user login with credentials")]
        public void WhenUserLoginWithCredentials()
        {
            BrowserConfig.login();
            
        }

        [Then(@"After landing on sharkspray page, click on AdhesiveType Dropdown\.")]
        public void ThenAfterLandingOnSharksprayPageClickOnAdhesiveTypeDropdown_()
        {
            ExplicitWaiting.waitForAnElementUntilClickable(ObjectIdentifiers._adhesiveDropdown);
        }

        [Then(@"Select adhesive type from dropdown\.")]
        public void ThenSelectAdhesiveTypeFromDropdown_(Table table)
        {
            ExplicitWaiting.waitForTime(2000);
            GetValues _adhesive = table.CreateInstance<GetValues>();
            HelpingFunctions.SelectAdhesiveType(_adhesive.AdhesiveType);
        }
        [Then(@"click on Model Phase Dropdown\.")]
        public void ThenClickOnModelPhaseDropdown_()
        {
            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._modelPhaseDropdown);
        }

        [Then(@"Select Model Phase from dropdown\.")]
        public void ThenSelectModelPhaseFromDropdown_(Table table)
        {
            ExplicitWaiting.waitForTime(2000);
            GetValues _model = table.CreateInstance<GetValues>();
            HelpingFunctions.SelectModelPhase(_model.ModelPhase);
        }
        [Then(@"Click on Division Dropdown\.")]
        public void ThenClickOnDivisionDropdown_()
        {
            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._divisionDropdown);
        }

        [Then(@"Select Division from dropdown\.")]
        public void ThenSelectDivisionFromDropdown_(Table table)
        {
            ExplicitWaiting.waitForTime(2000);
            GetValues _division = table.CreateInstance<GetValues>();
            HelpingFunctions.SelectDivision(_division.Division);
        }

        [Then(@"click on drop DMA files button and upload file\.")]
        public void ThenClickOnDropDMAFilesButtonAndUploadFile_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._dropDmaFilesIdentifier)).Click();
            ExplicitWaiting.waitForTime(2000);
            Process.Start(@"F:\3M-projects\sharkspray\FileUpload.exe");
        }

        [Then(@"Verify file upload\.")]
        public void ThenVerifyFileUpload_()
        {
            ExplicitWaiting.waitForTime(8000);
            IWebElement searchElement = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._removeFileButton));
            HelpingFunctions.elementVisible(searchElement);
        }
        [Then(@"Click on cancel upload button to cancel uploading the file\.")]
        public void ThenClickOnCancelUploadButtonToCancelUploadingTheFile_()
        {
            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._cancelUploadButton);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._cancelUploadButton)).Click();
        }

        [Then(@"click on OK from the popup to confirm upload cancellation\.")]
        public void ThenClickOnOKFromThePopupToConfirmUploadCancellation_()
        {
            IAlert simpleAlert = BrowserConfig._driver.SwitchTo().Alert();
            simpleAlert.Accept();
        }
       
        [Then(@"click on remove file button to delete the uploaded file\.")]
        public void ThenClickOnRemoveFileButtonToDeleteTheUploadedFile_()
        {
            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._removeFileButton);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._removeFileButton)).Click();
        }
        [Then(@"Click on Clear All Files Button\.")]
        public void ThenClickOnClearAllFilesButton_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._clearAllFilesButton)).Click();
        }

        [Then(@"Verify removal of files\.")]
        public void ThenVerifyRemovalOfFiles_()
        {
            IWebElement searchElement = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._dropDmaFilesIdentifier));
            HelpingFunctions.elementVisible(searchElement);
        }
        [Then(@"Select deformation Mode from dropdown\.")]
        public void ThenSelectDeformationModeFromDropdown_(Table table)
        {
            ExplicitWaiting.waitForTime(8000);
            GetValues _deformationType = table.CreateInstance<GetValues>();
            HelpingFunctions.SelectDeformationMode(_deformationType.DeformationMode);
        }
        [Then(@"Send density value\.")]
        public void ThenSendDensityValue_()
        {
            ExplicitWaiting.waitForTime(7000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._density)).SendKeys(".1");
        }
        [Then(@"click on generate constitutive mechanical model button\.")]
        public void ThenClickOnGenerateConstitutiveMechanicalModelButton_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._generateConstitutiveModelBtn)).Click();
        }
        [When(@"After landing on sharkspray page, click on AdhesiveType Dropdown\.")]
        public void WhenAfterLandingOnSharksprayPageClickOnAdhesiveTypeDropdown_()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Upload compression file\.")]
        public void ThenUploadCompressionFile_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._dropCompFilesIdentifier)).Click();
            ExplicitWaiting.waitForTime(2000);
            Process.Start(@"F:\3M-projects\sharkspray\CompressFileUpload.exe");
        }
        [Then(@"Upload tension file\.")]
        public void ThenUploadTensionFile_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._dropTensFilesIdentifier)).Click();
            ExplicitWaiting.waitForTime(2000);
            Process.Start(@"F:\3M-projects\sharkspray\TeansionFileUpload.exe");
        }





    }
}
