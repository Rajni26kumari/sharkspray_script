using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Sharkspray.ConfigFiles;

namespace Sharkspray.Utility
{
    class HelpingFunctions
    {
        /// <summary>
        /// selecting adhesive type  value from dropdown.
        /// </summary>
        /// <param name="_adhesive"></param>
        public static void SelectAdhesiveType(string _adhesive)
        {
            Console.WriteLine(_adhesive);
            switch (_adhesive)
            {
                case "PSA - Adhesive Transfer Tape (ATT)":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._adhesiveDropdown)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._pstt)).Click();
                    break;
                case "PSA - Adhesive Double-Coated Tape (DCT)":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._adhesiveDropdown)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._psdct)).Click();
                    break;
                case "VHB":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._adhesiveDropdown)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._vha)).Click();
                    break;
                case "OCA":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._adhesiveDropdown)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._oca)).Click();
                    break;

            }
        }
        /// <summary>
        /// selecting model phase value from dropdown.
        /// </summary>
        /// <param name="_model"></param>
        public static void SelectModelPhase(string _model)
        {
            switch (_model)
            {
                case "Phase 1(DMA)":
                    ExplicitWaiting.waitForTime(3000);
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._modelPhaseDropdown)).Click();
                    ExplicitWaiting.waitForTime(3000);
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._phase1)).Click();
                    break;
                case "Phase 2(DMA + Compression)":
                    ExplicitWaiting.waitForTime(3000);
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._modelPhaseDropdown)).Click();
                    ExplicitWaiting.waitForTime(3000);
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._phase2)).Click();
                    break;
                case "Phase 3(DMA + Compression + Tension)":
                    ExplicitWaiting.waitForTime(3000);
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._modelPhaseDropdown)).Click();
                    ExplicitWaiting.waitForTime(3000);
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._phase3)).Click();
                    break;
            }
        }
        public static void SelectDivision(string _division)
        {
            switch (_division)
            {
                case "AASD":
                    ExplicitWaiting.waitForTime(3000);
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._divisionDropdown)).Click();
                    ExplicitWaiting.waitForTime(3000);
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._aasd)).Click();
                    break;
                case "CRL":
                    ExplicitWaiting.waitForTime(3000);
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._divisionDropdown)).Click();
                    ExplicitWaiting.waitForTime(3000);
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._crl)).Click();
                    break;
                case "DMSD":
                    ExplicitWaiting.waitForTime(3000);
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._divisionDropdown)).Click();
                    ExplicitWaiting.waitForTime(3000);
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._dmsd)).Click();
                    break;
                case "EMSD":
                    ExplicitWaiting.waitForTime(3000);
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._divisionDropdown)).Click();
                    ExplicitWaiting.waitForTime(3000);
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._emsd)).Click();
                    break;
                case "IATD":
                    ExplicitWaiting.waitForTime(3000);
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._divisionDropdown)).Click();
                    ExplicitWaiting.waitForTime(3000);
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._iatd)).Click();
                    break;
                case "Other":
                    ExplicitWaiting.waitForTime(3000);
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._divisionDropdown)).Click();
                    ExplicitWaiting.waitForTime(3000);
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._other)).Click();
                    break;
            }
        }

        /// <summary>
        /// scrolling to an element.
        /// </summary>
        public static void ScrollToElement()
        {
            Actions actions = new Actions(BrowserConfig._driver);

        }
        /// <summary>
        /// to check visibility of an element on webpage.
        /// </summary>
        /// <param name="element"></param>
        public static void elementVisible(IWebElement element)
        {
            bool visibility = element.Displayed;
            if (visibility == false)
            {
                Assert.Fail("Fail.");

            }
        }
        /// <summary>
        /// to check visibility of selected model.
        /// </summary>
        /// <param name="saveSelectModelelement"></param>
        public static void SaveSelectedModelsVisible(IWebElement saveSelectModelelement)
        {
            bool visibilityBtn = saveSelectModelelement.Displayed;
            if (visibilityBtn == false)
            {
                Assert.Fail("Model Name Not selected.");

            }
        }
        /// <summary>
        /// selecting deformation mode value from dropdown.
        /// </summary>
        /// <param name="_deformationType"></param>
        public static void SelectDeformationMode(string _deformationType)
        {
            switch (_deformationType)
            {
                case "Shear":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deformationModeDropdownBtn)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deformModeVal1)).Click();
                    break;
                case "Tension":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deformationModeDropdownBtn)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deformModeVal1)).Click();
                    break;
                case "Dual-Cantilever Beam":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deformationModeDropdownBtn)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deformModeVal1)).Click();
                    break;
                case "Single-Cantilever Beam":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deformationModeDropdownBtn)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deformModeVal1)).Click();
                    break;
                case "Three Point Bending":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deformationModeDropdownBtn)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deformModeVal1)).Click();
                    break;

            }
        }
        /// <summary>
        /// to verify visibility of tick element.
        /// </summary>
        /// <param name="tickElement"></param>
        public static void TickElementVisible(IWebElement tickElement)
        {
            bool visibility = tickElement.Displayed;
            if (visibility == false)
            {
                Assert.Fail("Model not saved.");

            }
        }

        /// <summary>
        /// select value of chart type.
        /// </summary>
        /// <param name="_type"></param>
        public static void SelectChartType(string _type)
        {

            switch (_type)
            {
                case "Rheology Master Curve + Prony Series":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeDropdown)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeVal1)).Click();
                    break;
                case "Simulated Compression":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeDropdown)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeVal2)).Click();
                    break;
                case "Simulated Tensile":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeDropdown)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeVal3)).Click();
                    break;
                case "Simulated Stress Relaxation":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeDropdown)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeVal4)).Click();
                    break;
                case "Rheology Master Curve":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeDropdown)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeVal5)).Click();
                    break;
                case "Shift Factors vs. Temperature (°C)":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeDropdown)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeVal6)).Click();
                    break;
                case "Simulated Temperature Sweep":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeDropdown)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeVal7)).Click();
                    break;

            }
        }
    }
}
