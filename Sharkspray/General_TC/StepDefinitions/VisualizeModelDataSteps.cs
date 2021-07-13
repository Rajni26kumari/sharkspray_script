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
using TechTalk.SpecFlow.Assist;

namespace Sharkspray.StepDefinitions
{
    [Binding]
    class VisualizeModelDataSteps
    {
        
        [Then(@"verify Selected Model\.")]
        public void ThenVerifySelectedModel_()
        {
            ExplicitWaiting.waitForTime(20000);
            IWebElement selectormode = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._selectorModeIdentifier));
            string selectedmode = selectormode.Text;
            Console.WriteLine(selectormode);
            string filename = "rheology-test";
            if (selectedmode != filename)
            {
                Assert.Fail("Selector Mode file Name mismatch");
            }
        }
        [Then(@"select chart type from dropdown\.")]
        public void ThenSelectChartTypeFromDropdown_(Table table)
        {
            ExplicitWaiting.waitForTime(15000);
            GetValues _type = table.CreateInstance<GetValues>();
            HelpingFunctions.SelectChartType(_type.ChartType);
        }
        [Then(@"Clear the default value and enter the new value")]
        public void ThenClearTheDefaultValueAndEnterTheNewValue()
        {
            //int inputvalue = 25;
            ExplicitWaiting.waitForTime(15000);
            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._visulizeModelTitle);
            IWebElement MCRTempDefaultvalue = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._mastercurvereftemp));
            //String text = MCRTempDefaultvalue.Text;
            // int status = Int32.Parse(text);
            MCRTempDefaultvalue.Clear();
            //IWebElement value1= BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._mastercurvereftemp));
           MCRTempDefaultvalue.SendKeys("35");
            

            //IJavaScriptExecutor js = (IJavaScriptExecutor)BrowserConfig._driver;
            //js.ExecuteScript("arguments[0].value=2", value1);
            //value1.Click();
        }
        [Then(@"check the status of update master curve button")]
        public void ThenCheckTheStatusOfUpdateMasterCurveButton()
        {
            IWebElement Status = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._updatemastercurve));
            if (Status.Enabled)
            {
                Console.WriteLine("update master curve button is enable");
                BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._updatemastercurve)).Click();

            }
            else
            {
                HelpingFunctions.elementVisible(Status);
                Console.WriteLine("update master curve button is disable");

            }

            //string MCRTempDefaultvalue1 = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._mastercurvereftemp)).Text;
            //int status1 = Int32.Parse(MCRTempDefaultvalue1);
            //Convert.ToInt32("status");
            //statusValue = int(MCRTempDefaultvalue);
            //int SetValue= Integer.parseInt(statusValue);
            //Console.WriteLine("status value is " + MCRTempDefaultvalue);
            //string MCRTempDefaultvalue = status.GetAttribute("27");

            //int MCRTempSetvalue = 25;
            //if (status != status1)
            //{
            //    Console.WriteLine("update master curve button is enable");
            //    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._updatemastercurve)).Click();

            //}
            //else
            //{
            //    //HelpingFunctions.elementVisible(status);
            //    Console.WriteLine("update master curve button is disable");
            //}

        }
        [Then(@"click on save chart as png\.")]
        public void ThenClickOnSaveChartAsPng_()
        {
            ExplicitWaiting.waitForTime(20000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._saveChartBtn)).Click();
        }

        [Then(@"verify file saved\.")]
        public void ThenVerifyFileSaved_()
        {
            ExplicitWaiting.waitForTime(5000);
            String rootpath = System.Environment.CurrentDirectory;
            //String path = rootpath.Replace("\\source\repos\\sharkspray", "");
            String finalPath = rootpath + @"\Downloads\rheology-test–Rheology Master Curve.png";
            //var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
           // path = path.Substring(6) + @"\Data\" + FileName;
            string currentFile = finalPath;
            if (File.Exists(currentFile))
            {
                File.Delete(currentFile); 
            }
            else
            {
                Assert.Fail("chart download failed.");


            }
        }




    }
}
