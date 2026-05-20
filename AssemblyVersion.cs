#if DXCommon
#pragma warning disable CA1050
public static class AssemblyInfo {
#pragma warning restore CA1050
#else
namespace DevExpress.Internal {
    internal static class AssemblyInfo {
#endif
    public const string AssemblyCopyright = "Copyright © 2000-2026 Developer Express Inc."; // don't touch!!!!!
    public const string AssemblyCompany = "Developer Express Inc.";

    public const int VersionId = 261;
    public const int VersionIdMinor = 26101;
    public const string VersionShort = "26.1";
    public const string Version = VersionShort + ".0.0";

    public const string FileVersion = Version;
    public const string MarketingVersion = "v2026 vol 1";
    public const string VirtDirSuffix = "_v26_1";

    public const string PublicKeyToken = "79868b8147b5eae4";
    public const string PublicKey = "0024000004800000940000000602000000240000525341310004000001000100dd3415ad127e2479d518586804419e99231acd687f889e897fb021bec3d90d53781811bb9d569e032d00362413298930c553dfd43a24e699c6a3d4922824f3c987fc01524b94059de1ccfbef1ff6aedc86055d56c4c3c92c550c84a1410b0c0e891e8f2f0fa193e1532f25727ae634055808129b901bdc24cb517e95fb8815b5";

    public const string FullAssemblyVersionExtension = ", Version=" + Version + ", Culture=neutral, PublicKeyToken=" + PublicKeyToken;

    public const string TestsSuffix = ".Tests";
    public const string DesignSuffix = ".Design";
    public const string
        DesignToolsSuffix = ".DesignTools",
        DesignToolsVersion = ".v16.10",
        DesignToolsWithVersionSuffix = DesignToolsSuffix + DesignToolsVersion;

    public const string SatelliteContractVersion = VersionShort + ".0.0";
    public const string VSuffixWithoutSeparator = "v" + VersionShort;
    public const string VSuffix = "." + VSuffixWithoutSeparator;
    public const string VSuffixDesign = VSuffix + ".Design";
    public const string VSuffixExport = VSuffix + ".Export";
    public const string VSuffixLinq = VSuffix + ".Linq";
#if !DXShortInfo
    public const string SRAssemblyAgScheduler = "DevExpress.Xpf.Scheduler" + VSuffix;
    public const string SRAssemblyXpfSpellChecker = "DevExpress.Xpf.SpellChecker" + VSuffix;
    public const string SRAssemblyXpfOffice = "DevExpress.Xpf.Office" + VSuffix;
    public const string SRAssemblyXpfRichEdit = "DevExpress.Xpf.RichEdit" + VSuffix;
    public const string SRAssemblyXpfRichEditFull = SRAssemblyXpfRichEdit + FullAssemblyVersionExtension;
    public const string SRAssemblyXpfSpreadsheet = "DevExpress.Xpf.Spreadsheet" + VSuffix;
    public const string SRAssemblyXpfSpreadsheetFull = SRAssemblyXpfSpreadsheet + FullAssemblyVersionExtension;
    public const string SRAssemblyXpfScheduler = "DevExpress.Xpf.Scheduler" + VSuffix;
    public const string SRAssemblyXpfScheduling = "DevExpress.Xpf.Scheduling" + VSuffix;
    public const string SRAssemblyXpfSchedulingFull = SRAssemblyXpfScheduling + FullAssemblyVersionExtension;
    public const string SRAssemblyXpfSchedulingReportDesigner = "DevExpress.Xpf.Scheduling.ReportDesigner" + VSuffix;
    public const string SRAssemblyXpfSchedulingDesign = "DevExpress.Xpf.Scheduling" + VSuffixDesign;
    public const string SRAssemblyXpfRichEditExtensions = "DevExpress.Xpf.RichEdit" + VSuffix + ".Extensions";
    public const string SRAssemblyXpfPrinting = "DevExpress.Xpf.Printing" + VSuffix;
    public const string SRAssemblyXpfPrintingFull = SRAssemblyXpfPrinting + FullAssemblyVersionExtension;
    public const string SRAssemblyXpfDataAccess = "DevExpress.Xpf.DataAccess" + VSuffix;
    public const string SRAssemblyXpfExpressionEditor = "DevExpress.Xpf.ExpressionEditor" + VSuffix;
    public const string SRAssemblyXpfExpressionEditorFull = SRAssemblyXpfExpressionEditor + FullAssemblyVersionExtension;
    public const string SRAssemblyXpfReportDesigner = "DevExpress.Xpf.ReportDesigner" + VSuffix;
    public const string SRAssemblyXpfReportDesignerFull = SRAssemblyXpfReportDesigner + FullAssemblyVersionExtension;
    public const string SRAssemblyXpfCore = "DevExpress.Xpf.Core" + VSuffix;
    public const string SRAssemblyXpfCoreFull = SRAssemblyXpfCore + FullAssemblyVersionExtension;
    public const string SRAssemblyXpfPdfViewer = "DevExpress.Xpf.PdfViewer" + VSuffix;
    public const string SRAssemblyXpfPdfViewerFull = SRAssemblyXpfPdfViewer + FullAssemblyVersionExtension;
    public const string SRAssemblyXpfDocumentViewerCore = "DevExpress.Xpf.DocumentViewer" + VSuffix + ".Core";
    public const string SRAssemblyXpfMvvm = "DevExpress.Mvvm" + VSuffix;
    public const string SRAssemblyXpfMvvmFree = "DevExpress.Mvvm";
    public const string SRAssemblyXpfMvvmUIFree = "DevExpress.Mvvm.UI";
    public const string SRAssemblyXpfRibbon = "DevExpress.Xpf.Ribbon" + VSuffix;
    public const string SRAssemblyXpfRibbonFull = SRAssemblyXpfRibbon + FullAssemblyVersionExtension;
    public const string SRAssemblyXpfNavBar = "DevExpress.Xpf.NavBar" + VSuffix;
    public const string SRAssemblyXpfCoreExtensions = SRAssemblyXpfCore + ".Extensions";
    public const string SRAssemblyXpfDemoBase = "DevExpress.Xpf.DemoBase" + VSuffix;
    public const string SRAssemblyXpfGrid = "DevExpress.Xpf.Grid" + VSuffix;
    public const string SRAssemblyXpfGridFull = SRAssemblyXpfGrid + FullAssemblyVersionExtension;
    public const string SRAssemblyXpfGridCore = SRAssemblyXpfGrid + ".Core";
    public const string SRAssemblyXpfGridExtensions = SRAssemblyXpfGrid + ".Extensions";

    public const string SRAssemblyXpfPivotGrid = "DevExpress.Xpf.PivotGrid" + VSuffix;
    public const string SRAssemblyXpfPivotGridFull = SRAssemblyXpfPivotGrid + FullAssemblyVersionExtension;
    public const string SRAssemblyXpfPivotGridTests = SRAssemblyXpfPivotGrid + TestsSuffix;

    public const string SRAssemblyXpfPropertyGrid = "DevExpress.Xpf.PropertyGrid" + VSuffix;
    public const string SRAssemblyXpfPropertyGridFull = SRAssemblyXpfPropertyGrid + FullAssemblyVersionExtension;

    public const string SRAssemblyXpfDiagram = "DevExpress.Xpf.Diagram" + VSuffix;
    public const string SRAssemblyXpfDiagramFull = SRAssemblyXpfDiagram + FullAssemblyVersionExtension;
    public const string SRAssemblyXpfDiagramTests = "DevExpress.Xpf.Diagram" + VSuffix + ".Tests";
    public const string SRAssemblyXpfGantt = "DevExpress.Xpf.Gantt" + VSuffix;
    public const string SRAssemblyXpfGanttFull = SRAssemblyXpfGantt + FullAssemblyVersionExtension;
    public const string SRAssemblyXpfGanttTests = "DevExpress.Xpf.Gantt" + VSuffix + ".Tests";
    public const string SRAssemblyXpfDialogs = "DevExpress.Xpf.Dialogs" + VSuffix;
    public const string SRAssemblyXpfDialogsFull = SRAssemblyXpfDialogs + FullAssemblyVersionExtension;
    public const string SRAssemblyXpfDialogsTests = "DevExpress.Xpf.Dialogs" + VSuffix + ".Tests";
    public const string SRAssemblyXpfAccordion = "DevExpress.Xpf.Accordion" + VSuffix;
    public const string SRAssemblyXpfAccordionFull = SRAssemblyXpfAccordion + FullAssemblyVersionExtension;
    public const string SRAssemblyXpfAccordionTests = "DevExpress.Xpf.Accordion" + VSuffix + TestsSuffix;
    public const string SRAssemblyXpfAccordionDesign = "DevExpress.Xpf.Accordion" + VSuffixDesign;
    public const string SRAssemblyXpfDocking = "DevExpress.Xpf.Docking" + VSuffix;
    public const string SRAssemblyXpfDockingFull = SRAssemblyXpfDocking + FullAssemblyVersionExtension;
    public const string SRAssemblyXpfControls = "DevExpress.Xpf.Controls" + VSuffix;
    public const string SRAssemblyXpfControlsFull = SRAssemblyXpfControls + FullAssemblyVersionExtension;
    public const string SRAssemblyXpfLayoutControl = "DevExpress.Xpf.LayoutControl" + VSuffix;
    public const string SRAssemblyXpfLayoutControlFull = SRAssemblyXpfLayoutControl + FullAssemblyVersionExtension;
    public const string SRAssemblyImages = "DevExpress.Images" + VSuffix;
    public const string SRAssemblyImagesFull = "DevExpress.Images" + VSuffix + FullAssemblyVersionExtension;
    public const string SRAssemblyMvvm = SRAssemblyXpfMvvm;
    public const string SRAssemblyMvvmFull = SRAssemblyXpfMvvm + FullAssemblyVersionExtension;
    public const string SRAssemblyXpfDockingExtensions = "DevExpress.Xpf.Docking" + VSuffix + ".Extensions";
    public const string SRAssemblyXpfLayoutCore = "DevExpress.Xpf.Layout" + VSuffix + ".Core";
    public const string SRAssemblyDXCharts = "DevExpress.Xpf.Charts" + VSuffix;
    public const string SRAssemblyDXChartsFull = SRAssemblyDXCharts + FullAssemblyVersionExtension;
    public const string SRAssemblyChartDesigner = "DevExpress.Charts.Designer" + VSuffix;
    public const string SRAssemblyChartDesignerFull = "DevExpress.Charts.Designer" + VSuffix + FullAssemblyVersionExtension;

    public const string SRAssemblyDXGauges = "DevExpress.Xpf.Gauges" + VSuffix;
    public const string SRAssemblyDXGaugesFull = SRAssemblyDXGauges + FullAssemblyVersionExtension;
    public const string SRAssemblyDXMap = "DevExpress.Xpf.Map" + VSuffix;
    public const string SRAssemblyDXMapTests = "DevExpress.Xpf.Map.Tests";
    public const string SRAssemblyDXMapFull = SRAssemblyDXMap + FullAssemblyVersionExtension;
    public const string SRAssemblyDXTreeMap = "DevExpress.Xpf.TreeMap" + VSuffix;
    public const string SRAssemblyDXTreeMapFull = SRAssemblyDXTreeMap + FullAssemblyVersionExtension;

    public const string SRAssemblyData = "DevExpress.Data" + VSuffix;
    public const string SRAssemblyDataFull = SRAssemblyData + FullAssemblyVersionExtension;
    public const string SRAssemblyDataTests = "DevExpress.Data.Tests";
    public const string SRAssemblyDataDesktop = "DevExpress.Data.Desktop" + VSuffix;
    public const string SRAssemblyDataDesktopFull = "DevExpress.Data.Desktop" + VSuffix + FullAssemblyVersionExtension;
    public const string SRAssemblyDataDesktopTests = "DevExpress.Data.Desktop.Tests";
    public const string SRAssemblyDemoData = "DevExpress.DemoData" + VSuffix;
    public const string SRAssemblyPrintingCore = "DevExpress.Printing" + VSuffix + ".Core";
    public const string SRAssemblyPrintingCoreFull = "DevExpress.Printing" + VSuffix + ".Core" + FullAssemblyVersionExtension;
    public const string SRAssemblyRichEditCore = "DevExpress.RichEdit" + VSuffix + ".Core";
    public const string SRAssemblyRichEditCoreFull = SRAssemblyRichEditCore + FullAssemblyVersionExtension;
    public const string SRAssemblyRichEditCoreTests = SRAssemblyRichEditCore + TestsSuffix;
    public const string SRAssemblyOfficeCore = "DevExpress.Office" + VSuffix + ".Core";
    public const string SRAssemblyOfficeCoreFull = SRAssemblyOfficeCore + FullAssemblyVersionExtension;
    public const string SRAssemblyDocs = "DevExpress.Docs" + VSuffix;
    public const string SRAssemblyPresentation = "DevExpress.Docs.Presentation" + VSuffix;
    public const string SRAssemblyPresentationTests = "DevExpress.Docs.Presentation" + TestsSuffix;
    public const string SRAssemblySpreadsheetCore = "DevExpress.Spreadsheet" + VSuffix + ".Core";
    public const string SRAssemblySchedulerCore = "DevExpress.XtraScheduler" + VSuffix + ".Core";
    public const string SRAssemblySchedulerCoreDesktop = "DevExpress.XtraScheduler" + VSuffix + ".Core.Desktop";
    public const string SRAssemblyPrintingDesign = "DevExpress.XtraPrinting" + VSuffixDesign;
    public const string SRAssemblyPrintingDesignFull = "DevExpress.XtraPrinting" + VSuffixDesign + FullAssemblyVersionExtension;
    public const string SRAssemblyRichEditLayoutEngine = "DevExpress.RichEdit.LayoutEngine" + VSuffix;
    public const string SRAssemblyRichEditLayoutEngineTests = SRAssemblyRichEditLayoutEngine + TestsSuffix;
	public const string SRAssemblyBarcode = "DevExpress.Docs.Barcode" + VSuffix;
    public const string SRAssemblyBarcodeTests = "DevExpress.Docs.Barcode" + TestsSuffix;
    public const string SRAssemblyDocsCore = "DevExpress.Docs.Core" + VSuffix;
    public const string SRAssemblyDocsCoreTests = "DevExpress.Docs.Core" + TestsSuffix;
    public const string SRAssemblyDocsPdf = "DevExpress.Docs.Pdf" + VSuffix;
    public const string SRAssemblyDocsPdfTests = "DevExpress.Docs.Pdf" + TestsSuffix;
    public const string SRAssemblyRDSReportDesigner = "DevExpress.ReportDesigner" + VSuffix;

    public const string SRAssemblyDevExtremeAspNetCore = "DevExtreme.AspNet.Core";
    public const string SRAssemblyDevExtremeAspNetMvc = "DevExtreme.AspNet.Mvc";
#endif

    public const string SRDocumentationLink = "https://docs.devexpress.com/?l=true/";
    public const string SRNewDocumentationLink = "http://docs.devexpress.com/";
    public const string InstallationRegistryKeyBase = "SOFTWARE\\DevExpress\\Components\\";
    public const string InstallationRegistryKey = InstallationRegistryKeyBase + VSuffixWithoutSeparator;
    public const string InstallationDevExtremeRegistryKey = "SOFTWARE\\DevExpress\\DevExtreme\\" + VSuffixWithoutSeparator;
    public const string InstallationRegistryRootPathValueName = "RootDirectory";
    public const string SRAssemblyXpfPrefix = "DevExpress.Xpf";
    public const string SRAssemblyPrefix = "DevExpress";
    public const string ThemePrefixWithoutSeparator = "Themes";
    public const string ThemePrefix = "." + ThemePrefixWithoutSeparator + ".";
    public const string SupportedOSPlatform = "windows";

#if !DXShortInfo
    #region ASPNETCORE
    public const string
        SRAssemblyAspNetCore = "DevExpress.AspNetCore.Core" + VSuffix,
        SRAssemblyAspNetCoreTests = SRAssemblyAspNetCore + ".Tests",

        SRAssemblyAspNetCoreResources = "DevExpress.Web.Resources" + VSuffix,
        SRAssemblyAspNetCoreCommon = "DevExpress.AspNetCore.Common" + VSuffix,

        SRAssemblyAspNetCoreSpreadsheet = "DevExpress.AspNetCore.Spreadsheet" + VSuffix,
        SRAssemblyAspNetCoreSpreadsheetTest = SRAssemblyAspNetCoreSpreadsheet + ".Tests",

        SRAssemblyBlazor = "DevExpress.Blazor" + VSuffix,
        SRAssemblyBlazorCommon = "DevExpress.Blazor.Common" + VSuffix,
        SRAssemblyBlazorSpreadsheet = "DevExpress.Blazor.Spreadsheet" + VSuffix,
        SRAssemblyBlazorSpreadsheetUtils = "DevExpress.Blazor.SpreadsheetUtils" + VSuffix,
        SRAssemblyBlazorPdfViewer = "DevExpress.Blazor.PdfViewer" + VSuffix,
        SRAssemblyBlazorRichEdit = "DevExpress.Blazor.RichEdit" + VSuffix,
        SRAssemblyBlazorRichEditTest = "DevExpress.Blazor.RichEdit.Tests",
        SRAssemblyBlazorRichEditSeleniumTest = "DevExpress.Blazor.RichEdit.Selenium.Tests";
    #endregion

    public const string
        SRAssemblyMVC = "DevExpress.Web.Mvc" + VSuffix,
        SRAssemblyMVC5 = "DevExpress.Web.Mvc5" + VSuffix,
        SRAssemblyMVCTests = "DevExpress.Web.Mvc" + VSuffix + ".Tests",
        SRAssemblyMVCChartsTests = "DevExpress.Web.Mvc.Charts.Tests",
        SRAssemblyBootstrap = "DevExpress.Web.Bootstrap" + VSuffix,
        SRAssemblyBootstrapDesign = "DevExpress.Web.Bootstrap" + VSuffixDesign,
        SRAssemblyBootstrapDesignFull = "DevExpress.Web.Bootstrap" + VSuffixDesign + FullAssemblyVersionExtension,
        SRAssemblyBootstrapTests = "DevExpress.Web.Bootstrap" + VSuffix + ".Tests",
        SRAssemblyExpressApp = "DevExpress.ExpressApp" + VSuffix,
        SRAssemblyExpressAppWeb = "DevExpress.ExpressApp.Web" + VSuffix,
        SRAssemblyExpressAppBlazor = "DevExpress.ExpressApp.Blazor" + VSuffix,
        SRAssemblyExpressAppNotificationsWeb = "DevExpress.ExpressApp.Notifications.Web" + VSuffix,
        SRAssemblyExpressAppMapsWeb = "DevExpress.ExpressApp.Maps.Web" + VSuffix,
        SRAssemblyExpressAppOfficeBlazor = "DevExpress.ExpressApp.Office.Blazor" + VSuffix,
        SRAssemblyExpressAppOfficeWeb = "DevExpress.ExpressApp.Office.Web" + VSuffix,
        SRAssemblyASPxThemes = "DevExpress.Web.ASPxThemes" + VSuffix,
        SRAssemblyASPxThemesFull = SRAssemblyASPxThemes + FullAssemblyVersionExtension,
        SRAssemblyASPxThemesTests = "DevExpress.Web.ASPxThemes" + VSuffix + ".Tests",
        SRAssemblyASPxResources = "DevExpress.Web.Resources" + VSuffix,
        SRAssemblyASPxGridView = "DevExpress.Web.ASPxGridView" + VSuffix,
        SRAssemblyASPxPivotGrid = "DevExpress.Web.ASPxPivotGrid" + VSuffix,
        SRAssemblyASPxPivotGridExport = "DevExpress.Web.ASPxPivotGrid" + VSuffixExport,
        SRAssemblyASPxPivotGridTests = "DevExpress.Web.ASPxPivotGrid" + VSuffix + ".Tests",
        SRAssemblyBonusSkins = "DevExpress.BonusSkins" + VSuffix,
        SRAssemblyBonusSkinsFull = "DevExpress.BonusSkins" + VSuffix + FullAssemblyVersionExtension,
        //SRAssemblyOfficeSkins = "DevExpress.OfficeSkins" + VSuffix,
        SRAssemblyDesign = "DevExpress.Design" + VSuffix,
        SRAssemblyDesignFull = "DevExpress.Design" + VSuffix + FullAssemblyVersionExtension,
        SRAssemblyDataLinq = "DevExpress.Data" + VSuffixLinq,
        SRAssemblyUtils = "DevExpress.Utils" + VSuffix,
        SRAssemblyUtilsFull = SRAssemblyUtils + FullAssemblyVersionExtension,
        SRAssemblyParser = "DevExpress.Parser" + VSuffix,
        SRAssemblyPrinting = "DevExpress.XtraPrinting" + VSuffix,
        SRAssemblyPrintingFull = SRAssemblyPrinting + FullAssemblyVersionExtension,
        SRAssemblyEditors = "DevExpress.XtraEditors" + VSuffix,
        SRAssemblyEditorsFull = SRAssemblyEditors + FullAssemblyVersionExtension,
        SRAssemblyEditorsDesign = "DevExpress.XtraEditors" + VSuffixDesign,
        SRAssemblyEditorsDesignFull = "DevExpress.XtraEditors" + VSuffixDesign + FullAssemblyVersionExtension,
        SRAssemblyDiagramCore = "DevExpress.Diagram" + VSuffix + ".Core",
        SRAssemblyDiagramCoreFull = SRAssemblyDiagramCore + FullAssemblyVersionExtension,
        SRAssemblyDiagramCoreTests = "DevExpress.Diagram" + VSuffix + ".Core.Tests",
        SRAssemblyDiagram = "DevExpress.XtraDiagram" + VSuffix,
        SRAssemblyDiagramFull = SRAssemblyDiagram + FullAssemblyVersionExtension,
        SRAssemblyDiagramTests = "DevExpress.XtraDiagram" + VSuffix + ".Tests",
        SRAssemblyDiagramDesign = "DevExpress.XtraDiagram" + VSuffixDesign,
        SRAssemblyDiagramDesignFull = "DevExpress.XtraDiagram" + VSuffixDesign + FullAssemblyVersionExtension,
        SRAssemblyGanttCore = "DevExpress.Gantt" + VSuffix + ".Core",
        SRAssemblyGanttCoreTests = "DevExpress.Gantt" + VSuffix + ".Core.Tests",
        SRAssemblyGantt = "DevExpress.XtraGantt" + VSuffix,
        SRAssemblyGanttDesign = "DevExpress.XtraGantt" + VSuffixDesign,
        SRAssemblyGanttDesignFull = "DevExpress.XtraGantt" + VSuffixDesign + FullAssemblyVersionExtension,
        SRAssemblyDialogsCore = "DevExpress.Dialogs" + VSuffix + ".Core",
        SRAssemblyDialogs = "DevExpress.XtraDialogs" + VSuffix,
        SRAssemblyDialogsDesign = "DevExpress.XtraDialogs" + VSuffixDesign,
        SRAssemblyDialogsDesignFull = "DevExpress.XtraDialogs" + VSuffixDesign + FullAssemblyVersionExtension,
        SRAssemblyDialogsCoreTests = "DevExpress.Dialogs" + VSuffix + ".Core.Tests",
        SRAssemblyDialogsTests = "DevExpress.XtraDialogs" + VSuffix + ".Tests",
        SRAssemblyNavBar = "DevExpress.XtraNavBar" + VSuffix,
        SRAssemblyNavBarFull = SRAssemblyNavBar + FullAssemblyVersionExtension,
        SRAssemblyNavBarDesign = "DevExpress.XtraNavBar" + VSuffixDesign,
        SRAssemblyBars = "DevExpress.XtraBars" + VSuffix,
        SRAssemblyBarsFull = SRAssemblyBars + FullAssemblyVersionExtension,
        SRAssemblyBarsDesign = "DevExpress.XtraBars" + VSuffixDesign,
        SRAssemblyBarsDesignFull = "DevExpress.XtraBars" + VSuffixDesign + FullAssemblyVersionExtension,
        SRAssemblyGrid = "DevExpress.XtraGrid" + VSuffix,
        SRAssemblyGridFull = SRAssemblyGrid + FullAssemblyVersionExtension,
        SRAssemblyGaugesCore = "DevExpress.XtraGauges" + VSuffix + ".Core",
        SRAssemblyGaugesCoreFull = SRAssemblyGaugesCore + FullAssemblyVersionExtension,
        SRAssemblyGaugesPresets = "DevExpress.XtraGauges" + VSuffix + ".Presets",
        SRAssemblyGaugesPresetsFull = SRAssemblyGaugesPresets + FullAssemblyVersionExtension,
        SRAssemblyGaugesWin = "DevExpress.XtraGauges" + VSuffix + ".Win",
        SRAssemblyGaugesWinFull = SRAssemblyGaugesWin + FullAssemblyVersionExtension,
        SRAssemblyASPxGauges = "DevExpress.Web.ASPxGauges" + VSuffix,
        SRAssemblyASPxGaugesTests = "DevExpress.Web.ASPxGauges" + VSuffix + ".Tests",
        SRAssemblyGaugesDesignWin = "DevExpress.XtraGauges" + VSuffixDesign + ".Win",
        SRAssemblyGaugesDesignWinFull = SRAssemblyGaugesDesignWin + FullAssemblyVersionExtension,
        SRAssemblyGridDesign = "DevExpress.XtraGrid" + VSuffixDesign,
        SRAssemblyGridDesignFull = "DevExpress.XtraGrid" + VSuffixDesign + FullAssemblyVersionExtension,
        SRAssemblyPivotGrid = "DevExpress.XtraPivotGrid" + VSuffix,
        SRAssemblyPivotGridFull = SRAssemblyPivotGrid + FullAssemblyVersionExtension,
        SRAssemblyPivotGridCore = "DevExpress.PivotGrid" + VSuffix + ".Core",
        SRAssemblyPivotGridCoreFull = SRAssemblyPivotGridCore + FullAssemblyVersionExtension,
        SRAssemblyPivotGridDesign = "DevExpress.XtraPivotGrid" + VSuffixDesign,
        SRAssemblyPivotGridDesignFull = "DevExpress.XtraPivotGrid" + VSuffixDesign + FullAssemblyVersionExtension,
        SRAssemblyTreeList = "DevExpress.XtraTreeList" + VSuffix,
        SRAssemblyTreeListFull = SRAssemblyTreeList + FullAssemblyVersionExtension,
        SRAssemblyTreeListDesign = "DevExpress.XtraTreeList" + VSuffixDesign,
        SRAssemblyTreeListDesignFull = "DevExpress.XtraTreeList" + VSuffixDesign + FullAssemblyVersionExtension,
        SRAssemblyVertGrid = "DevExpress.XtraVerticalGrid" + VSuffix,
        SRAssemblyVertGridFull = SRAssemblyVertGrid + FullAssemblyVersionExtension,
        SRAssemblyVertGridDesign = "DevExpress.XtraVerticalGrid" + VSuffixDesign,
        SRAssemblyVertGridDesignFull = "DevExpress.XtraVerticalGrid" + VSuffixDesign + FullAssemblyVersionExtension,
        SRAssemblyReports = "DevExpress.XtraReports" + VSuffix,
        SRAssemblyReportsFull = SRAssemblyReports + FullAssemblyVersionExtension,
        SRAssemblyReportsTests = "DevExpress.XtraReports.Tests",
        SRAssemblyReportsService = "DevExpress.XtraReports" + VSuffix + ".Service",
        SRAssemblyReportsDesign = "DevExpress.XtraReports" + VSuffixDesign,
        SRAssemblyReportsDesignFull = SRAssemblyReportsDesign + FullAssemblyVersionExtension,
        SRAssemblyReportsDesignVSCore = SRAssemblyReportsDesign + ".VSCore",
        SRAssemblyReportsDesignVSCoreFull = SRAssemblyReportsDesignVSCore + FullAssemblyVersionExtension,
        SRAssemblyReportsImport = "DevExpress.XtraReports" + VSuffix + ".Import",
        SRAssemblyReportsWeb = "DevExpress.XtraReports" + VSuffix + ".Web",
        SRAssemblyReportsWebForms = "DevExpress.XtraReports" + VSuffix + ".Web.WebForms",
        SRAssemblyReportsWebTests = "DevExpress.XtraReports" + VSuffix + ".Web.Tests",
        SRAssemblyReportsWebCommonServices = "DevExpress.Web.Reporting" + VSuffix + ".Common.Services",
        SRAssemblyReportsAspNetCore = "DevExpress.AspNetCore.Reporting" + VSuffix,
        SRAssemblyReportsAspire = "DevExpress.Aspire.Reporting" + VSuffix,
        SRAssemblyReportsAspireAspNetCore = "DevExpress.Aspire.AspNetCore.Reporting" + VSuffix,
        SRAssemblyReportsAspNetCoreTests = "DevExpress.AspNetCore.Reporting" + VSuffix + ".Tests",
        SRAssemblyReportsBlazor = "DevExpress.Blazor.Reporting" + VSuffix,
        SRAssemblyReportsBlazorJSBasedControls = "DevExpress.Blazor.Reporting" + VSuffix + ".JSBasedControls",
        SRAssemblyReportsBlazorJSBasedControlsCommon = "DevExpress.Blazor.Reporting" + VSuffix + ".JSBasedControls.Common",
        SRAssemblyReportsBlazorWebAssembly = "DevExpress.Blazor.Reporting" + VSuffix + ".JSBasedControls.WebAssembly",
        SRAssemblyReportsBlazorTests = "DevExpress.Blazor.Reporting" + VSuffix + ".Tests",
        SRAssemblyReportsBlazorViewer = "DevExpress.Blazor.Reporting" + VSuffix + ".Viewer",
        SRAssemblyReportsBlazorViewerTests = "DevExpress.Blazor.Reporting" + VSuffix + ".Viewer.Tests",
        SRAssemblyBlazorViewer = "DevExpress.Blazor" + VSuffix + ".Viewer",
        SRAssemblyReportsExtensions = "DevExpress.XtraReports" + VSuffix + ".Extensions",
        SRAssemblyReportsDesignTool = "DevExpress.XtraReports" + VSuffix + ".Design.Tool",
        SRAssemblyReportsExtensionsFull = SRAssemblyReportsExtensions + FullAssemblyVersionExtension,
        SRAssemblyReportsExtensionsTests = "DevExpress.XtraReports.Extensions.Tests",
        SRAssemblyReportsNReportTest = "NReportTest" + VSuffix,
        SRAssemblyReportServerDesigner = "DevExpress.ReportDesigner" + VSuffix + ".Core",
        SRAssemblyReportServerWeb = "DevExpress.ReportServer" + VSuffix + ".Web",
        SRAssemblyReportServerDataAccess = "DevExpress.ReportServer" + VSuffix + ".DataAccess",
        SRAssemblyReportsCodeCompletion = SRAssemblyReports + ".CodeCompletion",
        SRAssemblyReportsCodeCompletionFull = SRAssemblyReportsCodeCompletion + FullAssemblyVersionExtension,
        SRAssemblyReportsCodeCompletionTests = SRAssemblyReportsCodeCompletion + ".Tests",

        SRAssemblyOfficeSkiaRenderer = "DevExpress.Office" + VSuffix + ".SkiaRenderer",
        SRAssemblyOfficeSkiaRendererFull = SRAssemblyOfficeSkiaRenderer + FullAssemblyVersionExtension,
        SRAssemblyRichEdit = "DevExpress.XtraRichEdit" + VSuffix,
        SRAssemblyRichEditFull = SRAssemblyRichEdit + FullAssemblyVersionExtension,
        SRAssemblyRichEditDesign = "DevExpress.XtraRichEdit" + VSuffixDesign,
        SRAssemblyRichEditDesignFull = "DevExpress.XtraRichEdit" + VSuffixDesign + FullAssemblyVersionExtension,
        SRAssemblyRichEditExport = "DevExpress.RichEdit" + VSuffix + ".Export",
        SRAssemblyRichEditExportFull = SRAssemblyRichEditExport + FullAssemblyVersionExtension,
        SRAssemblySpreadsheet = "DevExpress.XtraSpreadsheet" + VSuffix,
        SRAssemblySpreadsheetDesign = "DevExpress.XtraSpreadsheet" + VSuffixDesign,
        SRAssemblySpreadsheetDesignFull = SRAssemblySpreadsheetDesign + FullAssemblyVersionExtension,
        SRAssemblyScheduler = "DevExpress.XtraScheduler" + VSuffix,
        SRAssemblySchedulerDesign = "DevExpress.XtraScheduler" + VSuffixDesign,
        SRAssemblySchedulerDesignFull = "DevExpress.XtraScheduler" + VSuffixDesign + FullAssemblyVersionExtension,
        SRAssemblySchedulerWeb = "DevExpress.Web.ASPxScheduler" + VSuffix,
        SRAssemblySchedulerWebDesign = "DevExpress.Web.ASPxScheduler" + VSuffixDesign,
        SRAssemblySchedulerWebDesignFull = "DevExpress.Web.ASPxScheduler" + VSuffixDesign + FullAssemblyVersionExtension,
        SRAssemblySchedulerExtensions = "DevExpress.XtraScheduler" + VSuffix + ".Extensions",
        SRAssemblySchedulerSynchronizationGoogle = "DevExpress.XtraScheduler" + VSuffix + ".GoogleCalendar",
        SRAssemblySchedulerSynchronizationGoogleFull = SRAssemblySchedulerSynchronizationGoogle + FullAssemblyVersionExtension,
        SRAssemblySchedulerSynchronizationMicrosoft365Calendar = "DevExpress.XtraScheduler" + VSuffix + ".Microsoft365Calendar",
        SRAssemblySchedulerSynchronizationMicrosoft365CalendarFull = SRAssemblySchedulerSynchronizationMicrosoft365Calendar + FullAssemblyVersionExtension,
        SRAssemblySchedulerReporting = "DevExpress.XtraScheduler" + VSuffix + ".Reporting",
        SRAssemblySchedulerCoreReporting = "DevExpress.XtraScheduler" + VSuffix + ".Core.Reporting",
        SRAssemblySchedulerReportingTests = "DevExpress.XtraScheduler.Reporting.Tests",
        SRAssemblySchedulerReportingExtensions = "DevExpress.XtraScheduler" + VSuffix + ".Reporting.Extensions",
        SRAssemblyChartsCore = "DevExpress.Charts" + VSuffix + ".Core",
        SRAssemblyChartsCoreFull = SRAssemblyChartsCore + FullAssemblyVersionExtension,
        SRAssemblySparklineCore = "DevExpress.Sparkline" + VSuffix + ".Core",
        SRAssemblySparklineCoreFull = SRAssemblySparklineCore + FullAssemblyVersionExtension,
        SRAssemblyCharts = "DevExpress.XtraCharts" + VSuffix,
        SRAssemblyChartsFull = SRAssemblyCharts + FullAssemblyVersionExtension,
        SRAssemblyChartsExtensions = "DevExpress.XtraCharts" + VSuffix + ".Extensions",
        SRAssemblyChartsExtensionsFull = SRAssemblyChartsExtensions + FullAssemblyVersionExtension,
        SRAssemblyChartsWizard = "DevExpress.XtraCharts" + VSuffix + ".Wizard" + FullAssemblyVersionExtension,
        SRAssemblyChartsWizardShort = "DevExpress.XtraCharts" + VSuffix + ".Wizard",
        SRAssemblyChartsDesign = "DevExpress.XtraCharts" + VSuffixDesign,
        SRAssemblyChartsDesignFull = SRAssemblyChartsDesign + FullAssemblyVersionExtension,
        SRAssemblyChartsWebDesign = "DevExpress.XtraCharts" + VSuffix + ".Web.Design" + FullAssemblyVersionExtension,
        SRAssemblyChartsUI = "DevExpress.XtraCharts" + VSuffix + ".UI",
        SRAssemblyChartsWeb = "DevExpress.XtraCharts" + VSuffix + ".Web",
        SRAssemblyWizard = "DevExpress.XtraWizard" + VSuffix,
        SRAssemblyWizardDesign = "DevExpress.XtraWizard" + VSuffixDesign,
        SRAssemblyWizardDesignFull = SRAssemblyWizardDesign + FullAssemblyVersionExtension,
        SRAssemblyXpo = "DevExpress.Xpo" + VSuffix,
        SRAssemblyXpoFull = SRAssemblyXpo + FullAssemblyVersionExtension,
        SRAssemblyXpoUI = "DevExpress.Xpo" + VSuffix + ".UI",
        SRAssemblyXpoUIFull = SRAssemblyXpoUI + FullAssemblyVersionExtension,
        SRAssemblyXpoDesign = "DevExpress.Xpo" + VSuffixDesign,
        SRAssemblyXpoDesignFull = SRAssemblyXpoDesign + FullAssemblyVersionExtension,
        SRAssemblyLayoutControl = "DevExpress.XtraLayout" + VSuffix,
        SRAssemblyLayoutControlFull = "DevExpress.XtraLayout" + VSuffix + FullAssemblyVersionExtension,
        SRAssemblyLayoutControlDesign = "DevExpress.XtraLayout" + VSuffixDesign,
        SRAssemblyLayoutControlDesignFull = "DevExpress.XtraLayout" + VSuffixDesign + FullAssemblyVersionExtension,
        SRAssemblySpellCheckerCore = "DevExpress.SpellChecker" + VSuffix + ".Core",
        SRAssemblySpellChecker = "DevExpress.XtraSpellChecker" + VSuffix,
        SRAssemblySpellCheckerDesign = "DevExpress.XtraSpellChecker" + VSuffixDesign,
        SRAssemblySpellCheckerDesignFull = SRAssemblySpellCheckerDesign + FullAssemblyVersionExtension,
        SRAssemblySpellCheckerWeb = "DevExpress.Web.ASPxSpellChecker" + VSuffix,
        SRAssemblySpellCheckerWebTests = "DevExpress.Web.ASPxSpellChecker" + VSuffix + ".Tests",
        SRAssemblyWeb = "DevExpress.Web" + VSuffix,
        SRAssemblyWebDesign = "DevExpress.Web" + VSuffixDesign,
        SRAssemblyWebTests = "DevExpress.Web" + VSuffix + ".Tests",
        SRAssemblyWebDemoData = "DevExpress.Web.DemoData" + VSuffix,
        SRAssemblyWebDemoDataTests = "DevExpress.Web.DemoData" + VSuffix + ".Tests",
        SRAssemblyWebDesignFull = "DevExpress.Web" + VSuffixDesign + FullAssemblyVersionExtension,
        SRAssemblyWebDesignTests = "DevExpress.Web" + VSuffixDesign + ".Tests",
        SRAssemblyWebLinq = "DevExpress.Web" + VSuffixLinq,
        SRAssemblyWebProjectsWizardCoreTests = "DevExpress.Web.Projects.Wizard" + VSuffix + ".Core.Tests",
        SRAssemblyWebProjectsWizardAspNetTests = "DevExpress.Web.Projects.Wizard" + VSuffix + ".AspNet.Tests",
        SRAssemblyWebProjectsWizardNetCoreTests = "DevExpress.Web.Projects.Wizard" + VSuffix + ".NetCore.Tests",
        SRAssemblyWebProjectsMvcWizardTests = "DevExpress.Web.Projects.MvcWizard" + VSuffix + ".Tests",
        SRAssemblyANCSpreadsheet = "DevExpress.AspNetCore.Spreadsheet" + VSuffix,
        SRAssemblyWebSpreadsheet = "DevExpress.Web.ASPxSpreadsheet" + VSuffix,
        SRAssemblyWebSpreadsheetFull = "DevExpress.Web.ASPxSpreadsheet" + VSuffix + FullAssemblyVersionExtension,
        SRAssemblyWebSpreadsheetTests = "DevExpress.Web.ASPxSpreadsheet" + VSuffix + ".Tests",
        SRAssemblyWebRichEdit = "DevExpress.Web.ASPxRichEdit" + VSuffix,
        SRAssemblyWebRichEditFull = "DevExpress.Web.ASPxRichEdit" + VSuffix + FullAssemblyVersionExtension,
        SRAssemblyWebRichEditTests = "DevExpress.Web.ASPxRichEdit" + VSuffix + ".Tests",

        SRAssemblyHtmlEditorWeb = "DevExpress.Web.ASPxHtmlEditor" + VSuffix,
        SRAssemblyWebHtmlEditorTests = "DevExpress.Web.ASPxHtmlEditor" + VSuffix + ".Tests",
        SRAssemblyEditorsWeb = "DevExpress.Web.ASPxEditors" + VSuffix,
        SRAssemblyTreeListWeb = "DevExpress.Web.ASPxTreeList" + VSuffix,
        SRAssemblyDiagramWeb = "DevExpress.Web.ASPxDiagram" + VSuffix,
        SRAssemblyDiagramWebTests = "DevExpress.Web.ASPxDiagram" + VSuffix + ".Tests",
        SRAssemblyGanttWeb = "DevExpress.Web.ASPxGantt" + VSuffix,
        SRAssemblyGanttWebTests = "DevExpress.Web.ASPxGantt" + VSuffix + ".Tests",
        SRAssemblyTreeListWebTests = "DevExpress.Web.ASPxTreeList" + VSuffix + ".Tests",
        SRAssemblyDXPivotGrid = "DevExpress.Xpf.PivotGrid" + VSuffix,
        SRAssemblyDXThemeEditorUIWithoutVSuffix = "DevExpress.Xpf.ThemeEditor",
        SRAssemblyDXThemeEditorUI = SRAssemblyDXThemeEditorUIWithoutVSuffix + VSuffix,

        SRAssemblySnap = "DevExpress.Snap" + VSuffix,
        SRAssemblySnapCore = "DevExpress.Snap" + VSuffix + ".Core",
        SRAssemblySnapExtensions = "DevExpress.Snap" + VSuffix + ".Extensions",
        SRAssemblySnapDesign = "DevExpress.Snap" + VSuffixDesign,
        SRAssemblySnapDesignFull = "DevExpress.Snap" + VSuffixDesign + FullAssemblyVersionExtension,

        SRAssemblyUtilsUI = "DevExpress.Utils" + VSuffix + ".UI",
        SRAssemblyUtilsUIFull = SRAssemblyUtilsUI + FullAssemblyVersionExtension,
        SRAssemblyDashboardCore = "DevExpress.Dashboard" + VSuffix + ".Core",
        SRAssemblyDashboardWin = "DevExpress.Dashboard" + VSuffix + ".Win",
        SRAssemblyDashboardWinTests = "DevExpress.Dashboard" + VSuffix + ".Win.Tests",
        SRAssemblyDashboardWinFull = SRAssemblyDashboardWin + FullAssemblyVersionExtension,
        SRAssemblyDashboardXpf = "DevExpress.Xpf.Dashboard" + VSuffix,
        SRAssemblyDashboardWpf = "DevExpress.Dashboard" + VSuffix + ".Wpf",
        SRAssemblyDashboardWpfTests = "DevExpress.Dashboard" + VSuffix + ".Wpf.Tests",
        SRAssemblyDashboardWpfFull = SRAssemblyDashboardWpf + FullAssemblyVersionExtension,
        SRAssemblyDashboardWeb = "DevExpress.Dashboard" + VSuffix + ".Web",
        SRAssemblyDashboardWebWebForms = "DevExpress.Dashboard" + VSuffix + ".Web.WebForms",
        SRAssemblyDashboardWebWebFormsTests = "DevExpress.Dashboard" + VSuffix + ".Web.WebForms.Tests",
        SRAssemblyDashboardWebMVC = "DevExpress.Dashboard" + VSuffix + ".Web.Mvc",
        SRAssemblyDashboardWebMVC5 = "DevExpress.Dashboard" + VSuffix + ".Web.Mvc5",
        SRAssemblyDashboardAspNetCore = "DevExpress.Dashboard" + VSuffix + ".AspNetCore",
        SRAssemblyDashboardAspNetCoreTests = "DevExpress.Dashboard" + VSuffix + ".AspNetCore.Tests",
        SRAssemblyDashboardWpfDesign = "DevExpress.Dashboard" + VSuffix + ".Wpf.Design",
        SRAssemblyDashboardWinDesign = "DevExpress.Dashboard" + VSuffix + ".Win.Design",
        SRAssemblyDashboardWinDesignFull = SRAssemblyDashboardWinDesign + FullAssemblyVersionExtension,
        SRAssemblyDashboardWebDesign = "DevExpress.Dashboard" + VSuffix + ".Web.Design",
        SRAssemblyDashboardWebDesignFull = SRAssemblyDashboardWebDesign + FullAssemblyVersionExtension,
        SRAssemblyDashboardWebBlazor = "DevExpress.Dashboard" + VSuffix + ".Blazor",
        SRAssemblyMapCore = "DevExpress.Map" + VSuffix + ".Core",
        SRAssemblyMapCoreTests = "DevExpress.Map.Core.Tests",
        SRAssemblyMap = "DevExpress.XtraMap" + VSuffix,
        SRAssemblyMapFull = SRAssemblyMap + FullAssemblyVersionExtension,
        SRAssemblyMapTests = "DevExpress.XtraMap.Tests",
        SRAssemblyMapDesign = "DevExpress.XtraMap" + VSuffixDesign,
        SRAssemblyMapDesignFull = SRAssemblyMapDesign + FullAssemblyVersionExtension,
        SRAssemblyTreeMapCore = "DevExpress.TreeMap" + VSuffix + ".Core",
        SRAssemblyTreeMap = "DevExpress.XtraTreeMap" + VSuffix,
        SRAssemblyTreeMapDesign = "DevExpress.XtraTreeMap" + VSuffixDesign + FullAssemblyVersionExtension,
        SRAssemblyTreeMapUI = "DevExpress.XtraTreeMap" + VSuffix + ".UI",
        SRAssemblyDataVisualizationCore = "DevExpress.DataVisualization" + VSuffix + ".Core",
        SRAssemblyDataAccess = "DevExpress.DataAccess" + VSuffix,
        SRAssemblyDataAccessFull = SRAssemblyDataAccess + FullAssemblyVersionExtension,
        SRAssemblyDataAccessUI = "DevExpress.DataAccess" + VSuffix + ".UI",
        SRAssemblyDataAccessUIFull = SRAssemblyDataAccessUI + FullAssemblyVersionExtension,
        SRAssemblyDataAccessDesign = "DevExpress.DataAccess" + VSuffix + ".Design",
        SRAssemblyDataAccessDesignFull = SRAssemblyDataAccessDesign + FullAssemblyVersionExtension,
        SRAssemblyCodeParser = "DevExpress.CodeParser" + VSuffix,
        SRAssemblyCodeParserFull = SRAssemblyCodeParser + FullAssemblyVersionExtension,
        SRAssemblyDrawing = "DevExpress.Drawing" + VSuffix,
        SRAssemblyDrawingFull = SRAssemblyDrawing + FullAssemblyVersionExtension,
        SRAssemblyDrawingTests = SRAssemblyDrawing + TestsSuffix,
        SRAssemblyDrawingSkiaRenderer = "DevExpress.Drawing" + VSuffix + ".Skia",
        SRAssemblyDrawingSkiaRendererFull = SRAssemblyDrawingSkiaRenderer + FullAssemblyVersionExtension,
        SRAssemblyDrawingSkiaRendererTests = SRAssemblyDrawingSkiaRenderer + TestsSuffix,
        SRAssemblyPdfCore = "DevExpress.Pdf" + VSuffix + ".Core",
        SRAssemblyPdfCoreFull = SRAssemblyPdfCore + FullAssemblyVersionExtension,
        SRAssemblyPdfDrawing = "DevExpress.Pdf" + VSuffix + ".Drawing",
        SRAssemblyPdfDrawingFull = SRAssemblyPdfDrawing + FullAssemblyVersionExtension,
        SRAssemblyPdfSkiaRenderer = "DevExpress.Pdf" + VSuffix + ".SkiaRenderer",
        SRAssemblyPdfSkiaRendererFull = SRAssemblyPdfSkiaRenderer + FullAssemblyVersionExtension,
        SRAssemblyXtraPdfViewer = "DevExpress.XtraPdfViewer" + VSuffix,
        SRAssemblyXtraPdfViewerDesign = "DevExpress.XtraPdfViewer" + VSuffix + ".Design",
        SRAssemblyXtraPdfViewerDesignFull = SRAssemblyXtraPdfViewerDesign + FullAssemblyVersionExtension,
        SRAssemblySpreadsheetCoreTestsRangeCopy = "DevExpress.Spreadsheet" + VSuffix + ".Core.Tests.RangeCopy",
        SRAssemblySpreadsheetCoreTestsNotification = "DevExpress.Spreadsheet" + VSuffix + ".Core.Tests.Notification",
        SRAssemblySpreadsheetCoreTestsFunctions = "DevExpress.Spreadsheet" + VSuffix + ".Core.Tests.Functions",
        SRAssemblyMauiCore = "DevExpress.Maui.Core",
        SRAssemblyMauiCoreFull = SRAssemblyMauiCore + FullAssemblyVersionExtension,

        SRAssemblyAIIntegration = "DevExpress.AIIntegration" + VSuffix,
        SRAssemblyAIIntegrationFull = SRAssemblyAIIntegration + FullAssemblyVersionExtension,
        SRAssemblyAIIntegrationSemanticSearch = "DevExpress.AIIntegration.SemanticSearch" + VSuffix,
        SRAssemblyAIIntegrationSemanticSearchFull = SRAssemblyAIIntegrationSemanticSearch + FullAssemblyVersionExtension,
        SRAssemblyAIIntegrationDesktop = "DevExpress.AIIntegration.Desktop" + VSuffix,
        SRAssemblyAIIntegrationDesktopFull = SRAssemblyAIIntegrationDesktop + FullAssemblyVersionExtension,
        SRAssemblyAIIntegrationWinForms = "DevExpress.AIIntegration.WinForms" + VSuffix,
        SRAssemblyAIIntegrationWinFormsFull = SRAssemblyAIIntegrationWinForms + FullAssemblyVersionExtension,
        SRAssemblyAIIntegrationWinFormsChat = "DevExpress.AIIntegration.WinForms.Chat" + VSuffix,
        SRAssemblyAIIntegrationWinFormsChatFull = SRAssemblyAIIntegrationWinFormsChat + FullAssemblyVersionExtension,
        SRAssemblyAIIntegrationWinFormsSemanticSearch = "DevExpress.AIIntegration.WinForms.SemanticSearch" + VSuffix,
        SRAssemblyAIIntegrationWinFormsSemanticSearchFull = SRAssemblyAIIntegrationWinFormsSemanticSearch + FullAssemblyVersionExtension,
        SRAssemblyAIIntegrationEvaluationWinFormsTests = "DevExpress.AIIntegration.Evaluation.WinForms.Tests" + VSuffix,
        SRAssemblyAIIntegrationWpf = "DevExpress.AIIntegration.Wpf" + VSuffix,
        SRAssemblyAIIntegrationWpfChat = "DevExpress.AIIntegration.Wpf.Chat" + VSuffix,

        SRAssemblyAIIntegrationWpfFull = SRAssemblyAIIntegrationWpf + FullAssemblyVersionExtension,
        SRAssemblyAIIntegrationDocs = "DevExpress.AIIntegration.Docs" + VSuffix,
        SRAssemblyAIIntegrationDocsFull = SRAssemblyAIIntegrationDocs + FullAssemblyVersionExtension,

        SRAssemblyAIIntegrationWpfReporting = "DevExpress.AIIntegration.Wpf.Reporting" + VSuffix,
        SRAssemblyAIIntegrationWpfReportingFull = SRAssemblyAIIntegrationWpfReporting + FullAssemblyVersionExtension,

        SRAssemblyAIIntegrationWinFormsTests = "DevExpress.AIIntegration.WinForms.Tests" + VSuffix,
        SRAssemblyAIIntegrationWinFormsTestsFull = SRAssemblyAIIntegrationWinFormsTests + FullAssemblyVersionExtension,

        SRAssemblyAIIntegrationGeneration = "DevExpress.AIIntegration.Generation" + VSuffix,
        SRAssemblyAIIntegrationGenerationFull = SRAssemblyAIIntegrationGeneration + FullAssemblyVersionExtension,

        SRAssemblyAIIntegrationPrinting = "DevExpress.AIIntegration.Printing" + VSuffix,
        SRAssemblyAIIntegrationPrintingFull = SRAssemblyAIIntegrationPrinting + FullAssemblyVersionExtension,
        SRAssemblyAIIntegrationReportingCommon = "DevExpress.AIIntegration.Reporting.Common" + VSuffix,
        SRAssemblyAIIntegrationWebReportingCommon = "DevExpress.AIIntegration.Web.Reporting.Common" + VSuffix,
        SRAssemblyAIIntegrationReportingCommonFull = SRAssemblyAIIntegrationReportingCommon + FullAssemblyVersionExtension,
        SRAssemblyAIIntegrationGenerationReporting = "DevExpress.AIIntegration.Generation.Reporting" + VSuffix,
        SRAssemblyAIIntegrationGenerationReportingFull = SRAssemblyAIIntegrationGenerationReporting + FullAssemblyVersionExtension,
        SRAssemblyAIIntegrationWinFormsReporting = "DevExpress.AIIntegration.WinForms.Reporting" + VSuffix,
        SRAssemblyAIIntegrationWinFormsReportingFull = SRAssemblyAIIntegrationWinFormsReporting + FullAssemblyVersionExtension,
        SRAssemblyAIIntegrationVSIXReporting = "DevExpress.AIIntegration.VSIX.Reporting" + VSuffix,
        SRAssemblyAIIntegrationVSIXReportingFull = SRAssemblyAIIntegrationVSIXReporting + FullAssemblyVersionExtension,

        SRAssemblyAIIntegrationNetCoreReporting = "DevExpress.AIIntegration.AspNetCore.Reporting" + VSuffix,
        SRAssemblyAIIntegrationBlazorReportingViewer = "DevExpress.AIIntegration.Blazor.Reporting.Viewer" + VSuffix,
        SRAssemblyAIIntegrationBlazorRichEdit = "DevExpress.AIIntegration.Blazor.RichEdit" + VSuffix,
        SRAssemblyAIIntegrationWeb = "DevExpress.AIIntegration.Web" + VSuffix;

    public const string
        DXTabNameComponents = "Components",
        DXTabNameNavigationAndLayout = "Navigation & Layout",
        DXTabNameOrmComponents = "ORM Components",
        DXTabNameReporting = "Reporting",
        DXTabNameReportControls = "Report Controls",
        DXTabNameDashboardItems = "Dashboard Items",
        DXTabNameData = "Data & Analytics",
        DXTabNameVisualization = "Visualization",
        DXTabNameScheduling = "Scheduling",
        DXTabNameSchedulerReporting = "Scheduler Reporting",
        DXTabNameRichEdit = "Rich Text Editor",
        DXTabNameSpreadsheet = "Spreadsheet",
        DXTabNameCommon = "Common Controls",
        DXTabNameBootstrap = "Bootstrap Controls",
        DXTabNameLayoutContainers = "Layout Containers",
        DXTabNameLayoutControl = "Layout Control",
        DXTabPrefix = "DX." + VersionShort + ": ",
        DXTabFree = DXTabPrefix + "Free",
        DXTabComponents = DXTabPrefix + DXTabNameComponents,
        DXTabNavigation = DXTabPrefix + DXTabNameNavigationAndLayout,
        DXTabLayoutControl = DXTabPrefix + DXTabNameLayoutControl,
        DXTabLayoutContainers = DXTabPrefix + DXTabNameLayoutContainers,
        DXTabReporting = DXTabPrefix + DXTabNameReporting,
        DXTabReportControls = DXTabPrefix + DXTabNameReportControls,
        DXTabDashboardItems = DXTabPrefix + DXTabNameDashboardItems,
        DXTabData = DXTabPrefix + DXTabNameData,
        DXTabVisualization = DXTabPrefix + DXTabNameVisualization,
        DXTabOrmComponents = DXTabPrefix + DXTabNameOrmComponents,
        DXTabScheduling = DXTabPrefix + DXTabNameScheduling,
        DXTabSchedulerReporting = DXTabPrefix + DXTabNameSchedulerReporting,
        DXTabRichEdit = DXTabPrefix + DXTabNameRichEdit,
        DXTabSpreadsheet = DXTabPrefix + DXTabNameSpreadsheet,
        DXTabCommon = DXTabPrefix + DXTabNameCommon,
        DXTabBootstrap = DXTabPrefix + DXTabNameBootstrap,
        DXTabNameXPOProfiler = "XPO " + VersionShort + " Profiler";

    public const string
        DXTabWpfNavigation = "DX." + VersionShort + ": Navigation & Layout",
        DXTabWpfReporting = "DX." + VersionShort + ": Reporting",
        DXTabWpfData = "DX." + VersionShort + ": Data",
        DXTabWpfVisualization = "DX." + VersionShort + ": Visualization",
        DXTabWpfCommon = "DX." + VersionShort + ": Common Controls",
        DXTabWpfScheduling = "DX." + VersionShort + ": Scheduling",
        DXTabWpfSchedulingOld = "DX." + VersionShort + ": Scheduling (old)",
        DXTabWpfRichEdit = "DX." + VersionShort + ": Rich Text Editor",
        DXTabWpfSpreadsheet = "DX." + VersionShort + ": Spreadsheet";

    public const string
        DXLinkCompetitiveDiscounts = "https://go.devexpress.com/Demo_2013_Competitive_Discounts.aspx",
        DXLinkCompare = "https://go.devexpress.com/Demo_2013_CompareSubscriptions.aspx",
        DXLinkTrial = "https://go.devexpress.com/Demo_2013_DownloadTrial.aspx",
        DXLinkChat = "Https://go.devexpress.com/Demo_2013_Chat.aspx",
        DXLinkHelp = "Https://go.devexpress.com/Demo_2013_Help.aspx",
        DXLinkBuyNow = "Https://go.devexpress.com/Demo_2013_BuyNow.aspx",
        DXLinkBuyNowASP = "https://go.devexpress.com/Demo_2013_BuyNow_ASP.aspx",
        DXLinkWhatsNew = "Https://go.devexpress.com/Demo_2013_13_2_WhatsNew.aspx",
        DXLinkGetSupport = "Https://go.devexpress.com/Demo_2013_GetSupport.aspx",
        DXLinkGetStarted = "Https://go.devexpress.com/Demo_2013_GetStartedOverall.aspx",
        DXLinkRegisterKB = "https://go.devexpress.com/Demo_2013_RegisterTrial.aspx",
        DXLinkGetStartedWinGrid = "https://go.devexpress.com/Demo_2013_GetStartedWinGrid.aspx",

        DXLinkTrialASPNETCore = "https://go.devexpress.com/Licensing_Installer_Watermark_ASPNETCore.aspx",
        DXLinkTrialDashboards = "https://go.devexpress.com/Licensing_Installer_Watermark_Dashboards.aspx",
        DXLinkTrialDevExtreme = "https://go.devexpress.com/Licensing_Installer_Watermark_DevExtreme.aspx",
        DXLinkTrialReporting = "https://go.devexpress.com/Licensing_Installer_Watermark_Reporting.aspx",
        DXLinkTrialOffice = "https://go.devexpress.com/Licensing_Installer_Watermark_Office.aspx",
        DXLinkTrialBlazor = "https://go.devexpress.com/Licensing_Installer_Watermark_Blazor.aspx",
        DXLinkTrialXAF = "https://go.devexpress.com/Licensing_Installer_Watermark_XAF.aspx",
        DXLinkTrialCommon = "https://go.devexpress.com/Licensing_Installer_Watermark.aspx", // use this one everywhere if it is difficult to integrate product-specific links

        DXLinkLicensingDocASP = "https://www.devexpress.com/go/Licensing_Documentation_AspNetClassic.aspx",
        DXLinkLicensingDocASPNETCore = "https://www.devexpress.com/go/Licensing_Documentation_AspNetCore.aspx",
        DXLinkLicensingDocXAF = "https://www.devexpress.com/go/Licensing_Documentation_XAF.aspx",
        DXLinkLicensingDocBlazor = "https://www.devexpress.com/go/Licensing_Documentation_Blazor.aspx",
        DXLinkLicensingDocOffice = "https://www.devexpress.com/go/Licensing_Documentation_Office.aspx",
        DXLinkLicensingDocDashboards = "https://www.devexpress.com/go/Licensing_Documentation_Dashboards.aspx",
        DXLinkLicensingDocReporting = "https://www.devexpress.com/go/Licensing_Documentation_Reporting.aspx",
        DXLinkLicensingDocCommon = "https://www.devexpress.com/go/Licensing_Documentation.aspx",

        DXEmailInfo = "info@devexpress.com",
        DXLinkEmailInfo = "mailto:" + DXEmailInfo;

    public const string
        VisualStudio2019InteropAssembly = "DevExpress.VisualStudioInterop.VS2019" + VSuffix + FullAssemblyVersionExtension,
        VisualStudio2022InteropAssembly = "DevExpress.VisualStudioInterop.VS2022" + VSuffix + FullAssemblyVersionExtension;
#endif
}
#if !DXCommon
}
#endif
