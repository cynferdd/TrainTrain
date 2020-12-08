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
    public partial class ReservationDePlacesSurLeDernierMoisAvecLeveeDes70EtPossibiliteDeSplitFeature : object, Xunit.IClassFixture<ReservationDePlacesSurLeDernierMoisAvecLeveeDes70EtPossibiliteDeSplitFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "DernierMois.feature"
#line hidden
        
        public ReservationDePlacesSurLeDernierMoisAvecLeveeDes70EtPossibiliteDeSplitFeature(ReservationDePlacesSurLeDernierMoisAvecLeveeDes70EtPossibiliteDeSplitFeature.FixtureData fixtureData, TrainTrain_Domain_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("fr-FR"), "Features", "Réservation de places sur le dernier mois avec levée des 70% et possibilité de sp" +
                    "lit", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [Xunit.SkippableFactAttribute(DisplayName="dernier mois avec train à 80% et 70%, et 4 personnes réservent")]
        [Xunit.TraitAttribute("FeatureTitle", "Réservation de places sur le dernier mois avec levée des 70% et possibilité de sp" +
            "lit")]
        [Xunit.TraitAttribute("Description", "dernier mois avec train à 80% et 70%, et 4 personnes réservent")]
        public virtual void DernierMoisAvecTrainA80Et70Et4PersonnesReservent()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("dernier mois avec train à 80% et 70%, et 4 personnes réservent", null, tagsOfScenario, argumentsOfScenario);
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
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Numero",
                            "NbPlaces",
                            "Occupation"});
                table1.AddRow(new string[] {
                            "1",
                            "100",
                            "80%"});
                table1.AddRow(new string[] {
                            "2",
                            "100",
                            "70%"});
#line 4
testRunner.Given("un train avec les wagons suivants :", ((string)(null)), table1, "Etant donné ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "Prenom",
                            "CarteReduction"});
                table2.AddRow(new string[] {
                            "Toto",
                            "Titi",
                            ""});
                table2.AddRow(new string[] {
                            "Tata",
                            "Tyty",
                            ""});
                table2.AddRow(new string[] {
                            "Tutu",
                            "Titi",
                            ""});
                table2.AddRow(new string[] {
                            "Tptp",
                            "Tvtv",
                            ""});
#line 8
testRunner.When("on réserve pour ces voyageurs Un mois avant le départ :", ((string)(null)), table2, "Quand ");
#line hidden
#line 14
testRunner.Then("la réservation est validée", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Alors ");
#line hidden
#line 15
testRunner.And("le prix est de 240 €", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Numero",
                            "NbPlacesOccupees"});
                table3.AddRow(new string[] {
                            "1",
                            "80"});
                table3.AddRow(new string[] {
                            "2",
                            "74"});
#line 16
testRunner.And("les wagons sont composés comme ceci :", ((string)(null)), table3, "Et ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="dernier mois avec train à 95% et 92%, et 10 personnes réservent (split)")]
        [Xunit.TraitAttribute("FeatureTitle", "Réservation de places sur le dernier mois avec levée des 70% et possibilité de sp" +
            "lit")]
        [Xunit.TraitAttribute("Description", "dernier mois avec train à 95% et 92%, et 10 personnes réservent (split)")]
        public virtual void DernierMoisAvecTrainA95Et92Et10PersonnesReserventSplit()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("dernier mois avec train à 95% et 92%, et 10 personnes réservent (split)", null, tagsOfScenario, argumentsOfScenario);
#line 21
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
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Numero",
                            "NbPlaces",
                            "Occupation"});
                table4.AddRow(new string[] {
                            "1",
                            "100",
                            "95%"});
                table4.AddRow(new string[] {
                            "2",
                            "100",
                            "92%"});
#line 22
testRunner.Given("un train avec les wagons suivants :", ((string)(null)), table4, "Etant donné ");
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "Prenom",
                            "CarteReduction"});
                table5.AddRow(new string[] {
                            "Toto",
                            "Titi",
                            ""});
                table5.AddRow(new string[] {
                            "Tata",
                            "Tyty",
                            ""});
                table5.AddRow(new string[] {
                            "Tutu",
                            "Titi",
                            ""});
                table5.AddRow(new string[] {
                            "abcd",
                            "Tvtv",
                            ""});
                table5.AddRow(new string[] {
                            "efgh",
                            "Tvtv",
                            ""});
                table5.AddRow(new string[] {
                            "ijkl",
                            "Tvtv",
                            ""});
                table5.AddRow(new string[] {
                            "mnop",
                            "Tvtv",
                            ""});
                table5.AddRow(new string[] {
                            "qrst",
                            "Tvtv",
                            ""});
                table5.AddRow(new string[] {
                            "uvwx",
                            "Tvtv",
                            ""});
                table5.AddRow(new string[] {
                            "yzab",
                            "Tvtv",
                            ""});
#line 26
testRunner.When("on réserve pour ces voyageurs Un mois avant le départ :", ((string)(null)), table5, "Quand ");
#line hidden
#line 38
testRunner.Then("la réservation est validée", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Alors ");
#line hidden
#line 39
testRunner.And("le prix est de 600 €", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "Numero",
                            "NbPlacesOccupees"});
                table6.AddRow(new string[] {
                            "1",
                            "97"});
                table6.AddRow(new string[] {
                            "2",
                            "100"});
#line 40
testRunner.And("les wagons sont composés comme ceci :", ((string)(null)), table6, "Et ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="dernier mois avec train à 95% et 92%, et 20 personnes réservent (impossible)")]
        [Xunit.TraitAttribute("FeatureTitle", "Réservation de places sur le dernier mois avec levée des 70% et possibilité de sp" +
            "lit")]
        [Xunit.TraitAttribute("Description", "dernier mois avec train à 95% et 92%, et 20 personnes réservent (impossible)")]
        public virtual void DernierMoisAvecTrainA95Et92Et20PersonnesReserventImpossible()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("dernier mois avec train à 95% et 92%, et 20 personnes réservent (impossible)", null, tagsOfScenario, argumentsOfScenario);
#line 45
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
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "Numero",
                            "NbPlaces",
                            "Occupation"});
                table7.AddRow(new string[] {
                            "1",
                            "100",
                            "95%"});
                table7.AddRow(new string[] {
                            "2",
                            "100",
                            "92%"});
#line 46
testRunner.Given("un train avec les wagons suivants :", ((string)(null)), table7, "Etant donné ");
#line hidden
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "Prenom",
                            "CarteReduction"});
                table8.AddRow(new string[] {
                            "Toto",
                            "Titi",
                            ""});
                table8.AddRow(new string[] {
                            "Tata",
                            "Tyty",
                            ""});
                table8.AddRow(new string[] {
                            "Tutu",
                            "Titi",
                            ""});
                table8.AddRow(new string[] {
                            "abcd",
                            "Tvtv",
                            ""});
                table8.AddRow(new string[] {
                            "efgh",
                            "Tvtv",
                            ""});
                table8.AddRow(new string[] {
                            "ijkl",
                            "Tvtv",
                            ""});
                table8.AddRow(new string[] {
                            "mnop",
                            "Tvtv",
                            ""});
                table8.AddRow(new string[] {
                            "qrst",
                            "Tvtv",
                            ""});
                table8.AddRow(new string[] {
                            "uvwx",
                            "Tvtv",
                            ""});
                table8.AddRow(new string[] {
                            "yzab",
                            "Tvtv",
                            ""});
                table8.AddRow(new string[] {
                            "abcd",
                            "Tvtv",
                            ""});
                table8.AddRow(new string[] {
                            "2ata",
                            "Tyty",
                            ""});
                table8.AddRow(new string[] {
                            "2utu",
                            "Titi",
                            ""});
                table8.AddRow(new string[] {
                            "2oto",
                            "Titi",
                            ""});
                table8.AddRow(new string[] {
                            "2fgh",
                            "Tvtv",
                            ""});
                table8.AddRow(new string[] {
                            "2jkl",
                            "Tvtv",
                            ""});
                table8.AddRow(new string[] {
                            "2nop",
                            "Tvtv",
                            ""});
                table8.AddRow(new string[] {
                            "2rst",
                            "Tvtv",
                            ""});
                table8.AddRow(new string[] {
                            "2vwx",
                            "Tvtv",
                            ""});
                table8.AddRow(new string[] {
                            "2zab",
                            "Tvtv",
                            ""});
#line 50
testRunner.When("on réserve pour ces voyageurs Un mois avant le départ :", ((string)(null)), table8, "Quand ");
#line hidden
#line 72
testRunner.Then("la réservation est annulée", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Alors ");
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
                ReservationDePlacesSurLeDernierMoisAvecLeveeDes70EtPossibiliteDeSplitFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ReservationDePlacesSurLeDernierMoisAvecLeveeDes70EtPossibiliteDeSplitFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion