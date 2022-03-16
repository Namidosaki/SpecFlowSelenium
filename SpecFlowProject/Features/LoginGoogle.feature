Feature: Login email Google
	

@positive
Scenario Outline: Sign in to Google Mail with correct data
	Given open the Google website
	When enter the "<login>" "login"
	And click the "login" button
	When enter the "<password>" "password"
	And click the "password" button
	Then expected result is opened
Examples: 
| login                      | password   |
| exampleforteasts@gmail.com | QWERty1982 |
| exampleforteasts			 | QWERty1982 |

@negative
Scenario Outline: Sign in to Google Mail with incorrect login
	Given open the Google website
	When enter the "<login>" "login"
	And click the "login" button
	Then next page doesn't open
Examples: 
| login               |
| examplers@gmail.com |
| examplers			  |

@negative
Scenario Outline: Sign in to Google Mail with correct login and incorrect password
	Given open the Google website
	When enter the "<login>" "login"
	And click the "login" button
	When enter the "<password>" "password"
	And click the "password" button
	Then expected result isn't opened
Examples: 
| login                      | password   |
| exampleforteasts@gmail.com | qwerty1982 |
| exampleforteasts			 | qwerty1982 |