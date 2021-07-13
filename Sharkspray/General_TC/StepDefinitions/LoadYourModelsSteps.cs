using NUnit.Framework;
using OpenQA.Selenium;
using Sharkspray.ConfigFiles;
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
    public class LoadYourModelsSteps
    {
        [Then(@"Click on Load your Models \.")]
        public void ThenClickOnLoadYourModels_()
        {
            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._createnewmodeltitle);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._loadYourModelsIdentifier)).Click();
        }

        [Then(@"search for a model\.")]
        public void ThenSearchForAModel_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._modelSearchboxButton)).Click();
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._modelSearchboxIdentifier)).SendKeys("Model 1-3");
        }

        [Then(@"verify if model is retreived or not\.")]
        public void ThenVerifyIfModelIsRetreivedOrNot_()
        {
            ExplicitWaiting.waitForTime(3000);
            String Modelname = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._modelNameIdentifier)).Text;
            if (Modelname != "Model 1-3")
            {
                Assert.Fail("search failed");
            }
        }
        [Then(@"Select a model to load\.")]
        public void ThenSelectAModelToLoad_()
        {
            ExplicitWaiting.waitForTime(10000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._modelNameCheckboxIdentifier)).Click();
        }

        [Then(@"Verify model selection\.")]
        public void ThenVerifyModelSelection_()
        {
            String Modelnameselect = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._modelNameTextBox)).Text;
            if (Modelnameselect != "Model 1-3")
            {
                Assert.Fail("Model Selection Failed");
            }
        }
        [Then(@"click on load constitutive mechanical model button\.")]
        public void ThenClickOnLoadConstitutiveMechanicalModelButton_()
        {
            ExplicitWaiting.waitForTime(5000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._loadConstitutiveModelButton)).Click();
        }

        [Then(@"Verify load constitutive mechanical model button clicked\.")]
        public void ThenVerifyLoadConstitutiveMechanicalModelButtonClicked_()
        {
            ExplicitWaiting.waitForTime(5000);
            IWebElement chartElement = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._saveChartBtn));
            HelpingFunctions.elementVisible(chartElement);

        }


    }

}

