Feature: EditYourModels
Scenario:_13 Verify Searchbox of edit your Models.
Given Go to url.
When user login with credentials
Then Click on Edit Your Models.
And click on searchbox button and send search input.

Scenario:_14 Update selected Model.
Given Go to url.
When user login with credentials
Then Click on Edit Your Models.
And Select on model to be edited
And Update model.
Then click on Update selected Model Button.
And verify that model was updated

Scenario:_15 Delete selected Model.
Given Go to url.
When user login with credentials
Then Click on Edit Your Models.
And Select on model to be edited
Then click on Delete Selected Models Button.
And click on button to confirm delete.

Scenario: _16 Cancel Delete selected Model
Given Go to url.
When user login with credentials
Then Click on Edit Your Models.
And Select on model to be edited
Then click on Delete Selected Models Button.
And Click on cancel button.








