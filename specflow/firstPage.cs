using OpenQA.Selenium;

namespace specflow
{
    class FirstPage : BasePage
    {
        public FirstPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement searchBar => driver.FindElement(By.Name("q"));

        private IWebElement firstSearchResult => driver.FindElement(
            By.CssSelector("#rso > div:nth-child(1) > div > div > div > div h3"));

        public void goTo()
        {
            driver.Navigate().GoToUrl("https://www.google.co.uk");
        }

        public void searchForTrainline()
        {
            enterText(searchBar, "padmaraj nidagundi");
            pressEnter();
        }

        public void clickOnSite()
        {
            waitAndClick(firstSearchResult);
        }
    }
}
