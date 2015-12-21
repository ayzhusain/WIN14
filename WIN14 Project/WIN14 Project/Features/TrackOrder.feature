Feature: TrackOrder

@mytag
Scenario: Track Order Location
	Given You have ordernumber/id
	When You enter ordernumber/id
	Then You get location of order/package
