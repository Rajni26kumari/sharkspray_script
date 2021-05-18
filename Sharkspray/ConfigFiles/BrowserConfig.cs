using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Diagnostics;
using System.Threading;
using Sharkspray.Utility;
using System.Configuration;

namespace Sharkspray
{
    class BrowserConfig
    {
        public static IWebDriver _driver;
        public static readonly string _baseUrl = ConfigurationManager.AppSettings.Get("url");
        public static readonly string _browser = ConfigurationManager.AppSettings.Get("browsers");
        public static readonly string _username = ConfigurationManager.AppSettings.Get("username");
        public static string _sftwrDwnldPortalUrl = "https://download-qa.3m.com/Home/ViewSoftwareAno";

        public static void Init()
        {
            Thread.Sleep(2000);
            if (_driver != null)
            {
                string _currentUrl = _driver.Url;
                if (_currentUrl.Equals(_sftwrDwnldPortalUrl))
                {
                    Console.WriteLine("Already on the 3M Software Download Portal.");
                }
                else
                {
                    Goto(_baseUrl);
                }
            }
            
            else
            {
                switch (_browser)
                {
                    case "Chrome":
                        _driver = new ChromeDriver();


                        break;
                    case "IE":
                        _driver = new InternetExplorerDriver();
                        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                        break;
                    case "Firefox":
                        _driver = new FirefoxDriver();
                        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                        break;
                }
                _driver.Manage().Window.Maximize();
                Goto(_baseUrl);

            }
        }

        public static void Goto(string baseUrl)
        {
            _driver.Url = baseUrl;
        }

        public static void login()
        {
            _driver.FindElement(By.XPath(ObjectIdentifiers._username)).SendKeys(_username);
            _driver.FindElement(By.XPath(ObjectIdentifiers._next)).Click();
            Thread.Sleep(3000);
            _driver.FindElement(By.XPath(ObjectIdentifiers._workac)).Click();
            ExplicitWaiting.waitForTime(5000);
            try
            {
                Process.Start(@"C:\Users\DELL\source\repos\Sharkspray3M_projcode\AutoitScript.exe");
            }
            catch (Exception _ex)
            {
                //log
            }

            
        }


        //public static void setCookie()
        //{

        //    Cookie ck = new Cookie("csrftoken", "2YJohLJqanvJ8Jb2SUm2XEbkBbpDLdHj6WMAUenVMbVTSJnX1MpensR3OMwvL8iM");
        //    Cookie ck1 = new Cookie("sessionid", "igoo616mphr5vdub0rzps0so77e3t6ni");

        //    _driver.Manage().Cookies.AddCookie(ck);
        //    _driver.Manage().Cookies.AddCookie(ck1);



        //}
    }
}
