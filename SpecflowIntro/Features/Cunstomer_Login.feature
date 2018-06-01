Feature: Customer_Login
simple feature to demostrate customer login feature

@customer_login
Scenario: Login for customer portal
	Given I have open the application
	And I login to application
	Then I see customer portal
