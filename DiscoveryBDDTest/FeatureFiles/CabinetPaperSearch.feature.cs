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
    [NUnit.Framework.DescriptionAttribute("CabinetPaperSearch")]
    public partial class CabinetPaperSearchFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CabinetPaperSearch.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-GB"), "CabinetPaperSearch", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void FeatureBackground()
        {
#line 3
#line 4
 testRunner.Given("I am on cabinetPaperSearch form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("CabinetPapers_Date_descriptionOnly")]
        [NUnit.Framework.TestCaseAttribute("conclusions", "1915", "1980", null)]
        [NUnit.Framework.TestCaseAttribute("memoranda", "1870", "1910", null)]
        [NUnit.Framework.TestCaseAttribute("notebooks", "1800", "1850", null)]
        public virtual void CabinetPapers_Date_DescriptionOnly(string documentType, string fromDate, string toDate, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("CabinetPapers_Date_descriptionOnly", null, exampleTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 7
 testRunner.When(string.Format("enter \"*\", click on \"{0}\", \"{1}\", \"{2}\" and select document description only", documentType, fromDate, toDate), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
 testRunner.Then(string.Format("check for the filters \"{0}\", \"{1}\" and \"{2}\"", documentType, fromDate, toDate), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("CabinetPapers_NoDate_Document_descriptionOnly")]
        [NUnit.Framework.TestCaseAttribute("conclusions", null)]
        [NUnit.Framework.TestCaseAttribute("notebooks", null)]
        [NUnit.Framework.TestCaseAttribute("memoranda", null)]
        public virtual void CabinetPapers_NoDate_Document_DescriptionOnly(string documentType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("CabinetPapers_NoDate_Document_descriptionOnly", null, exampleTags);
#line 16
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 17
 testRunner.When(string.Format("enter \"*\", click on \"{0}\" and select Document description only", documentType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("check for the title Return to cabinet papers website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("CabinetPapers_Educationresources")]
        [NUnit.Framework.TestCaseAttribute("CAB 65", null)]
        [NUnit.Framework.TestCaseAttribute("CAB 129", null)]
        [NUnit.Framework.TestCaseAttribute("CAB 24", null)]
        public virtual void CabinetPapers_Educationresources(string word, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("CabinetPapers_Educationresources", null, exampleTags);
#line 26
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 27
 testRunner.When(string.Format("click on Education resources tab, enter \"{0}\"", word), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("check for the title Return to cabinet papers website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("CabinetPapers_FilterByDifferentDocument_EntireDocument")]
        [NUnit.Framework.TestCaseAttribute("all", null)]
        [NUnit.Framework.TestCaseAttribute("memoranda", null)]
        [NUnit.Framework.TestCaseAttribute("precedentbooks", null)]
        [NUnit.Framework.TestCaseAttribute("notebooks", null)]
        public virtual void CabinetPapers_FilterByDifferentDocument_EntireDocument(string filterByDocumentType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("CabinetPapers_FilterByDifferentDocument_EntireDocument", null, exampleTags);
#line 36
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 37
 testRunner.When(string.Format("enter \"*\" , \"{0}\" and click on entire document", filterByDocumentType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.Then("check for the title Return to cabinet papers website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
