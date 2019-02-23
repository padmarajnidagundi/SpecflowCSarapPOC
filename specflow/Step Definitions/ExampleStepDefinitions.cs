using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace specflow
{
    [Binding]
    public sealed class ExampleStepDefinitions
    {
        static DriverFactory driverFactory = new DriverFactory();
        static IWebDriver driver = driverFactory.getDriver();
        FirstPage firstpage = new FirstPage(driver);

        [Given(@"I am on google")]
        public void GivenIAmOnGoogle()
        {
            firstpage.goTo();
            Console.WriteLine("Opened URL");
        }

        [Given(@"I search for the website")]
        public void GivenISearchForTheWebsite()
        {
            firstpage.searchForTrainline();
            Console.WriteLine("searched");
        }

        [When(@"I click on the result")]
        public void WhenIClickOnTheResult()
        {
            firstpage.clickOnSite();
            Console.WriteLine("clicked on site");

        }

        [Then(@"the page title will be correct")]
        public void ThenThePageTitleWillBeCorrect()
        {
            Assert.AreEqual("Padmaraj Nidagundi - Google Scholar Citations", driver.Title);
            Console.WriteLine("Page title is correct");
        }

        [AfterTestRun]
        public static void AfterWebFeature()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
