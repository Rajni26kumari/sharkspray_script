Feature: VisualizeModelData

Scenario:_24 Verify Selected Model.
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
And verify Selected Model.

Scenario: _25 Verify chart type
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
And select chart type from dropdown.
|ChartType  |
| Rheology Master Curve | 

Scenario: _26 Verify Master Curve Reference Temperature
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
Then Clear the default value and enter the new value

Scenario: _27 Verify update master curve button status
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
Then Clear the default value and enter the new value
And check the status of update master curve button

Scenario:_28 Verify Chart save.
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
Then click on save chart as png.
And verify file saved.
