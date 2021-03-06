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
    [NUnit.Framework.DescriptionAttribute("SARServerTests")]
    public partial class SARServerTestsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SARServerTests.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-GB"), "SARServerTests", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("catalogue description subtitles")]
        [NUnit.Framework.TestCaseAttribute("C14499665", "Record opening date", "Access conditions", "Description", null)]
        [NUnit.Framework.TestCaseAttribute("C4220383", "Reconsideration due in", "Lord Chancellor\'s Instrument", "LCI signed date", null)]
        [NUnit.Framework.TestCaseAttribute("C10878728", "Exemption 2", "FOI decision date", "Legal status", null)]
        [NUnit.Framework.TestCaseAttribute("C10831067", "LCI signed date", "Closure criterion", "Former reference in its original department", null)]
        [NUnit.Framework.TestCaseAttribute("C9501656", "Explanation", "FOI decision date", "Exemption", null)]
        [NUnit.Framework.TestCaseAttribute("C3219685", "Closure criterion", "Lord Chancellor\'s Instrument", "LCI signed date", null)]
        [NUnit.Framework.TestCaseAttribute("224b9e65b97b49dd983c11e9f1b45bf4#", "Exemption 1", "Exemption 3", "Record opening date", null)]
        [NUnit.Framework.TestCaseAttribute("5cbe4cfd2f224c0d9d88fc045b3ee5d9", "Physical description", "FOI decision date", "Exemption 2", null)]
        public virtual void CatalogueDescriptionSubtitles(string iaID, string assetDetails1, string assetDetails2, string assetDetails3, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("catalogue description subtitles", null, exampleTags);
#line 3
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
 testRunner.Given(string.Format("I am on details page for SAR server \"{0}\"", iaID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
 testRunner.When("I check the catalogue description", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 6
 testRunner.Then(string.Format("I should see \"{0}\", \"{1}\",\"{2}\" in catalogue description", assetDetails1, assetDetails2, assetDetails3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
