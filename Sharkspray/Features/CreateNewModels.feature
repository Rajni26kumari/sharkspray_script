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

Scenario: _04 DMA files upload verification.
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

Scenario: _05 Cancel Upload Button verification.
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
Then Click on cancel upload button to cancel uploading the file.
And click on OK from the popup to confirm upload cancellation.

Scenario:_06 Remove file button verification.
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
Then click on remove file button to delete the uploaded file.

Scenario:_07 Verification of Clear All Files Button.
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
Then  Click on Clear All Files Button.
And Verify removal of files.

Scenario:_08 Verification of Deformation Mode dropdown.
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
And Select deformation Mode from dropdown.
| DeformationMode  |
| Tension | 

Scenario:_09 Verification of Density.
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
And Send density value.

Scenario:_10 Verification of generate constitutive  mechanical model button.
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
And Select deformation Mode from dropdown.
| DeformationMode  |
| Tension | 
And click on generate constitutive mechanical model button.

Scenario:_11 Multiple DMA (compress) file upload.
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
Then Click on Division Dropdown.
And Select Division from dropdown.
| Division |
|  EMSD        |
And  click on drop DMA files button and upload file.
Then Upload compression file.

Scenario:_12 Multiple DMA (Tesnion) file upload.
Given Go to url.
When user login with credentials
Then After landing on sharkspray page, click on AdhesiveType Dropdown.
And Select adhesive type from dropdown.
| AdhesiveType                               |
|PSA - Adhesive Double-Coated Tape (DCT)|
Then click on Model Phase Dropdown.
And Select Model Phase from dropdown.
| ModelPhase   |
| Phase 3(DMA + Compression + Tension) |
Then Click on Division Dropdown.
And Select Division from dropdown.
| Division |
|  EMSD        |
And  click on drop DMA files button and upload file.
Then Upload compression file.
And Upload tension file.