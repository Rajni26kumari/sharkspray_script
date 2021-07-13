﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharkspray.JSON_TC.Helper
{
    class CreateDropdowns
    {
        public static string _rootPath = AppDomain.CurrentDomain.BaseDirectory;
        //public static string _sourcePath = _rootPath + "\\TestFiles";
        public static string _destpath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\JSON_TC\\TestFiles");
        protected static string path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
        string FileUploadtPath = path + "\\AutiITScripts" + "\\FileUpload1" + ".exe";
        By _adhesiveDropdown1 = By.XPath("//div[@id='select-newmodel_adhesive_type_select']");
        By _modelPhaseDropdown = By.XPath("//div[@id='select-newmodel_phase_select']");
        public void Setadhesivedropdowns(string adhesivetype, IWebDriver _driver)
        {     
           IWebElement dropdown= _driver.FindElement(By.XPath("//div[@id='select-newmodel_adhesive_type_select']"));
            dropdown.Click();
            IList<IWebElement> options = dropdown.FindElements(By.XPath("//*[@id='menu-newmodel_adhesive_type_select']/div[2]/ul/li"));
            foreach(IWebElement option in options)
            {
                if (option.Text.Equals(adhesivetype)) 
                {
                    option.Click();
                    break;
                }
            }
        }
        public void Setmodelphasedropdown(string modelphase, IWebDriver _driver)
        {
            IWebElement dropdown = _driver.FindElement(By.XPath("//div[@id='select-newmodel_phase_select']"));
            dropdown.Click();
            IList<IWebElement> options = dropdown.FindElements(By.XPath("//*[@id='menu-newmodel_phase_select']/div[2]/ul/li"));
            foreach (IWebElement option in options)
            {
                if (option.Text.Equals(modelphase))
                {
                    option.Click();
                    break;
                }
            }
        }
        public void FileUpload(string dmafiles,string compressionfile,string tesionfile)
        {
            bool _destFolder = Directory.Exists(_destpath);
            if (_destFolder)
            {
                string _destFile = _destpath + dmafiles;
                bool _isFilePresent = File.Exists(_destFile);
                if (_isFilePresent)
                {
                    ExplicitWaiting.waitForTime(3000);
                    BrowserConfig.webDriver.FindElement(By.XPath(ObjectIdentifiers._dropDmaFilesIdentifier)).Click();
                    ExplicitWaiting.waitForTime(2000);
                    string UploadFile = _destFile;
                    try
                    {
                        Process.Start(FileUploadtPath, UploadFile);
                    }
                    catch (Exception _ex)
                    {
                        Console.WriteLine("Error" + _ex.Message);
                    }
                }
                }
                else
                {
                    Directory.CreateDirectory(_destpath);
                    string _destFile = _destpath + dmafiles;
                    bool _isFilePresent = File.Exists(_destFile);
                    if (_isFilePresent)
                    {
                    ExplicitWaiting.waitForTime(3000);
                    BrowserConfig.webDriver.FindElement(By.XPath(ObjectIdentifiers._dropDmaFilesIdentifier)).Click();
                    ExplicitWaiting.waitForTime(2000);
                    string UploadFile = _destFile;
                    try
                    {
                        Process.Start(FileUploadtPath, UploadFile);
                    }
                    catch (Exception _ex)
                    {
                        Console.WriteLine("Error" + _ex.Message);
                    }
                }
            }
           
        }
    }
}