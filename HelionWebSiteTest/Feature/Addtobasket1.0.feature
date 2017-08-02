Feature: Adding item to bascet
     In order to buy item
	I want to add item to my basket
@mytag
Scenario: Sucessfull adding item to basket
	Given User is on webpage: "http://helion.pl/"
	When User enters "C#"
	And Click Search button
	And Click searched item
	And Clik Add to bascet button
	And Click bascet ikon and goes to bascet
	Then Check if item : "C#. Praktyczny kurs. Wydanie III" is in bascet
