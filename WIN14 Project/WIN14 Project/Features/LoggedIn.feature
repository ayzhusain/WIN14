Feature: Logged In
	When you are logged in

@mytag
Scenario: When you are logged in
	Given That you are logged in
	When You are at the startpage
	Then See your status "You are logged in"