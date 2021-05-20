using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Sharkspray.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Sharkspray.StepDefinitions
{
    [Binding]
    public sealed class EditYourModelsSteps
    {
        [Then(@"Click on Edit Your Models\.")]
        public void ThenClickOnEditYourModels_()
        {
            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._createnewmodeltitle);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._editYourModelsIdentifier)).Click();
        }

        [Then(@"click on searchbox button and send search input\.")]
        public void ThenClickOnSearchboxButtonAndSendSearchInput_()
        {
            ExplicitWaiting.waitForTime(2000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._searchboxEditModelButton)).Click();
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._searchBoxInputIdentifier)).SendKeys("Model 1-1");
        }
        [Then(@"Select on model to be edited")]
        public void ThenSelectOnModelToBeEdited()
        {
            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._editexistingmodeltitle);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._modelEditCheckboxBtn)).Click();
        }

        [Then(@"Update model\.")]
        public void ThenUpdateModel_()
        {
            
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._descrptionTextboxIdentifier)).Clear();
            ExplicitWaiting.waitForTime(2000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._descrptionTextboxIdentifier)).SendKeys("model is under test");
        }

        [Then(@"click on Update selected Model Button\.")]
        public void ThenClickOnUpdateSelectedModelButton_()
        {
            ExplicitWaiting.waitForAnElementUntilClickable(ObjectIdentifiers._updateSelectedModelBtn);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._updateSelectedModelBtn)).Click();
        }

        [Then(@"verify that model was updated")]
        public void ThenVerifyThatModelWasUpdated()
        {
            
            IWebElement description = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._descrptionTextboxIdentifier));
            string descriptionText = description.Text;
            Assert.AreEqual(descriptionText, "model is under test");
        }
        [Then(@"click on Delete Selected Models Button\.")]
        public void ThenClickOnDeleteSelectedModelsButton_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deleteSelectedModelBtn)).Click();
            ExplicitWaiting.waitForTime(1000);
        }

        [Then(@"click on button to confirm delete\.")]
        public void ThenClickOnButtonToConfirmDelete_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deleteConfirmBtn)).Click();
        }
        [Then(@"Click on cancel button\.")]
        public void ThenClickOnCancelButton_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._canceldeleteConfirmBtn)).Click();
        }


    }
}
