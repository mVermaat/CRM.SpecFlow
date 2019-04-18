// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Vermaat.Crm.Specflow.Sample
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Salesflow", Description="\tTests for the lead/opportunity entity to show special dialogs like the qualify l" +
        "ead, process flows and related entities", SourceFile="SalesFlow.feature", SourceLine=0)]
    public partial class SalesflowFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SalesFlow.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Salesflow", "\tTests for the lead/opportunity entity to show special dialogs like the qualify l" +
                    "ead, process flows and related entities", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Lead Qualification", new string[] {
                "API",
                "Cleanup"}, SourceLine=4)]
        public virtual void LeadQualification()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Lead Qualification", null, new string[] {
                        "API",
                        "Cleanup"});
#line 5
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table16.AddRow(new string[] {
                        "First Name",
                        "Qualify"});
            table16.AddRow(new string[] {
                        "Last Name",
                        "Test"});
            table16.AddRow(new string[] {
                        "Topic",
                        "Qualification Test"});
            table16.AddRow(new string[] {
                        "Company Name",
                        "Qualify Account"});
#line 6
testRunner.Given("a lead named ToQualify with the following values", ((string)(null)), table16, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Account",
                        "Opportunity",
                        "Contact"});
            table17.AddRow(new string[] {
                        "true",
                        "true",
                        "true"});
#line 12
testRunner.When("ToQualify is qualified to a", ((string)(null)), table17, "When ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table18.AddRow(new string[] {
                        "Originating Lead",
                        "ToQualify"});
            table18.AddRow(new string[] {
                        "Account Name",
                        "Qualify Account"});
#line 15
testRunner.Then("an account named QualifyAccount exists with the following values", ((string)(null)), table18, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table19.AddRow(new string[] {
                        "Originating Lead",
                        "ToQualify"});
            table19.AddRow(new string[] {
                        "Company Name",
                        "QualifyAccount"});
            table19.AddRow(new string[] {
                        "First Name",
                        "Qualify"});
            table19.AddRow(new string[] {
                        "Last Name",
                        "Test"});
#line 19
testRunner.And("a contact exists with the following values", ((string)(null)), table19, "And ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table20.AddRow(new string[] {
                        "Originating Lead",
                        "ToQualify"});
            table20.AddRow(new string[] {
                        "Topic",
                        "Qualification Test"});
#line 25
testRunner.And("an opportunity exists with the following values", ((string)(null)), table20, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
