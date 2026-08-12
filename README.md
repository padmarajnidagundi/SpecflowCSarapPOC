# SpecFlow C# Automated Selenium Testing Framework - WebDriver

A Page Object Model (POM) based BDD test automation framework using **SpecFlow 3**, **Selenium WebDriver 4**, and **NUnit 3** targeting .NET Framework 4.6.1.

---

## Prerequisites

- Visual Studio 2019 or later (with .NET desktop development workload)
- Google Chrome (latest)
- NuGet Package Restore (automatic in VS)

---

## Package Versions

| Package | Version |
|---|---|
| Selenium.WebDriver | 4.18.1 |
| Selenium.Support | 4.18.1 |
| Selenium.WebDriver.ChromeDriver | 120.x |
| SpecFlow | 3.9.74 |
| SpecFlow.NUnit | 3.9.74 |
| NUnit | 3.14.0 |
| NUnit3TestAdapter | 4.5.0 |
| Newtonsoft.Json | 13.0.3 |

---

## How to Run

1. Open `specflow.sln` in Visual Studio
2. Right-click solution → **Restore NuGet Packages**
3. **Build** → **Clean Solution**, then **Build Solution**
4. Open **Test** → **Test Explorer**
5. Click **Run All Tests**

---

## Project Structure

```
specflow/
├── Features/
│   └── SpecFlowFeature1.feature   # BDD scenarios (Gherkin)
├── Step Definitions/
│   └── ExampleStepDefinitions.cs  # Step bindings
├── BasePage.cs                    # Base page with shared WebDriver helpers
├── DriverFactory.cs               # ChromeDriver factory/singleton
└── firstPage.cs                   # Page Object for Google search page
```

---

## Notes

- `PageFactory` / `FindsBy` attributes were removed as they are **deprecated** in Selenium 4. Elements are now located using standard `By` locators via `driver.FindElement()`.
- `WebDriverWait` is configured for a **20-second** explicit wait timeout.
- ChromeDriver is managed via the `Selenium.WebDriver.ChromeDriver` NuGet package — no manual driver download needed.

---

## Useful Links

- [SpecFlow Documentation](https://docs.specflow.org/)
- [Selenium WebDriver .NET](https://www.selenium.dev/documentation/webdriver/)
- [NUnit Assertions](https://docs.nunit.org/articles/nunit/writing-tests/assertions/assertion-models/classic.html)

---

## Keywords

page object model c# selenium specflow · specflow 3 · selenium 4 · nunit · bdd c# · chromedriver · page object model tutorial

