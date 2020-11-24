﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.5.0.0
//      SpecFlow Generator Version:3.5.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TrainTrain.Domain.Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ReservationDePlacesDansPlusieursWagonUnTrainFeature : object, Xunit.IClassFixture<ReservationDePlacesDansPlusieursWagonUnTrainFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Train.feature"
#line hidden
        
        public ReservationDePlacesDansPlusieursWagonUnTrainFeature(ReservationDePlacesDansPlusieursWagonUnTrainFeature.FixtureData fixtureData, TrainTrain_Domain_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("fr-FR"), "Features", "Réservation de places dans plusieurs wagon (un train)", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Train avec wagon 1 à 70% et wagon 2 vide")]
        [Xunit.TraitAttribute("FeatureTitle", "Réservation de places dans plusieurs wagon (un train)")]
        [Xunit.TraitAttribute("Description", "Train avec wagon 1 à 70% et wagon 2 vide")]
        public virtual void TrainAvecWagon1A70EtWagon2Vide()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Train avec wagon 1 à 70% et wagon 2 vide", null, tagsOfScenario, argumentsOfScenario);
#line 3
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
  testRunner.Given("un premier wagon occupé à 70%", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Etant donné ");
#line hidden
#line 5
  testRunner.And("un deuxième wagon vide", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line hidden
#line 6
  testRunner.When("on réserve 4 places", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quand ");
#line hidden
#line 7
  testRunner.Then("la réservation est validée", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Alors ");
#line hidden
#line 8
  testRunner.And("le prix est de 200 €", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line hidden
#line 9
  testRunner.And("il y a 70 places occupées dans le premier wagon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line hidden
#line 10
  testRunner.And("il y a 4 places occupées dans le deuxième wagon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.5.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ReservationDePlacesDansPlusieursWagonUnTrainFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ReservationDePlacesDansPlusieursWagonUnTrainFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
