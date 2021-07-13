Feature: ExportandSaveModels

Scenario:_29 Loaded Models Selection.
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
|  EMSD        |
And  click on drop DMA files button and upload file.
And  Verify file upload.
Then Click on model name text-box and write a name.
And Select deformation Mode from dropdown.
| DeformationMode  |
| Shear | 
And click on generate constitutive mechanical model button.
Then click on Model Name.
And Verify Selection Of Model Name.

Scenario:_30 'Save Selected Model' Button Verification.
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
|  EMSD        |
And  click on drop DMA files button and upload file.
And  Verify file upload.
Then Click on model name text-box and write a name.
And Select deformation Mode from dropdown.
| DeformationMode  |
| Shear | 
And click on generate constitutive mechanical model button.
Then click on Model Name.
And  Click on Save Selected  Models Button.
And Verify Model saved.

Scenario:_31 'Export External Data Package' Verification.
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
|  EMSD        |
And  click on drop DMA files button and upload file.
And  Verify file upload.
Then Click on model name text-box and write a name.
And Select deformation Mode from dropdown.
| DeformationMode  |
| Shear | 
And click on generate constitutive mechanical model button.
Then click on Model Name.
And click on Export External Data Package(zip) button.
And Click to unzip the downloaded file.