Feature: LoadYourModels
	
Scenario:_17 Verify Searchbox
Given Go to url.
When user login with credentials
Then Click on Load your Models .
And search for a model.
Then verify if model is retreived or not.

Scenario:_18 Model Name Selection.
Given Go to url.
When user login with credentials
Then Click on Load your Models .
Then Select a model to load.
And Verify model selection.

Scenario:_19 Load Constitutive Mechanical Model Verification.
Given Go to url.
When user login with credentials
Then Click on Load your Models .
Then Select a model to load.
And click on load constitutive mechanical model button.
Then Verify load constitutive mechanical model button clicked.











