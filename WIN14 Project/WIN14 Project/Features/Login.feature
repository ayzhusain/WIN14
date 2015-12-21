Feature: Login

@mytag
Scenario: Login to webshop
	Given I am on the login page
	When I input my user name and password
	Then I should get confirmation