﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Sharkspray.ConfigFiles;

namespace Sharkspray.Utility
{
    class ExplicitWaiting
    {
        /// <summary>
        /// to wait until element is visible.
        /// </summary>
        /// <param name="_elementIdentifier"></param>
        public static void waitForAnElement(string _elementIdentifier)
        {
            try
            {
                var _waitvariable = new WebDriverWait(BrowserConfig._driver, new TimeSpan(0, 0, 10));
                var element = _waitvariable.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(_elementIdentifier)));
            }
            catch (Exception _ex)
            {
                Exception _customException = new Exception("The expected element " + _elementIdentifier + " not found");
                throw _customException;
            }
        }

        /// <summary>
        /// to wait until an element is clickable.
        /// </summary>
        /// <param name="_element"></param>
        public static void waitForAnElementUntilClickable(string _element)
        {
            try
            {
                var _waitvariable = new WebDriverWait(BrowserConfig._driver, new TimeSpan(0, 0, 10));
                var element = _waitvariable.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(_element)));
            }
            catch (Exception _ex)
            {
                Exception _customException = new Exception("The expected element " + _element + " not found");
                throw _customException;
            }
        }

        /// <summary>
        /// to wait for specified time.
        /// </summary>
        /// <param name="_time"></param>
        public static void waitForTime(int _time)
        {
            Thread.Sleep(_time);
        }
    }
}
