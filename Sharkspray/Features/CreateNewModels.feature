Feature: CreateNewModels
Scenario:_01 Verify AdhesiveType dropdown.
Given Go to url.
When user login with credentials
Then After landing on sharkspray page, click on AdhesiveType Dropdown.
And Select adhesive type from dropdown.
| AdhesiveType                               |
|PSA - Adhesive Double-Coated Tape (DCT)|

Scenario:_02 Verify Model Phase Dropdown.
Given Go to url.
When user login with credentials
Then After landing on sharkspray page, click on AdhesiveType Dropdown.
And Select adhesive type from dropdown.
| AdhesiveType                               |
|PSA - Adhesive Double-Coated Tape (DCT)|
Then click on Model Phase Dropdown.
And Select Model Phase from dropdown.
| ModelPhase   |
| Phase 2(DMA + Compression) | 

Scenario: _03 Verify division Dropdown
Given Go to url.
When user login with credentials
Then After landing on sharkspray page, click on AdhesiveType Dropdown.
And Select adhesive type from dropdown.
| AdhesiveType                               |
|PSA - Adhesive Double-Coated Tape (DCT)|
Then click on Model Phase Dropdown.
And Select Model Phase from dropdown.
| ModelPhase   |
| Phase 1(DMA) |
Then Click on Division Dropdown.
And Select Division from dropdown.
| Division |
|  IATD        |  
