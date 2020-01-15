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
    [NUnit.Framework.DescriptionAttribute("Ecommerce")]
    public partial class EcommerceFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Ecommerce.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-GB"), "Ecommerce", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("certifiedNaturalisationRequest")]
        [NUnit.Framework.TestCaseAttribute("C16120922", null)]
        public virtual void CertifiedNaturalisationRequest(string iaId, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("certifiedNaturalisationRequest", null, exampleTags);
#line 3
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
 testRunner.Given(string.Format("I am on eCommerce page for \"{0}\"", iaId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
 testRunner.And("Request a copy, add to basket, checkout and signed in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 6
 testRunner.When("click on proceed, T&C, pay through paypal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
 testRunner.Then("I should see Thank you for your order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DigitizedAddToBasket")]
        [NUnit.Framework.TestCaseAttribute("C7351413", null)]
        public virtual void DigitizedAddToBasket(string iaId, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DigitizedAddToBasket", null, exampleTags);
#line 13
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 14
 testRunner.Given(string.Format("I am on eCommerce page for \"{0}\"", iaId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
 testRunner.When("add to basket, go to basket, viewbasket,checkout, enter email address under send " +
                    "a reciept", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.And("T&C, Submit order pay through paypal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.Then("I should see Thank you for your order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("YourOrders_RequestAcopy")]
        [NUnit.Framework.TestCaseAttribute("C16120922", null)]
        [NUnit.Framework.TestCaseAttribute("C7351413", null)]
        public virtual void YourOrders_RequestAcopy(string iaId, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("YourOrders_RequestAcopy", null, exampleTags);
#line 23
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 24
 testRunner.Given(string.Format("I am on eCommerce page for \"{0}\"", iaId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
 testRunner.And("Request a copy, add to basket, checkout and signed in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.When("click on proceed, T&C, pay through paypal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.Then("go to your orders and I can see order number from your orders list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("FOI1939 register")]
        [NUnit.Framework.TestCaseAttribute("ThisIsATest", "George", "Female", "01/01/1900", "notSubject", "Tester", "SurTester", "tnadiscovery100@gmail.com", "tnadiscovery100@gmail.com", "63highstreet", "London", "tw96nu", "United Kingdom", null)]
        [NUnit.Framework.TestCaseAttribute("ThisIsATest", "James", "Male", "01/11/1890", "isSubject", "Tester", "SurTester", "tnadiscovery100@gmail.com", "tnadiscovery100@gmail.com", "99 highway road", "London", "tw81nn", "United Kingdom", null)]
        public virtual void FOI1939Register(string searchFirstName, string searchLastName, string gender, string dOB, string dataSubjectAccess, string firstName, string lastName, string email, string confirmEmail, string address, string townCity, string postcode, string country, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("FOI1939 register", null, exampleTags);
#line 34
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 35
 testRunner.Given("I am on Request a search of closed records page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
 testRunner.When(string.Format("I enter the details \"{0}\", \"{1}\",\"{2}\",\"{3}\",\"{4}\", upload proof of identity", searchFirstName, searchLastName, gender, dOB, dataSubjectAccess), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.And(string.Format("I enter contact details \"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\"", firstName, lastName, email, confirmEmail, address, townCity, postcode, country), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("Submit request", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.Then("I can see confirmation page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("HomeGuard")]
        [NUnit.Framework.TestCaseAttribute("90ad00a1aa6149efa3991fab6037a5ec", "test", "testing for something", "tnadiscovery100@gmail.com", "99", "coventry", "cv25hz", "United Kingdom", null)]
        [NUnit.Framework.TestCaseAttribute("c5c872216727433d95c427b801b9a9ba", "test", "testing for something", "tnadiscovery100@gmail.com", "65", "london", "tw96aw", "United Kingdom", null)]
        [NUnit.Framework.TestCaseAttribute("9f6e3f6c40ce4cdd9707728b7348c84d", "test", "testing for something", "tnadiscovery100@gmail.com", "789", "reading", "rg16jr", "United Kingdom", null)]
        public virtual void HomeGuard(string iaId, string firstName, string lastName, string email, string adress1, string townCity, string postcode, string country, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HomeGuard", null, exampleTags);
#line 46
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 47
 testRunner.Given(string.Format("I am on FOI request page for \"{0}\"", iaId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 48
 testRunner.When(string.Format("I upload evidence of death, enter \"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\"", firstName, lastName, email, adress1, townCity, postcode, country), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
 testRunner.And("add to basket, go to basket, viewbasket,checkout, enter email address under send " +
                    "a reciept", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And("T&C, Submit order pay through paypal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.Then("I should see Thank you for your order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("PageCheckRequestACopy")]
        [NUnit.Framework.TestCaseAttribute("C6553048", null)]
        [NUnit.Framework.TestCaseAttribute("C4771085", null)]
        public virtual void PageCheckRequestACopy(string iaId, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PageCheckRequestACopy", null, exampleTags);
#line 59
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 60
 testRunner.Given(string.Format("I am on page check page for \"{0}\"", iaId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 61
 testRunner.When("click on Get started, enter details, add to basket, checkout, signed in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
 testRunner.And("T&C, Submit order pay through paypal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.Then("I should see Thank you for your order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("PageCheckRequestACopy_Morethan1000Characters")]
        [NUnit.Framework.TestCaseAttribute("C2050263", null)]
        [NUnit.Framework.TestCaseAttribute("C2849839", null)]
        public virtual void PageCheckRequestACopy_Morethan1000Characters(string iaId, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("PageCheckRequestACopy_Morethan1000Characters", "This scenario we are checking the validation message by entering morethan 1000 ch" +
                    "arcters in customer instructions field.", exampleTags);
#line 70
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 72
 testRunner.Given(string.Format("I am on page check page for \"{0}\"", iaId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 73
 testRunner.When("click on Get started, enter morethan one thousand characters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
 testRunner.Then("I can see a message Customer Instructions cannot exceed one thousand characters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("FOIRequest_WO416")]
        [NUnit.Framework.TestCaseAttribute("C14568023", "Test", "George", "10/11/1888", "Army", "Tester", "SurTester", "tnadiscovery100@gmail.com", "99", "coventry", "cv25hz", "United Kingdom", null)]
        [NUnit.Framework.TestCaseAttribute("C14567986", "Test", "David", "05/03/1770", "Royal Navy", "test", "tester", "tnadiscovery100@gmail.com", "65", "london", "tw96aw", "United Kingdom", null)]
        [NUnit.Framework.TestCaseAttribute("C14567986", "Test", "David", "05/03/1770", "Royal Air Force", "test", "tester", "tnadiscovery100@gmail.com", "65", "Reading", "tw96aw", "Afghanistan", null)]
        public virtual void FOIRequest_WO416(string iaId, string searchFirstName, string searchLastName, string dOB, string category, string firstName, string lastName, string email, string adress1, string townCity, string postcode, string country, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("FOIRequest_WO416", null, exampleTags);
#line 81
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 82
 testRunner.Given(string.Format("I am on eCommerce page for \"{0}\"", iaId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 83
 testRunner.When(string.Format("click on request a search of closed records, enter search details \"{0}\",\"{1}\",\"{2" +
                        "}\",\"{3}\"", searchFirstName, searchLastName, dOB, category), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
 testRunner.And(string.Format("I upload evidence of death, enter \"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\"", firstName, lastName, email, adress1, townCity, postcode, country), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
 testRunner.And("add to basket, go to basket, viewbasket,checkout, enter email address under send " +
                    "a reciept", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
 testRunner.And("T&C, Submit order pay through paypal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
 testRunner.Then("I should see Thank you for your order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
