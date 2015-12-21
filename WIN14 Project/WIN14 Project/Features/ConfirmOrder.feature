Feature: ConfirmOrder

@mytag
Scenario: Confirm the order
	Given I stand on checkout page
	When I press Confirm order
	Then Show Thank You message
