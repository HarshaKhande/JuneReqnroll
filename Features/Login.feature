Feature: Login

test the login functionality


Background: 
	Given User is on the orangehrm login page

 @Regression,@Functional
Scenario: Verify login with valid credentails
	When User enters the username "Admin" and password "admin123" in the text fields
	When User clicks on submit button
	Then User is navigated to home page 

# scenario outline passing test parameters

@Sanity
Scenario Outline: Verify login with diff test parameters
	When User enters the "<username>" and "<password>" in the input fields 
	And User clicks on submit button
	Then User is navigated to home page
	 

Examples: 
	| username | password |
	| Admin    | admin123 |
	| Ad       | adn      |
	| Adm      | an       |

# Data tables passing arguments to test steps 

@Sanity
Scenario Outline: Verify login with data table  parameters
	When User enters the "<username>" and "<password>" in the input fields 
	And User clicks on submit button
	Then User is navigated to home page
	Then User selected city and country information
	| city   | country |
	| Delhi  | India   |
	| Boston | USA     | 

Examples: 
	| username | password |
	| Admin    | admin123 |
	| Ad       | adn      |
	| Adm      | an       |



		

