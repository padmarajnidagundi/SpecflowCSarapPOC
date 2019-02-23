using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace specflow
{
    abstract class BasePage
    {

        protected IWebDriver driver;
        protected WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
           this.wait = new WebDriverWait(driver,new TimeSpan( 20000));
        }

        public void enterText(IWebElement element, String text)
        {
            element.SendKeys(text);
        }

        public void pressEnter()
        {
            IWebElement currentElement = driver.SwitchTo().ActiveElement();
            currentElement.SendKeys(Keys.Return);
        }

        public void waitAndClick(IWebElement element)
        {
              wait.Until(ExpectedConditions.ElementToBeClickable(element));
            element.Click(); 
        }
    }
}
