Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@smokeTest
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add 
	Then the result should be 120 on the screen



Scenario: Create a new employee with mandatary details
	#Given I have opened my application
	#Then I should see employee details page
	When I fill all the mandatory details in form
	| Name    | Age | Phone     | Email        |
	| karthik | 28  | 112548523 | ka@gmail.com |
	| huamin | 28  | 112556568523 | aa@gmail.com |
	| zhang | 28  | 112548234234523 |huahuaa@gmail.com |
	#And I click the save button
	#Then I should see all the details saved in my appliation and DB

	#use single scenaril to run mutipul datas,need to use Example
Scenario Outline: Create a new employee with mandatary details for multiple datas on
	#Given I have opened my application
	#Then I should see employee details page
	When I fill all the mandatory details to form <Name>,<Age> and <Phone>
	#And I click the save button
	#Then I should see all the details saved in my appliation and DB
Examples: 
	| Name    | Age | Phone           |
	| karthik | 28  | 112548523       |
	| huamin  | 28  | 112556568523    |
	| zhang   | 28  | 112548234234523 |


	Scenario: check if i could get the details entred via Table from extended stps
	When I fill all the mandatory details in form
	| Name   | Age | Phone  | Email     |
	| huamin | 44  | 998899 | huh@hh.hh |
	Then I should the the same value from Extended steps


