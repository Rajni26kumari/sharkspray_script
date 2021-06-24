Feature: HashCodeComparison
	

Scenario:_32 HashComparison
Given I Check whether directories are available or not
When I Unzip the file
And I Calculate hash code of the files
Then I Compare the hash codes