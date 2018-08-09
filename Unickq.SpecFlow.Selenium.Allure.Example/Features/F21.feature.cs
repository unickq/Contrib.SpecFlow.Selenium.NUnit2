﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Unickq.SpecFlow.Selenium.Example.Features
{
    using TechTalk.SpecFlow;
    using Unickq.SpecFlow.Selenium.Helpers;
    using Unickq.SpecFlow.Selenium;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("f2")]
    [NUnit.Framework.ParallelizableAttribute()]
    public partial class F2Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private UnickqSpecFlowSeleniumGeneratorHelper helper;
        
        [NUnit.Framework.OneTimeSetUp()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "f2", "As Dasdsadsa\r\nsadas\r\nasd\r\nsad\r\nsa\r\ndas\r\nd\r\nas", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
            helper = new UnickqSpecFlowSeleniumAllureGeneratorHelper(testRunner);
            helper.FeatureSetup();
        }
        
        [NUnit.Framework.OneTimeTearDown()]
        public virtual void FeatureTearDown()
        {
            helper.FeatureTearDown();
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
            helper.SetUp();
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            helper.TearDown();
            helper.ClearScenarioContext(testRunner.ScenarioContext, "author");
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.Add("Driver", helper.Driver);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check website title")]
        [NUnit.Framework.TestCaseAttribute("ChromeDebug", "Nick", "Gwoogle", null, Category="ChromeDebug,Nick", TestName="CheckWebsiteTitle with ChromeDebug,Nick and \"Gwoogle\"")]
        public virtual void CheckWebsiteTitle(string browser, string author, string @string, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Browser:ChromeDebug",
                    "author:Nick"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check website title", @__tags);
            this.ScenarioSetup(scenarioInfo);
            testRunner.ScenarioContext.Add("author", author);
            testRunner.Given("I have opened https://translate.google.com/", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then(string.Format("the title should contain \'{0}\'", @string), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check website title 2")]
        [NUnit.Framework.TestCaseAttribute("ChromeDebug", "xxx", "Google", null, Category="ChromeDebug,xxx", TestName="CheckWebsiteTitle2 with ChromeDebug,xxx and \"Google\"")]
        [NUnit.Framework.TestCaseAttribute("BrowserStack_Win10_Chrome", "xxx", "Google", null, Category="BrowserStack_Win10_Chrome,xxx", TestName="CheckWebsiteTitle2 with BrowserStack_Win10_Chrome,xxx and \"Google\"")]
        public virtual void CheckWebsiteTitle2(string browser, string author, string @string, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Browser:ChromeDebug",
                    "Browser:BrowserStack_Win10_Chrome",
                    "author:xxx"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check website title 2", @__tags);
            this.ScenarioSetup(scenarioInfo);
            testRunner.ScenarioContext.Add("author", author);
            testRunner.Given("I have opened https://translate.google.com/", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then(string.Format("the title should contain \'{0}\'", @string), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion