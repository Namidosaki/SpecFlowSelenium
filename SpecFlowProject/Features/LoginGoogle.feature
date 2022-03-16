Feature: Login email Google
	

@positive
Scenario Outline: Sign in to Google Mail with correct data
	Given open the Google website
	When enter the "valid" "<login>" "login"
	And click the "login" button
	When enter the "valid" "<password>" "password"
	And click the "password" button
	Then expected result is opened
Examples: 
| login | password   |
| 0		| 0			 |
| 1		| 1			 |

@negative
Scenario Outline: Sign in to Google Mail with incorrect login
	Given open the Google website
	When enter the "invalid" "<login>" "login"
	And click the "login" button
	Then next page doesn't open
Examples: 
| login |
| 0		|
| 1		|

@negative
Scenario Outline: Sign in to Google Mail with correct login and incorrect password
	Given open the Google website
	When enter the "valid" "<login>" "login"
	And click the "login" button
	When enter the "invalid" "<password>" "password"
	And click the "password" button
	Then expected result isn't opened
Examples: 
| login | password |
| 0		| 0		   |
| 1		| 1		   |
