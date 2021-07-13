Feature: VerifiedModels

Scenario:_20 Verify SearchBox Functionality.
Given Go to url.
When user login with credentials
Then Click on Verified Models Button.
And Enter data in searchbox.
Then verify search functionality.

Scenario:_21 Verify Download Model(Internal)
Given Go to url.
When user login with credentials
Then Click on Verified Models Button.
And Enter data in searchbox.
Then verify search functionality.
And Download internal model.
Then verify the internal model is downloaded.

Scenario:_22 Verify Download Model(External)
Given Go to url.
When user login with credentials
Then Click on Verified Models Button.
And Enter data in searchbox.
Then verify search functionality.
And Download External verified Model.
Then verify that external model is downloaded.


	



	
	