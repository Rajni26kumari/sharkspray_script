using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharkspray
{
    class ObjectIdentifiers
    {
        
        public static readonly string _adhesiveDropdown = "//*[@id='select-newmodel_adhesive_type_select']";
        public static readonly string _pstt = "//*[@id='menu-newmodel_adhesive_type_select']/div[2]/ul/li[1]";
        public static readonly string _psdct ="//*[@id='menu-newmodel_adhesive_type_select']/div[2]/ul/li[2]";
        public static readonly string _vha = "//*[@id='menu-newmodel_adhesive_type_select']/div[2]/ul/li[3]";
        public static readonly string _oca = "//*[@id='menu-newmodel_adhesive_type_select']/div[2]/ul/li[4]";
        public static readonly string _dropDmaFilesIdentifier = "//*[@id='dmaDrop']";
        public static readonly string _dropCompFilesIdentifier = "//*[@id='comp_drop']";
        public static readonly string _dropTensFilesIdentifier = "//*[@id='root']/div/div/main/div[2]/div/div[2]/div/div/div[2]/div[3]/div/div";
        public static readonly string _removeFileButton = "//*[@id='root']/div/div/main/div[2]/div/div[2]/div/div/div[2]/div[1]/div/div/div[2]/a";
        public static readonly string _cancelUploadButton = "//*[@id='root']/div/div/main/div[2]/div/div[2]/div/div/div[2]/div[1]/div/div/div[2]/a";
        public static readonly string _fileDisplayTable = "/html/body/div[3]/div/div/main/div[2]/div/div[2]/div/div/div[4]/div/div/div/div[3]/table/tbody/tr";
        public static readonly string _clearAllFilesButton = "//*[@id='root']/div/div/main/div[2]/div/div[2]/div/div/div[3]/span/span[1]";
        public static readonly string _generateConstitutiveModelBtn = "//*[@id='root']/div/div/main/div[2]/div/div[2]/div/div/div[5]/div/span/span[1]";
        public static readonly string _deformationModeDropdownBtn = "//*[@id='select-deformation_mode_select']";
        public static readonly string _density = "//*[@id='standard-number']";
        public static readonly string _replicateNumberDropdownBtn = "//*[@id='select-replicate_group_select']";
        public static readonly string _phase1 = "//*[@id='menu-newmodel_phase_select']/div[2]/ul/li[1]";
        public static readonly string _phase2 = "//*[@id='menu-newmodel_phase_select']/div[2]/ul/li[2]";
        public static readonly string _phase3 = "//*[@id='menu-newmodel_phase_select']/div[2]/ul/li[3]";
        public static readonly string _modelPhaseDropdown = "//*[@id='select-newmodel_phase_select']";
        public static readonly string _divisionDropdown = "//*[@id='select-newmodel_division_type_select']";
        public static readonly string _aasd = "//*[@id='menu-newmodel_division_type_select']/div[2]/ul/li[1]";
        public static readonly string _crl = "//*[@id='menu-newmodel_division_type_select']/div[2]/ul/li[2]";
        public static readonly string _dmsd = "//*[@id='menu-newmodel_division_type_select']/div[2]/ul/li[3]";
        public static readonly string _emsd = "//*[@id='menu-newmodel_division_type_select']/div[2]/ul/li[4]";
        public static readonly string _iatd = "//*[@id='menu-newmodel_division_type_select']/div[2]/ul/li[5]";
        public static readonly string _other = "//*[@id='menu-newmodel_division_type_select']/div[2]/ul/li[6]";
        public static readonly string _deformModeVal1 = "/html/body/div[4]/div[2]/ul/li[1]";
        public static readonly string _deformModeVal2 = "/html/body/div[4]/div[2]/ul/li[2]";
        public static readonly string _deformModeVal3 = "/html/body/div[4]/div[2]/ul/li[3]";
        public static readonly string _deformModeVal4 = "/html/body/div[4]/div[2]/ul/li[4]";
        public static readonly string _deformModeVal5 = "/html/body/div[4]/div[2]/ul/li[5]";
        public static readonly string _username = "//*[@id='i0116']";
        public static readonly string _next = "//*[@id='idSIButton9']";
        public static readonly string _workac = "//*[@id='aadTileTitle']";

        ///Visualize Model Data 
        public static readonly string _selectorModeIdentifier = "/html/body/div[3]/div/div/main/div[6]/div/div/div[2]/div/div/div[1]/div/div[3]/table/tbody/tr/td[3]";
        public static readonly string _chartTypeDropdown = "/html/body/div[3]/div/div/main/div[6]/div/div/div[1]/div/div/div[2]/div[1]/div/div/div";
        public static readonly string _chartTypeVal1 = "/html/body/div[5]/div[2]/ul/li[1]";
        public static readonly string _chartTypeVal2 = "/html/body/div[5]/div[2]/ul/li[2]";
        public static readonly string _chartTypeVal3 = "/html/body/div[5]/div[2]/ul/li[3]";
        public static readonly string _chartTypeVal4 = "/html/body/div[5]/div[2]/ul/li[4]";
        public static readonly string _chartTypeVal5 = "/html/body/div[5]/div[2]/ul/li[5]";
        public static readonly string _chartTypeVal6 = "/html/body/div[5]/div[2]/ul/li[6]";
        public static readonly string _chartTypeVal7 = "/html/body/div[5]/div[2]/ul/li[7]";
        public static readonly string _saveChartBtn = " /html/body/div[3]/div/div/main/div[6]/div/div/div[1]/div/div/div[2]/span[2]";

        //Export and save models

        public static readonly string _modelNameSelectButton = "/html/body/div[3]/div/div/main/div[6]/div/div/div[2]/div/div/div[1]/div/div[3]/table/tbody/tr/td[1]/span/span[1]/input";
        public static readonly string _saveSelectedModelsButton = "/html/body/div[3]/div/div/main/div[6]/div/div/div[2]/div/div/div[2]/span[1]/span[1]";
        public static readonly string _modelSavedTickIdentifier = "/html/body/div[3]/div/div/main/div[6]/div/div/div[2]/div/div/div[1]/div/div[3]/table/tbody/tr/td[11]";
        public static readonly string _tick = "//*[local-name()='table' and @class ='jss01663']//*[local-name()='tbody' and @class='jss01705']//*[local-name()='tr' and @class='jss01668 jss01670 jss01669 jss01706']//*[local-name()='td' and @class='jss01677 jss01679 jss01708'][5]]//*[local-name()='svg' and @class='object SVGAnimatedString' and @style='fill: green;']";
        public static readonly string _tick1 = "#export > div > div > div.jss1555.jss1594.jss1608.jss1620.jss1634 > div > div.jss1777 > table > tbody > tr > td:nth-child(11) > svg";
        public static readonly string _fileUploadTableIdentifier = "/html/body/div[3]/div/div/main/div[2]/div/div[2]/div/div/div[4]/div/div/div/div[3]/table";
        public static readonly string _dmaUploadSecondFile = "/html/body/div[3]/div/div/main/div[2]/div/div[2]/div/div/div[4]/div/div/div/div[3]/table/tbody/tr[2]/td[2]";
        public static readonly string _exportModelasZipButton = "/html/body/div[3]/div/div/main/div[6]/div/div/div[2]/div/div/div[2]/span[3]/span[1]";

        //Load Your Models
        public static readonly string _loadYourModelsIdentifier = "/html/body/div[3]/div/div/div/div/div/div/div[2]/nav[1]/li[2]/div/p";
        public static readonly string _modelSearchboxButton = "/html/body/div[3]/div/div/main/div[3]/div/div/div/div[2]/div[1]/div/div/div[1]/div[2]/button";
        public static readonly string _modelSearchboxIdentifier = "/html/body/div[3]/div/div/main/div[3]/div/div/div/div[2]/div[1]/div/div/div[1]/div[1]/div/div/div/input";
        public static readonly string _modelNameIdentifier = "/html/body/div[3]/div/div/main/div[3]/div/div/div/div[2]/div[1]/div/div/div[3]/table/tbody/tr[1]/td[3]";
        public static readonly string _modelNameCheckboxIdentifier = "/html/body/div[3]/div/div/main/div[3]/div/div/div/div[2]/div[1]/div/div/div[3]/table/tbody/tr/td[1]/span/span[1]/input";
        public static readonly string _modelNameTextBox = "/html/body/div[3]/div/div/main/div[3]/div/div/div/div[2]/div[1]/div/div/div[1]";
        public static readonly string _loadConstitutiveModelButton = "/html/body/div[3]/div/div/main/div[3]/div/div/div/div[2]/div[2]/div/span/span[1]";
        public static readonly string _visualizeModelDataButton = "/html/body/div[3]/div/div/div/div/div/div/div[2]/nav[2]/li[1]/div/p";
        public static readonly string _visualizeModelCss = "#root > div > div > div > div > div > div > div.jss0149 > nav:nth-child(4) > li.jss0184.jss0173.jss0176.jss0180.jss0181.jss0183.jss0171.jss0172 > div > p";

        //edit your models
        public static readonly string _editYourModelsIdentifier = "/html/body/div[3]/div/div/div/div/div/div/div[2]/nav[1]/li[3]/div/p";
        public static readonly string _searchboxEditModelButton = "/html/body/div[3]/div/div/main/div[4]/div/div/div/div/div[1]/div/div/div[1]/div[2]/button";
        public static readonly string _searchBoxInputIdentifier = "/html/body/div[3]/div/div/main/div[4]/div/div/div/div/div[1]/div/div/div[1]/div[1]/div/div/div/input";
        public static readonly string _checkboxEditModel = "/html/body/div[3]/div/div/main/div[4]/div/div/div/div/div[1]/div/div/div[3]/table/tbody/tr[1]/td[1]/span/span[1]/input";
        public static readonly string _deleteSelectedModelBtn = "/html/body/div[3]/div/div/main/div[4]/div/div/div/div/div[2]/div/span[2]/span[1]";
        public static readonly string _deleteConfirmBtn = "/html/body/div[4]/div[2]/div/div[3]/button[2]/span[1]";
        public static readonly string _modelEditCheckboxBtn = "/html/body/div[3]/div/div/main/div[4]/div/div/div/div/div[1]/div/div/div[3]/table/tbody/tr[1]/td[1]/span/span[1]/input";
        public static readonly string _descrptionTextboxIdentifier = "//*[@id='edit_0_descinput']";
        public static readonly string _updateSelectedModelBtn = "/html/body/div[3]/div/div/main/div[4]/div/div/div/div/div[2]/div/span[1]/span[1]";

        //Verified Models
        public static readonly string _verifiedModelsBtn = "/html/body/div[3]/div/div/div/div/div/div/div[2]/nav[2]/li[3]/div[2]/p";
        public static readonly string _searchBoxIdentifier = "/html/body/div[3]/div/div/main/div[7]/div/div/div/div[2]/div/div/div/div[1]/div[2]/button";
        public static readonly string _searchBoxVerifiedModels = "/html/body/div[3]/div/div/main/div[7]/div/div/div/div[2]/div/div/div/div[1]/div[1]/div/div/div/input";
        public static readonly string _verifiedModelsTableIdentifier = "/html/body/div[3]/div/div/main/div[7]/div/div/div/div[2]/div/div/div/div[3]/table/tbody/tr/td[2]";
        public static readonly string _downloadModelInternal = "/html/body/div[3]/div/div/main/div[7]/div/div/div/div[2]/div/div/div/div[3]/table/tbody/tr[1]/td[14]/span/span/u";
        public static readonly string _downloadModelExternal = "/html/body/div[3]/div/div/main/div[7]/div/div/div/div[2]/div/div/div/div[3]/table/tbody/tr[1]/td[16]/span/span/u";
    }
}
