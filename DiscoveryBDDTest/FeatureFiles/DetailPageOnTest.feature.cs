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
namespace DiscoveryBDDTest.FeatureFiles
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("DetailPageOnTest")]
    public partial class DetailPageOnTestFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DetailPageOnTest.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-GB"), "DetailPageOnTest", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("DetailPage_CouldThisPageBeImproved_NO")]
        [NUnit.Framework.TestCaseAttribute("D32670", null)]
        [NUnit.Framework.TestCaseAttribute("N13780091", null)]
        public virtual void DetailPage_CouldThisPageBeImproved_NO(string iaId, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DetailPage_CouldThisPageBeImproved_NO", null, exampleTags);
#line 3
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
 testRunner.Given(string.Format("I am on details page for \"{0}\"", iaId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
 testRunner.When("click on NO for could this page be improved?", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 6
 testRunner.And("check for the title Your feedback helps us improve our services. Please share any" +
                    " comments below (optional).", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.And("click on send", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
 testRunner.Then("check for the title Thank you for your feedback", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DetailPage_CouldThisPageBeImproved_Yes")]
        [NUnit.Framework.TestCaseAttribute("N13959850", "did-not-understand", null)]
        [NUnit.Framework.TestCaseAttribute("N13780091", "too-much-information", null)]
        [NUnit.Framework.TestCaseAttribute("N13759454", "expected-the-record", null)]
        public virtual void DetailPage_CouldThisPageBeImproved_Yes(string iaId, string checkBox, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DetailPage_CouldThisPageBeImproved_Yes", null, exampleTags);
#line 15
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 16
 testRunner.Given(string.Format("I am on details page for \"{0}\"", iaId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
 testRunner.When("click on YES for could this page be improved?", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.And(string.Format("click on \"{0}\" under please let us know why you are dissatisfied", checkBox), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("click on send", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.Then("check for the title Thank you for your feedback", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DetailPage_ErrorOnRecordDescription")]
        [NUnit.Framework.TestCaseAttribute("N13780091", "Creator", null)]
        [NUnit.Framework.TestCaseAttribute("C3091668", "Physical description", null)]
        public virtual void DetailPage_ErrorOnRecordDescription(string iaId, string fieldContainsError, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DetailPage_ErrorOnRecordDescription", null, exampleTags);
#line 28
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 29
 testRunner.Given(string.Format("I am on details page for \"{0}\"", iaId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
 testRunner.When("click on \"letUsKnow\" under catalogue description", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.And(string.Format("I enter fieldContainsError \"{0}\"", fieldContainsError), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "whatIsTheError",
                        "correctInformation",
                        "name",
                        "email"});
            table1.AddRow(new string[] {
                        "Test check",
                        "Test check correct",
                        "Tester",
                        "tnadiscovery100@gmail.com"});
#line 33
 testRunner.And("I enter info", ((string)(null)), table1, "And ");
#line 36
 testRunner.Then("check for the message Thank you for taking time to submit a suggestion", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DetailPage_ShowImages_Offsite")]
        [NUnit.Framework.TestCaseAttribute("C4236021", null)]
        [NUnit.Framework.TestCaseAttribute("C4235988", null)]
        public virtual void DetailPage_ShowImages_Offsite(string iaId, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DetailPage_ShowImages_Offsite", null, exampleTags);
#line 43
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 44
 testRunner.Given(string.Format("I am on details page for offsite \"{0}\"", iaId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
 testRunner.When("click on preview an image of this record", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
 testRunner.Then("check for the title To download this record without a watermark please add it to " +
                    "your basket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DetailPage_ShowImages_staffin")]
        [NUnit.Framework.TestCaseAttribute("C4236021", null)]
        [NUnit.Framework.TestCaseAttribute("C4235988", null)]
        public virtual void DetailPage_ShowImages_Staffin(string iaId, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DetailPage_ShowImages_staffin", null, exampleTags);
#line 53
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 54
 testRunner.Given(string.Format("I am on details page for staffin \"{0}\"", iaId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 55
 testRunner.When("click on preview an image of this record", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.Then("I shouldn\'t see the message To download this recordwithout watermark please add i" +
                    "t to your basket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify_DetailPage_OnAllLevels")]
        [NUnit.Framework.TestCaseAttribute("C252", null)]
        public virtual void Verify_DetailPage_OnAllLevels(string iaId, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify_DetailPage_OnAllLevels", null, exampleTags);
#line 63
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 64
 testRunner.Given(string.Format("I am on details page for offsite \"{0}\"", iaId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 65
 testRunner.When("verify the reference On Department level", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
 testRunner.And("verify the reference on Division level", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
 testRunner.And("verify series level", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.And("verify Subseries level", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.And("verify subsubseries level", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.Then("I shouls verify Piece level and item level", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify_DetailPage_OnSeriesLevel")]
        [NUnit.Framework.TestCaseAttribute("C12122", "John", "Taylor", "PROB 11", null)]
        [NUnit.Framework.TestCaseAttribute("C1848", "George", "William", "ADM 139", null)]
        [NUnit.Framework.TestCaseAttribute("C15459", "Richard", "William", "BT 377", null)]
        [NUnit.Framework.TestCaseAttribute("C14576", "Thomas", "Allen", "WO 372", null)]
        public virtual void Verify_DetailPage_OnSeriesLevel(string iaId, string firstName, string lastName, string filter, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify_DetailPage_OnSeriesLevel", null, exampleTags);
#line 76
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 77
 testRunner.Given(string.Format("I am on details page for offsite \"{0}\"", iaId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 78
 testRunner.When(string.Format("I enter all these \"{0}\", \"{1}\"", firstName, lastName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.Then(string.Format("check for \"{0}\",\"{1}\" from the first record and check \"{2}\"", firstName, lastName, filter), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify_DetailPage_OnSeriesLevel_Validation")]
        [NUnit.Framework.TestCaseAttribute("C12122", "George", "Mary", null)]
        [NUnit.Framework.TestCaseAttribute("C1848", "Abraham", "Royal", null)]
        public virtual void Verify_DetailPage_OnSeriesLevel_Validation(string iaId, string fromDate, string toDate, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify_DetailPage_OnSeriesLevel_Validation", null, exampleTags);
#line 88
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 89
 testRunner.Given(string.Format("I am on details page for offsite \"{0}\"", iaId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 90
 testRunner.When(string.Format("I enter charcters in \"{0}\", \"{1}\"", fromDate, toDate), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 91
 testRunner.Then("check for the validation message You have entered invalid date format", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
