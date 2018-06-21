using Api;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.CheckBoxButton;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.Selector;
using Controls.FileColumnButton;
using Controls.Grid;
using Controls.Grid.Filter;
using Controls.Grid.Upload;
using Controls.Input;
using Controls.Input.PXNumberEdit;
using Controls.Input.PXTextEdit;
using Controls.Label;
using Controls.NoteColumnButton;
using Controls.PxControlCollection;
using Controls.ToolBarButton;
using Core;
using Core.ApiConnection;
using Core.Core.Browser;
using Core.Wait;
using System;


namespace ConsoleTest
{
	public class GL301000 : Wrapper
	{
		public form tool_form = new form("ctl00_phF_form", "Tool_form");
		public class form : Container
		{
			public Selector FinPeriodID { get; set; }

			public form(string locator, string name) :
					base(locator, name)
			{
				FinPeriodID = new Selector("ctl00_phF_form_edFinPeriodID", "Post Period", locator, null);
				FinPeriodID.DataField = "FinPeriodID";
			}
		}

		public virtual void Save()
		{
			
		}
	}


	public class GL301000_JournalEntry : Wrapper {
        
        public Note NotePanel;
        
        public ActivityPanel ActivityPanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        private c_batchmodule_form batchmodule_form = new c_batchmodule_form("ctl00_phF_form", "BatchModule_form");
        
        private c_firstselect_formactions firstselect_formactions = new c_firstselect_formactions("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions", "FirstSelect_FormActions");
        
        private c_vieweleminfo_formeleminfo vieweleminfo_formeleminfo = new c_vieweleminfo_formeleminfo("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", "ViewElemInfo_FormElemInfo");
        
        private c_filterworkingproject_formnewproject filterworkingproject_formnewproject = new c_filterworkingproject_formnewproject("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", "FilterWorkingProject_FormNewProject");
        
        private c_filterworkingproject_formselectproject filterworkingproject_formselectproject = new c_filterworkingproject_formselectproject("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", "FilterWorkingProject_FormSelectProject");
        
        private c__batch_currencyinfo__rf _batch_currencyinfo__rf = new c__batch_currencyinfo__rf("ctl00_phF_form_edCury_pnlRate_rf", "_Batch_CurrencyInfo__rf");
        
        private c_gltranmodulebatnbr_lv0 gltranmodulebatnbr_lv0 = new c_gltranmodulebatnbr_lv0("ctl00_phG_grid_lv0", "GLTranModuleBatNbr_lv0");
        
        private c_gltranmodulebatnbr_grid gltranmodulebatnbr_grid = new c_gltranmodulebatnbr_grid("ctl00_phG_grid", "GLTranModuleBatNbr_grid");
        
        private c_voucher_voucherdetails voucher_voucherdetails = new c_voucher_voucherdetails("ctl00_phF_form_VoucherDetails", "Voucher_VoucherDetails");
        
        private c_gltranmodulebatnbr_importcsvsettings_frmimportcsvsettings gltranmodulebatnbr_importcsvsettings_frmimportcsvsettings = new c_gltranmodulebatnbr_importcsvsettings_frmimportcsvsettings("ctl00_phG_grid_imp_importCSVSettingsDlg_frmImportCSVSettings", "GLTranModuleBatNbr$ImportCSVSettings_frmImportCSVSettings");
        
        private c_gltranmodulebatnbr_importxlsxsettings_frmimportxlsxsettings gltranmodulebatnbr_importxlsxsettings_frmimportxlsxsettings = new c_gltranmodulebatnbr_importxlsxsettings_frmimportxlsxsettings("ctl00_phG_grid_imp_importXLSXSettingsDlg_frmImportXLSXSettings", "GLTranModuleBatNbr$ImportXLSXSettings_frmImportXLSXSettings");
        
        private c_gltranmodulebatnbr_importcolumns_grdimportcolumn gltranmodulebatnbr_importcolumns_grdimportcolumn = new c_gltranmodulebatnbr_importcolumns_grdimportcolumn("ctl00_phG_grid_imp_importColumnDlg_grdImportColumn", "GLTranModuleBatNbr$ImportColumns_grdImportColumn");
        
        private c_gltranmodulebatnbr_importcolumns_lv0 gltranmodulebatnbr_importcolumns_lv0 = new c_gltranmodulebatnbr_importcolumns_lv0("ctl00_phG_grid_imp_importColumnDlg_grdImportColumn_lv0", "GLTranModuleBatNbr$ImportColumns_lv0");
        
        public GL301000_JournalEntry() {
            ScreenId = "GL301000";
            ScreenUrl = "/Pages/GL/GL301000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            ActivityPanel = new ActivityPanel("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar(null);
        }
        
        protected virtual c_batchmodule_form BatchModule_form {
            get {
                return batchmodule_form;
            }
        }
        
        protected virtual c_firstselect_formactions FirstSelect_FormActions {
            get {
                return firstselect_formactions;
            }
        }
        
        protected virtual c_vieweleminfo_formeleminfo ViewElemInfo_FormElemInfo {
            get {
                return vieweleminfo_formeleminfo;
            }
        }
        
        protected virtual c_filterworkingproject_formnewproject FilterWorkingProject_FormNewProject {
            get {
                return filterworkingproject_formnewproject;
            }
        }
        
        protected virtual c_filterworkingproject_formselectproject FilterWorkingProject_FormSelectProject {
            get {
                return filterworkingproject_formselectproject;
            }
        }
        
        protected virtual c__batch_currencyinfo__rf _Batch_CurrencyInfo__rf {
            get {
                return _batch_currencyinfo__rf;
            }
        }
        
        protected virtual c_gltranmodulebatnbr_lv0 GLTranModuleBatNbr_lv0 {
            get {
                return gltranmodulebatnbr_lv0;
            }
        }
        
        protected virtual c_gltranmodulebatnbr_grid GLTranModuleBatNbr_grid {
            get {
                return gltranmodulebatnbr_grid;
            }
        }
        
        protected virtual c_voucher_voucherdetails Voucher_VoucherDetails {
            get {
                return voucher_voucherdetails;
            }
        }
        
        protected virtual c_gltranmodulebatnbr_importcsvsettings_frmimportcsvsettings GLTranModuleBatNbr_ImportCSVSettings_frmImportCSVSettings {
            get {
                return gltranmodulebatnbr_importcsvsettings_frmimportcsvsettings;
            }
        }
        
        protected virtual c_gltranmodulebatnbr_importxlsxsettings_frmimportxlsxsettings GLTranModuleBatNbr_ImportXLSXSettings_frmImportXLSXSettings {
            get {
                return gltranmodulebatnbr_importxlsxsettings_frmimportxlsxsettings;
            }
        }
        
        protected virtual c_gltranmodulebatnbr_importcolumns_grdimportcolumn GLTranModuleBatNbr_ImportColumns_grdImportColumn {
            get {
                return gltranmodulebatnbr_importcolumns_grdimportcolumn;
            }
        }
        
        protected virtual c_gltranmodulebatnbr_importcolumns_lv0 GLTranModuleBatNbr_ImportColumns_lv0 {
            get {
                return gltranmodulebatnbr_importcolumns_lv0;
            }
        }
        
        public virtual GL301000_JournalEntry ReadOne(Gate gate, string Module, string BatchNbr) {
            new BiObject<GL301000_JournalEntry>(gate).ReadOne(this, Module, BatchNbr);
            return this;
        }
        
        public virtual GL301000_JournalEntry ReadOne(string Module, string BatchNbr) {
            return this.ReadOne(ApiConnection.Source, Module, BatchNbr);
        }
        
        public virtual void SyncTOC() {
            ToolBar.SyncTOC.Click();
        }
        
        public virtual void Favorites() {
            ToolBar.Favorites.Click();
        }
        
        public virtual void ClearFilter() {
            ToolBar.ClearFilter.Click();
        }
        
        public virtual void Note() {
            ToolBar.Note.Click();
        }
        
        public virtual void ActivityShow() {
            ToolBar.ActivityShow.Click();
        }
        
        public virtual void FilesMenuShow() {
            ToolBar.FilesMenuShow.Click();
        }
        
        public virtual void NotifyShow() {
            ToolBar.NotifyShow.Click();
        }
        
        public virtual void Custom() {
            ToolBar.Custom.Click();
        }
        
        public virtual void ActionSelectWorkingProject() {
            ToolBar.ActionSelectWorkingProject.Click();
        }
        
        public virtual void InspectElementCtrlAtlClick() {
            ToolBar.InspectElementCtrlAtlClick.Click();
        }
        
        public virtual void MenuEditProj() {
            ToolBar.MenuEditProj.Click();
        }
        
        public virtual void ManageCustomizations() {
            ToolBar.ManageCustomizations.Click();
        }
        
        public virtual void ActionNavigateAspx() {
            ToolBar.ActionNavigateAspx.Click();
        }
        
        public virtual void ActionCreateNewProject() {
            ToolBar.ActionCreateNewProject.Click();
        }
        
        public virtual void MenuLayoutEditor() {
            ToolBar.MenuLayoutEditor.Click();
        }
        
        public virtual void MenuEditProj1() {
            ToolBar.MenuEditProj1.Click();
        }
        
        public virtual void MenuDacEditor() {
            ToolBar.MenuDacEditor.Click();
        }
        
        public virtual void MenuGraphEditor() {
            ToolBar.MenuGraphEditor.Click();
        }
        
        public virtual void MenuLayoutSrc() {
            ToolBar.MenuLayoutSrc.Click();
        }
        
        public virtual void MenuGraphSrc() {
            ToolBar.MenuGraphSrc.Click();
        }
        
        public virtual void MenuDacSrc() {
            ToolBar.MenuDacSrc.Click();
        }
        
        public virtual void MenuLayoutVS() {
            ToolBar.MenuLayoutVS.Click();
        }
        
        public virtual void MenuDacVS() {
            ToolBar.MenuDacVS.Click();
        }
        
        public virtual void MenuGraphVS() {
            ToolBar.MenuGraphVS.Click();
        }
        
        public virtual void ActionSelectWorkingProject1() {
            ToolBar.ActionSelectWorkingProject1.Click();
        }
        
        public virtual void LongRun() {
            ToolBar.LongRun.Click();
        }
        
        public virtual void ElapsedTime() {
            ToolBar.ElapsedTime.Click();
        }
        
        public virtual void KeyBtnRefresh() {
            ToolBar.KeyBtnRefresh.Click();
        }
        
        public virtual void Help() {
            ToolBar.Help.Click();
        }
        
        public virtual void Save() {
            ToolBar.Save.Click();
        }
        
        public virtual void Cancel() {
            ToolBar.Cancel.Click();
        }
        
        public virtual void Insert() {
            ToolBar.Insert.Click();
        }
        
        public virtual void Delete() {
            ToolBar.Delete.Click();
        }
        
        public virtual void Clipboard() {
            ToolBar.Clipboard.Click();
        }
        
        public virtual void CopyDocument() {
            ToolBar.CopyDocument.Click();
        }
        
        public virtual void PasteDocument() {
            ToolBar.PasteDocument.Click();
        }
        
        public virtual void SaveTemplate() {
            ToolBar.SaveTemplate.Click();
        }
        
        public virtual void PasteFromFixHeadcountInStatLedger() {
            ToolBar.PasteFromFixHeadcountInStatLedger.Click();
        }
        
        public virtual void First() {
            ToolBar.First.Click();
        }
        
        public virtual void Previous() {
            ToolBar.Previous.Click();
        }
        
        public virtual void Next() {
            ToolBar.Next.Click();
        }
        
        public virtual void Last() {
            ToolBar.Last.Click();
        }
        
        public virtual void EditReclassBatch() {
            ToolBar.EditReclassBatch.Click();
        }
        
        public virtual void Release() {
            ToolBar.Release.Click();
        }
        
        public virtual void Release(bool status, string message = null) {
            ToolBar.Release.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.Release.Click();
        }
        
        public virtual void Actions() {
            ToolBar.Actions.Click();
        }
        
        public virtual void ReverseBatch() {
            ToolBar.ReverseBatch.Click();
        }
        
        public virtual void CreateSchedule() {
            ToolBar.CreateSchedule.Click();
        }
        
        public virtual void Reclassify() {
            ToolBar.Reclassify.Click();
        }
        
        public virtual void Reports() {
            ToolBar.Reports.Click();
        }
        
        public virtual void BatchRegisterDetails() {
            ToolBar.BatchRegisterDetails.Click();
        }
        
        public virtual void GLEditDetails() {
            ToolBar.GLEditDetails.Click();
        }
        
        public virtual void GLReversingBatches() {
            ToolBar.GLReversingBatches.Click();
        }
        
        public virtual void ViewOrigBatch() {
            ToolBar.ViewOrigBatch.Click();
        }
        
        public virtual void ViewReclassBatch() {
            ToolBar.ViewReclassBatch.Click();
        }
        
        public class PxToolBar : PxControlCollection {
            
			public ToolBarButton SyncTOC {get; private set; }
			public ToolBarButton Favorites {get; private set; }
			public ToolBarButton ClearFilter {get; private set; }
			public ToolBarButton Note {get; private set; }
			public ToolBarButton ActivityShow {get; private set; }
			public ToolBarButton FilesMenuShow {get; private set; }
			public ToolBarButton NotifyShow {get; private set; }
			public ToolBarButton Custom {get; private set; }
			public ToolBarButton ActionSelectWorkingProject {get; private set; }
			public ToolBarButton InspectElementCtrlAtlClick {get; private set; }
			public ToolBarButton MenuEditProj {get; private set; }
			public ToolBarButton ManageCustomizations {get; private set; }
			public ToolBarButton ActionNavigateAspx {get; private set; }
			public ToolBarButton ActionCreateNewProject {get; private set; }
			public ToolBarButton MenuLayoutEditor {get; private set; }
			public ToolBarButton MenuEditProj1 {get; private set; }
			public ToolBarButton MenuDacEditor {get; private set; }
			public ToolBarButton MenuGraphEditor {get; private set; }
			public ToolBarButton MenuLayoutSrc {get; private set; }
			public ToolBarButton MenuGraphSrc {get; private set; }
			public ToolBarButton MenuDacSrc {get; private set; }
			public ToolBarButton MenuLayoutVS {get; private set; }
			public ToolBarButton MenuDacVS {get; private set; }
			public ToolBarButton MenuGraphVS {get; private set; }
			public ToolBarButton ActionSelectWorkingProject1 {get; private set; }
			public ToolBarButton LongRun {get; private set; }
			public ToolBarButton ElapsedTime {get; private set; }
			public ToolBarButton KeyBtnRefresh {get; private set; }
			public ToolBarButton Help {get; private set; }
			public ToolBarButton Save {get; private set; }
			public ToolBarButton Cancel {get; private set; }
			public ToolBarButton Insert {get; private set; }
			public ToolBarButton Delete {get; private set; }
			public ToolBarButton Clipboard {get; private set; }
			public ToolBarButton CopyDocument {get; private set; }
			public ToolBarButton PasteDocument {get; private set; }
			public ToolBarButton SaveTemplate {get; private set; }
			public ToolBarButton PasteFromFixHeadcountInStatLedger {get; private set; }
			public ToolBarButton First {get; private set; }
			public ToolBarButton Previous {get; private set; }
			public ToolBarButton Next {get; private set; }
			public ToolBarButton Last {get; private set; }
			public ToolBarButton EditReclassBatch {get; private set; }
			public ToolBarButton Release {get; private set; }
			public ToolBarButton Actions {get; private set; }
			public ToolBarButton ReverseBatch {get; private set; }
			public ToolBarButton CreateSchedule {get; private set; }
			public ToolBarButton Reclassify {get; private set; }
			public ToolBarButton Reports {get; private set; }
			public ToolBarButton BatchRegisterDetails {get; private set; }
			public ToolBarButton GLEditDetails {get; private set; }
			public ToolBarButton GLReversingBatches {get; private set; }
			public ToolBarButton ViewOrigBatch {get; private set; }
			public ToolBarButton ViewReclassBatch {get; private set; }
            
            public PxToolBar(string locator) {
                SyncTOC = new ToolBarButton("css=div[data-cmd=\'syncTOC\']", "Sync Navigation Pane", locator, null);
                Favorites = new ToolBarButton("css=div[data-cmd=\'favorites\']", "Add to Favorites", locator, null);
                ClearFilter = new ToolBarButton("css=div[data-cmd=\'clearFilter\']", "Clear Active Filter", locator, null);
                Note = new ToolBarButton("css=div[data-cmd=\'NoteShow\']", "Add Note", locator, null);
                ActivityShow = new ToolBarButton("css=div[data-cmd=\'ActivityShow\']", "Activities", locator, null);
                FilesMenuShow = new ToolBarButton("css=div[data-cmd=\'FilesMenuShow\']", "Files", locator, null);
                NotifyShow = new ToolBarButton("css=div[data-cmd=\'NotifyShow\']", "Notifications", locator, null);
                Custom = new ToolBarButton("css=div[data-cmd=\'Custom\']", "Customization", locator, null);
                ActionSelectWorkingProject = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li[data-cmd=\'" +
                        "ActionSelectWorkingProject\']", "Select Project...", locator, Custom);
                InspectElementCtrlAtlClick = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li.menuItem d" +
                        "iv:textEqual(\"Inspect Element (Ctrl+Atl+Click)\")", "Inspect Element (Ctrl+Atl+Click)", locator, Custom);
                MenuEditProj = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li[data-cmd=\'" +
                        "menuEditProj\']", "Edit Project...", locator, Custom);
                ManageCustomizations = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li.menuItem d" +
                        "iv:textEqual(\"Manage Customizations...\")", "Manage Customizations...", locator, Custom);
                ActionNavigateAspx = new ToolBarButton("css=div[data-cmd=\'actionNavigateAspx\']", "actionNavigateAspx", locator, null);
                ActionCreateNewProject = new ToolBarButton("css=div[data-cmd=\'actionCreateNewProject\']", "actionCreateNewProject", locator, null);
                MenuLayoutEditor = new ToolBarButton("css=div[data-cmd=\'menuLayoutEditor\']", "Customize", locator, null);
                MenuEditProj1 = new ToolBarButton("css=div[data-cmd=\'menuEditProj\']", "Edit Project ...", locator, null);
                MenuDacEditor = new ToolBarButton("css=div[data-cmd=\'menuDacEditor\']", "menuDacEditor", locator, null);
                MenuGraphEditor = new ToolBarButton("css=div[data-cmd=\'menuGraphEditor\']", "menuGraphEditor", locator, null);
                MenuLayoutSrc = new ToolBarButton("css=div[data-cmd=\'menuLayoutSrc\']", "menuLayoutSrc", locator, null);
                MenuGraphSrc = new ToolBarButton("css=div[data-cmd=\'menuGraphSrc\']", "menuGraphSrc", locator, null);
                MenuDacSrc = new ToolBarButton("css=div[data-cmd=\'menuDacSrc\']", "menuDacSrc", locator, null);
                MenuLayoutVS = new ToolBarButton("css=div[data-cmd=\'menuLayoutVS\']", "menuLayoutVS", locator, null);
                MenuDacVS = new ToolBarButton("css=div[data-cmd=\'menuDacVS\']", "menuDacVS", locator, null);
                MenuGraphVS = new ToolBarButton("css=div[data-cmd=\'menuGraphVS\']", "menuGraphVS", locator, null);
                ActionSelectWorkingProject1 = new ToolBarButton("css=div[data-cmd=\'actionSelectWorkingProject\']", "actionSelectWorkingProject", locator, null);
                LongRun = new ToolBarButton("css=div[data-cmd=\'LongRun\']", "Nothing in progress", locator, null);
                ElapsedTime = new ToolBarButton("css=div[data-cmd=\'ElapsedTime\']", "Elapsed time", locator, null);
                KeyBtnRefresh = new ToolBarButton("css=div[data-cmd=\'keyBtnRefresh\']", "Click to refresh page.", locator, null);
                Help = new ToolBarButton("css=div[data-cmd=\'help\']", "View Help", locator, null);
                Save = new ToolBarButton("css=div[data-cmd=\'Save\']", "Save (Ctrl+S).", locator, null);
                Cancel = new ToolBarButton("css=div[data-cmd=\'Cancel\']", "Cancel (Esc)", locator, null);
                Cancel.ConfirmAction = Alert.AlertToException;
                Insert = new ToolBarButton("css=div[data-cmd=\'Insert\']", "Add New Record (Ctrl+Ins)", locator, null);
                Delete = new ToolBarButton("css=div[data-cmd=\'Delete\']", "Delete (Ctrl+Del).", locator, null);
                Delete.ConfirmAction = Alert.AlertToException;
                Clipboard = new ToolBarButton("css=li>div.toolsBtn[tooltip=\'Clipboard\']", "Clipboard", locator, null);
                CopyDocument = new ToolBarButton("css=li[data-cmd=\'CopyPaste@CopyDocument\']", "Copy", locator, Clipboard);
                PasteDocument = new ToolBarButton("css=li[data-cmd=\'CopyPaste@PasteDocument\']", "Paste", locator, Clipboard);
                SaveTemplate = new ToolBarButton("css=li[data-cmd=\'CopyPaste@SaveTemplate\']", "Save as Template...", locator, Clipboard);
                PasteFromFixHeadcountInStatLedger = new ToolBarButton("css=li[data-cmd=\'CopyPaste@#10\']", "Paste from [Fix headcount in STAT ledger]", locator, Clipboard);
                First = new ToolBarButton("css=div[data-cmd=\'First\']", "Go to First Record", locator, null);
                Previous = new ToolBarButton("css=div[data-cmd=\'Previous\']", "Go to Previous Record (PgUp)", locator, null);
                Next = new ToolBarButton("css=div[data-cmd=\'Next\']", "Go to Next Record (PgDn)", locator, null);
                Last = new ToolBarButton("css=div[data-cmd=\'Last\']", "Go to Last Record", locator, null);
                EditReclassBatch = new ToolBarButton("css=div[data-cmd=\'EditReclassBatch\']", "Edit", locator, null);
                Release = new ToolBarButton("css=div[data-cmd=\'Release\']", "Release", locator, null);
                Release.WaitAction = Wait.WaitForLongOperationToComplete;
                Actions = new ToolBarButton("css=div:textEqual(\"Actions\") > div[data-type=\'drop\']", "Actions", locator, null);
                ReverseBatch = new ToolBarButton("css=li[data-cmd=\'Action@ReverseBatch\']", "Reverse Batch", locator, Actions);
                CreateSchedule = new ToolBarButton("css=li[data-cmd=\'Action@CreateSchedule\']", "Add to Schedule", locator, Actions);
                Reclassify = new ToolBarButton("css=li[data-cmd=\'Action@Reclassify\']", "Reclassify", locator, Actions);
                Reports = new ToolBarButton("css=div:textEqual(\"Reports\") > div[data-type=\'drop\']", "Reports", locator, null);
                BatchRegisterDetails = new ToolBarButton("css=li[data-cmd=\'Report@BatchRegisterDetails\']", "Batch Register Details", locator, Reports);
                GLEditDetails = new ToolBarButton("css=li[data-cmd=\'Report@GLEditDetails\']", "GL Edit Details", locator, Reports);
                GLReversingBatches = new ToolBarButton("css=li[data-cmd=\'Report@GLReversingBatches\']", "GL Reversing Batches", locator, Reports);
                ViewOrigBatch = new ToolBarButton("css=div[data-cmd=\'ViewOrigBatch\']", "ViewOrigBatch", locator, null);
                ViewReclassBatch = new ToolBarButton("css=div[data-cmd=\'viewReclassBatch\']", "viewReclassBatch", locator, null);
            }
        }
        
        public class c_batchmodule_form : Container {
            
            public PxButtonCollection Buttons;
            
			public DropDown Module { get; set; }
			public Label ModuleLabel { get; private set; }
			public Selector BatchNbr { get; set; }
			public Label BatchNbrLabel { get; private set; }
			public DropDown Status { get; set; }
			public Label StatusLabel { get; private set; }
			public CheckBox Hold { get; set; }
			public Label HoldLabel { get; private set; }
			public DateSelector DateEntered { get; set; }
			public Label DateEnteredLabel { get; private set; }
			public Selector FinPeriodID { get; set; }
			public Label FinPeriodIDLabel { get; private set; }
			public Selector BranchID { get; set; }
			public Label BranchIDLabel { get; private set; }
			public Selector LedgerID { get; set; }
			public Label LedgerIDLabel { get; private set; }
			public Selector CuryID { get; set; }
			public Label CuryIDLabel { get; private set; }
			public CheckBoxButton CuryViewState { get; set; }
			public Label CuryViewStateLabel { get; private set; }
			public CheckBox AutoReverse { get; set; }
			public Label AutoReverseLabel { get; private set; }
			public CheckBox AutoReverseCopy { get; set; }
			public Label AutoReverseCopyLabel { get; private set; }
			public CheckBox CreateTaxTrans { get; set; }
			public Label CreateTaxTransLabel { get; private set; }
			public CheckBox SkipTaxValidation { get; set; }
			public Label SkipTaxValidationLabel { get; private set; }
			public DropDown BatchType { get; set; }
			public Label BatchTypeLabel { get; private set; }
			public Selector OrigBatchNbr { get; set; }
			public Label OrigBatchNbrLabel { get; private set; }
			public PXNumberEdit ReverseCount { get; set; }
			public Label ReverseCountLabel { get; private set; }
			public PXNumberEdit CuryDebitTotal { get; set; }
			public Label CuryDebitTotalLabel { get; private set; }
			public PXNumberEdit CuryCreditTotal { get; set; }
			public Label CuryCreditTotalLabel { get; private set; }
			public PXNumberEdit CuryControlTotal { get; set; }
			public Label CuryControlTotalLabel { get; private set; }
			public PXTextEdit Description { get; set; }
			public Label DescriptionLabel { get; private set; }
			public Label LblRateType_ { get; set; }
			public Label LblEffDate_ { get; set; }
			public Label LblCount_ { get; set; }
			public Label LblCount2_ { get; set; }
			public Label LblEQ_ { get; set; }
			public Label LblEQ2_ { get; set; }
            
            public c_batchmodule_form(string locator, string name) : 
                    base(locator, name) {
                Module = new DropDown("ctl00_phF_form_edModule", "Module", locator, null);
                ModuleLabel = new Label(Module);
                Module.DataField = "Module";
                Module.Items.Add("GL", "GL");
                Module.Items.Add("AP", "AP");
                Module.Items.Add("AR", "AR");
                Module.Items.Add("CM", "CM");
                Module.Items.Add("CA", "CA");
                Module.Items.Add("IN", "IN");
                Module.Items.Add("DR", "DR");
                Module.Items.Add("FA", "FA");
                Module.Items.Add("PM", "PM");
                Module.Items.Add("PR", "PR");
                BatchNbr = new Selector("ctl00_phF_form_edBatchNbr", "Batch Number", locator, null);
                BatchNbrLabel = new Label(BatchNbr);
                BatchNbr.DataField = "BatchNbr";
                Status = new DropDown("ctl00_phF_form_edStatus", "Status", locator, null);
                StatusLabel = new Label(Status);
                Status.DataField = "Status";
                Status.Items.Add("H", "On Hold");
                Status.Items.Add("B", "Balanced");
                Status.Items.Add("U", "Unposted");
                Status.Items.Add("P", "Posted");
                Status.Items.Add("C", "Completed");
                Status.Items.Add("V", "Voided");
                Status.Items.Add("R", "Released");
                Status.Items.Add("Q", "Partially Released");
                Status.Items.Add("S", "Scheduled");
                Hold = new CheckBox("ctl00_phF_form_chkHold", "Hold", locator, null);
                HoldLabel = new Label(Hold);
                Hold.DataField = "Hold";
                DateEntered = new DateSelector("ctl00_phF_form_edDateEntered", "Transaction Date", locator, null);
                DateEnteredLabel = new Label(DateEntered);
                DateEntered.DataField = "DateEntered";
                FinPeriodID = new Selector("ctl00_phF_form_edFinPeriodID", "Post Period", locator, null);
                FinPeriodIDLabel = new Label(FinPeriodID);
                FinPeriodID.DataField = "FinPeriodID";
                BranchID = new Selector("ctl00_phF_form_edBranchID", "Branch", locator, null);
                BranchIDLabel = new Label(BranchID);
                BranchID.DataField = "BranchID";
                LedgerID = new Selector("ctl00_phF_form_edLedgerID", "Ledger", locator, null);
                LedgerIDLabel = new Label(LedgerID);
                LedgerID.DataField = "LedgerID";
                CuryID = new Selector("ctl00_phF_form_edCury_cury", "Cury ID", locator, null);
                CuryIDLabel = new Label(CuryID);
                CuryID.DataField = "CuryID";
                CuryViewState = new CheckBoxButton("ctl00_phF_form_edCury_curyB", "CuryViewState", locator, null);
                CuryViewStateLabel = new Label(CuryViewState);
                CuryViewState.DataField = "CuryViewState";
                AutoReverse = new CheckBox("ctl00_phF_form_chkAutoReverse", "Auto Reversing", locator, null);
                AutoReverseLabel = new Label(AutoReverse);
                AutoReverse.DataField = "AutoReverse";
                AutoReverseCopy = new CheckBox("ctl00_phF_form_AutoReverseCopy", "Reversing Entry", locator, null);
                AutoReverseCopyLabel = new Label(AutoReverseCopy);
                AutoReverseCopy.DataField = "AutoReverseCopy";
                CreateTaxTrans = new CheckBox("ctl00_phF_form_chkCreateTaxTrans", "Create Tax Transactions", locator, null);
                CreateTaxTransLabel = new Label(CreateTaxTrans);
                CreateTaxTrans.DataField = "CreateTaxTrans";
                SkipTaxValidation = new CheckBox("ctl00_phF_form_chkSkipTaxValidation", "Skip Tax Amount Validation", locator, null);
                SkipTaxValidationLabel = new Label(SkipTaxValidation);
                SkipTaxValidation.DataField = "SkipTaxValidation";
                BatchType = new DropDown("ctl00_phF_form_edBatchType", "Type", locator, null);
                BatchTypeLabel = new Label(BatchType);
                BatchType.DataField = "BatchType";
                BatchType.Items.Add("H", "Normal");
                BatchType.Items.Add("C", "Consolidation");
                BatchType.Items.Add("T", "Trial Balance");
                BatchType.Items.Add("RCL", "Reclassification");
                BatchType.Items.Add("A", "Allocation");
                OrigBatchNbr = new Selector("ctl00_phF_form_edOrigBatchNbr", "Orig. Batch Number", locator, null);
                OrigBatchNbrLabel = new Label(OrigBatchNbr);
                OrigBatchNbr.DataField = "OrigBatchNbr";
                ReverseCount = new PXNumberEdit("ctl00_phF_form_edReverseCount", "Reversing Batches", locator, null);
                ReverseCountLabel = new Label(ReverseCount);
                ReverseCount.DataField = "ReverseCount";
                CuryDebitTotal = new PXNumberEdit("ctl00_phF_form_edCuryDebitTotal", "Debit Total", locator, null);
                CuryDebitTotalLabel = new Label(CuryDebitTotal);
                CuryDebitTotal.DataField = "CuryDebitTotal";
                CuryCreditTotal = new PXNumberEdit("ctl00_phF_form_edCuryCreditTotal", "Credit Total", locator, null);
                CuryCreditTotalLabel = new Label(CuryCreditTotal);
                CuryCreditTotal.DataField = "CuryCreditTotal";
                CuryControlTotal = new PXNumberEdit("ctl00_phF_form_edCuryControlTotal", "Control Total", locator, null);
                CuryControlTotalLabel = new Label(CuryControlTotal);
                CuryControlTotal.DataField = "CuryControlTotal";
                Description = new PXTextEdit("ctl00_phF_form_edDescription", "Description", locator, null);
                DescriptionLabel = new Label(Description);
                Description.DataField = "Description";
                LblRateType_ = new Label("ctl00_phF_form_edCury_pnlRate_rf_lblRateType", "Curr. Rate Type ID:", locator, null);
                LblEffDate_ = new Label("ctl00_phF_form_edCury_pnlRate_rf_lblEffDate", "Effective Date:", locator, null);
                LblCount_ = new Label("ctl00_phF_form_edCury_pnlRate_rf_lblCount", "1.000", locator, null);
                LblCount2_ = new Label("ctl00_phF_form_edCury_pnlRate_rf_lblCount2", "1.000", locator, null);
                LblEQ_ = new Label("ctl00_phF_form_edCury_pnlRate_rf_lblEQ", "=", locator, null);
                LblEQ2_ = new Label("ctl00_phF_form_edCury_pnlRate_rf_lblEQ2", "=", locator, null);
                DataMemberName = "BatchModule";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Unnamed() {
                Buttons.Unnamed.ClickAndWait();
            }
            
            public virtual void Viewbase() {
                Buttons.Viewbase.ClickAndWait();
            }
            
            public virtual void Ok() {
                Buttons.Ok.ClickAndWait();
            }
            
            public class PxButtonCollection : PxControlCollection {
                
			public Button Unnamed {get; private set; }
			public Button Viewbase {get; private set; }
			public Button Ok {get; private set; }
                
                public PxButtonCollection() {
                    Unnamed = new Button("ctl00_phF_form_edCury_rateB", "0", "ctl00_phF_form");
                    Viewbase = new Button("ctl00_phF_form_edCury_curyB", "View base", "ctl00_phF_form");
                    Ok = new Button("ctl00_phF_form_edCury_pnlRate_btnOk", "OK", "ctl00_phF_form");
                }
            }
        }
        
        public class c_firstselect_formactions : Container {
            
			public PXTextEdit Key { get; set; }
			public Label KeyLabel { get; private set; }
            
            public c_firstselect_formactions(string locator, string name) : 
                    base(locator, name) {
                Key = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions_edKey", "Key", locator, null);
                KeyLabel = new Label(Key);
                Key.DataField = "Key";
                DataMemberName = "FirstSelect";
            }
        }
        
        public class c_vieweleminfo_formeleminfo : Container {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit AspxControl { get; set; }
			public Label AspxControlLabel { get; private set; }
			public PXTextEdit CacheType { get; set; }
			public Label CacheTypeLabel { get; private set; }
			public PXTextEdit FieldName { get; set; }
			public Label FieldNameLabel { get; private set; }
			public PXTextEdit ViewName { get; set; }
			public Label ViewNameLabel { get; private set; }
			public PXTextEdit GraphName { get; set; }
			public Label GraphNameLabel { get; private set; }
            
            public c_vieweleminfo_formeleminfo(string locator, string name) : 
                    base(locator, name) {
                AspxControl = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_edAspxControl", "Control Type", locator, null);
                AspxControlLabel = new Label(AspxControl);
                AspxControl.DataField = "AspxControl";
                CacheType = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_CacheType", "Data Class", locator, null);
                CacheTypeLabel = new Label(CacheType);
                CacheType.DataField = "CacheType";
                FieldName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_FieldName", "Data Field", locator, null);
                FieldNameLabel = new Label(FieldName);
                FieldName.DataField = "FieldName";
                ViewName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_ViewName", "View Name", locator, null);
                ViewNameLabel = new Label(ViewName);
                ViewName.DataField = "ViewName";
                GraphName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_GraphName", "Business Logic", locator, null);
                GraphNameLabel = new Label(GraphName);
                GraphName.DataField = "GraphName";
                DataMemberName = "ViewElemInfo";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Customize() {
                Buttons.Customize.ClickAndWait();
            }
            
            public virtual void Actions() {
                Buttons.Actions.ClickAndWait();
            }
            
            public virtual void Cancel() {
                Buttons.Cancel.ClickAndWait();
            }
            
            public class PxButtonCollection : PxControlCollection {
                
			public Button Customize {get; private set; }
			public Button Actions {get; private set; }
			public Button Cancel {get; private set; }
                
                public PxButtonCollection() {
                    Customize = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_PXButton3", "Customize", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
                    Actions = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_ButtonGraphActions", "Actions", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
                    Cancel = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_PXButton4", "Cancel", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
                }
            }
        }
        
        public class c_filterworkingproject_formnewproject : Container {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit NewProject { get; set; }
			public Label NewProjectLabel { get; private set; }
            
            public c_filterworkingproject_formnewproject(string locator, string name) : 
                    base(locator, name) {
                NewProject = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject_edNewProject", "Project Name", locator, null);
                NewProjectLabel = new Label(NewProject);
                NewProject.DataField = "NewProject";
                DataMemberName = "FilterWorkingProject";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok() {
                Buttons.Ok.ClickAndWait();
            }
            
            public virtual void Cancel() {
                Buttons.Cancel.ClickAndWait();
            }
            
            public class PxButtonCollection : PxControlCollection {
                
			public Button Ok {get; private set; }
			public Button Cancel {get; private set; }
                
                public PxButtonCollection() {
                    Ok = new Button("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_DlgNewProjectButtonOk", "OK", "ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject");
                    Cancel = new Button("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_DlgNewProjectButtonCancel", "Cancel", "ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject");
                }
            }
        }
        
        public class c_filterworkingproject_formselectproject : Container {
            
            public PxButtonCollection Buttons;
            
			public Selector Name { get; set; }
			public Label NameLabel { get; private set; }
            
            public c_filterworkingproject_formselectproject(string locator, string name) : 
                    base(locator, name) {
                Name = new Selector("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject_edWP", "Project Name", locator, null);
                NameLabel = new Label(Name);
                Name.DataField = "Name";
                DataMemberName = "FilterWorkingProject";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok() {
                Buttons.Ok.ClickAndWait();
            }
            
            public virtual void Cancel() {
                Buttons.Cancel.ClickAndWait();
            }
            
            public virtual void New() {
                Buttons.New.ClickAndWait();
            }
            
            public class PxButtonCollection : PxControlCollection {
                
			public Button Ok {get; private set; }
			public Button Cancel {get; private set; }
			public Button New {get; private set; }
                
                public PxButtonCollection() {
                    Ok = new Button("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_SelectProjectOk", "OK", "ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject");
                    Cancel = new Button("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_SelectProjectCancel", "Cancel", "ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject");
                    New = new Button("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_BtnNewProject", "New...", "ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject");
                }
            }
        }
        
        public class c__batch_currencyinfo__rf : Container {
            
            public PxButtonCollection Buttons;
            
			public Selector CuryRateTypeID { get; set; }
			public Label CuryRateTypeIDLabel { get; private set; }
			public DateSelector CuryEffDate { get; set; }
			public Label CuryEffDateLabel { get; private set; }
			public PXTextEdit DisplayCuryID { get; set; }
			public Label DisplayCuryIDLabel { get; private set; }
			public PXTextEdit BaseCuryID { get; set; }
			public Label BaseCuryIDLabel { get; private set; }
			public PXNumberEdit SampleCuryRate { get; set; }
			public Label SampleCuryRateLabel { get; private set; }
			public PXNumberEdit SampleRecipRate { get; set; }
			public Label SampleRecipRateLabel { get; private set; }
			public PXTextEdit DisplayCuryID2 { get; set; }
			public Label DisplayCuryID2Label { get; private set; }
			public PXTextEdit BaseCuryID2 { get; set; }
			public Label BaseCuryID2Label { get; private set; }
			public Label LblRateType_ { get; set; }
			public Label LblEffDate_ { get; set; }
			public Label LblCount_ { get; set; }
			public Label LblCount2_ { get; set; }
			public Label LblEQ_ { get; set; }
			public Label LblEQ2_ { get; set; }
            
            public c__batch_currencyinfo__rf(string locator, string name) : 
                    base(locator, name) {
                CuryRateTypeID = new Selector("ctl00_phF_form_edCury_pnlRate_rf_edRateType", "Cury Rate Type ID", locator, null);
                CuryRateTypeIDLabel = new Label(CuryRateTypeID);
                CuryRateTypeID.DataField = "CuryRateTypeID";
                CuryEffDate = new DateSelector("ctl00_phF_form_edCury_pnlRate_rf_edEffDate", "Cury Eff Date", locator, null);
                CuryEffDateLabel = new Label(CuryEffDate);
                CuryEffDate.DataField = "CuryEffDate";
                DisplayCuryID = new PXTextEdit("ctl00_phF_form_edCury_pnlRate_rf_txtCury", "Display Cury ID", locator, null);
                DisplayCuryIDLabel = new Label(DisplayCuryID);
                DisplayCuryID.DataField = "DisplayCuryID";
                BaseCuryID = new PXTextEdit("ctl00_phF_form_edCury_pnlRate_rf_txtBaseCury", "Base Cury ID", locator, null);
                BaseCuryIDLabel = new Label(BaseCuryID);
                BaseCuryID.DataField = "BaseCuryID";
                SampleCuryRate = new PXNumberEdit("ctl00_phF_form_edCury_pnlRate_rf_txtCuryRate", "Sample Cury Rate", locator, null);
                SampleCuryRateLabel = new Label(SampleCuryRate);
                SampleCuryRate.DataField = "SampleCuryRate";
                SampleRecipRate = new PXNumberEdit("ctl00_phF_form_edCury_pnlRate_rf_txtCuryRate2", "Sample Recip Rate", locator, null);
                SampleRecipRateLabel = new Label(SampleRecipRate);
                SampleRecipRate.DataField = "SampleRecipRate";
                DisplayCuryID2 = new PXTextEdit("ctl00_phF_form_edCury_pnlRate_rf_txtCury2", "Display Cury ID 2", locator, null);
                DisplayCuryID2Label = new Label(DisplayCuryID2);
                DisplayCuryID2.DataField = "DisplayCuryID";
                BaseCuryID2 = new PXTextEdit("ctl00_phF_form_edCury_pnlRate_rf_txtBaseCury2", "Base Cury ID 2", locator, null);
                BaseCuryID2Label = new Label(BaseCuryID2);
                BaseCuryID2.DataField = "BaseCuryID";
                LblRateType_ = new Label("ctl00_phF_form_edCury_pnlRate_rf_lblRateType", "Curr. Rate Type ID:", locator, null);
                LblEffDate_ = new Label("ctl00_phF_form_edCury_pnlRate_rf_lblEffDate", "Effective Date:", locator, null);
                LblCount_ = new Label("ctl00_phF_form_edCury_pnlRate_rf_lblCount", "1.000", locator, null);
                LblCount2_ = new Label("ctl00_phF_form_edCury_pnlRate_rf_lblCount2", "1.000", locator, null);
                LblEQ_ = new Label("ctl00_phF_form_edCury_pnlRate_rf_lblEQ", "=", locator, null);
                LblEQ2_ = new Label("ctl00_phF_form_edCury_pnlRate_rf_lblEQ2", "=", locator, null);
                DataMemberName = "_Batch_CurrencyInfo_";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok() {
                Buttons.Ok.ClickAndWait();
            }
            
            public class PxButtonCollection : PxControlCollection {
                
			public Button Ok {get; private set; }
                
                public PxButtonCollection() {
                    Ok = new Button("ctl00_phF_form_edCury_pnlRate_btnOk", "OK", "ctl00_phF_form_edCury_pnlRate_rf");
                }
            }
        }
        
        public class c_gltranmodulebatnbr_lv0 : Container {
            
			public Selector BranchID { get; set; }
			public Label BranchIDLabel { get; private set; }
			public Selector AccountID { get; set; }
			public Label AccountIDLabel { get; private set; }
			public Selector SubID { get; set; }
			public Label SubIDLabel { get; private set; }
			public PXTextEdit RefNbr { get; set; }
			public Label RefNbrLabel { get; private set; }
			public DateSelector TranDate { get; set; }
			public Label TranDateLabel { get; private set; }
			public Selector UOM { get; set; }
			public Label UOMLabel { get; private set; }
			public PXNumberEdit Qty { get; set; }
			public Label QtyLabel { get; private set; }
			public PXNumberEdit CuryDebitAmt { get; set; }
			public Label CuryDebitAmtLabel { get; private set; }
			public PXNumberEdit CuryCreditAmt { get; set; }
			public Label CuryCreditAmtLabel { get; private set; }
			public Selector ProjectID { get; set; }
			public Label ProjectIDLabel { get; private set; }
			public Selector TaskID { get; set; }
			public Label TaskIDLabel { get; private set; }
			public Selector ReferenceID { get; set; }
			public Label ReferenceIDLabel { get; private set; }
			public Selector InventoryID { get; set; }
			public Label InventoryIDLabel { get; private set; }
			public Selector LedgerID { get; set; }
			public Label LedgerIDLabel { get; private set; }
			public Selector TaxID { get; set; }
			public Label TaxIDLabel { get; private set; }
			public PXTextEdit TranDesc { get; set; }
			public Label TranDescLabel { get; private set; }
			public Selector Es { get; set; }
			public Label EsLabel { get; private set; }
			public DropDown Ec { get; set; }
			public DropDown Module { get; set; }
			public Label ModuleLabel { get; private set; }
			public PXTextEdit BatchNbr { get; set; }
			public Label BatchNbrLabel { get; private set; }
			public PXNumberEdit LineNbr { get; set; }
			public Label LineNbrLabel { get; private set; }
            
            public c_gltranmodulebatnbr_lv0(string locator, string name) : 
                    base(locator, name) {
                BranchID = new Selector("ctl00_phG_grid_lv0_edBranchID", "Branch", locator, null);
                BranchIDLabel = new Label(BranchID);
                BranchID.DataField = "BranchID";
                AccountID = new Selector("ctl00_phG_grid_lv0_edAccountID", "Account", locator, null);
                AccountIDLabel = new Label(AccountID);
                AccountID.DataField = "AccountID";
                SubID = new Selector("ctl00_phG_grid_lv0_edSubID", "Subaccount", locator, null);
                SubIDLabel = new Label(SubID);
                SubID.DataField = "SubID";
                RefNbr = new PXTextEdit("ctl00_phG_grid_lv0_edRefNbr", "Ref. Number", locator, null);
                RefNbrLabel = new Label(RefNbr);
                RefNbr.DataField = "RefNbr";
                TranDate = new DateSelector("ctl00_phG_grid_lv0_edTranDate", "Transaction Date", locator, null);
                TranDateLabel = new Label(TranDate);
                TranDate.DataField = "TranDate";
                UOM = new Selector("ctl00_phG_grid_lv0_edUOM", "UOM", locator, null);
                UOMLabel = new Label(UOM);
                UOM.DataField = "UOM";
                Qty = new PXNumberEdit("ctl00_phG_grid_lv0_edQty", "Quantity", locator, null);
                QtyLabel = new Label(Qty);
                Qty.DataField = "Qty";
                CuryDebitAmt = new PXNumberEdit("ctl00_phG_grid_lv0_edCuryDebitAmt", "Debit Amount", locator, null);
                CuryDebitAmtLabel = new Label(CuryDebitAmt);
                CuryDebitAmt.DataField = "CuryDebitAmt";
                CuryCreditAmt = new PXNumberEdit("ctl00_phG_grid_lv0_edCuryCreditAmt", "Credit Amount", locator, null);
                CuryCreditAmtLabel = new Label(CuryCreditAmt);
                CuryCreditAmt.DataField = "CuryCreditAmt";
                ProjectID = new Selector("ctl00_phG_grid_lv0_edProjectID", "Project", locator, null);
                ProjectIDLabel = new Label(ProjectID);
                ProjectID.DataField = "ProjectID";
                TaskID = new Selector("ctl00_phG_grid_lv0_edTaskID", "Project Task", locator, null);
                TaskIDLabel = new Label(TaskID);
                TaskID.DataField = "TaskID";
                ReferenceID = new Selector("ctl00_phG_grid_lv0_edReferenceID", "Customer/Vendor", locator, null);
                ReferenceIDLabel = new Label(ReferenceID);
                ReferenceID.DataField = "ReferenceID";
                InventoryID = new Selector("ctl00_phG_grid_lv0_edInventoryID", "Inventory ID", locator, null);
                InventoryIDLabel = new Label(InventoryID);
                InventoryID.DataField = "InventoryID";
                LedgerID = new Selector("ctl00_phG_grid_lv0_edLedger", "Ledger", locator, null);
                LedgerIDLabel = new Label(LedgerID);
                LedgerID.DataField = "LedgerID";
                TaxID = new Selector("ctl00_phG_grid_lv0_edTaxID", "Tax ID", locator, null);
                TaxIDLabel = new Label(TaxID);
                TaxID.DataField = "TaxID";
                TranDesc = new PXTextEdit("ctl00_phG_grid_lv0_edTranDesc", "Transaction Description", locator, null);
                TranDescLabel = new Label(TranDesc);
                TranDesc.DataField = "TranDesc";
                Es = new Selector("ctl00_phG_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_phG_grid_lv0_ec", "Ec", locator, null);
                Module = new DropDown("ctl00_phG_grid_lv0_edModule", "Module", locator, null);
                ModuleLabel = new Label(Module);
                Module.DataField = "Module";
                Module.Items.Add("GL", "GL");
                Module.Items.Add("AP", "AP");
                Module.Items.Add("AR", "AR");
                Module.Items.Add("CM", "CM");
                Module.Items.Add("CA", "CA");
                Module.Items.Add("IN", "IN");
                Module.Items.Add("DR", "DR");
                Module.Items.Add("FA", "FA");
                Module.Items.Add("PM", "PM");
                Module.Items.Add("PR", "PR");
                BatchNbr = new PXTextEdit("ctl00_phG_grid_lv0_edBatchNbr", "Batch Nbr", locator, null);
                BatchNbrLabel = new Label(BatchNbr);
                BatchNbr.DataField = "BatchNbr";
                LineNbr = new PXNumberEdit("ctl00_phG_grid_lv0_edLineNbr", "Line Nbr", locator, null);
                LineNbrLabel = new Label(LineNbr);
                LineNbr.DataField = "LineNbr";
                DataMemberName = "GLTranModuleBatNbr";
            }
        }
        
        public class c_gltranmodulebatnbr_grid : Grid<c_gltranmodulebatnbr_grid.c_grid_row, c_gltranmodulebatnbr_grid.c_grid_header> {
            
            public PxToolBar ToolBar;
            
			public c_grid_upload UploadForm { get; set; }
			public c_grid_filter FilterForm { get; set; }
			public SmartPanel_AttachFile FilesUploadDialog {get; private set;}
			public Note NotePanel {get; private set;}
            
            public c_gltranmodulebatnbr_grid(string locator, string name) : 
                    base(locator, name) {
                ToolBar = new PxToolBar("ctl00_phG_grid");
                DataMemberName = "GLTranModuleBatNbr";
                UploadForm = new c_grid_upload("ctl00_phG_grid_imp_upl_pnl", "UploadForm");
                FilterForm = new c_grid_filter("ctl00_phG_grid_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void Refresh() {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New() {
                ToolBar.New.Click();
            }
            
            public virtual void FormView() {
                ToolBar.FormView.Click();
            }
            
            public virtual void Delete() {
                ToolBar.Delete.Click();
            }
            
            public virtual void ViewDocument() {
                ToolBar.ViewDocument.Click();
            }
            
            public virtual void ReclassificationHistory() {
                ToolBar.ReclassificationHistory.Click();
            }
            
            public virtual void Adjust() {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export() {
                ToolBar.Export.Click();
            }
            
            public virtual void Upload() {
                ToolBar.Upload.Click();
            }
            
            public virtual void FilterBar() {
                ToolBar.FilterBar.Click();
            }
            
            public virtual void PageFirst() {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev() {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext() {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast() {
                ToolBar.PageLast.Click();
            }
            
            public class PxToolBar : PxControlCollection {
                
			public ToolBarButtonGrid Refresh {get; private set; }
			public ToolBarButtonGrid New {get; private set; }
			public ToolBarButtonGrid FormView {get; private set; }
			public ToolBarButtonGrid Delete {get; private set; }
			public ToolBarButtonGrid ViewDocument {get; private set; }
			public ToolBarButtonGrid ReclassificationHistory {get; private set; }
			public ToolBarButtonGrid Adjust {get; private set; }
			public ToolBarButtonGrid Export {get; private set; }
			public ToolBarButtonGrid Upload {get; private set; }
			public ToolBarButtonGrid FilterBar {get; private set; }
			public ToolBarButtonGrid PageFirst {get; private set; }
			public ToolBarButtonGrid PagePrev {get; private set; }
			public ToolBarButtonGrid PageNext {get; private set; }
			public ToolBarButtonGrid PageLast {get; private set; }
                
                public PxToolBar(string locator) {
                    Refresh = new ToolBarButtonGrid("css=div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    FormView = new ToolBarButtonGrid("css=div[data-cmd=\'EditRecord\']", "Switch Between Grid and Form", locator, null);
                    Delete = new ToolBarButtonGrid("css=div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = Alert.AlertToException;
                    ViewDocument = new ToolBarButtonGrid("css=div[data-cmd=\'ViewDocument\']", "View Source Document", locator, null);
                    ReclassificationHistory = new ToolBarButtonGrid("css=div[data-cmd=\'ReclassificationHistory\']", "Reclassification History", locator, null);
                    Adjust = new ToolBarButtonGrid("css=div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Upload = new ToolBarButtonGrid("css=div[data-cmd=\'Upload\']", "Load Records from File", locator, null);
                    FilterBar = new ToolBarButtonGrid("css=div[data-cmd=\'FilterBar\']", "FilterBar", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                }
            }
            
            public class c_grid_row : GridRow {
                
			public FileColumnButton Files { get; set; }
			public NoteColumnButton Notes { get; set; }
			public PXNumberEdit LineNbr { get; set; }
			public Selector BranchID { get; set; }
			public Selector AccountID { get; set; }
			public PXTextEdit AccountID_Account_description { get; set; }
			public Selector SubID { get; set; }
			public Selector ProjectID { get; set; }
			public Selector TaskID { get; set; }
			public PXTextEdit RefNbr { get; set; }
			public DateSelector TranDate { get; set; }
			public PXNumberEdit Qty { get; set; }
			public Selector UOM { get; set; }
			public PXNumberEdit CuryDebitAmt { get; set; }
			public PXNumberEdit CuryCreditAmt { get; set; }
			public PXTextEdit TranDesc { get; set; }
			public Selector InventoryID { get; set; }
			public Selector LedgerID { get; set; }
			public Selector ReferenceID { get; set; }
			public Selector TaxID { get; set; }
			public Selector TaxCategoryID { get; set; }
			public CheckBox NonBillable { get; set; }
			public PXTextEdit ReclassBatchNbr { get; set; }
			public PXTextEdit OrigModule { get; set; }
			public PXTextEdit OrigBatchNbr { get; set; }
			public PXNumberEdit OrigLineNbr { get; set; }
			public PXTextEdit IncludedInReclassHistory { get; set; }
			public DropDown Module { get; set; }
			public PXTextEdit BatchNbr { get; set; }
                
                public c_grid_row(c_gltranmodulebatnbr_grid grid) : 
                        base(grid) {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    LineNbr = new PXNumberEdit("_ctl00_phG_grid_lv0_edLineNbr", "Line Nbr.", grid.Locator, "LineNbr");
                    LineNbr.DataField = "LineNbr";
                    BranchID = new Selector("_ctl00_phG_grid_lv0_edBranchID", "Branch", grid.Locator, "BranchID");
                    BranchID.DataField = "BranchID";
                    AccountID = new Selector("_ctl00_phG_grid_lv0_edAccountID", "Account", grid.Locator, "AccountID");
                    AccountID.DataField = "AccountID";
                    AccountID_Account_description = new PXTextEdit("ctl00_phG_grid_ei", "Description", grid.Locator, "AccountID_Account_description");
                    AccountID_Account_description.DataField = "AccountID_Account_description";
                    SubID = new Selector("_ctl00_phG_grid_lv0_edSubID", "Subaccount", grid.Locator, "SubID");
                    SubID.DataField = "SubID";
                    ProjectID = new Selector("_ctl00_phG_grid_lv0_edProjectID", "Project", grid.Locator, "ProjectID");
                    ProjectID.DataField = "ProjectID";
                    TaskID = new Selector("_ctl00_phG_grid_lv0_edTaskID", "Project Task", grid.Locator, "TaskID");
                    TaskID.DataField = "TaskID";
                    RefNbr = new PXTextEdit("_ctl00_phG_grid_lv0_edRefNbr", "Ref. Number", grid.Locator, "RefNbr");
                    RefNbr.DataField = "RefNbr";
                    TranDate = new DateSelector("_ctl00_phG_grid_lv0_edTranDate", "Transaction Date", grid.Locator, "TranDate");
                    TranDate.DataField = "TranDate";
                    Qty = new PXNumberEdit("_ctl00_phG_grid_lv0_edQty", "Quantity", grid.Locator, "Qty");
                    Qty.DataField = "Qty";
                    UOM = new Selector("_ctl00_phG_grid_lv0_edUOM", "UOM", grid.Locator, "UOM");
                    UOM.DataField = "UOM";
                    CuryDebitAmt = new PXNumberEdit("_ctl00_phG_grid_lv0_edCuryDebitAmt", "Debit Amount", grid.Locator, "CuryDebitAmt");
                    CuryDebitAmt.DataField = "CuryDebitAmt";
                    CuryCreditAmt = new PXNumberEdit("_ctl00_phG_grid_lv0_edCuryCreditAmt", "Credit Amount", grid.Locator, "CuryCreditAmt");
                    CuryCreditAmt.DataField = "CuryCreditAmt";
                    TranDesc = new PXTextEdit("_ctl00_phG_grid_lv0_edTranDesc", "Transaction Description", grid.Locator, "TranDesc");
                    TranDesc.DataField = "TranDesc";
                    InventoryID = new Selector("_ctl00_phG_grid_lv0_edInventoryID", "Inventory ID", grid.Locator, "InventoryID");
                    InventoryID.DataField = "InventoryID";
                    LedgerID = new Selector("_ctl00_phG_grid_lv0_edLedger", "Ledger", grid.Locator, "LedgerID");
                    LedgerID.DataField = "LedgerID";
                    ReferenceID = new Selector("_ctl00_phG_grid_lv0_edReferenceID", "Customer/Vendor", grid.Locator, "ReferenceID");
                    ReferenceID.DataField = "ReferenceID";
                    TaxID = new Selector("_ctl00_phG_grid_lv0_edTaxID", "Tax ID", grid.Locator, "TaxID");
                    TaxID.DataField = "TaxID";
                    TaxCategoryID = new Selector("_ctl00_phG_grid_lv0_es", "Tax Category", grid.Locator, "TaxCategoryID");
                    TaxCategoryID.DataField = "TaxCategoryID";
                    NonBillable = new CheckBox("ctl00_phG_grid_ef", "Non Billable", grid.Locator, "NonBillable");
                    NonBillable.DataField = "NonBillable";
                    ReclassBatchNbr = new PXTextEdit("ctl00_phG_grid_ei", "Reclass. Batch Number", grid.Locator, "ReclassBatchNbr");
                    ReclassBatchNbr.DataField = "ReclassBatchNbr";
                    OrigModule = new PXTextEdit("ctl00_phG_grid_ei", "Orig. Module", grid.Locator, "OrigModule");
                    OrigModule.DataField = "OrigModule";
                    OrigBatchNbr = new PXTextEdit("ctl00_phG_grid_ei", "Orig. Batch Nbr.", grid.Locator, "OrigBatchNbr");
                    OrigBatchNbr.DataField = "OrigBatchNbr";
                    OrigLineNbr = new PXNumberEdit("ctl00_phG_grid_en", "Orig. Line Nbr.", grid.Locator, "OrigLineNbr");
                    OrigLineNbr.DataField = "OrigLineNbr";
                    IncludedInReclassHistory = new PXTextEdit("ctl00_phG_grid_ef", "Included in Reclass. History", grid.Locator, "IncludedInReclassHistory");
                    IncludedInReclassHistory.DataField = "IncludedInReclassHistory";
                    Module = new DropDown("_ctl00_phG_grid_lv0_edModule", "Module", grid.Locator, "Module");
                    Module.DataField = "Module";
                    Module.Items.Add("GL", "GL");
                    Module.Items.Add("AP", "AP");
                    Module.Items.Add("AR", "AR");
                    Module.Items.Add("CM", "CM");
                    Module.Items.Add("CA", "CA");
                    Module.Items.Add("IN", "IN");
                    Module.Items.Add("DR", "DR");
                    Module.Items.Add("FA", "FA");
                    Module.Items.Add("PM", "PM");
                    Module.Items.Add("PR", "PR");
                    BatchNbr = new PXTextEdit("_ctl00_phG_grid_lv0_edBatchNbr", "Batch Number", grid.Locator, "BatchNbr");
                    BatchNbr.DataField = "BatchNbr";
                }
            }
            
            public class c_grid_header : GridHeader {
                
				public GridColumnHeader Files {get;set;}
				public GridColumnHeader Notes {get;set;}
				public PXNumberEditColumnFilter LineNbr {get;set;}
				public SelectorColumnFilter BranchID {get;set;}
				public SelectorColumnFilter AccountID {get;set;}
				public PXTextEditColumnFilter AccountID_Account_description {get;set;}
				public SelectorColumnFilter SubID {get;set;}
				public SelectorColumnFilter ProjectID {get;set;}
				public SelectorColumnFilter TaskID {get;set;}
				public PXTextEditColumnFilter RefNbr {get;set;}
				public DateSelectorColumnFilter TranDate {get;set;}
				public PXNumberEditColumnFilter Qty {get;set;}
				public SelectorColumnFilter UOM {get;set;}
				public PXNumberEditColumnFilter CuryDebitAmt {get;set;}
				public PXNumberEditColumnFilter CuryCreditAmt {get;set;}
				public PXTextEditColumnFilter TranDesc {get;set;}
				public SelectorColumnFilter InventoryID {get;set;}
				public SelectorColumnFilter LedgerID {get;set;}
				public SelectorColumnFilter ReferenceID {get;set;}
				public SelectorColumnFilter TaxID {get;set;}
				public SelectorColumnFilter TaxCategoryID {get;set;}
				public CheckBoxColumnFilter NonBillable {get;set;}
				public PXTextEditColumnFilter ReclassBatchNbr {get;set;}
				public PXTextEditColumnFilter OrigModule {get;set;}
				public PXTextEditColumnFilter OrigBatchNbr {get;set;}
				public PXNumberEditColumnFilter OrigLineNbr {get;set;}
				public PXTextEditColumnFilter IncludedInReclassHistory {get;set;}
				public DropDownColumnFilter Module {get;set;}
				public PXTextEditColumnFilter BatchNbr {get;set;}
                
                public c_grid_header(c_gltranmodulebatnbr_grid grid) : 
                        base(grid) {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    LineNbr = new PXNumberEditColumnFilter(grid.Row.LineNbr);
                    BranchID = new SelectorColumnFilter(grid.Row.BranchID);
                    AccountID = new SelectorColumnFilter(grid.Row.AccountID);
                    AccountID_Account_description = new PXTextEditColumnFilter(grid.Row.AccountID_Account_description);
                    SubID = new SelectorColumnFilter(grid.Row.SubID);
                    ProjectID = new SelectorColumnFilter(grid.Row.ProjectID);
                    TaskID = new SelectorColumnFilter(grid.Row.TaskID);
                    RefNbr = new PXTextEditColumnFilter(grid.Row.RefNbr);
                    TranDate = new DateSelectorColumnFilter(grid.Row.TranDate);
                    Qty = new PXNumberEditColumnFilter(grid.Row.Qty);
                    UOM = new SelectorColumnFilter(grid.Row.UOM);
                    CuryDebitAmt = new PXNumberEditColumnFilter(grid.Row.CuryDebitAmt);
                    CuryCreditAmt = new PXNumberEditColumnFilter(grid.Row.CuryCreditAmt);
                    TranDesc = new PXTextEditColumnFilter(grid.Row.TranDesc);
                    InventoryID = new SelectorColumnFilter(grid.Row.InventoryID);
                    LedgerID = new SelectorColumnFilter(grid.Row.LedgerID);
                    ReferenceID = new SelectorColumnFilter(grid.Row.ReferenceID);
                    TaxID = new SelectorColumnFilter(grid.Row.TaxID);
                    TaxCategoryID = new SelectorColumnFilter(grid.Row.TaxCategoryID);
                    NonBillable = new CheckBoxColumnFilter(grid.Row.NonBillable);
                    ReclassBatchNbr = new PXTextEditColumnFilter(grid.Row.ReclassBatchNbr);
                    OrigModule = new PXTextEditColumnFilter(grid.Row.OrigModule);
                    OrigBatchNbr = new PXTextEditColumnFilter(grid.Row.OrigBatchNbr);
                    OrigLineNbr = new PXNumberEditColumnFilter(grid.Row.OrigLineNbr);
                    IncludedInReclassHistory = new PXTextEditColumnFilter(grid.Row.IncludedInReclassHistory);
                    Module = new DropDownColumnFilter(grid.Row.Module);
                    BatchNbr = new PXTextEditColumnFilter(grid.Row.BatchNbr);
                }
            }
        }
        
        public class c_voucher_voucherdetails : Container {
            
			public PXTextEdit VoucherBatchNbr { get; set; }
			public Label VoucherBatchNbrLabel { get; private set; }
			public PXTextEdit WorkBookID { get; set; }
			public Label WorkBookIDLabel { get; private set; }
            
            public c_voucher_voucherdetails(string locator, string name) : 
                    base(locator, name) {
                VoucherBatchNbr = new PXTextEdit("ctl00_phF_form_VoucherDetails_linkGLVoucherBatch", "Voucher Batch Nbr.", locator, null);
                VoucherBatchNbrLabel = new Label(VoucherBatchNbr);
                VoucherBatchNbr.DataField = "VoucherBatchNbr";
                WorkBookID = new PXTextEdit("ctl00_phF_form_VoucherDetails_linkGLWorkBook", "Workbook ID", locator, null);
                WorkBookIDLabel = new Label(WorkBookID);
                WorkBookID.DataField = "WorkBookID";
                DataMemberName = "Voucher";
            }
        }
        
        public class c_gltranmodulebatnbr_importcsvsettings_frmimportcsvsettings : Container {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit Separator { get; set; }
			public Label SeparatorLabel { get; private set; }
			public PXTextEdit NullValue { get; set; }
			public Label NullValueLabel { get; private set; }
			public DropDown CodePage { get; set; }
			public Label CodePageLabel { get; private set; }
			public DropDown Culture { get; set; }
			public Label CultureLabel { get; private set; }
			public DropDown Mode { get; set; }
			public Label ModeLabel { get; private set; }
            
            public c_gltranmodulebatnbr_importcsvsettings_frmimportcsvsettings(string locator, string name) : 
                    base(locator, name) {
                Separator = new PXTextEdit("ctl00_phG_grid_imp_importCSVSettingsDlg_frmImportCSVSettings_edSeparator", "Separator", locator, null);
                SeparatorLabel = new Label(Separator);
                Separator.DataField = "Separator";
                NullValue = new PXTextEdit("ctl00_phG_grid_imp_importCSVSettingsDlg_frmImportCSVSettings_edNullValue", "Null Value", locator, null);
                NullValueLabel = new Label(NullValue);
                NullValue.DataField = "NullValue";
                CodePage = new DropDown("ctl00_phG_grid_imp_importCSVSettingsDlg_frmImportCSVSettings_edCodePage", "Code Page", locator, null);
                CodePageLabel = new Label(CodePage);
                CodePage.DataField = "CodePage";
                Culture = new DropDown("ctl00_phG_grid_imp_importCSVSettingsDlg_frmImportCSVSettings_edCultures", "Culture", locator, null);
                CultureLabel = new Label(Culture);
                Culture.DataField = "Culture";
                Mode = new DropDown("ctl00_phG_grid_imp_importCSVSettingsDlg_frmImportCSVSettings_edMode", "Mode", locator, null);
                ModeLabel = new Label(Mode);
                Mode.DataField = "Mode";
                DataMemberName = "GLTranModuleBatNbr$ImportCSVSettings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok() {
                Buttons.Ok.ClickAndWait();
            }
            
            public virtual void Cancel() {
                Buttons.Cancel.ClickAndWait();
            }
            
            public class PxButtonCollection : PxControlCollection {
                
			public Button Ok {get; private set; }
			public Button Cancel {get; private set; }
                
                public PxButtonCollection() {
                    Ok = new Button("ctl00_phG_grid_imp_importCSVSettingsDlg_btnSave1", "OK", "ctl00_phG_grid_imp_importCSVSettingsDlg_frmImportCSVSettings");
                    Cancel = new Button("ctl00_phG_grid_imp_importCSVSettingsDlg_btnCancel1", "Cancel", "ctl00_phG_grid_imp_importCSVSettingsDlg_frmImportCSVSettings");
                }
            }
        }
        
        public class c_gltranmodulebatnbr_importxlsxsettings_frmimportxlsxsettings : Container {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit NullValue { get; set; }
			public Label NullValueLabel { get; private set; }
			public DropDown Culture { get; set; }
			public Label CultureLabel { get; private set; }
			public DropDown Mode { get; set; }
			public Label ModeLabel { get; private set; }
            
            public c_gltranmodulebatnbr_importxlsxsettings_frmimportxlsxsettings(string locator, string name) : 
                    base(locator, name) {
                NullValue = new PXTextEdit("ctl00_phG_grid_imp_importXLSXSettingsDlg_frmImportXLSXSettings_edNullValue", "Null Value", locator, null);
                NullValueLabel = new Label(NullValue);
                NullValue.DataField = "NullValue";
                Culture = new DropDown("ctl00_phG_grid_imp_importXLSXSettingsDlg_frmImportXLSXSettings_edCultures", "Culture", locator, null);
                CultureLabel = new Label(Culture);
                Culture.DataField = "Culture";
                Mode = new DropDown("ctl00_phG_grid_imp_importXLSXSettingsDlg_frmImportXLSXSettings_edMode", "Mode", locator, null);
                ModeLabel = new Label(Mode);
                Mode.DataField = "Mode";
                DataMemberName = "GLTranModuleBatNbr$ImportXLSXSettings";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok() {
                Buttons.Ok.ClickAndWait();
            }
            
            public virtual void Cancel() {
                Buttons.Cancel.ClickAndWait();
            }
            
            public class PxButtonCollection : PxControlCollection {
                
			public Button Ok {get; private set; }
			public Button Cancel {get; private set; }
                
                public PxButtonCollection() {
                    Ok = new Button("ctl00_phG_grid_imp_importXLSXSettingsDlg_btnSave2", "OK", "ctl00_phG_grid_imp_importXLSXSettingsDlg_frmImportXLSXSettings");
                    Cancel = new Button("ctl00_phG_grid_imp_importXLSXSettingsDlg_btnCancel2", "Cancel", "ctl00_phG_grid_imp_importXLSXSettingsDlg_frmImportXLSXSettings");
                }
            }
        }
        
        public class c_gltranmodulebatnbr_importcolumns_grdimportcolumn : Grid<c_gltranmodulebatnbr_importcolumns_grdimportcolumn.c_grid_row, c_gltranmodulebatnbr_importcolumns_grdimportcolumn.c_grid_header> {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
            public c_gltranmodulebatnbr_importcolumns_grdimportcolumn(string locator, string name) : 
                    base(locator, name) {
                ToolBar = new PxToolBar("ctl00_phG_grid_imp_importColumnDlg_grdImportColumn");
                DataMemberName = "GLTranModuleBatNbr$ImportColumns";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Refresh() {
                ToolBar.Refresh.Click();
            }
            
            public virtual void Search() {
                ToolBar.Search.Click();
            }
            
            public virtual void Export() {
                ToolBar.Export.Click();
            }
            
            public virtual void Adjust() {
                ToolBar.Adjust.Click();
            }
            
            public virtual void New() {
                ToolBar.New.Click();
            }
            
            public virtual void Save() {
                ToolBar.Save.Click();
            }
            
            public virtual void Delete() {
                ToolBar.Delete.Click();
            }
            
            public virtual void Note() {
                ToolBar.Note.Click();
            }
            
            public virtual void First() {
                Buttons.First.ClickAndWait();
            }
            
            public virtual void Prev() {
                Buttons.Prev.ClickAndWait();
            }
            
            public virtual void Next() {
                Buttons.Next.ClickAndWait();
            }
            
            public virtual void Last() {
                Buttons.Last.ClickAndWait();
            }
            
            public virtual void Ok() {
                Buttons.Ok.ClickAndWait();
            }
            
            public virtual void Cancel() {
                Buttons.Cancel.ClickAndWait();
            }
            
            public class PxToolBar : PxControlCollection {
                
			public ToolBarButtonGrid Refresh {get; private set; }
			public ToolBarButtonGrid Search {get; private set; }
			public ToolBarButtonGrid Export {get; private set; }
			public ToolBarButtonGrid Adjust {get; private set; }
			public ToolBarButtonGrid New {get; private set; }
			public ToolBarButtonGrid Save {get; private set; }
			public ToolBarButtonGrid Delete {get; private set; }
			public ToolBarButtonGrid Note {get; private set; }
                
                public PxToolBar(string locator) {
                    Refresh = new ToolBarButtonGrid("css=div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Search = new ToolBarButtonGrid("css=div[data-cmd=\'Search\']", "Search records.", locator, null);
                    Export = new ToolBarButtonGrid("css=div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Adjust = new ToolBarButtonGrid("css=div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    New = new ToolBarButtonGrid("css=div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Save = new ToolBarButtonGrid("css=div[data-cmd=\'Save\']", "Save data changes.", locator, null);
                    Delete = new ToolBarButtonGrid("css=div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Delete.ConfirmAction = Alert.AlertToException;
                    Note = new ToolBarButtonGrid("css=div[data-cmd=\'NoteShow\']", "Show the note of the record.", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection {
                
			public Button First {get; private set; }
			public Button Prev {get; private set; }
			public Button Next {get; private set; }
			public Button Last {get; private set; }
			public Button Ok {get; private set; }
			public Button Cancel {get; private set; }
                
                public PxButtonCollection() {
                    First = new Button("ctl00_phG_grid_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_grid_imp_importColumnDlg_grdImportColumn");
                    Prev = new Button("ctl00_phG_grid_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_grid_imp_importColumnDlg_grdImportColumn");
                    Next = new Button("ctl00_phG_grid_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_grid_imp_importColumnDlg_grdImportColumn");
                    Last = new Button("ctl00_phG_grid_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_grid_imp_importColumnDlg_grdImportColumn");
                    Ok = new Button("ctl00_phG_grid_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_grid_imp_importColumnDlg_grdImportColumn");
                    Cancel = new Button("ctl00_phG_grid_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_grid_imp_importColumnDlg_grdImportColumn");
                }
            }
            
            public class c_grid_row : GridRow {
                
			public PXTextEdit ColumnName { get; set; }
			public DropDown PropertyName { get; set; }
                
                public c_grid_row(c_gltranmodulebatnbr_importcolumns_grdimportcolumn grid) : 
                        base(grid) {
                    ColumnName = new PXTextEdit("ctl00_phG_grid_imp_importColumnDlg_grdImportColumn_ei", "ColumnName", grid.Locator, "ColumnName");
                    ColumnName.DataField = "ColumnName";
                    PropertyName = new DropDown("_ctl00_phG_grid_imp_importColumnDlg_grdImportColumn_lv0_ec", "PropertyName", grid.Locator, "PropertyName");
                    PropertyName.DataField = "PropertyName";
                }
            }
            
            public class c_grid_header : GridHeader {
                
				public PXTextEditColumnFilter ColumnName {get;set;}
				public InputColumnFilter PropertyName {get;set;}
                
                public c_grid_header(c_gltranmodulebatnbr_importcolumns_grdimportcolumn grid) : 
                        base(grid) {
                    ColumnName = new PXTextEditColumnFilter(grid.Row.ColumnName);
                    PropertyName = new InputColumnFilter(grid.Row.PropertyName);
                }
            }
        }
        
        public class c_gltranmodulebatnbr_importcolumns_lv0 : Container {
            
            public PxButtonCollection Buttons;
            
			public DateSelector Ed { get; set; }
			public Label EdLabel { get; private set; }
			public DropDown Ec { get; set; }
			public Selector Es { get; set; }
			public Label EsLabel { get; private set; }
			public Selector Em { get; set; }
			public Label EmLabel { get; private set; }
            
            public c_gltranmodulebatnbr_importcolumns_lv0(string locator, string name) : 
                    base(locator, name) {
                Ed = new DateSelector("ctl00_phG_grid_imp_importColumnDlg_grdImportColumn_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phG_grid_imp_importColumnDlg_grdImportColumn_lv0_ec", "Ec", locator, null);
                Es = new Selector("ctl00_phG_grid_imp_importColumnDlg_grdImportColumn_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Em = new Selector("ctl00_phG_grid_imp_importColumnDlg_grdImportColumn_lv0_em", "Em", locator, null);
                EmLabel = new Label(Em);
                DataMemberName = "GLTranModuleBatNbr$ImportColumns";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void First() {
                Buttons.First.ClickAndWait();
            }
            
            public virtual void Prev() {
                Buttons.Prev.ClickAndWait();
            }
            
            public virtual void Next() {
                Buttons.Next.ClickAndWait();
            }
            
            public virtual void Last() {
                Buttons.Last.ClickAndWait();
            }
            
            public virtual void Ok() {
                Buttons.Ok.ClickAndWait();
            }
            
            public virtual void Cancel() {
                Buttons.Cancel.ClickAndWait();
            }
            
            public class PxButtonCollection : PxControlCollection {
                
			public Button First {get; private set; }
			public Button Prev {get; private set; }
			public Button Next {get; private set; }
			public Button Last {get; private set; }
			public Button Ok {get; private set; }
			public Button Cancel {get; private set; }
                
                public PxButtonCollection() {
                    First = new Button("ctl00_phG_grid_imp_importColumnDlg_grdImportColumn_lfFirst0", "First", "ctl00_phG_grid_imp_importColumnDlg_grdImportColumn_lv0");
                    Prev = new Button("ctl00_phG_grid_imp_importColumnDlg_grdImportColumn_lfPrev0", "Prev", "ctl00_phG_grid_imp_importColumnDlg_grdImportColumn_lv0");
                    Next = new Button("ctl00_phG_grid_imp_importColumnDlg_grdImportColumn_lfNext0", "Next", "ctl00_phG_grid_imp_importColumnDlg_grdImportColumn_lv0");
                    Last = new Button("ctl00_phG_grid_imp_importColumnDlg_grdImportColumn_lfLast0", "Last", "ctl00_phG_grid_imp_importColumnDlg_grdImportColumn_lv0");
                    Ok = new Button("ctl00_phG_grid_imp_importColumnDlg_btnSave", "OK", "ctl00_phG_grid_imp_importColumnDlg_grdImportColumn_lv0");
                    Cancel = new Button("ctl00_phG_grid_imp_importColumnDlg_btnCancel", "Cancel", "ctl00_phG_grid_imp_importColumnDlg_grdImportColumn_lv0");
                }
            }
        }
    }
}
