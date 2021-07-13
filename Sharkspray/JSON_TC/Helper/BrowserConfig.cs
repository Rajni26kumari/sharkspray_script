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


namespace Sharkspray.JSON_TC.Helper
{
    class BrowserConfig
    {
        public static IWebDriver webDriver;
        public static readonly string _baseUrl = ConfigurationManager.AppSettings.Get("url");
        public static readonly string _browser = ConfigurationManager.AppSettings.Get("browsers");
        public static readonly string _username = ConfigurationManager.AppSettings.Get("username");
        protected static string path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
        


        public static void Init()
        {
            Thread.Sleep(2000);
            if (webDriver != null)
            {
                string _currentUrl = webDriver.Url;
                if (_currentUrl.Equals(_baseUrl))
                {
                    Console.WriteLine("Already on sharkspray site ");
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
                        webDriver = new ChromeDriver();


                        break;
                    case "IE":
                        webDriver = new InternetExplorerDriver();
                        webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                        break;
                    case "Firefox":
                        webDriver = new FirefoxDriver();
                        webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                        break;
                }
                webDriver.Manage().Window.Maximize();
                Goto(_baseUrl);

            }
        }
        public static string Title
        {
            get { return webDriver.Title; }
        }
        public static IWebDriver getDriver
        {
            get { return webDriver; }
        }

        public static void Goto(string baseUrl)
        {
            webDriver.Url = baseUrl;
        }

        public static void login()
        {
           // ExplicitWaiting.waitForAnElement(ObjectIdentifiers._next); ;
            webDriver.FindElement(By.XPath(ObjectIdentifiers._username)).SendKeys(_username);
            webDriver.FindElement(By.XPath(ObjectIdentifiers._next)).Click();
            ExplicitWaiting.waitForTime(3000);
            webDriver.FindElement(By.XPath(ObjectIdentifiers._workac)).Click();
            ExplicitWaiting.waitForTime(5000);
            string AutoITpath = path + "\\AutiITScripts" + "\\cred" + ".exe";
            try
            {
                Process.Start(AutoITpath);
                Thread.Sleep(2000);
            }
            catch(Exception _ex)
            {
                Console.WriteLine("Error" + _ex.Message);
            }
           

        }
    }
    }

