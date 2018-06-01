Feature: User_Login
simple feature to demostrate user login feature

@user_login
Scenario: Login for user portal
	Given I have open the application
	And I login to application
	Then I see user portal
