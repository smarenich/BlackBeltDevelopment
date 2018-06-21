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


namespace GeneratedWrappers.Acumatica
{
    
    
    public class GL501000_BatchRelease : Wrapper
    {
        
        public PxToolBar ToolBar;
        
			public QuickSearch QuickSearch { get; }
        protected c_batchlist_lv0 BatchList_lv0 { get; } = new c_batchlist_lv0("ctl00_phL_grid_lv0", "BatchList_lv0");
        protected c_batchlist_grid BatchList_grid { get; } = new c_batchlist_grid("ctl00_phL_grid", "BatchList_grid");
        protected c_parameters_gridwizard Parameters_gridWizard { get; } = new c_parameters_gridwizard("ctl00_usrCaption_shareColumnsDlg_gridWizard", "Parameters_gridWizard");
        protected c_firstselect_formactions FirstSelect_FormActions { get; } = new c_firstselect_formactions("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions", "FirstSelect_FormActions");
        protected c_vieweleminfo_formeleminfo ViewElemInfo_FormElemInfo { get; } = new c_vieweleminfo_formeleminfo("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", "ViewElemInfo_FormElemInfo");
        protected c_filterworkingproject_formnewproject FilterWorkingProject_FormNewProject { get; } = new c_filterworkingproject_formnewproject("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", "FilterWorkingProject_FormNewProject");
        protected c_filterworkingproject_formselectproject FilterWorkingProject_FormSelectProject { get; } = new c_filterworkingproject_formselectproject("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", "FilterWorkingProject_FormSelectProject");
        protected c_gridlist_gridgrid GridList_gridGrid { get; } = new c_gridlist_gridgrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid", "GridList_gridGrid");
        protected c_userlist_usergrid UserList_userGrid { get; } = new c_userlist_usergrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "UserList_userGrid");
        protected c_userlist_lv0 UserList_lv0 { get; } = new c_userlist_lv0("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0", "UserList_lv0");
        protected c__schedulehistoryparameters__frmschedulehistory _ScheduleHistoryParameters__frmScheduleHistory { get; } = new c__schedulehistoryparameters__frmschedulehistory("ctl00_phDS_ds_pnlScheduleHistory_frmScheduleHistory", "_ScheduleHistoryParameters__frmScheduleHistory");
        
        public GL501000_BatchRelease()
        {
            ScreenId = "GL501000";
            ScreenUrl = "/Pages/GL/GL501000.aspx";
            ToolBar = new PxToolBar(null);
            QuickSearch = new QuickSearch("ctl00_phDS_ds_ToolBar_fb", "QuickSearch", null, null);
        }
        
        public virtual GL501000_BatchRelease ReadOne(Gate gate, string Module, string BatchNbr)
        {
            new BiObject<GL501000_BatchRelease>(gate).ReadOne(this, Module, BatchNbr);
            return this;
        }
        
        public virtual GL501000_BatchRelease ReadOne(string Module, string BatchNbr)
        {
            return this.ReadOne(ApiConnection.Source, Module, BatchNbr);
        }
        
        public virtual void SyncTOC()
        {
            ToolBar.SyncTOC.Click();
        }
        
        public virtual void Favorites()
        {
            ToolBar.Favorites.Click();
        }
        
        public virtual void Custom()
        {
            ToolBar.Custom.Click();
        }
        
        public virtual void ActionSelectWorkingProject()
        {
            ToolBar.ActionSelectWorkingProject.Click();
        }
        
        public virtual void InspectElementCtrlAltClick()
        {
            ToolBar.InspectElementCtrlAltClick.Click();
        }
        
        public virtual void MenuEditProj()
        {
            ToolBar.MenuEditProj.Click();
        }
        
        public virtual void ManageCustomizations()
        {
            ToolBar.ManageCustomizations.Click();
        }
        
        public virtual void ActionNavigateAspx()
        {
            ToolBar.ActionNavigateAspx.Click();
        }
        
        public virtual void ActionCreateNewProject()
        {
            ToolBar.ActionCreateNewProject.Click();
        }
        
        public virtual void MenuLayoutEditor()
        {
            ToolBar.MenuLayoutEditor.Click();
        }
        
        public virtual void MenuEditProj1()
        {
            ToolBar.MenuEditProj1.Click();
        }
        
        public virtual void MenuDacEditor()
        {
            ToolBar.MenuDacEditor.Click();
        }
        
        public virtual void MenuGraphEditor()
        {
            ToolBar.MenuGraphEditor.Click();
        }
        
        public virtual void MenuLayoutSrc()
        {
            ToolBar.MenuLayoutSrc.Click();
        }
        
        public virtual void MenuGraphSrc()
        {
            ToolBar.MenuGraphSrc.Click();
        }
        
        public virtual void MenuDacSrc()
        {
            ToolBar.MenuDacSrc.Click();
        }
        
        public virtual void MenuLayoutVS()
        {
            ToolBar.MenuLayoutVS.Click();
        }
        
        public virtual void MenuDacVS()
        {
            ToolBar.MenuDacVS.Click();
        }
        
        public virtual void MenuGraphVS()
        {
            ToolBar.MenuGraphVS.Click();
        }
        
        public virtual void ActionSelectWorkingProject1()
        {
            ToolBar.ActionSelectWorkingProject1.Click();
        }
        
        public virtual void LongRun()
        {
            ToolBar.LongRun.Click();
        }
        
        public virtual void ElapsedTime()
        {
            ToolBar.ElapsedTime.Click();
        }
        
        public virtual void KeyBtnRefresh()
        {
            ToolBar.KeyBtnRefresh.Click();
        }
        
        public virtual void Help()
        {
            ToolBar.Help.Click();
        }
        
        public virtual void Refresh()
        {
            ToolBar.Refresh.Click();
        }
        
        public virtual void Cancel()
        {
            ToolBar.Cancel.Click();
        }
        
        public virtual void BatchlistBatchnbrViewdetails()
        {
            ToolBar.BatchlistBatchnbrViewdetails.Click();
        }
        
        public virtual void Process()
        {
            ToolBar.Process.Click();
        }
        
        public virtual void Process(bool status, string message = null)
        {
            ToolBar.Process.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.Process.Click();
        }
        
        public virtual void ProcessAll()
        {
            ToolBar.ProcessAll.Click();
        }
        
        public virtual void ProcessAll(bool status, string message = null)
        {
            ToolBar.ProcessAll.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.ProcessAll.Click();
        }
        
        public virtual void ScheduleAddHidden()
        {
            ToolBar.ScheduleAddHidden.Click();
        }
        
        public virtual void ScheduleViewHidden()
        {
            ToolBar.ScheduleViewHidden.Click();
        }
        
        public virtual void ScheduleHistory()
        {
            ToolBar.ScheduleHistory.Click();
        }
        
        public virtual void ScheduleHistoryDeleteHidden()
        {
            ToolBar.ScheduleHistoryDeleteHidden.Click();
        }
        
        public virtual void ScheduleHistoryDeleteAllHidden()
        {
            ToolBar.ScheduleHistoryDeleteAllHidden.Click();
        }
        
        public virtual void Schedules()
        {
            ToolBar.Schedules.Click();
        }
        
        public virtual void History()
        {
            ToolBar.History.Click();
        }
        
        public virtual void ScheduleHistoryDelete()
        {
            ToolBar.ScheduleHistoryDelete.Click();
        }
        
        public virtual void ScheduleHistoryDeleteAll()
        {
            ToolBar.ScheduleHistoryDeleteAll.Click();
        }
        
        public virtual void ScheduleAdd()
        {
            ToolBar.ScheduleAdd.Click();
        }
        
        public virtual void ScheduleView()
        {
            ToolBar.ScheduleView.Click();
        }
        
        public virtual void Adjust()
        {
            ToolBar.Adjust.Click();
        }
        
        public virtual void Export()
        {
            ToolBar.Export.Click();
        }
        
        public virtual void Filter()
        {
            ToolBar.Filter.Click();
        }
        
        public class PxToolBar : PxControlCollection
        {
            
			public ToolBarButton SyncTOC { get; }
			public ToolBarButton Favorites { get; }
			public ToolBarButton Custom { get; }
			public ToolBarButton ActionSelectWorkingProject { get; }
			public ToolBarButton InspectElementCtrlAltClick { get; }
			public ToolBarButton MenuEditProj { get; }
			public ToolBarButton ManageCustomizations { get; }
			public ToolBarButton ActionNavigateAspx { get; }
			public ToolBarButton ActionCreateNewProject { get; }
			public ToolBarButton MenuLayoutEditor { get; }
			public ToolBarButton MenuEditProj1 { get; }
			public ToolBarButton MenuDacEditor { get; }
			public ToolBarButton MenuGraphEditor { get; }
			public ToolBarButton MenuLayoutSrc { get; }
			public ToolBarButton MenuGraphSrc { get; }
			public ToolBarButton MenuDacSrc { get; }
			public ToolBarButton MenuLayoutVS { get; }
			public ToolBarButton MenuDacVS { get; }
			public ToolBarButton MenuGraphVS { get; }
			public ToolBarButton ActionSelectWorkingProject1 { get; }
			public ToolBarButton LongRun { get; }
			public ToolBarButton ElapsedTime { get; }
			public ToolBarButton KeyBtnRefresh { get; }
			public ToolBarButton Help { get; }
			public ToolBarButton Refresh { get; }
			public ToolBarButton Cancel { get; }
			public ToolBarButton BatchlistBatchnbrViewdetails { get; }
			public ToolBarButton Process { get; }
			public ToolBarButton ProcessAll { get; }
			public ToolBarButton ScheduleAddHidden { get; }
			public ToolBarButton ScheduleViewHidden { get; }
			public ToolBarButton ScheduleHistory { get; }
			public ToolBarButton ScheduleHistoryDeleteHidden { get; }
			public ToolBarButton ScheduleHistoryDeleteAllHidden { get; }
			public ToolBarButton Schedules { get; }
			public ToolBarButton History { get; }
			public ToolBarButton ScheduleHistoryDelete { get; }
			public ToolBarButton ScheduleHistoryDeleteAll { get; }
			public ToolBarButton ScheduleAdd { get; }
			public ToolBarButton ScheduleView { get; }
			public ToolBarButton Adjust { get; }
			public ToolBarButton Export { get; }
			public ToolBarButton Filter { get; }
            
            public PxToolBar(string locator)
            {
                SyncTOC = new ToolBarButton("css=div[data-cmd=\'syncTOC\']", "Sync Navigation Pane", locator, null);
                Favorites = new ToolBarButton("css=div[data-cmd=\'favorites\']", "Add to Favorites", locator, null);
                Custom = new ToolBarButton("css=div[data-cmd=\'Custom\']", "Customization", locator, null);
                ActionSelectWorkingProject = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li[data-cmd=\'" +
                        "ActionSelectWorkingProject\']", "Select Project...", locator, Custom);
                InspectElementCtrlAltClick = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li.menuItem d" +
                        "iv:textEqual(\"Inspect Element (Ctrl+Alt+Click)\")", "Inspect Element (Ctrl+Alt+Click)", locator, Custom);
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
                History = new ToolBarButton("css=div#ctl00_phDS_ds_ToolBar_menu10 li.menuItem div:textEqual(\"History\")", "History", locator, Schedules);
                ScheduleHistoryDelete = new ToolBarButton("css=li[data-cmd=\'Schedule@_ScheduleHistoryDelete_\']", "Delete", locator, Schedules);
                ScheduleHistoryDeleteAll = new ToolBarButton("css=li[data-cmd=\'Schedule@_ScheduleHistoryDeleteAll_\']", "Delete All", locator, Schedules);
                ScheduleAdd = new ToolBarButton("css=li[data-cmd=\'Schedule@_ScheduleAdd_\']", "Add", locator, Schedules);
                ScheduleView = new ToolBarButton("css=li[data-cmd=\'Schedule@_ScheduleView_\']", "View", locator, Schedules);
                Adjust = new ToolBarButton("css=div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                Export = new ToolBarButton("css=div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                Filter = new ToolBarButton("css=div[data-cmd=\'FilterShow\']", "Filter Settings", locator, null);
            }
        }
        
        public class c_batchlist_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
			public DropDown Ec { get; }
            
            public c_batchlist_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phL_grid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phL_grid_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                Ec = new DropDown("ctl00_phL_grid_lv0_ec", "Ec", locator, null);
                DataMemberName = "BatchList";
            }
        }
        
        public class c_batchlist_grid : Grid<c_batchlist_grid.c_grid_row, c_batchlist_grid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_batchlist_grid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phL_grid");
                DataMemberName = "BatchList";
                FilterForm = new c_grid_filter("ctl00_phL_grid_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void SetFilter()
            {
                ToolBar.SetFilter.Click();
            }
            
            public virtual void AllRecords()
            {
                ToolBar.AllRecords.Click();
            }
            
            public virtual void Edit()
            {
                ToolBar.Edit.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid SetFilter { get; }
			public ToolBarButtonGrid AllRecords { get; }
			public ToolBarButtonGrid Edit { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
                
                public PxToolBar(string locator)
                {
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
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public CheckBox Selected { get; }
			public PXTextEdit AUScheduleHistory__ScheduleID { get; }
			public DateSelector AUScheduleHistory__ExecutionDate { get; }
			public PXTextEdit AUScheduleHistory__ExecutionResult { get; }
			public PXNumberEdit AUScheduleHistory__Ticks { get; }
			public PXTextEdit AUScheduleHistory__ScheduleID_Description { get; }
			public DropDown Module { get; }
			public Selector BatchNbr { get; }
			public Selector LedgerID { get; }
			public DateSelector DateEntered { get; }
			public PXTextEdit LastModifiedByID_Modifier_Username { get; }
			public Selector FinPeriodID { get; }
			public PXNumberEdit ControlTotal { get; }
			public PXTextEdit Description { get; }
                
                public c_grid_row(c_batchlist_grid grid) : 
                        base(grid)
                {
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
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public CheckBoxColumnFilter Selected { get; }
				public PXTextEditColumnFilter AUScheduleHistory__ScheduleID { get; }
				public DateSelectorColumnFilter AUScheduleHistory__ExecutionDate { get; }
				public PXTextEditColumnFilter AUScheduleHistory__ExecutionResult { get; }
				public PXNumberEditColumnFilter AUScheduleHistory__Ticks { get; }
				public PXTextEditColumnFilter AUScheduleHistory__ScheduleID_Description { get; }
				public DropDownColumnFilter Module { get; }
				public SelectorColumnFilter BatchNbr { get; }
				public SelectorColumnFilter LedgerID { get; }
				public DateSelectorColumnFilter DateEntered { get; }
				public PXTextEditColumnFilter LastModifiedByID_Modifier_Username { get; }
				public SelectorColumnFilter FinPeriodID { get; }
				public PXNumberEditColumnFilter ControlTotal { get; }
				public PXTextEditColumnFilter Description { get; }
                
                public c_grid_header(c_batchlist_grid grid) : 
                        base(grid)
                {
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
        
        public class c_parameters_gridwizard : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox IsDefault { get; }
			public Label IsDefaultLabel { get; }
			public CheckBox Override { get; }
			public Label OverrideLabel { get; }
			public Selector RoleName { get; }
			public Label RoleNameLabel { get; }
            
            public c_parameters_gridwizard(string locator, string name) : 
                    base(locator, name)
            {
                IsDefault = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_defaultCkbx", "Is Default", locator, null);
                IsDefaultLabel = new Label(IsDefault);
                IsDefault.DataField = "IsDefault";
                Override = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_overrideCkbx", "Override", locator, null);
                OverrideLabel = new Label(Override);
                Override.DataField = "Override";
                RoleName = new Selector("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_edRole", "Role Name", locator, null);
                RoleNameLabel = new Label(RoleName);
                RoleName.DataField = "RoleName";
                DataMemberName = "Parameters";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.ClickAndWait();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.ClickAndWait();
            }
            
            public virtual void Next()
            {
                Buttons.Next.ClickAndWait();
            }
            
            public virtual void Finish()
            {
                Buttons.Finish.ClickAndWait();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Cancel { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Finish { get; }
                
                public PxButtonCollection()
                {
                    Cancel = new Button("ctl00_usrCaption_shareColumnsDlg_gridWizard_cancel", "Cancel", "ctl00_usrCaption_shareColumnsDlg_gridWizard");
                    Prev = new Button("ctl00_usrCaption_shareColumnsDlg_gridWizard_prev", "Prev", "ctl00_usrCaption_shareColumnsDlg_gridWizard");
                    Next = new Button("ctl00_usrCaption_shareColumnsDlg_gridWizard_next", "Next", "ctl00_usrCaption_shareColumnsDlg_gridWizard");
                    Finish = new Button("ctl00_usrCaption_shareColumnsDlg_gridWizard_save", "Finish", "ctl00_usrCaption_shareColumnsDlg_gridWizard");
                }
            }
        }
        
        public class c_firstselect_formactions : Container
        {
            
			public PXTextEdit Key { get; }
			public Label KeyLabel { get; }
            
            public c_firstselect_formactions(string locator, string name) : 
                    base(locator, name)
            {
                Key = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions_edKey", "Key", locator, null);
                KeyLabel = new Label(Key);
                Key.DataField = "Key";
                DataMemberName = "FirstSelect";
            }
        }
        
        public class c_vieweleminfo_formeleminfo : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit AspxControl { get; }
			public Label AspxControlLabel { get; }
			public PXTextEdit CacheType { get; }
			public Label CacheTypeLabel { get; }
			public PXTextEdit FieldName { get; }
			public Label FieldNameLabel { get; }
			public PXTextEdit ViewName { get; }
			public Label ViewNameLabel { get; }
			public PXTextEdit GraphName { get; }
			public Label GraphNameLabel { get; }
			public PXTextEdit ActionName { get; }
			public Label ActionNameLabel { get; }
            
            public c_vieweleminfo_formeleminfo(string locator, string name) : 
                    base(locator, name)
            {
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
                ActionName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_ActionName", "Action Name", locator, null);
                ActionNameLabel = new Label(ActionName);
                ActionName.DataField = "ActionName";
                DataMemberName = "ViewElemInfo";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Customize()
            {
                Buttons.Customize.ClickAndWait();
            }
            
            public virtual void Actions()
            {
                Buttons.Actions.ClickAndWait();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.ClickAndWait();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Customize { get; }
			public Button Actions { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Customize = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_PXButton3", "Customize", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
                    Actions = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_ButtonGraphActions", "Actions", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
                    Cancel = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_PXButton4", "Cancel", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
                }
            }
        }
        
        public class c_filterworkingproject_formnewproject : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit NewProject { get; }
			public Label NewProjectLabel { get; }
            
            public c_filterworkingproject_formnewproject(string locator, string name) : 
                    base(locator, name)
            {
                NewProject = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject_edNewProject", "Project Name", locator, null);
                NewProjectLabel = new Label(NewProject);
                NewProject.DataField = "NewProject";
                DataMemberName = "FilterWorkingProject";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.ClickAndWait();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.ClickAndWait();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_DlgNewProjectButtonOk", "OK", "ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject");
                    Cancel = new Button("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_DlgNewProjectButtonCancel", "Cancel", "ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject");
                }
            }
        }
        
        public class c_filterworkingproject_formselectproject : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Name { get; }
			public Label NameLabel { get; }
            
            public c_filterworkingproject_formselectproject(string locator, string name) : 
                    base(locator, name)
            {
                Name = new Selector("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject_edWP", "Project Name", locator, null);
                NameLabel = new Label(Name);
                Name.DataField = "Name";
                DataMemberName = "FilterWorkingProject";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.ClickAndWait();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.ClickAndWait();
            }
            
            public virtual void New()
            {
                Buttons.New.ClickAndWait();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
			public Button New { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_SelectProjectOk", "OK", "ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject");
                    Cancel = new Button("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_SelectProjectCancel", "Cancel", "ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject");
                    New = new Button("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_BtnNewProject", "New...", "ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject");
                }
            }
        }
        
        public class c_gridlist_gridgrid : Grid<c_gridlist_gridgrid.c_grid_row, c_gridlist_gridgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_gridlist_gridgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid");
                DataMemberName = "GridList";
                FilterForm = new c_grid_filter("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_fe_gf", "FilterForm");
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
                
                public PxToolBar(string locator)
                {
                    PageFirst = new ToolBarButtonGrid("css=div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public PXTextEdit View { get; }
			public PXTextEdit Id { get; }
                
                public c_grid_row(c_gridlist_gridgrid grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ef", "Included", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    View = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ei", "Table ID", grid.Locator, "View");
                    View.DataField = "View";
                    Id = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ei", "Grid ID", grid.Locator, "Id");
                    Id.DataField = "Id";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public PXTextEditColumnFilter View { get; }
				public PXTextEditColumnFilter Id { get; }
                
                public c_grid_header(c_gridlist_gridgrid grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    View = new PXTextEditColumnFilter(grid.Row.View);
                    Id = new PXTextEditColumnFilter(grid.Row.Id);
                }
            }
        }
        
        public class c_userlist_usergrid : Grid<c_userlist_usergrid.c_grid_row, c_userlist_usergrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_userlist_usergrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid");
                DataMemberName = "UserList";
                FilterForm = new c_grid_filter("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void FilterBar()
            {
                ToolBar.FilterBar.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid FilterBar { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=div[data-cmd=\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    Adjust = new ToolBarButtonGrid("css=div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    FilterBar = new ToolBarButtonGrid("css=div[data-cmd=\'FilterBar\']", "FilterBar", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Included { get; }
			public Selector Username { get; }
			public PXTextEdit DisplayName { get; }
			public PXTextEdit Email { get; }
			public PXTextEdit Guest { get; }
			public DropDown State { get; }
                
                public c_grid_row(c_userlist_usergrid grid) : 
                        base(grid)
                {
                    Included = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ef", "Included", grid.Locator, "Included");
                    Included.DataField = "Included";
                    Username = new Selector("_ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0_es", "Login", grid.Locator, "Username");
                    Username.DataField = "Username";
                    DisplayName = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ei", "Display Name", grid.Locator, "DisplayName");
                    DisplayName.DataField = "DisplayName";
                    Email = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ei", "Email", grid.Locator, "Email");
                    Email.DataField = "Email";
                    Guest = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ef", "Guest Account", grid.Locator, "Guest");
                    Guest.DataField = "Guest";
                    State = new DropDown("_ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0_ec", "Status", grid.Locator, "State");
                    State.DataField = "State";
                    State.Items.Add("N", "Not Created");
                    State.Items.Add("O", "Online");
                    State.Items.Add("P", "Pending Activation");
                    State.Items.Add("D", "Disabled");
                    State.Items.Add("A", "Active");
                    State.Items.Add("L", "Temporarily Locked");
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Included { get; }
				public SelectorColumnFilter Username { get; }
				public PXTextEditColumnFilter DisplayName { get; }
				public PXTextEditColumnFilter Email { get; }
				public PXTextEditColumnFilter Guest { get; }
				public DropDownColumnFilter State { get; }
                
                public c_grid_header(c_userlist_usergrid grid) : 
                        base(grid)
                {
                    Included = new CheckBoxColumnFilter(grid.Row.Included);
                    Username = new SelectorColumnFilter(grid.Row.Username);
                    DisplayName = new PXTextEditColumnFilter(grid.Row.DisplayName);
                    Email = new PXTextEditColumnFilter(grid.Row.Email);
                    Guest = new PXTextEditColumnFilter(grid.Row.Guest);
                    State = new DropDownColumnFilter(grid.Row.State);
                }
            }
        }
        
        public class c_userlist_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_userlist_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0_ec", "Ec", locator, null);
                DataMemberName = "UserList";
            }
        }
        
        public class c__schedulehistoryparameters__frmschedulehistory : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector ScheduleID { get; }
			public Label ScheduleIDLabel { get; }
			public DateSelector FromDateTime { get; }
			public Label FromDateTimeLabel { get; }
			public DateSelector ToDateTime { get; }
			public Label ToDateTimeLabel { get; }
			public Label LblSchedule_ { get; }
			public Label LblFromDateTime_ { get; }
			public Label LblToDateTime_ { get; }
            
            public c__schedulehistoryparameters__frmschedulehistory(string locator, string name) : 
                    base(locator, name)
            {
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
            
            public virtual void Ok()
            {
                Buttons.Ok.ClickAndWait();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.ClickAndWait();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phDS_ds_pnlScheduleHistory_btnScheduleHistoryOK", "OK", "ctl00_phDS_ds_pnlScheduleHistory_frmScheduleHistory");
                    Cancel = new Button("ctl00_phDS_ds_pnlScheduleHistory_btnScheduleHistoryCancel", "Cancel", "ctl00_phDS_ds_pnlScheduleHistory_frmScheduleHistory");
                }
            }
        }
    }
}
