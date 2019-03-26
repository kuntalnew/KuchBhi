Feature: POMPAYTMFeature
Description: Some basic features of Paytm
	

@paytm
Scenario: Verifying number of services provided by Paytm
	Given I am on the home page of Paytm
	Then the number of services can be verified

@paytm
Scenario: Verifying prepaid mobile recharge-1
	Given I am on the home page of Paytm
	When I click on the radio button Mobile
	Then the paytm website should redirect to https://paytm.com/recharge

@paytm
Scenario: Verifying prepaid mobile recharge-2
	Given I am on the home page of Paytm
	When I select the option Mobile
	And I enter valid prepaid mobile number and amount
	And I click on the button Proceed to recharge
	Then The button Proceed to Pay the amount is displayed
	And The paytm website should redirect tos https://paytm.com/coupons