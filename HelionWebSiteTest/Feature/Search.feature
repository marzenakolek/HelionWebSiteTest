Feature: Add to bascet
	Adding item to bascet on Helion

@mytag
Scenario: Sucessfull search
	Given User is on page: "http://helion.pl/"
	And User enters "Android" is Search box
	And User Click search button
	And User Click "Android Studio w 24 godziny"
	Then user should bo on page: "http://helion.pl/ksiazki/android-studio-w-24-godziny-wygodne-programowanie-dla-platformy-android-wydanie-iv-carmen-delessio-lauren-darcey-shane-conder,as24w4.htm"
	
