using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharkspray.JSON_TC.Helper
{
    class HelpFunction
    {
        public static string _rootPath = AppDomain.CurrentDomain.BaseDirectory;
        public static string _destpath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\JSON_TC\\Test_files");
        protected static string path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
        public static void SaveSelectedModelsVisible(IWebElement saveSelectModelelement)
        {
            bool visibilityBtn = saveSelectModelelement.Displayed;
            if (visibilityBtn == false)
            {
                Assert.Fail("Model Name Not selected.");

            }
        }
        public void filedownloadverification(IWebDriver webDriver)
        {            
            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("download.default_directory", _destpath);
            
            BrowserConfig.webDriver.FindElement(By.XPath(ObjectIdentifiers._exportModelasZipButton)).Click();
            ExplicitWaiting.waitForTime(2000);

        }
    }
}
