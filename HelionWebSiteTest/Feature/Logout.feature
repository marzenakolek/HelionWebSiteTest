Feature: Logout
	Log out from Website

@mytag
Scenario: Scenario: Sucessfull Log out 
    Given He is on page:"https://helion.pl/users/index.cgi"
	And User enters "pocztatestowa456@o2.pl" as e-mail
	And User enters "test111" as password
	And User click on Log in button
	And He is on site: "https://helion.pl/users/index2.cgi"
	And He hoovers on Twoje konto
	And He click on Log out
	When He is on page:"https://helion.pl/users/?logout=1"
	Then message is onpage:"Zostałeś poprawnie wylogowany"