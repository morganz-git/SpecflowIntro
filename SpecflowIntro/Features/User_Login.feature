Feature: User_Login
simple feature to demostrate user login feature

@user_login
Scenario: Login for user portal
	Given I have open the application
	And I login to application
	Then I see user portal, the date is 5 days from current time
	And I see the menus live
	| Menu1 | Menu2   | Menu3    | Menu4    |
	| Login | Setting | Loginout | Advanced |
