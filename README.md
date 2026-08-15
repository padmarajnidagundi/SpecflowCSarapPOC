# SpecFlow C# Selenium POC

A small **BDD + Page Object Model** proof of concept built with **SpecFlow 3**, **Selenium WebDriver 4**, and **NUnit 3** on **.NET Framework 4.6.1**.

This repository demonstrates a simple end-to-end UI flow:

- open Google
- search for **Padmaraj Nidagundi**
- open the first result
- verify the final page title

## Why this repo is useful

- lightweight starter for SpecFlow + Selenium
- clear Page Object Model structure
- easy to extend for additional UI scenarios
- good base for modernization with **MCP** and **AI agents**

## Current stack

| Package | Version |
|---|---|
| Selenium.WebDriver | 4.18.1 |
| Selenium.Support | 4.18.1 |
| Selenium.WebDriver.ChromeDriver | 120.0.6099.7100 |
| SpecFlow | 3.9.74 |
| SpecFlow.NUnit | 3.9.74 |
| SpecFlow.Tools.MsBuild.Generation | 3.9.74 |
| NUnit | 3.14.0 |
| NUnit3TestAdapter | 4.5.0 |
| Newtonsoft.Json | 13.0.3 |

## Project structure

```text
specflow/
├── Features/
│   └── SpecFlowFeature1.feature
├── Step Definitions/
│   └── ExampleStepDefinitions.cs
├── BasePage.cs
├── DriverFactory.cs
└── firstPage.cs
```

## How to run

1. Open `specflow.sln` in Visual Studio.
2. Restore NuGet packages.
3. Build the solution.
4. Open **Test Explorer**.
5. Run the SpecFlow/NUnit tests.

## Notes

- `PageFactory` is not used because it is deprecated in Selenium 4.
- Elements are located with standard `By` selectors and `driver.FindElement(...)`.
- ChromeDriver is managed through the NuGet package already referenced by the project.
- The project targets **.NET Framework 4.6.1**, so it is best treated as a legacy-compatible POC.

## Modernization direction: MCP + AI Agents

To make this project more modern, use it as a foundation for:

- **MCP-driven test orchestration** to let tools and agents inspect runs, files, and logs in a standard way
- **AI agent assisted test authoring** for generating new Gherkin scenarios, step definitions, and page objects
- **AI-powered failure triage** for analyzing flaky selectors, screenshots, logs, and driver failures
- **Agent-based maintenance** for README updates, dependency review, and test documentation improvements
- **future migration planning** toward newer .NET, stronger test reporting, and CI-first execution

## Suggested next upgrades

- migrate from .NET Framework 4.6.1 to a supported modern .NET target
- add CI execution for browser tests
- separate test data from step definitions
- improve selector resilience and waiting strategy
- add richer reporting for test failures
- introduce MCP/AI workflows for test generation and diagnostics

## Useful links

- [SpecFlow Documentation](https://docs.specflow.org/)
- [Selenium WebDriver .NET](https://www.selenium.dev/documentation/webdriver/)
- [NUnit Documentation](https://docs.nunit.org/)
