Feature: SharksprayAutomation
	Matching input-output files hash code


Scenario Outline: Visualize Model Data.
Given I have navigated to Sharkspray Web Application.
Then I set <AdhesiveType> and <ModelPhase> from sheet.
And I compare <dma_filename>,<compression_filename> and <tension_filename> from the sheet and upload it.
Then I select <deformation_mode> from sheet.
And Clicked on the genrate constitutive mechanical model button.
Then On visualize model page click on the save chart as png button.
And Click on export and save model check-box and description.
Then Click on the save select model button and verify it.
And Click on the export external data package(*.ZIP) and verify if it downloaded.
Then Extract the downloaded file.
And Comapre external downloaded zip file with <reference_filename> file
@source:Sharkspray_Testcases.xlsx:sheet1
Examples:
|Sno.|name|dma_filename|compression_filename|tension_filename|reps|AdhesiveType|ModelPhase|deformation_mode|should_build|reference_filename|