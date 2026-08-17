Feature: API Tests
	Verify REST API endpoints using JSONPlaceholder

@APITest
Scenario: Get a single post returns 200 status
	Given I send a GET request to "/posts/1"
	Then the response status code should be 200

@APITest
Scenario: Get a single post returns expected title
	Given I send a GET request to "/posts/1"
	Then the response body should contain "sunt aut facere repellat provident occaecati excepturi optio reprehenderit"

@APITest
Scenario: Get all posts returns a list
	Given I send a GET request to "/posts"
	Then the response status code should be 200
	And the response should contain more than 0 items

@APITest
Scenario: Create a new post returns 201 status
	Given I send a POST request to "/posts" with body:
		"""
		{
			"title": "SpecFlow API Test",
			"body": "This is a test post",
			"userId": 1
		}
		"""
	Then the response status code should be 201

@APITest
Scenario: Get a non-existent post returns 404 status
	Given I send a GET request to "/posts/9999"
	Then the response status code should be 404
