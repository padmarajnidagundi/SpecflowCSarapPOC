# SpecFlow + Selenium + AI Agents POC (2026)

This repository is a lightweight **BDD + Page Object Model (POM)** proof of concept built with **SpecFlow 3**, **Selenium WebDriver 4**, and **NUnit 3**. It originally validated a browser automation flow in a simple, maintainable way, and it now serves as a practical starting point for **AI-assisted quality engineering** in 2026.

The example scenario demonstrates a basic UI journey:

- open Google
- search for **Padmaraj Nidagundi**
- open the first result
- verify the page title

## Why this repo matters in 2026

Modern test automation is no longer just about recording scripts and running them in CI. In 2026, the best teams combine:

- **AI-native test authoring** to generate and refine Gherkin scenarios and step definitions
- **agentic automation** for diagnosis, maintenance, and test orchestration
- **MCP-based tool interoperability** so AI agents can safely inspect logs, files, and test artifacts
- **self-healing selectors** and resilient waits to reduce flaky automation
- **observability-first execution** with traceable failures, screenshots, and browser diagnostics
- **shift-left quality practices** that bring validation earlier in delivery workflows

This repository provides a simple, understandable baseline for those trends without the complexity of a full enterprise stack.

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

## AI and automation trends shaping this repo

### 1. Agentic QA
A modern QA workflow increasingly uses AI agents to:

- generate new scenarios from product requirements
- explain failing UI tests in plain English
- identify root causes in selectors, timing, or app state
- maintain page objects as the UI evolves

### 2. MCP-first interoperability
The **Model Context Protocol (MCP)** is becoming a standard way for tools and agents to connect to:

- execution logs
- browser metadata
- test reports
- application configuration
- CI artifacts

This repo is intentionally positioned as a good candidate for MCP-driven orchestration and analysis.

### 3. Self-healing and resilient automation
Industry leaders are moving away from brittle hard-coded selectors toward:

- stable locators
- semantic targeting
- explicit wait strategies
- dynamic fallback logic
- visual and accessibility validation

### 4. AI-enhanced developer workflows
Teams are using AI to:

- create reusable step definitions
- summarize failure patterns
- improve documentation
- review dependency drift and upgrade risk
- generate maintainable test data

### 5. Cloud-native browser execution
The next generation of automation runs in containerized or cloud-hosted browser environments with:

- faster parallel execution
- better artifact retention
- richer telemetry
- easier scaling across browsers and regions

## Repository structure

```text
specflow/
├── Features/
│   ├── ApiTests.feature
│   └── SpecFlowFeature1.feature
├── Step Definitions/
│   ├── ApiStepDefinitions.cs
│   └── ExampleStepDefinitions.cs
├── BasePage.cs
├── DriverFactory.cs
├── firstPage.cs
├── App.config
├── packages.config
├── specflow.csproj
├── specflow.sln
└── Properties/
    └── AssemblyInfo.cs
```

## How to run

1. Open `specflow.sln` in Visual Studio, or use the .NET CLI where available.
2. Restore NuGet packages.
3. Build the solution.
4. Run the tests from **Test Explorer** or via your configured runner.
5. Review browser output and logs to diagnose failures.

## Notes

- `PageFactory` is intentionally not used because it is deprecated in Selenium 4.
- Elements are located with standard `By` selectors and `driver.FindElement(...)` calls.
- ChromeDriver is provided by the NuGet package already referenced in the project.
- The project targets **.NET Framework 4.6.1**, which makes it a useful legacy-compatible baseline, but not a long-term target for new greenfield automation.

## Modernization roadmap

This repo is a good base for upgrading toward a modern 2026-ready QA architecture:

- migrate from **.NET Framework 4.6.1** to a supported modern .NET target
- add **CI-first execution** with browser automation in GitHub Actions, Azure DevOps, or another pipeline
- separate **test data**, config, and environment variables from test code
- improve **wait strategy**, selector stability, and page object ergonomics
- integrate **MCP and AI agents** for scenario generation, debugging, and reporting
- add richer **test reporting**, screenshots, and failure triage workflows
- move toward **parallel, cloud-run browser execution** and artifact-based validation

## Suggested AI-enabled next steps

- generate more business-facing Gherkin scenarios from feature specs
- use AI agents to synthesize missing step definitions and page object updates
- connect browser execution to MCP-compatible tooling for log ingestion and diagnostics
- build an AI-assisted triage workflow for flaky selectors and intermittent test issues
- document a migration path to .NET 8/9 and modern browser automation practices

## Useful links

- [SpecFlow Documentation](https://docs.specflow.org/)
- [Selenium WebDriver .NET](https://www.selenium.dev/documentation/webdriver/)
- [NUnit Documentation](https://docs.nunit.org/)
- [Model Context Protocol](https://modelcontextprotocol.io/)
- [GitHub Copilot](https://github.com/features/copilot)

## Summary

This project demonstrates a classic automation baseline and shows how that same foundation can evolve into an **AI-enabled, MCP-aware, industry-aligned quality engineering platform** for 2026 and beyond.
