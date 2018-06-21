using Api;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.QuickSearch;
using Controls.Editors.Selector;
using Controls.FileColumnButton;
using Controls.Grid;
using Controls.Grid.Filter;
using Controls.Grid.Upload;
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
    
    
    public class GL501000_BatchRelease : Wrapper {
        
        public PxToolBar ToolBar;
        
        private c_batchlist_lv0 batchlist_lv0 = new c_batchlist_lv0("ctl00_phL_grid_lv0", "BatchList_lv0");
        
        private c_batchlist_grid batchlist_grid = new c_batchlist_grid("ctl00_phL_grid", "BatchList_grid");
        
        private c_firstselect_formactions firstselect_formactions = new c_firstselect_formactions("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions", "FirstSelect_FormActions");
        
        private c_vieweleminfo_formeleminfo vieweleminfo_formeleminfo = new c_vieweleminfo_formeleminfo("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", "ViewElemInfo_FormElemInfo");
        
        private c_filterworkingproject_formnewproject filterworkingproject_formnewproject = new c_filterworkingproject_formnewproject("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", "FilterWorkingProject_FormNewProject");
        
        private c_filterworkingproject_formselectproject filterworkingproject_formselectproject = new c_filterworkingproject_formselectproject("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", "FilterWorkingProject_FormSelectProject");
        
        private c__schedulehistoryparameters__frmschedulehistory _schedulehistoryparameters__frmschedulehistory = new c__schedulehistoryparameters__frmschedulehistory("ctl00_phDS_ds_pnlScheduleHistory_frmScheduleHistory", "_ScheduleHistoryParameters__frmScheduleHistory");
        
			public QuickSearch QuickSearch { get; set; }
        
        public GL501000_BatchRelease() {
            ScreenId = "GL501000";
            ScreenUrl = "/Pages/GL/GL501000.aspx";
            ToolBar = new PxToolBar(null);
            QuickSearch = new QuickSearch("ctl00_phDS_ds_ToolBar_fb", "QuickSearch", null, null);
        }
        
        protected virtual c_batchlist_lv0 BatchList_lv0 {
            get {
                return batchlist_lv0;
            }
        }
        
        protected virtual c_batchlist_grid BatchList_grid {
            get {
                return batchlist_grid;
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
        
        protected virtual c__schedulehistoryparameters__frmschedulehistory _ScheduleHistoryParameters__frmScheduleHistory {
            get {
                return _schedulehistoryparameters__frmschedulehistory;
            }
        }
        
        public virtual GL501000_BatchRelease ReadOne(Gate gate, string Module, string BatchNbr) {
            new BiObject<GL501000_BatchRelease>(gate).ReadOne(this, Module, BatchNbr);
            return this;
        }
        
        public virtual GL501000_BatchRelease ReadOne(string Module, string BatchNbr) {
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
        
        public virtual void Refresh() {
            ToolBar.Refresh.Click();
        }
        
        public virtual void Cancel() {
            ToolBar.Cancel.Click();
        }
        
        public virtual void BatchlistBatchnbrViewdetails() {
            ToolBar.BatchlistBatchnbrViewdetails.Click();
        }
        
        public virtual void Process() {
            ToolBar.Process.Click();
        }
        
        public virtual void Process(bool status, string message = null) {
            ToolBar.Process.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.Process.Click();
        }
        
        public virtual void ProcessAll() {
            ToolBar.ProcessAll.Click();
        }
        
        public virtual void ProcessAll(bool status, string message = null) {
            ToolBar.ProcessAll.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.ProcessAll.Click();
        }
        
        public virtual void ScheduleAddHidden() {
            ToolBar.ScheduleAddHidden.Click();
        }
        
        public virtual void ScheduleViewHidden() {
            ToolBar.ScheduleViewHidden.Click();
        }
        
        public virtual void ScheduleHistory() {
            ToolBar.ScheduleHistory.Click();
        }
        
        public virtual void ScheduleHistoryDeleteHidden() {
            ToolBar.ScheduleHistoryDeleteHidden.Click();
        }
        
        public virtual void ScheduleHistoryDeleteAllHidden() {
            ToolBar.ScheduleHistoryDeleteAllHidden.Click();
        }
        
        public virtual void Schedules() {
            ToolBar.Schedules.Click();
        }
        
        public virtual void History() {
            ToolBar.History.Click();
        }
        
        public virtual void ScheduleHistoryDelete() {
            ToolBar.ScheduleHistoryDelete.Click();
        }
        
        public virtual void ScheduleHistoryDeleteAll() {
            ToolBar.ScheduleHistoryDeleteAll.Click();
        }
        
        public virtual void ScheduleAdd() {
            ToolBar.ScheduleAdd.Click();
        }
        
        public virtual void ScheduleView() {
            ToolBar.ScheduleView.Click();
        }
        
        public virtual void Adjust() {
            ToolBar.Adjust.Click();
        }
        
        public virtual void Export() {
            ToolBar.Export.Click();
        }
        
        public virtual void Filter() {
            ToolBar.Filter.Click();
        }
        
        public class PxToolBar : PxControlCollection {
            
			public ToolBarButton SyncTOC {get; private set; }
			public ToolBarButton Favorites {get; private set; }
			public ToolBarButton ClearFilter {get; private set; }
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
			public ToolBarButton Refresh {get; private set; }
			public ToolBarButton Cancel {get; private set; }
			public ToolBarButton BatchlistBatchnbrViewdetails {get; private set; }
			public ToolBarButton Process {get; private set; }
			public ToolBarButton ProcessAll {get; private set; }
			public ToolBarButton ScheduleAddHidden {get; private set; }
			public ToolBarButton ScheduleViewHidden {get; private set; }
			public ToolBarButton ScheduleHistory {get; private set; }
			public ToolBarButton ScheduleHistoryDeleteHidden {get; private set; }
			public ToolBarButton ScheduleHistoryDeleteAllHidden {get; private set; }
			public ToolBarButton Schedules {get; private set; }
			public ToolBarButton History {get; private set; }
			public ToolBarButton ScheduleHistoryDelete {get; private set; }
			public ToolBarButton ScheduleHistoryDeleteAll {get; private set; }
			public ToolBarButton ScheduleAdd {get; private set; }
			public ToolBarButton ScheduleView {get; private set; }
			public ToolBarButton Adjust {get; private set; }
			public ToolBarButton Export {get; private set; }
			public ToolBarButton Filter {get; private set; }
            
            public PxToolBar(string locator) {
                SyncTOC = new ToolBarButton("css=div[data-cmd=\'syncTOC\']", "Sync Navigation Pane", locator, null);
                Favorites = new ToolBarButton("css=div[data-cmd=\'favorites\']", "Add to Favorites", locator, null);
                ClearFilter = new ToolBarButton("css=div[data-cmd=\'clearFilter\']", "Clear Active Filter", locator, null);
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
                Refresh = new ToolBarButton("css=div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                Cancel = new ToolBarButton("css=div[data-cmd=\'Cancel\']", "Cancel (Esc)", locator, null);
                Cancel.ConfirmAction = Alert.AlertToException;
                BatchlistBatchnbrViewdetails = new ToolBarButton("css=div[data-cmd=\'BatchList_batchNbr_ViewDetails\']", "Edit Record", locator, null);
                Process = new ToolBarButton("css=div[data-cmd=\'Process\']", "Release", locator, null);
                Process.WaitAction = Wait.WaitForLongOperationToComplete;
                ProcessAll = new ToolBarButton("css=div[data-cmd=\'ProcessAll\']", "Release All", locator, null);
                ProcessAll.WaitAction = Wait.WaitForLongOperationToComplete;
                ScheduleAddHidden = new ToolBarButton("css=div[data-cmd=\'_ScheduleAdd_\']", "Add", locator, null);
                ScheduleViewHidden = new ToolBarButton("css=div[data-cmd=\'_ScheduleView_\']", "View", locator, null);
                ScheduleHistory = new ToolBarButton("css=div[data-cmd=\'_ScheduleHistory_\']", "History", locator, null);
                ScheduleHistoryDeleteHidden = new ToolBarButton("css=div[data-cmd=\'_ScheduleHistoryDelete_\']", "Delete", locator, null);
                ScheduleHistoryDeleteAllHidden = new ToolBarButton("css=div[data-cmd=\'_ScheduleHistoryDeleteAll_\']", "Delete All", locator, null);
                Schedules = new ToolBarButton("css=li>div.toolsBtn[tooltip=\'Schedules\']", "Schedules", locator, null);
                History = new ToolBarButton("css=li[data-cmd=\'\']", "History", locator, Schedules);
                ScheduleHistoryDelete = new ToolBarButton("css=li[data-cmd=\'Schedule@_ScheduleHistoryDelete_\']", "Delete", locator, Schedules);
                ScheduleHistoryDeleteAll = new ToolBarButton("css=li[data-cmd=\'Schedule@_ScheduleHistoryDeleteAll_\']", "Delete All", locator, Schedules);
                ScheduleAdd = new ToolBarButton("css=li[data-cmd=\'Schedule@_ScheduleAdd_\']", "Add", locator, Schedules);
                ScheduleView = new ToolBarButton("css=li[data-cmd=\'Schedule@_ScheduleView_\']", "View", locator, Schedules);
                Adjust = new ToolBarButton("css=div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                Export = new ToolBarButton("css=div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                Filter = new ToolBarButton("css=div[data-cmd=\'FilterShow\']", "Filter Settings", locator, null);
            }
        }
        
        public class c_batchlist_lv0 : Container {
            
			public Selector Es { get; set; }
			public Label EsLabel { get; private set; }
			public DateSelector Ed { get; set; }
			public Label EdLabel { get; private set; }
			public DropDown Ec { get; set; }
            
            public c_batchlist_lv0(string locator, string name) : 
                    base(locator, name) {
                Es = new Selector("ctl00_phL_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phL_grid_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phL_grid_lv0_ec", "Ec", locator, null);
                DataMemberName = "BatchList";
            }
        }
        
        public class c_batchlist_grid : Grid<c_batchlist_grid.c_grid_row, c_batchlist_grid.c_grid_header> {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; set; }
			public SmartPanel_AttachFile FilesUploadDialog {get; private set;}
			public Note NotePanel {get; private set;}
            
            public c_batchlist_grid(string locator, string name) : 
                    base(locator, name) {
                ToolBar = new PxToolBar("ctl00_phL_grid");
                DataMemberName = "BatchList";
                FilterForm = new c_grid_filter("ctl00_phL_grid_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void SetFilter() {
                ToolBar.SetFilter.Click();
            }
            
            public virtual void AllRecords() {
                ToolBar.AllRecords.Click();
            }
            
            public virtual void Edit() {
                ToolBar.Edit.Click();
            }
            
            public virtual void Hi() {
                ToolBar.Hi.Click();
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
                
			public ToolBarButtonGrid SetFilter {get; private set; }
			public ToolBarButtonGrid AllRecords {get; private set; }
			public ToolBarButtonGrid Edit {get; private set; }
			public ToolBarButtonGrid Hi {get; private set; }
			public ToolBarButtonGrid PageFirst {get; private set; }
			public ToolBarButtonGrid PagePrev {get; private set; }
			public ToolBarButtonGrid PageNext {get; private set; }
			public ToolBarButtonGrid PageLast {get; private set; }
                
                public PxToolBar(string locator) {
                    SetFilter = new ToolBarButtonGrid("css=div[data-cmd=\'FilterSet\']", "Cancel Filter", locator, null);
                    AllRecords = new ToolBarButtonGrid("css=div[data-cmd=\'all\']", "All Records", locator, null);
                    Edit = new ToolBarButtonGrid("css=div[data-cmd=\'edit\']", "Edit", locator, null);
                    Hi = new ToolBarButtonGrid("css=div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                }
            }
            
            public class c_grid_row : GridRow {
                
			public FileColumnButton Files { get; set; }
			public NoteColumnButton Notes { get; set; }
			public CheckBox Selected { get; set; }
			public PXTextEdit AUScheduleHistory__ScheduleID { get; set; }
			public DateSelector AUScheduleHistory__ExecutionDate { get; set; }
			public PXTextEdit AUScheduleHistory__ExecutionResult { get; set; }
			public PXNumberEdit AUScheduleHistory__Ticks { get; set; }
			public PXTextEdit AUScheduleHistory__ScheduleID_Description { get; set; }
			public DropDown Module { get; set; }
			public Selector BatchNbr { get; set; }
			public Selector LedgerID { get; set; }
			public DateSelector DateEntered { get; set; }
			public PXTextEdit LastModifiedByID_Modifier_Username { get; set; }
			public Selector FinPeriodID { get; set; }
			public PXNumberEdit ControlTotal { get; set; }
			public PXTextEdit Description { get; set; }
                
                public c_grid_row(c_batchlist_grid grid) : 
                        base(grid) {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Selected = new CheckBox("ctl00_phL_grid_ef", "Selected", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    AUScheduleHistory__ScheduleID = new PXTextEdit("ctl00_phL_grid_ei", "Schedule ID", grid.Locator, "AUScheduleHistory__ScheduleID");
                    AUScheduleHistory__ScheduleID.DataField = "AUScheduleHistory__ScheduleID";
                    AUScheduleHistory__ExecutionDate = new DateSelector("_ctl00_phL_grid_lv0_ed4", "Execution Date", grid.Locator, "AUScheduleHistory__ExecutionDate");
                    AUScheduleHistory__ExecutionDate.DataField = "AUScheduleHistory__ExecutionDate";
                    AUScheduleHistory__ExecutionResult = new PXTextEdit("ctl00_phL_grid_ei", "Execution Result", grid.Locator, "AUScheduleHistory__ExecutionResult");
                    AUScheduleHistory__ExecutionResult.DataField = "AUScheduleHistory__ExecutionResult";
                    AUScheduleHistory__Ticks = new PXNumberEdit("ctl00_phL_grid_en", "Ticks", grid.Locator, "AUScheduleHistory__Ticks");
                    AUScheduleHistory__Ticks.DataField = "AUScheduleHistory__Ticks";
                    AUScheduleHistory__ScheduleID_Description = new PXTextEdit("ctl00_phL_grid_ei", "Description", grid.Locator, "AUScheduleHistory__ScheduleID_Description");
                    AUScheduleHistory__ScheduleID_Description.DataField = "AUScheduleHistory__ScheduleID_Description";
                    Module = new DropDown("_ctl00_phL_grid_lv0_ec", "Module", grid.Locator, "Module");
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
                    BatchNbr = new Selector("_ctl00_phL_grid_lv0_es", "Batch Number", grid.Locator, "BatchNbr");
                    BatchNbr.DataField = "BatchNbr";
                    LedgerID = new Selector("_ctl00_phL_grid_lv0_es", "Ledger", grid.Locator, "LedgerID");
                    LedgerID.DataField = "LedgerID";
                    DateEntered = new DateSelector("_ctl00_phL_grid_lv0_ed11", "Transaction Date", grid.Locator, "DateEntered");
                    DateEntered.DataField = "DateEntered";
                    LastModifiedByID_Modifier_Username = new PXTextEdit("ctl00_phL_grid_ei", "Last Modified By", grid.Locator, "LastModifiedByID_Modifier_Username");
                    LastModifiedByID_Modifier_Username.DataField = "LastModifiedByID_Modifier_Username";
                    FinPeriodID = new Selector("_ctl00_phL_grid_lv0_es", "Post Period", grid.Locator, "FinPeriodID");
                    FinPeriodID.DataField = "FinPeriodID";
                    ControlTotal = new PXNumberEdit("ctl00_phL_grid_en", "Control Total", grid.Locator, "ControlTotal");
                    ControlTotal.DataField = "ControlTotal";
                    Description = new PXTextEdit("ctl00_phL_grid_ei", "Description", grid.Locator, "Description");
                    Description.DataField = "Description";
                }
            }
            
            public class c_grid_header : GridHeader {
                
				public GridColumnHeader Files {get;set;}
				public GridColumnHeader Notes {get;set;}
				public CheckBoxColumnFilter Selected {get;set;}
				public PXTextEditColumnFilter AUScheduleHistory__ScheduleID {get;set;}
				public DateSelectorColumnFilter AUScheduleHistory__ExecutionDate {get;set;}
				public PXTextEditColumnFilter AUScheduleHistory__ExecutionResult {get;set;}
				public PXNumberEditColumnFilter AUScheduleHistory__Ticks {get;set;}
				public PXTextEditColumnFilter AUScheduleHistory__ScheduleID_Description {get;set;}
				public DropDownColumnFilter Module {get;set;}
				public SelectorColumnFilter BatchNbr {get;set;}
				public SelectorColumnFilter LedgerID {get;set;}
				public DateSelectorColumnFilter DateEntered {get;set;}
				public PXTextEditColumnFilter LastModifiedByID_Modifier_Username {get;set;}
				public SelectorColumnFilter FinPeriodID {get;set;}
				public PXNumberEditColumnFilter ControlTotal {get;set;}
				public PXTextEditColumnFilter Description {get;set;}
                
                public c_grid_header(c_batchlist_grid grid) : 
                        base(grid) {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    AUScheduleHistory__ScheduleID = new PXTextEditColumnFilter(grid.Row.AUScheduleHistory__ScheduleID);
                    AUScheduleHistory__ExecutionDate = new DateSelectorColumnFilter(grid.Row.AUScheduleHistory__ExecutionDate);
                    AUScheduleHistory__ExecutionResult = new PXTextEditColumnFilter(grid.Row.AUScheduleHistory__ExecutionResult);
                    AUScheduleHistory__Ticks = new PXNumberEditColumnFilter(grid.Row.AUScheduleHistory__Ticks);
                    AUScheduleHistory__ScheduleID_Description = new PXTextEditColumnFilter(grid.Row.AUScheduleHistory__ScheduleID_Description);
                    Module = new DropDownColumnFilter(grid.Row.Module);
                    BatchNbr = new SelectorColumnFilter(grid.Row.BatchNbr);
                    LedgerID = new SelectorColumnFilter(grid.Row.LedgerID);
                    DateEntered = new DateSelectorColumnFilter(grid.Row.DateEntered);
                    LastModifiedByID_Modifier_Username = new PXTextEditColumnFilter(grid.Row.LastModifiedByID_Modifier_Username);
                    FinPeriodID = new SelectorColumnFilter(grid.Row.FinPeriodID);
                    ControlTotal = new PXNumberEditColumnFilter(grid.Row.ControlTotal);
                    Description = new PXTextEditColumnFilter(grid.Row.Description);
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
        
        public class c__schedulehistoryparameters__frmschedulehistory : Container {
            
            public PxButtonCollection Buttons;
            
			public Selector ScheduleID { get; set; }
			public Label ScheduleIDLabel { get; private set; }
			public DateSelector FromDateTime { get; set; }
			public Label FromDateTimeLabel { get; private set; }
			public DateSelector ToDateTime { get; set; }
			public Label ToDateTimeLabel { get; private set; }
			public Label LblSchedule_ { get; set; }
			public Label LblFromDateTime_ { get; set; }
			public Label LblToDateTime_ { get; set; }
            
            public c__schedulehistoryparameters__frmschedulehistory(string locator, string name) : 
                    base(locator, name) {
                ScheduleID = new Selector("ctl00_phDS_ds_pnlScheduleHistory_frmScheduleHistory_edScheduleID", "Schedule ID", locator, null);
                ScheduleIDLabel = new Label(ScheduleID);
                ScheduleID.DataField = "ScheduleID";
                FromDateTime = new DateSelector("ctl00_phDS_ds_pnlScheduleHistory_frmScheduleHistory_edFromDateTime", "From Date Time", locator, null);
                FromDateTimeLabel = new Label(FromDateTime);
                FromDateTime.DataField = "FromDateTime";
                ToDateTime = new DateSelector("ctl00_phDS_ds_pnlScheduleHistory_frmScheduleHistory_edToDateTime", "To Date Time", locator, null);
                ToDateTimeLabel = new Label(ToDateTime);
                ToDateTime.DataField = "ToDateTime";
                LblSchedule_ = new Label("ctl00_phDS_ds_pnlScheduleHistory_frmScheduleHistory_lblSchedule", "Schedule ID :", locator, null);
                LblFromDateTime_ = new Label("ctl00_phDS_ds_pnlScheduleHistory_frmScheduleHistory_lblFromDateTime", "From:", locator, null);
                LblToDateTime_ = new Label("ctl00_phDS_ds_pnlScheduleHistory_frmScheduleHistory_lblToDateTime", "To:", locator, null);
                DataMemberName = "_ScheduleHistoryParameters_";
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
                    Ok = new Button("ctl00_phDS_ds_pnlScheduleHistory_btnScheduleHistoryOK", "OK", "ctl00_phDS_ds_pnlScheduleHistory_frmScheduleHistory");
                    Cancel = new Button("ctl00_phDS_ds_pnlScheduleHistory_btnScheduleHistoryCancel", "Cancel", "ctl00_phDS_ds_pnlScheduleHistory_frmScheduleHistory");
                }
            }
        }
    }
}
