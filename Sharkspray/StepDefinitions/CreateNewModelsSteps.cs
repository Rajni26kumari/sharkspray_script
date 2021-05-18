using Sharkspray.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Sharkspray.StepDefinitions
{
    [Binding]
    
    public sealed class CreateNewModelsSteps
    {
        
        [Given(@"Go to url\.")]
        public void GivenGoToUrl_()
        {
            BrowserConfig.Init(); 
        }

        [When(@"user login with credentials")]
        public void WhenUserLoginWithCredentials()
        {
            BrowserConfig.login();
            
        }

        [Then(@"After landing on sharkspray page, click on AdhesiveType Dropdown\.")]
        public void ThenAfterLandingOnSharksprayPageClickOnAdhesiveTypeDropdown_()
        {
            ExplicitWaiting.waitForAnElementUntilClickable(ObjectIdentifiers._adhesiveDropdown);
        }

        [Then(@"Select adhesive type from dropdown\.")]
        public void ThenSelectAdhesiveTypeFromDropdown_(Table table)
        {
            ExplicitWaiting.waitForTime(2000);
            GetValues _adhesive = table.CreateInstance<GetValues>();
            HelpingFunctions.SelectAdhesiveType(_adhesive.AdhesiveType);
        }
        [Then(@"click on Model Phase Dropdown\.")]
        public void ThenClickOnModelPhaseDropdown_()
        {
            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._modelPhaseDropdown);
        }

        [Then(@"Select Model Phase from dropdown\.")]
        public void ThenSelectModelPhaseFromDropdown_(Table table)
        {
            ExplicitWaiting.waitForTime(2000);
            GetValues _model = table.CreateInstance<GetValues>();
            HelpingFunctions.SelectModelPhase(_model.ModelPhase);
        }
        [Then(@"Click on Division Dropdown\.")]
        public void ThenClickOnDivisionDropdown_()
        {
            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._divisionDropdown);
        }

        [Then(@"Select Division from dropdown\.")]
        public void ThenSelectDivisionFromDropdown_(Table table)
        {
            ExplicitWaiting.waitForTime(2000);
            GetValues _division = table.CreateInstance<GetValues>();
            HelpingFunctions.SelectDivision(_division.Division);
        }


    }
}
