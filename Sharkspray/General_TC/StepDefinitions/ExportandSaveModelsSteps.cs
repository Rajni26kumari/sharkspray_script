using NUnit.Framework;
using OpenQA.Selenium;
using Sharkspray.ConfigFiles;
using Sharkspray.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Sharkspray.StepDefinitions
{
    [Binding]
    class ExportandSaveModelsSteps
    {
        [Then(@"click on Model Name\.")]
        public void ThenClickOnModelName_()
        {
            ExplicitWaiting.waitForTime(20000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._modelNameSelectButton)).Click();
        }

        [Then(@"Verify Selection Of Model Name\.")]
        public void ThenVerifySelectionOfModelName_()
        {
            IWebElement saveSelectModelelement = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._saveSelectedModelsButton));
            HelpingFunctions.SaveSelectedModelsVisible(saveSelectModelelement);
        }
        [Then(@"Click on Save Selected  Models Button\.")]
        public void ThenClickOnSaveSelectedModelsButton_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._saveSelectedModelsButton)).Click();
        }

        [Then(@"Verify Model saved\.")]
        public void ThenVerifyModelSaved_()
        {
            ExplicitWaiting.waitForTime(10000);
            IWebElement tickElement2 = BrowserConfig._driver.FindElement(By.CssSelector(ObjectIdentifiers._tick1));
            String colour = tickElement2.GetAttribute("style");
            Assert.AreEqual(colour, "fill: green;");
        }
        [Then(@"click on Export External Data Package\(zip\) button\.")]
        public void ThenClickOnExportExternalDataPackageZipButton_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._exportModelasZipButton)).Click();
        }

        [Then(@"Click to unzip the downloaded file\.")]
        public void ThenClickToUnzipTheDownloadedFile_()
        {
            ExplicitWaiting.waitForTime(5000);
            String path = System.Environment.CurrentDirectory.Replace("AppData\\Local\\Temp", "");
            String finalPath = path + @"Downloads\VHB_GPH-060GF_smallstrain_MDC_MasterCurve_ModelFiles.zip";
            string currentFile = finalPath;
            String extractPath = path + @"Downloads\TestDownloads";
            if (!Directory.Exists(extractPath))
            {
                Directory.CreateDirectory(extractPath);
            }
            if (File.Exists(currentFile))
            {

                ZipFile.ExtractToDirectory(currentFile, extractPath);
                File.Delete(currentFile);
            }
            Directory.Delete(extractPath, true);
        }

    }



}

