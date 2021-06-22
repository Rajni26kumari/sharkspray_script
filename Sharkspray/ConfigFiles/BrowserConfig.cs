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
using AutoItX3Lib;

namespace Sharkspray
{
    class BrowserConfig
    {
        public static IWebDriver _driver;
        public static readonly string _baseUrl = ConfigurationManager.AppSettings.Get("url");
        public static readonly string _browser = ConfigurationManager.AppSettings.Get("browsers");
        public static readonly string _username = ConfigurationManager.AppSettings.Get("username");
        protected static string path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");


        public static void Init()
        {
            Thread.Sleep(2000);
            if (_driver != null)
            {
                string _currentUrl = _driver.Url;
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
            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._next); ;
            _driver.FindElement(By.XPath(ObjectIdentifiers._username)).SendKeys(_username);
            _driver.FindElement(By.XPath(ObjectIdentifiers._next)).Click();
            ExplicitWaiting.waitForTime(3000);
            _driver.FindElement(By.XPath(ObjectIdentifiers._workac)).Click();
            ExplicitWaiting.waitForTime(5000);
            string autoitPath= path + "\\AutiITScripts" + "\\AutoitScript" + ".exe";
          
            try
            {
                Process.Start(autoitPath);
            }
            catch (Exception _ex)
            {
                Console.WriteLine("Error" + _ex.Message);
            }
        }
    }
    }

