using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharkspray.JSON_TC.Helper
{
    class HelpFunction
    {
        IWebDriver webDriver;
        public static string _rootPath = AppDomain.CurrentDomain.BaseDirectory;
        public static string _downloadpath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\JSON_TC\\Test_files");
        protected static string path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
        public static void SaveSelectedModelsVisible(IWebElement saveSelectModelelement)
        {
            bool visibilityBtn = saveSelectModelelement.Displayed;
            if (visibilityBtn == false)
            {
                Assert.Fail("Model Name Not selected.");

            }
        }
        
        public void filedownloadverification1()
        {

            //Dictionary<string, object> perfs = new Dictionary<string, object>();
            //perfs["profile.default_content_settings.popups"] = 0;
            //perfs["download.default_directory"] = _downloadpath;
            //ChromeOptions options = new ChromeOptions();
            //options.AddUserProfilePreference("download.default_directory", _downloadpath);
            //options.AddAdditionalCapability("perfs", perfs);
            ////options = BrowserConfig.webDriver.Chrome(chrome_options = options);

            //var caps = new ChromeOptions();
            //caps.AddAdditionalCapability(ChromeOptions.Capability, options);
            //caps.AddUserProfilePreference("download.default_directory", _downloadpath);
            //BrowserConfig.filedownloadverification(ChromeOptions);
            BrowserConfig.webDriver.FindElement(By.XPath(ObjectIdentifiers._exportModelasZipButton)).Click();
            ExplicitWaiting.waitForAnElementUntilClickable(ObjectIdentifiers._exportModelasZipButton);
        }
        
    }
}
