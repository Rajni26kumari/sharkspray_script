using NUnit.Framework;
using OpenQA.Selenium;
using Sharkspray.ConfigFiles;
using Sharkspray.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Sharkspray.StepDefinitions
{
    [Binding]
    public class VerifiedModelsSteps
    {
        [Then(@"Click on Verified Models Button\.")]
        public void ThenClickOnVerifiedModelsButton_()
        {
            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._createnewmodeltitle);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._verifiedModelsBtn)).Click();
        }

        [Then(@"Enter data in searchbox\.")]
        public void ThenEnterDataInSearchbox_()
        {
            ExplicitWaiting.waitForTime(2000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._searchBoxIdentifier)).Click();
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._searchBoxVerifiedModels)).SendKeys("100MP");
        }

        [Then(@"verify search functionality\.")]
        public void ThenVerifySearchFunctionality_()
        {
            try
            {
                IWebElement verifiedModelsElement = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._verifiedModelsTableIdentifier));
            }
            catch (Exception ex)
            {
                Assert.Fail("Search Failed");
            }
        }
        [Then(@"Download internal model\.")]
        public void ThenDownloadInternalModel_()
        {
            ExplicitWaiting.waitForTime(10000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._downloadModelInternal)).Click();
        }

        [Then(@"verify the internal model is downloaded\.")]
        public void ThenVerifyTheInternalModelIsDownloaded_()
        {
            ExplicitWaiting.waitForTime(20000);
            String path = System.Environment.CurrentDirectory.Replace("AppData\\Local\\Temp", "");
            String finalPath = path + @"Downloads\\100MP_InternalDataPackage.zip";
            string currentFile = finalPath;
            if (File.Exists(currentFile))
            {
                File.Delete(currentFile);
            }
            else
            {
                Assert.Fail("Verified Model Download Failed.");


            }
        }
        [Then(@"Download External verified Model\.")]
        public void ThenDownloadExternalVerifiedModel_()
        {
            ExplicitWaiting.waitForTime(10000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._downloadModelExternal)).Click();
        }

        [Then(@"verify that external model is downloaded\.")]
        public void ThenVerifyThatExternalModelIsDownloaded_()
        {
            ExplicitWaiting.waitForTime(20000);
            String path = System.Environment.CurrentDirectory.Replace("AppData\\Local\\Temp", "");
            String finalPath = path + @"Downloads\\100MP_ExternalDataPackage.zip";
            string currentFile = finalPath;
            if (File.Exists(currentFile))
            {
                File.Delete(currentFile);
            }
            else
            {
                Assert.Fail("Verified Model Download Failed.");


            }
        }



    }
}
