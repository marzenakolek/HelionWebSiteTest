Feature: HelionLogIn/LogOut
	Testing Log in/Log out on Helion

@mytag
Scenario: Sucessful Log in Helion
	Given User is on page:"https://helion.pl/users/index.cgi"
	And User enters "pocztatestowa456@o2.pl" as e-mail
	And User enters "test111" as password
	And User click on Log in button
	When User is Log in on Helion page: "https://helion.pl/users/index2.cgi"
	Then massage is shown: "Witaj w Twoim koncie"



Scenario: Unsucessful Log in Helion
    Given User is on website: "https://helion.pl/users/index.cgi"
	And User enters "poczta"  e-mail
	And User enters "test"  password
	And User click on Sign Button
	When User is on website: "https://helion.pl/users/index.cgi"
	Then unsucessful log in message is shown: "Niestety podałeś niewłaściwy adres email lub hasło."