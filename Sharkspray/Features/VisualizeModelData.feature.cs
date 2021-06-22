﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sharkspray.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("VisualizeModelData")]
    public partial class VisualizeModelDataFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "VisualizeModelData.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "VisualizeModelData", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("_24 Verify Selected Model.")]
        public virtual void _24VerifySelectedModel_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("_24 Verify Selected Model.", null, ((string[])(null)));
#line 3
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
testRunner.Given("Go to url.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
testRunner.When("user login with credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 6
testRunner.Then("After landing on sharkspray page, click on AdhesiveType Dropdown.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table51 = new TechTalk.SpecFlow.Table(new string[] {
                        "AdhesiveType"});
            table51.AddRow(new string[] {
                        "PSA - Adhesive Double-Coated Tape (DCT)"});
#line 7
testRunner.And("Select adhesive type from dropdown.", ((string)(null)), table51, "And ");
#line 10
testRunner.Then("click on Model Phase Dropdown.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table52 = new TechTalk.SpecFlow.Table(new string[] {
                        "ModelPhase"});
            table52.AddRow(new string[] {
                        "Phase 1(DMA)"});
#line 11
testRunner.And("Select Model Phase from dropdown.", ((string)(null)), table52, "And ");
#line 14
testRunner.Then("Click on Division Dropdown.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table53 = new TechTalk.SpecFlow.Table(new string[] {
                        "Division"});
            table53.AddRow(new string[] {
                        "EMSD"});
#line 15
testRunner.And("Select Division from dropdown.", ((string)(null)), table53, "And ");
#line 18
testRunner.And("click on drop DMA files button and upload file.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
testRunner.And("Verify file upload.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
testRunner.Then("Click on model name text-box and write a name.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table54 = new TechTalk.SpecFlow.Table(new string[] {
                        "DeformationMode"});
            table54.AddRow(new string[] {
                        "Shear"});
#line 21
testRunner.And("Select deformation Mode from dropdown.", ((string)(null)), table54, "And ");
#line 24
testRunner.And("click on generate constitutive mechanical model button.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
testRunner.And("verify Selected Model.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("_25 Verify chart type")]
        public virtual void _25VerifyChartType()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("_25 Verify chart type", null, ((string[])(null)));
#line 27
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 28
testRunner.Given("Go to url.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
testRunner.When("user login with credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
testRunner.Then("After landing on sharkspray page, click on AdhesiveType Dropdown.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table55 = new TechTalk.SpecFlow.Table(new string[] {
                        "AdhesiveType"});
            table55.AddRow(new string[] {
                        "PSA - Adhesive Double-Coated Tape (DCT)"});
#line 31
testRunner.And("Select adhesive type from dropdown.", ((string)(null)), table55, "And ");
#line 34
testRunner.Then("click on Model Phase Dropdown.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table56 = new TechTalk.SpecFlow.Table(new string[] {
                        "ModelPhase"});
            table56.AddRow(new string[] {
                        "Phase 1(DMA)"});
#line 35
testRunner.And("Select Model Phase from dropdown.", ((string)(null)), table56, "And ");
#line 38
testRunner.Then("Click on Division Dropdown.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table57 = new TechTalk.SpecFlow.Table(new string[] {
                        "Division"});
            table57.AddRow(new string[] {
                        "EMSD"});
#line 39
testRunner.And("Select Division from dropdown.", ((string)(null)), table57, "And ");
#line 42
testRunner.And("click on drop DMA files button and upload file.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
testRunner.And("Verify file upload.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
testRunner.Then("Click on model name text-box and write a name.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table58 = new TechTalk.SpecFlow.Table(new string[] {
                        "DeformationMode"});
            table58.AddRow(new string[] {
                        "Shear"});
#line 45
testRunner.And("Select deformation Mode from dropdown.", ((string)(null)), table58, "And ");
#line 48
testRunner.And("click on generate constitutive mechanical model button.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table59 = new TechTalk.SpecFlow.Table(new string[] {
                        "ChartType"});
            table59.AddRow(new string[] {
                        "Rheology Master Curve"});
#line 49
testRunner.And("select chart type from dropdown.", ((string)(null)), table59, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("_26 Verify Master Curve Reference Temperature")]
        public virtual void _26VerifyMasterCurveReferenceTemperature()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("_26 Verify Master Curve Reference Temperature", null, ((string[])(null)));
#line 53
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 54
testRunner.Given("Go to url.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 55
testRunner.When("user login with credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
testRunner.Then("After landing on sharkspray page, click on AdhesiveType Dropdown.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table60 = new TechTalk.SpecFlow.Table(new string[] {
                        "AdhesiveType"});
            table60.AddRow(new string[] {
                        "PSA - Adhesive Double-Coated Tape (DCT)"});
#line 57
testRunner.And("Select adhesive type from dropdown.", ((string)(null)), table60, "And ");
#line 60
testRunner.Then("click on Model Phase Dropdown.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table61 = new TechTalk.SpecFlow.Table(new string[] {
                        "ModelPhase"});
            table61.AddRow(new string[] {
                        "Phase 1(DMA)"});
#line 61
testRunner.And("Select Model Phase from dropdown.", ((string)(null)), table61, "And ");
#line 64
testRunner.Then("Click on Division Dropdown.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table62 = new TechTalk.SpecFlow.Table(new string[] {
                        "Division"});
            table62.AddRow(new string[] {
                        "EMSD"});
#line 65
testRunner.And("Select Division from dropdown.", ((string)(null)), table62, "And ");
#line 68
testRunner.And("click on drop DMA files button and upload file.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
testRunner.And("Verify file upload.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
testRunner.Then("Click on model name text-box and write a name.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table63 = new TechTalk.SpecFlow.Table(new string[] {
                        "DeformationMode"});
            table63.AddRow(new string[] {
                        "Shear"});
#line 71
testRunner.And("Select deformation Mode from dropdown.", ((string)(null)), table63, "And ");
#line 74
testRunner.And("click on generate constitutive mechanical model button.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
testRunner.Then("Clear the default value and enter the new value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("_27 Verify update master curve button status")]
        public virtual void _27VerifyUpdateMasterCurveButtonStatus()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("_27 Verify update master curve button status", null, ((string[])(null)));
#line 77
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 78
testRunner.Given("Go to url.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 79
testRunner.When("user login with credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
testRunner.Then("After landing on sharkspray page, click on AdhesiveType Dropdown.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table64 = new TechTalk.SpecFlow.Table(new string[] {
                        "AdhesiveType"});
            table64.AddRow(new string[] {
                        "PSA - Adhesive Double-Coated Tape (DCT)"});
#line 81
testRunner.And("Select adhesive type from dropdown.", ((string)(null)), table64, "And ");
#line 84
testRunner.Then("click on Model Phase Dropdown.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table65 = new TechTalk.SpecFlow.Table(new string[] {
                        "ModelPhase"});
            table65.AddRow(new string[] {
                        "Phase 1(DMA)"});
#line 85
testRunner.And("Select Model Phase from dropdown.", ((string)(null)), table65, "And ");
#line 88
testRunner.Then("Click on Division Dropdown.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table66 = new TechTalk.SpecFlow.Table(new string[] {
                        "Division"});
            table66.AddRow(new string[] {
                        "EMSD"});
#line 89
testRunner.And("Select Division from dropdown.", ((string)(null)), table66, "And ");
#line 92
testRunner.And("click on drop DMA files button and upload file.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
testRunner.And("Verify file upload.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
testRunner.Then("Click on model name text-box and write a name.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table67 = new TechTalk.SpecFlow.Table(new string[] {
                        "DeformationMode"});
            table67.AddRow(new string[] {
                        "Shear"});
#line 95
testRunner.And("Select deformation Mode from dropdown.", ((string)(null)), table67, "And ");
#line 98
testRunner.And("click on generate constitutive mechanical model button.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
testRunner.Then("Clear the default value and enter the new value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 100
testRunner.And("check the status of update master curve button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("_28 Verify Chart save.")]
        public virtual void _28VerifyChartSave_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("_28 Verify Chart save.", null, ((string[])(null)));
#line 102
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 103
testRunner.Given("Go to url.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 104
testRunner.When("user login with credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 105
testRunner.Then("After landing on sharkspray page, click on AdhesiveType Dropdown.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table68 = new TechTalk.SpecFlow.Table(new string[] {
                        "AdhesiveType"});
            table68.AddRow(new string[] {
                        "PSA - Adhesive Double-Coated Tape (DCT)"});
#line 106
testRunner.And("Select adhesive type from dropdown.", ((string)(null)), table68, "And ");
#line 109
testRunner.Then("click on Model Phase Dropdown.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table69 = new TechTalk.SpecFlow.Table(new string[] {
                        "ModelPhase"});
            table69.AddRow(new string[] {
                        "Phase 1(DMA)"});
#line 110
testRunner.And("Select Model Phase from dropdown.", ((string)(null)), table69, "And ");
#line 113
testRunner.Then("Click on Division Dropdown.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table70 = new TechTalk.SpecFlow.Table(new string[] {
                        "Division"});
            table70.AddRow(new string[] {
                        "EMSD"});
#line 114
testRunner.And("Select Division from dropdown.", ((string)(null)), table70, "And ");
#line 117
testRunner.And("click on drop DMA files button and upload file.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
testRunner.And("Verify file upload.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
testRunner.Then("Click on model name text-box and write a name.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table71 = new TechTalk.SpecFlow.Table(new string[] {
                        "DeformationMode"});
            table71.AddRow(new string[] {
                        "Shear"});
#line 120
testRunner.And("Select deformation Mode from dropdown.", ((string)(null)), table71, "And ");
#line 123
testRunner.And("click on generate constitutive mechanical model button.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
testRunner.Then("click on save chart as png.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 125
testRunner.And("verify file saved.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
