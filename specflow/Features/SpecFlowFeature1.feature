Feature: I go to google search engine
		I search for Padmaraj Nidagundi
		I open first link and verify the title

@SmokeTest
Scenario: Navigate to website from google 
	Given I am on google
	And I search for the website
	When I click on the result
	Then the page title will be correct 
