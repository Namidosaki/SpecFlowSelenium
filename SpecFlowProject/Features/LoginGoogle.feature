Feature: Login email Google
	

@positive
Scenario Outline: Sign in to Google Mail
	Given open the Google website
	When enter the "<login>" "login"
	And click the "login" button
	When enter the "<password>" "password"
	And click the "password" button
	Then expected result is opened
Examples: 
| login                      | password   |
| exampleforteasts@gmail.com | QWERty1982 |