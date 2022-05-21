Feature: SpecflowWebDriver

Login into website

Scenario: Login into web site
	Given Go To Url 'url'
	When Fill 'LoginFormField' by 'login'
	When Fill 'PasswordFormField' by 'pwd'
	When Click By Path 'LoginButton'
	And Wait 10000
	Then See Console Empty
