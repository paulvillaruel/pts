<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientMain))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Creation")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Container Update", 22, 22)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Physical Check", 10, 10)
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Information")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Yard Handling")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Empty Depot")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Full Export")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Import")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Registered")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("List", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Container", 5, 5, New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode10})
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Shifting")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Discharging")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Loading")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Vessel Operation", 17, 17, New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode13, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gate In")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gate Out")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Truck Activity", New System.Windows.Forms.TreeNode() {TreeNode16, TreeNode17})
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Carrier", 6, 6, New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reports", 7, 7)
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Quayside Activity", 28, 28)
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Delivery")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Receiving")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gate Activity", New System.Windows.Forms.TreeNode() {TreeNode22, TreeNode23})
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Yard Inventory")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stripping")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stuffing")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Yard Activity", New System.Windows.Forms.TreeNode() {TreeNode25, TreeNode26, TreeNode27})
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Job Booking Activity")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Monitoring", New System.Windows.Forms.TreeNode() {TreeNode21, TreeNode24, TreeNode28, TreeNode29})
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Carrier Rotation")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Carrier Data")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ISO Codes")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Country Codes")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Location Codes")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Handling Equipment")
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Line Data")
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Agent Data")
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Trucking Company")
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Color Coding")
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("User")
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Customer")
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tariff List")
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Delay Codes")
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Basic Data", New System.Windows.Forms.TreeNode() {TreeNode31, TreeNode32, TreeNode33, TreeNode34, TreeNode35, TreeNode36, TreeNode37, TreeNode38, TreeNode39, TreeNode40, TreeNode41, TreeNode42, TreeNode43, TreeNode44})
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("System Options")
        Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tools", 8, 8, New System.Windows.Forms.TreeNode() {TreeNode30, TreeNode45, TreeNode46})
        Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Billing")
        Dim TreeNode49 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Electronic Data Interchange")
        Dim TreeNode50 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Job Booking")
        Dim TreeNode51 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Remote Terminal")
        Dim TreeNode52 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Vessel Builder")
        Dim TreeNode53 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Vessel Visit Management", 27, 27)
        Dim TreeNode54 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Yard Viewer")
        Dim TreeNode55 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Applications", New System.Windows.Forms.TreeNode() {TreeNode48, TreeNode49, TreeNode50, TreeNode51, TreeNode52, TreeNode53, TreeNode54})
        Dim TreeNode56 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Log Out")
        Dim TreeNode57 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Help")
        Me.menuMainClient = New System.Windows.Forms.MenuStrip()
        Me.menuSystem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuContainer = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCreation = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuContainerUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPCheck = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuInformation = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuHandling = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEmptyDepot = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFullExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuImport = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRegistered = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCarrier = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuVessel = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuShifting = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLoading = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuDischarging = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.TruckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuGateIn = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuGateOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.SepToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.menuReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuMonitoring = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuQuay = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuGateActivity = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuDelivery = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReceiving = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuYardActivity = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStripping = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStuffing = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuJobBookingMonitor = New System.Windows.Forms.ToolStripMenuItem()
        Me.BasicDataToolItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCarrierRotation = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCarrierData = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuISOCodes = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCountryCodes = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLocationCodes = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHEquipment = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLine = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAgent = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuTrucking = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuColorCoding = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuTariffList = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuDelayCodes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuApplications = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEDI = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuVesselVisit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuVesselBuilder = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuJobBooking = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiceBillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRDTViewer = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelpContents = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelpIndex = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelpSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusMainClient = New System.Windows.Forms.StatusStrip()
        Me.toolShowMenu = New System.Windows.Forms.ToolStripSplitButton()
        Me.stServer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stDatabase = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stUserId = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stDateLog = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stTimeLog = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tooltipPreview = New System.Windows.Forms.ToolTip(Me.components)
        Me.iListMain = New System.Windows.Forms.ImageList(Me.components)
        Me.toolMainFunction = New System.Windows.Forms.ToolStrip()
        Me.toolCreation = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolInformation = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolGateIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolGateOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolJobBooking = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolLoading = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolDischarging = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolShifting = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolHandling = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolBilling = New System.Windows.Forms.ToolStripButton()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.treeTaskList = New System.Windows.Forms.TreeView()
        Me.toolSideMenu = New System.Windows.Forms.ToolStrip()
        Me.toolHideMenu = New System.Windows.Forms.ToolStripButton()
        Me.splitParent = New System.Windows.Forms.Splitter()
        Me.tabFormControl = New WinControl.WinControl()
        Me.menuYardViewer = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuMainClient.SuspendLayout()
        Me.statusMainClient.SuspendLayout()
        Me.toolMainFunction.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.toolSideMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuMainClient
        '
        Me.menuMainClient.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuSystem, Me.menuContainer, Me.menuCarrier, Me.menuReports, Me.menuTools, Me.menuApplications, Me.menuHelp})
        Me.menuMainClient.Location = New System.Drawing.Point(0, 0)
        Me.menuMainClient.Name = "menuMainClient"
        Me.menuMainClient.Size = New System.Drawing.Size(981, 24)
        Me.menuMainClient.TabIndex = 5
        Me.menuMainClient.Text = "MenuStrip"
        '
        'menuSystem
        '
        Me.menuSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.menuSystem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuLogOut, Me.menuExit})
        Me.menuSystem.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.menuSystem.Name = "menuSystem"
        Me.menuSystem.Size = New System.Drawing.Size(57, 20)
        Me.menuSystem.Text = "&System"
        '
        'menuLogOut
        '
        Me.menuLogOut.Name = "menuLogOut"
        Me.menuLogOut.Size = New System.Drawing.Size(143, 22)
        Me.menuLogOut.Text = "Log Out User"
        '
        'menuExit
        '
        Me.menuExit.Image = CType(resources.GetObject("menuExit.Image"), System.Drawing.Image)
        Me.menuExit.Name = "menuExit"
        Me.menuExit.Size = New System.Drawing.Size(143, 22)
        Me.menuExit.Text = "E&xit"
        '
        'menuContainer
        '
        Me.menuContainer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCreation, Me.menuContainerUpdate, Me.menuPCheck, Me.ToolStripSeparator12, Me.menuInformation, Me.ToolStripSeparator13, Me.menuHandling, Me.ToolStripSeparator1, Me.ListToolStripMenuItem})
        Me.menuContainer.Name = "menuContainer"
        Me.menuContainer.Size = New System.Drawing.Size(71, 20)
        Me.menuContainer.Text = "Container"
        '
        'menuCreation
        '
        Me.menuCreation.Name = "menuCreation"
        Me.menuCreation.Size = New System.Drawing.Size(167, 22)
        Me.menuCreation.Text = "Creation"
        '
        'menuContainerUpdate
        '
        Me.menuContainerUpdate.Name = "menuContainerUpdate"
        Me.menuContainerUpdate.Size = New System.Drawing.Size(167, 22)
        Me.menuContainerUpdate.Text = "Container Update"
        '
        'menuPCheck
        '
        Me.menuPCheck.Name = "menuPCheck"
        Me.menuPCheck.Size = New System.Drawing.Size(167, 22)
        Me.menuPCheck.Text = "Physical Check"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(164, 6)
        '
        'menuInformation
        '
        Me.menuInformation.Name = "menuInformation"
        Me.menuInformation.Size = New System.Drawing.Size(167, 22)
        Me.menuInformation.Text = "Information"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(164, 6)
        '
        'menuHandling
        '
        Me.menuHandling.Name = "menuHandling"
        Me.menuHandling.Size = New System.Drawing.Size(167, 22)
        Me.menuHandling.Text = "Handling"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(164, 6)
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuEmptyDepot, Me.menuFullExport, Me.menuImport, Me.menuRegistered})
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'menuEmptyDepot
        '
        Me.menuEmptyDepot.Name = "menuEmptyDepot"
        Me.menuEmptyDepot.Size = New System.Drawing.Size(143, 22)
        Me.menuEmptyDepot.Text = "&Empty Depot"
        '
        'menuFullExport
        '
        Me.menuFullExport.Name = "menuFullExport"
        Me.menuFullExport.Size = New System.Drawing.Size(143, 22)
        Me.menuFullExport.Text = "&Full Export"
        '
        'menuImport
        '
        Me.menuImport.Name = "menuImport"
        Me.menuImport.Size = New System.Drawing.Size(143, 22)
        Me.menuImport.Text = "&Import"
        '
        'menuRegistered
        '
        Me.menuRegistered.Name = "menuRegistered"
        Me.menuRegistered.Size = New System.Drawing.Size(143, 22)
        Me.menuRegistered.Text = "&Registered"
        '
        'menuCarrier
        '
        Me.menuCarrier.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuVessel, Me.ToolStripSeparator9, Me.TruckToolStripMenuItem, Me.SepToolStripMenuItem})
        Me.menuCarrier.Name = "menuCarrier"
        Me.menuCarrier.Size = New System.Drawing.Size(54, 20)
        Me.menuCarrier.Text = "Carrier"
        '
        'menuVessel
        '
        Me.menuVessel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuShifting, Me.menuLoading, Me.menuDischarging})
        Me.menuVessel.Name = "menuVessel"
        Me.menuVessel.Size = New System.Drawing.Size(162, 22)
        Me.menuVessel.Text = "Vessel Operation"
        '
        'menuShifting
        '
        Me.menuShifting.Name = "menuShifting"
        Me.menuShifting.Size = New System.Drawing.Size(152, 22)
        Me.menuShifting.Text = "Shifting"
        '
        'menuLoading
        '
        Me.menuLoading.Name = "menuLoading"
        Me.menuLoading.Size = New System.Drawing.Size(152, 22)
        Me.menuLoading.Text = "Loading"
        '
        'menuDischarging
        '
        Me.menuDischarging.Name = "menuDischarging"
        Me.menuDischarging.Size = New System.Drawing.Size(152, 22)
        Me.menuDischarging.Text = "Discharging"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(159, 6)
        '
        'TruckToolStripMenuItem
        '
        Me.TruckToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuGateIn, Me.menuGateOut})
        Me.TruckToolStripMenuItem.Name = "TruckToolStripMenuItem"
        Me.TruckToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.TruckToolStripMenuItem.Text = "Truck Activity"
        '
        'menuGateIn
        '
        Me.menuGateIn.Name = "menuGateIn"
        Me.menuGateIn.Size = New System.Drawing.Size(152, 22)
        Me.menuGateIn.Text = "Gate In"
        '
        'menuGateOut
        '
        Me.menuGateOut.Name = "menuGateOut"
        Me.menuGateOut.Size = New System.Drawing.Size(152, 22)
        Me.menuGateOut.Text = "Gate Out"
        '
        'SepToolStripMenuItem
        '
        Me.SepToolStripMenuItem.Name = "SepToolStripMenuItem"
        Me.SepToolStripMenuItem.Size = New System.Drawing.Size(159, 6)
        '
        'menuReports
        '
        Me.menuReports.Name = "menuReports"
        Me.menuReports.Size = New System.Drawing.Size(59, 20)
        Me.menuReports.Text = "Reports"
        '
        'menuTools
        '
        Me.menuTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuMonitoring, Me.BasicDataToolItem, Me.ToolStripSeparator15, Me.menuOptions})
        Me.menuTools.Name = "menuTools"
        Me.menuTools.Size = New System.Drawing.Size(48, 20)
        Me.menuTools.Text = "&Tools"
        '
        'menuMonitoring
        '
        Me.menuMonitoring.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuQuay, Me.menuGateActivity, Me.menuYardActivity, Me.menuJobBookingMonitor})
        Me.menuMonitoring.Name = "menuMonitoring"
        Me.menuMonitoring.Size = New System.Drawing.Size(152, 22)
        Me.menuMonitoring.Text = "Monitoring..."
        '
        'menuQuay
        '
        Me.menuQuay.Name = "menuQuay"
        Me.menuQuay.Size = New System.Drawing.Size(182, 22)
        Me.menuQuay.Text = "Quay Activity"
        '
        'menuGateActivity
        '
        Me.menuGateActivity.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuDelivery, Me.menuReceiving})
        Me.menuGateActivity.Name = "menuGateActivity"
        Me.menuGateActivity.Size = New System.Drawing.Size(182, 22)
        Me.menuGateActivity.Text = "Gate Activity"
        '
        'menuDelivery
        '
        Me.menuDelivery.Name = "menuDelivery"
        Me.menuDelivery.Size = New System.Drawing.Size(125, 22)
        Me.menuDelivery.Text = "&Delivery"
        '
        'menuReceiving
        '
        Me.menuReceiving.Name = "menuReceiving"
        Me.menuReceiving.Size = New System.Drawing.Size(125, 22)
        Me.menuReceiving.Text = "&Receiving"
        '
        'menuYardActivity
        '
        Me.menuYardActivity.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuInventory, Me.menuStripping, Me.menuStuffing})
        Me.menuYardActivity.Name = "menuYardActivity"
        Me.menuYardActivity.Size = New System.Drawing.Size(182, 22)
        Me.menuYardActivity.Text = "Yard Activity"
        '
        'menuInventory
        '
        Me.menuInventory.Name = "menuInventory"
        Me.menuInventory.Size = New System.Drawing.Size(151, 22)
        Me.menuInventory.Text = "Yard Inventory"
        '
        'menuStripping
        '
        Me.menuStripping.Name = "menuStripping"
        Me.menuStripping.Size = New System.Drawing.Size(151, 22)
        Me.menuStripping.Text = "Stripping"
        '
        'menuStuffing
        '
        Me.menuStuffing.Name = "menuStuffing"
        Me.menuStuffing.Size = New System.Drawing.Size(151, 22)
        Me.menuStuffing.Text = "Stuffing"
        '
        'menuJobBookingMonitor
        '
        Me.menuJobBookingMonitor.Name = "menuJobBookingMonitor"
        Me.menuJobBookingMonitor.Size = New System.Drawing.Size(182, 22)
        Me.menuJobBookingMonitor.Text = "Job Booking Activity"
        '
        'BasicDataToolItem
        '
        Me.BasicDataToolItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCarrierRotation, Me.menuCarrierData, Me.menuISOCodes, Me.menuCountryCodes, Me.menuLocationCodes, Me.menuHEquipment, Me.menuLine, Me.menuAgent, Me.menuTrucking, Me.menuColorCoding, Me.menuUser, Me.menuCustomer, Me.menuTariffList, Me.menuDelayCodes})
        Me.BasicDataToolItem.Name = "BasicDataToolItem"
        Me.BasicDataToolItem.Size = New System.Drawing.Size(152, 22)
        Me.BasicDataToolItem.Text = "&Basic Data"
        '
        'menuCarrierRotation
        '
        Me.menuCarrierRotation.Name = "menuCarrierRotation"
        Me.menuCarrierRotation.Size = New System.Drawing.Size(184, 22)
        Me.menuCarrierRotation.Text = "Carrier Rotation"
        '
        'menuCarrierData
        '
        Me.menuCarrierData.Name = "menuCarrierData"
        Me.menuCarrierData.Size = New System.Drawing.Size(184, 22)
        Me.menuCarrierData.Text = "Carrier Data"
        '
        'menuISOCodes
        '
        Me.menuISOCodes.Name = "menuISOCodes"
        Me.menuISOCodes.Size = New System.Drawing.Size(184, 22)
        Me.menuISOCodes.Text = "ISO Codes"
        '
        'menuCountryCodes
        '
        Me.menuCountryCodes.Name = "menuCountryCodes"
        Me.menuCountryCodes.Size = New System.Drawing.Size(184, 22)
        Me.menuCountryCodes.Text = "Country Codes"
        '
        'menuLocationCodes
        '
        Me.menuLocationCodes.Name = "menuLocationCodes"
        Me.menuLocationCodes.Size = New System.Drawing.Size(184, 22)
        Me.menuLocationCodes.Text = "Location Codes"
        '
        'menuHEquipment
        '
        Me.menuHEquipment.Name = "menuHEquipment"
        Me.menuHEquipment.Size = New System.Drawing.Size(184, 22)
        Me.menuHEquipment.Text = "Handling Equipment"
        '
        'menuLine
        '
        Me.menuLine.Name = "menuLine"
        Me.menuLine.Size = New System.Drawing.Size(184, 22)
        Me.menuLine.Text = "Line Data"
        '
        'menuAgent
        '
        Me.menuAgent.Name = "menuAgent"
        Me.menuAgent.Size = New System.Drawing.Size(184, 22)
        Me.menuAgent.Text = "Agent Data"
        '
        'menuTrucking
        '
        Me.menuTrucking.Name = "menuTrucking"
        Me.menuTrucking.Size = New System.Drawing.Size(184, 22)
        Me.menuTrucking.Text = "Truck Driver..."
        '
        'menuColorCoding
        '
        Me.menuColorCoding.Name = "menuColorCoding"
        Me.menuColorCoding.Size = New System.Drawing.Size(184, 22)
        Me.menuColorCoding.Text = "Color Coding"
        '
        'menuUser
        '
        Me.menuUser.Name = "menuUser"
        Me.menuUser.Size = New System.Drawing.Size(184, 22)
        Me.menuUser.Text = "Users..."
        '
        'menuCustomer
        '
        Me.menuCustomer.Name = "menuCustomer"
        Me.menuCustomer.Size = New System.Drawing.Size(184, 22)
        Me.menuCustomer.Text = "Customer"
        '
        'menuTariffList
        '
        Me.menuTariffList.Name = "menuTariffList"
        Me.menuTariffList.Size = New System.Drawing.Size(184, 22)
        Me.menuTariffList.Text = "Tariff List"
        '
        'menuDelayCodes
        '
        Me.menuDelayCodes.Name = "menuDelayCodes"
        Me.menuDelayCodes.Size = New System.Drawing.Size(184, 22)
        Me.menuDelayCodes.Text = "Delay Codes"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(149, 6)
        '
        'menuOptions
        '
        Me.menuOptions.Name = "menuOptions"
        Me.menuOptions.Size = New System.Drawing.Size(152, 22)
        Me.menuOptions.Text = "Options..."
        '
        'menuApplications
        '
        Me.menuApplications.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServiceBillingToolStripMenuItem, Me.menuEDI, Me.menuJobBooking, Me.menuRDTViewer, Me.menuVesselVisit, Me.menuVesselBuilder, Me.menuYardViewer})
        Me.menuApplications.Name = "menuApplications"
        Me.menuApplications.Size = New System.Drawing.Size(85, 20)
        Me.menuApplications.Text = "Applications"
        '
        'menuEDI
        '
        Me.menuEDI.Name = "menuEDI"
        Me.menuEDI.Size = New System.Drawing.Size(228, 22)
        Me.menuEDI.Text = "Electronic Data Interchange..."
        '
        'menuVesselVisit
        '
        Me.menuVesselVisit.Name = "menuVesselVisit"
        Me.menuVesselVisit.Size = New System.Drawing.Size(228, 22)
        Me.menuVesselVisit.Text = "Vessel Visit Management"
        '
        'menuVesselBuilder
        '
        Me.menuVesselBuilder.Name = "menuVesselBuilder"
        Me.menuVesselBuilder.Size = New System.Drawing.Size(228, 22)
        Me.menuVesselBuilder.Text = "Vessel Builder"
        '
        'menuJobBooking
        '
        Me.menuJobBooking.Name = "menuJobBooking"
        Me.menuJobBooking.Size = New System.Drawing.Size(228, 22)
        Me.menuJobBooking.Text = "Job Booking"
        '
        'ServiceBillingToolStripMenuItem
        '
        Me.ServiceBillingToolStripMenuItem.Name = "ServiceBillingToolStripMenuItem"
        Me.ServiceBillingToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.ServiceBillingToolStripMenuItem.Text = "Billing"
        '
        'menuRDTViewer
        '
        Me.menuRDTViewer.Name = "menuRDTViewer"
        Me.menuRDTViewer.Size = New System.Drawing.Size(228, 22)
        Me.menuRDTViewer.Text = "Remote Terminal"
        '
        'menuHelp
        '
        Me.menuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuHelpContents, Me.menuHelpIndex, Me.menuHelpSearch, Me.ToolStripSeparator8, Me.menuAbout})
        Me.menuHelp.Name = "menuHelp"
        Me.menuHelp.Size = New System.Drawing.Size(44, 20)
        Me.menuHelp.Text = "&Help"
        '
        'menuHelpContents
        '
        Me.menuHelpContents.Name = "menuHelpContents"
        Me.menuHelpContents.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.menuHelpContents.Size = New System.Drawing.Size(168, 22)
        Me.menuHelpContents.Text = "&Contents"
        '
        'menuHelpIndex
        '
        Me.menuHelpIndex.Image = CType(resources.GetObject("menuHelpIndex.Image"), System.Drawing.Image)
        Me.menuHelpIndex.ImageTransparentColor = System.Drawing.Color.Black
        Me.menuHelpIndex.Name = "menuHelpIndex"
        Me.menuHelpIndex.Size = New System.Drawing.Size(168, 22)
        Me.menuHelpIndex.Text = "&Index"
        '
        'menuHelpSearch
        '
        Me.menuHelpSearch.Image = CType(resources.GetObject("menuHelpSearch.Image"), System.Drawing.Image)
        Me.menuHelpSearch.ImageTransparentColor = System.Drawing.Color.Black
        Me.menuHelpSearch.Name = "menuHelpSearch"
        Me.menuHelpSearch.Size = New System.Drawing.Size(168, 22)
        Me.menuHelpSearch.Text = "&Search"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(165, 6)
        '
        'menuAbout
        '
        Me.menuAbout.Name = "menuAbout"
        Me.menuAbout.Size = New System.Drawing.Size(168, 22)
        Me.menuAbout.Text = "&About ..."
        '
        'statusMainClient
        '
        Me.statusMainClient.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolShowMenu, Me.stServer, Me.stDatabase, Me.stUserId, Me.stDateLog, Me.stTimeLog})
        Me.statusMainClient.Location = New System.Drawing.Point(0, 541)
        Me.statusMainClient.Name = "statusMainClient"
        Me.statusMainClient.Size = New System.Drawing.Size(981, 22)
        Me.statusMainClient.TabIndex = 7
        Me.statusMainClient.Text = "StatusStrip"
        '
        'toolShowMenu
        '
        Me.toolShowMenu.Image = CType(resources.GetObject("toolShowMenu.Image"), System.Drawing.Image)
        Me.toolShowMenu.Name = "toolShowMenu"
        Me.toolShowMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.toolShowMenu.Size = New System.Drawing.Size(68, 20)
        Me.toolShowMenu.Text = "Show"
        Me.toolShowMenu.Visible = False
        '
        'stServer
        '
        Me.stServer.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.stServer.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.stServer.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.stServer.Name = "stServer"
        Me.stServer.Size = New System.Drawing.Size(50, 17)
        Me.stServer.Text = "Server: "
        '
        'stDatabase
        '
        Me.stDatabase.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.stDatabase.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.stDatabase.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.stDatabase.Name = "stDatabase"
        Me.stDatabase.Size = New System.Drawing.Size(64, 17)
        Me.stDatabase.Text = "Database: "
        '
        'stUserId
        '
        Me.stUserId.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.stUserId.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.stUserId.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.stUserId.Name = "stUserId"
        Me.stUserId.Size = New System.Drawing.Size(53, 17)
        Me.stUserId.Text = "User Id: "
        '
        'stDateLog
        '
        Me.stDateLog.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.stDateLog.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.stDateLog.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.stDateLog.Name = "stDateLog"
        Me.stDateLog.Size = New System.Drawing.Size(79, 17)
        Me.stDateLog.Text = "Date Logged: "
        '
        'stTimeLog
        '
        Me.stTimeLog.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.stTimeLog.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.stTimeLog.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.stTimeLog.Name = "stTimeLog"
        Me.stTimeLog.Size = New System.Drawing.Size(78, 17)
        Me.stTimeLog.Text = "Time Logged: "
        '
        'tooltipPreview
        '
        Me.tooltipPreview.AutoPopDelay = 5000
        Me.tooltipPreview.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tooltipPreview.InitialDelay = 500
        Me.tooltipPreview.IsBalloon = True
        Me.tooltipPreview.ReshowDelay = 100
        Me.tooltipPreview.ShowAlways = True
        Me.tooltipPreview.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tooltipPreview.ToolTipTitle = "Quick Info"
        '
        'iListMain
        '
        Me.iListMain.ImageStream = CType(resources.GetObject("iListMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iListMain.TransparentColor = System.Drawing.Color.Transparent
        Me.iListMain.Images.SetKeyName(0, "new.gif")
        Me.iListMain.Images.SetKeyName(1, "open.gif")
        Me.iListMain.Images.SetKeyName(2, "page_edit.png")
        Me.iListMain.Images.SetKeyName(3, "page_white_gear.png")
        Me.iListMain.Images.SetKeyName(4, "application_side_list.png")
        Me.iListMain.Images.SetKeyName(5, "stock_3d-all-attributes-16.png")
        Me.iListMain.Images.SetKeyName(6, "stock_repeat-16.png")
        Me.iListMain.Images.SetKeyName(7, "lc_dbqueryedit.png")
        Me.iListMain.Images.SetKeyName(8, "stock_file-properties-16.png")
        Me.iListMain.Images.SetKeyName(9, "help.png")
        Me.iListMain.Images.SetKeyName(10, "accept.png")
        Me.iListMain.Images.SetKeyName(11, "lc_arrowshapes_006.png")
        Me.iListMain.Images.SetKeyName(12, "lc_arrowshapes_011.png")
        Me.iListMain.Images.SetKeyName(13, "lc_arrowshapes_013.png")
        Me.iListMain.Images.SetKeyName(14, "page_lightning.png")
        Me.iListMain.Images.SetKeyName(15, "stock_form-pattern-field.png")
        Me.iListMain.Images.SetKeyName(16, "stock_object-infront-16.png")
        Me.iListMain.Images.SetKeyName(17, "stock_reverse-order.png")
        Me.iListMain.Images.SetKeyName(18, "stock_table-align-bottom.png")
        Me.iListMain.Images.SetKeyName(19, "stock_table-align-top.png")
        Me.iListMain.Images.SetKeyName(20, "wand.png")
        Me.iListMain.Images.SetKeyName(21, "stock_zoom-shift-16.png")
        Me.iListMain.Images.SetKeyName(22, "sc_dbnewreport.png")
        Me.iListMain.Images.SetKeyName(23, "bricks.png")
        Me.iListMain.Images.SetKeyName(24, "chart_pie.png")
        Me.iListMain.Images.SetKeyName(25, "application_osx_terminal.png")
        Me.iListMain.Images.SetKeyName(26, "chart_curve.png")
        Me.iListMain.Images.SetKeyName(27, "resultset_next.png")
        Me.iListMain.Images.SetKeyName(28, "stock_anchor-16.png")
        Me.iListMain.Images.SetKeyName(29, "stock_draw-connector-with-arrows-16.png")
        Me.iListMain.Images.SetKeyName(30, "stock_insert-form.png")
        Me.iListMain.Images.SetKeyName(31, "stock_insert-note.png")
        Me.iListMain.Images.SetKeyName(32, "monitor_go.png")
        '
        'toolMainFunction
        '
        Me.toolMainFunction.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolMainFunction.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolCreation, Me.ToolStripSeparator5, Me.toolInformation, Me.ToolStripSeparator2, Me.toolGateIn, Me.ToolStripSeparator6, Me.toolGateOut, Me.ToolStripSeparator4, Me.toolJobBooking, Me.ToolStripSeparator3, Me.toolLoading, Me.ToolStripSeparator7, Me.toolDischarging, Me.ToolStripSeparator14, Me.toolShifting, Me.ToolStripSeparator16, Me.toolHandling, Me.ToolStripSeparator10, Me.toolBilling})
        Me.toolMainFunction.Location = New System.Drawing.Point(0, 24)
        Me.toolMainFunction.Name = "toolMainFunction"
        Me.toolMainFunction.Size = New System.Drawing.Size(981, 62)
        Me.toolMainFunction.TabIndex = 14
        Me.toolMainFunction.Text = "ToolStrip1"
        '
        'toolCreation
        '
        Me.toolCreation.BackColor = System.Drawing.Color.Transparent
        Me.toolCreation.Image = CType(resources.GetObject("toolCreation.Image"), System.Drawing.Image)
        Me.toolCreation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.toolCreation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolCreation.Name = "toolCreation"
        Me.toolCreation.Size = New System.Drawing.Size(79, 59)
        Me.toolCreation.Text = "F1 - Creation"
        Me.toolCreation.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.toolCreation.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.toolCreation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.toolCreation.ToolTipText = "F1 Create Container"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 62)
        '
        'toolInformation
        '
        Me.toolInformation.Image = CType(resources.GetObject("toolInformation.Image"), System.Drawing.Image)
        Me.toolInformation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.toolInformation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolInformation.Name = "toolInformation"
        Me.toolInformation.Size = New System.Drawing.Size(94, 59)
        Me.toolInformation.Text = "F2- Information"
        Me.toolInformation.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.toolInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 62)
        '
        'toolGateIn
        '
        Me.toolGateIn.Image = CType(resources.GetObject("toolGateIn.Image"), System.Drawing.Image)
        Me.toolGateIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.toolGateIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolGateIn.Name = "toolGateIn"
        Me.toolGateIn.Size = New System.Drawing.Size(104, 59)
        Me.toolGateIn.Text = "F5 - Truck Gate In"
        Me.toolGateIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 62)
        '
        'toolGateOut
        '
        Me.toolGateOut.Image = CType(resources.GetObject("toolGateOut.Image"), System.Drawing.Image)
        Me.toolGateOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.toolGateOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolGateOut.Name = "toolGateOut"
        Me.toolGateOut.Size = New System.Drawing.Size(114, 59)
        Me.toolGateOut.Text = "F6 - Truck Gate Out"
        Me.toolGateOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 62)
        '
        'toolJobBooking
        '
        Me.toolJobBooking.Image = CType(resources.GetObject("toolJobBooking.Image"), System.Drawing.Image)
        Me.toolJobBooking.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.toolJobBooking.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolJobBooking.Name = "toolJobBooking"
        Me.toolJobBooking.Size = New System.Drawing.Size(99, 59)
        Me.toolJobBooking.Text = "F8 - Job Booking"
        Me.toolJobBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 62)
        '
        'toolLoading
        '
        Me.toolLoading.Image = CType(resources.GetObject("toolLoading.Image"), System.Drawing.Image)
        Me.toolLoading.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.toolLoading.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolLoading.Name = "toolLoading"
        Me.toolLoading.Size = New System.Drawing.Size(77, 59)
        Me.toolLoading.Text = "F9 - Loading"
        Me.toolLoading.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 62)
        '
        'toolDischarging
        '
        Me.toolDischarging.Image = CType(resources.GetObject("toolDischarging.Image"), System.Drawing.Image)
        Me.toolDischarging.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.toolDischarging.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolDischarging.Name = "toolDischarging"
        Me.toolDischarging.Size = New System.Drawing.Size(103, 59)
        Me.toolDischarging.Text = "F10 - Discharging"
        Me.toolDischarging.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 62)
        '
        'toolShifting
        '
        Me.toolShifting.Image = CType(resources.GetObject("toolShifting.Image"), System.Drawing.Image)
        Me.toolShifting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.toolShifting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolShifting.Name = "toolShifting"
        Me.toolShifting.Size = New System.Drawing.Size(81, 59)
        Me.toolShifting.Text = "F11 - Shifting"
        Me.toolShifting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(6, 62)
        '
        'toolHandling
        '
        Me.toolHandling.Image = CType(resources.GetObject("toolHandling.Image"), System.Drawing.Image)
        Me.toolHandling.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.toolHandling.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolHandling.Name = "toolHandling"
        Me.toolHandling.Size = New System.Drawing.Size(89, 59)
        Me.toolHandling.Text = "F12 - Handling"
        Me.toolHandling.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 62)
        '
        'toolBilling
        '
        Me.toolBilling.Image = CType(resources.GetObject("toolBilling.Image"), System.Drawing.Image)
        Me.toolBilling.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.toolBilling.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolBilling.Name = "toolBilling"
        Me.toolBilling.Size = New System.Drawing.Size(67, 59)
        Me.toolBilling.Text = "F3 - Billing"
        Me.toolBilling.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'pnlMenu
        '
        Me.pnlMenu.Controls.Add(Me.Label1)
        Me.pnlMenu.Controls.Add(Me.treeTaskList)
        Me.pnlMenu.Controls.Add(Me.toolSideMenu)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 86)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(226, 455)
        Me.pnlMenu.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Main Menu"
        '
        'treeTaskList
        '
        Me.treeTaskList.BackColor = System.Drawing.SystemColors.Control
        Me.treeTaskList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeTaskList.ForeColor = System.Drawing.Color.MidnightBlue
        Me.treeTaskList.FullRowSelect = True
        Me.treeTaskList.HotTracking = True
        Me.treeTaskList.ImageIndex = 27
        Me.treeTaskList.ImageList = Me.iListMain
        Me.treeTaskList.Location = New System.Drawing.Point(0, 23)
        Me.treeTaskList.Name = "treeTaskList"
        TreeNode1.ImageKey = "wand.png"
        TreeNode1.Name = "nodeCreation"
        TreeNode1.SelectedImageIndex = 20
        TreeNode1.Text = "Creation"
        TreeNode1.ToolTipText = "Create Container record for discharging, loading, shifting or depot"
        TreeNode2.ImageIndex = 22
        TreeNode2.Name = "nodeContainerUpdate"
        TreeNode2.SelectedImageIndex = 22
        TreeNode2.Text = "Container Update"
        TreeNode3.ImageIndex = 10
        TreeNode3.Name = "nodePCheck"
        TreeNode3.SelectedImageIndex = 10
        TreeNode3.Text = "Physical Check"
        TreeNode3.ToolTipText = "Encode physical checking data of container, eg. seals, damages and over dimension" & _
            ""
        TreeNode4.ImageKey = "page_lightning.png"
        TreeNode4.Name = "nodeInformation"
        TreeNode4.SelectedImageIndex = 14
        TreeNode4.Text = "Information"
        TreeNode4.ToolTipText = "View complete history of container"
        TreeNode5.ImageKey = "stock_zoom-shift-16.png"
        TreeNode5.Name = "nodeHandling"
        TreeNode5.SelectedImageIndex = 21
        TreeNode5.Text = "Yard Handling"
        TreeNode5.ToolTipText = "Execute handling of container"
        TreeNode6.Name = "nodeEmptyDepot"
        TreeNode6.Text = "Empty Depot"
        TreeNode7.Name = "nodeFullExport"
        TreeNode7.Text = "Full Export"
        TreeNode8.Name = "nodeImport"
        TreeNode8.Text = "Import"
        TreeNode9.Name = "nodeRegistered"
        TreeNode9.Text = "Registered"
        TreeNode10.Name = "nodeList"
        TreeNode10.Text = "List"
        TreeNode11.ImageIndex = 5
        TreeNode11.Name = "nodeContainer"
        TreeNode11.SelectedImageIndex = 5
        TreeNode11.Text = "Container"
        TreeNode11.ToolTipText = "Expand to view 'Container' functions"
        TreeNode12.ImageKey = "lc_arrowshapes_011.png"
        TreeNode12.Name = "nodeShifting"
        TreeNode12.SelectedImageIndex = 12
        TreeNode12.Text = "Shifting"
        TreeNode12.ToolTipText = "Shifting or restow"
        TreeNode13.ImageKey = "lc_arrowshapes_013.png"
        TreeNode13.Name = "nodeDischarging"
        TreeNode13.SelectedImageIndex = 13
        TreeNode13.Text = "Discharging"
        TreeNode13.ToolTipText = "Module to discharge container from vessel to terminal"
        TreeNode14.ImageKey = "lc_arrowshapes_006.png"
        TreeNode14.Name = "nodeLoading"
        TreeNode14.SelectedImageIndex = 11
        TreeNode14.Text = "Loading"
        TreeNode14.ToolTipText = "Loads container to pre-stowed vessel location"
        TreeNode15.ImageIndex = 17
        TreeNode15.Name = "nodeVessel"
        TreeNode15.SelectedImageIndex = 17
        TreeNode15.Text = "Vessel Operation"
        TreeNode15.ToolTipText = "Perform vessel operation"
        TreeNode16.ImageKey = "stock_table-align-top.png"
        TreeNode16.Name = "nodeGateIn"
        TreeNode16.SelectedImageIndex = 19
        TreeNode16.Text = "Gate In"
        TreeNode16.ToolTipText = "Receiving of container from outside terminal to yard"
        TreeNode17.ImageKey = "stock_table-align-bottom.png"
        TreeNode17.Name = "nodeGateOut"
        TreeNode17.SelectedImageIndex = 18
        TreeNode17.Text = "Gate Out"
        TreeNode17.ToolTipText = "Delivery of container from outside terminal to yard"
        TreeNode18.ImageKey = "stock_object-infront-16.png"
        TreeNode18.Name = "nodeTruck"
        TreeNode18.SelectedImageIndex = 16
        TreeNode18.Text = "Truck Activity"
        TreeNode18.ToolTipText = "Logs truck's 'Gate-In' and 'Gate-Out'"
        TreeNode19.ImageIndex = 6
        TreeNode19.Name = "nodeCarrier"
        TreeNode19.SelectedImageIndex = 6
        TreeNode19.Text = "Carrier"
        TreeNode19.ToolTipText = "Click to expand 'Carrier' functions for vessel and truck activity"
        TreeNode20.ImageIndex = 7
        TreeNode20.Name = "nodeReports"
        TreeNode20.SelectedImageIndex = 7
        TreeNode20.Text = "Reports"
        TreeNode20.ToolTipText = "On-Demand Reports"
        TreeNode21.ImageIndex = 28
        TreeNode21.Name = "nodeQuay"
        TreeNode21.SelectedImageIndex = 28
        TreeNode21.Text = "Quayside Activity"
        TreeNode21.ToolTipText = "Monitoring quayside activity"
        TreeNode22.Name = "nodeDelivery"
        TreeNode22.Text = "Delivery"
        TreeNode23.Name = "nodeReceiving"
        TreeNode23.Text = "Receiving"
        TreeNode24.ImageKey = "stock_draw-connector-with-arrows-16.png"
        TreeNode24.Name = "nodeGateActivity"
        TreeNode24.SelectedImageIndex = 29
        TreeNode24.Text = "Gate Activity"
        TreeNode24.ToolTipText = "Monitoring gate activity"
        TreeNode25.ImageKey = "sc_dbnewreport.png"
        TreeNode25.Name = "nodeYardInventory"
        TreeNode25.SelectedImageIndex = 22
        TreeNode25.Text = "Yard Inventory"
        TreeNode25.ToolTipText = "Yard inventory as of current time"
        TreeNode26.Name = "nodeStripping"
        TreeNode26.Text = "Stripping"
        TreeNode27.Name = "nodeStuffing"
        TreeNode27.Text = "Stuffing"
        TreeNode28.ImageKey = "stock_reverse-order.png"
        TreeNode28.Name = "nodeYardActivity"
        TreeNode28.Text = "Yard Activity"
        TreeNode29.Name = "nodeJobBookingMonitor"
        TreeNode29.Text = "Job Booking Activity"
        TreeNode30.ImageKey = "chart_curve.png"
        TreeNode30.Name = "nodeMonitoring"
        TreeNode30.SelectedImageIndex = 26
        TreeNode30.Text = "Monitoring"
        TreeNode30.ToolTipText = "Monitoring tools for operations"
        TreeNode31.Name = "nodeCarrierRotation"
        TreeNode31.Text = "Carrier Rotation"
        TreeNode31.ToolTipText = "Vessel port rotation"
        TreeNode32.Name = "nodeCarrierData"
        TreeNode32.Text = "Carrier Data"
        TreeNode32.ToolTipText = "Carrier data on use"
        TreeNode33.Name = "nodeISOCodes"
        TreeNode33.Text = "ISO Codes"
        TreeNode33.ToolTipText = "Container ISO Types"
        TreeNode34.Name = "nodeCountryCodes"
        TreeNode34.Text = "Country Codes"
        TreeNode34.ToolTipText = "Country code worldwide"
        TreeNode35.Name = "nodeLocationCodes"
        TreeNode35.Text = "Location Codes"
        TreeNode35.ToolTipText = "Locations code worldwide"
        TreeNode36.Name = "nodeHEquipment"
        TreeNode36.Text = "Handling Equipment"
        TreeNode36.ToolTipText = "CHE Collection"
        TreeNode37.Name = "nodeLine"
        TreeNode37.Text = "Line Data"
        TreeNode37.ToolTipText = "Shipping Line Data"
        TreeNode38.Name = "nodeAgent"
        TreeNode38.Text = "Agent Data"
        TreeNode38.ToolTipText = "Agent Data Maintenance"
        TreeNode39.Name = "nodeTrucking"
        TreeNode39.Text = "Trucking Company"
        TreeNode39.ToolTipText = "Module for encoding trucking company, trucks and driver information"
        TreeNode40.Name = "nodeColorCoding"
        TreeNode40.Text = "Color Coding"
        TreeNode40.ToolTipText = "Color coding guide"
        TreeNode41.Name = "nodeUser"
        TreeNode41.Text = "User"
        TreeNode41.ToolTipText = "System user maintenance"
        TreeNode42.Name = "nodeCustomer"
        TreeNode42.Text = "Customer"
        TreeNode43.Name = "nodeTariffList"
        TreeNode43.Text = "Tariff List"
        TreeNode44.Name = "nodeDelayCodes"
        TreeNode44.Text = "Delay Codes"
        TreeNode45.ImageKey = "stock_insert-note.png"
        TreeNode45.Name = "nodeBasicData"
        TreeNode45.SelectedImageIndex = 31
        TreeNode45.Text = "Basic Data"
        TreeNode45.ToolTipText = "Terminal Basic Data"
        TreeNode46.ImageKey = "stock_insert-form.png"
        TreeNode46.Name = "nodeSystemOptions"
        TreeNode46.SelectedImageIndex = 30
        TreeNode46.Text = "System Options"
        TreeNode46.ToolTipText = "System and Application Options"
        TreeNode47.ImageIndex = 8
        TreeNode47.Name = "nodeTools"
        TreeNode47.SelectedImageIndex = 8
        TreeNode47.Text = "Tools"
        TreeNode47.ToolTipText = "Tools and Options"
        TreeNode48.Name = "nodeBilling"
        TreeNode48.Text = "Billing"
        TreeNode49.ImageKey = "resultset_next.png"
        TreeNode49.Name = "nodeEDI"
        TreeNode49.SelectedImageIndex = 27
        TreeNode49.Text = "Electronic Data Interchange"
        TreeNode49.ToolTipText = "EDIFact Standard EDI Generator"
        TreeNode50.ImageKey = "resultset_next.png"
        TreeNode50.Name = "nodeJobBooking"
        TreeNode50.SelectedImageIndex = 27
        TreeNode50.Text = "Job Booking"
        TreeNode50.ToolTipText = "Create automated job order request interfaced in Special Services"
        TreeNode51.Name = "nodeRDTViewer"
        TreeNode51.Text = "Remote Terminal"
        TreeNode52.Name = "nodeVesselBuilder"
        TreeNode52.Text = "Vessel Builder"
        TreeNode52.ToolTipText = "Module to create vessel structure and stowage options"
        TreeNode53.ImageIndex = 27
        TreeNode53.Name = "nodeVesselVisit"
        TreeNode53.SelectedImageIndex = 27
        TreeNode53.Text = "Vessel Visit Management"
        TreeNode53.ToolTipText = "System to create and monitor vessel visits and moves"
        TreeNode54.Name = "nodeYardViewer"
        TreeNode54.Text = "Yard Viewer"
        TreeNode55.ImageKey = "application_osx_terminal.png"
        TreeNode55.Name = "nodeApplications"
        TreeNode55.SelectedImageIndex = 25
        TreeNode55.Text = "Applications"
        TreeNode55.ToolTipText = "Applications and modules"
        TreeNode56.ImageKey = "monitor_go.png"
        TreeNode56.Name = "nodeLogOut"
        TreeNode56.SelectedImageIndex = 32
        TreeNode56.Text = "Log Out"
        TreeNode57.ImageKey = "help.png"
        TreeNode57.Name = "nodeHelp"
        TreeNode57.SelectedImageIndex = 9
        TreeNode57.Text = "Help"
        Me.treeTaskList.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode19, TreeNode20, TreeNode47, TreeNode55, TreeNode56, TreeNode57})
        Me.treeTaskList.SelectedImageIndex = 27
        Me.treeTaskList.ShowNodeToolTips = True
        Me.treeTaskList.Size = New System.Drawing.Size(226, 432)
        Me.treeTaskList.TabIndex = 10
        '
        'toolSideMenu
        '
        Me.toolSideMenu.BackColor = System.Drawing.SystemColors.Control
        Me.toolSideMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolSideMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolHideMenu})
        Me.toolSideMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.toolSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.toolSideMenu.Name = "toolSideMenu"
        Me.toolSideMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.toolSideMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.toolSideMenu.Size = New System.Drawing.Size(226, 23)
        Me.toolSideMenu.TabIndex = 2
        Me.toolSideMenu.Text = "ToolStrip2"
        '
        'toolHideMenu
        '
        Me.toolHideMenu.Image = CType(resources.GetObject("toolHideMenu.Image"), System.Drawing.Image)
        Me.toolHideMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolHideMenu.Name = "toolHideMenu"
        Me.toolHideMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.toolHideMenu.Size = New System.Drawing.Size(52, 20)
        Me.toolHideMenu.Text = "Hide"
        '
        'splitParent
        '
        Me.splitParent.Location = New System.Drawing.Point(226, 86)
        Me.splitParent.Name = "splitParent"
        Me.splitParent.Size = New System.Drawing.Size(3, 455)
        Me.splitParent.TabIndex = 17
        Me.splitParent.TabStop = False
        '
        'tabFormControl
        '
        Me.tabFormControl.BackColor = System.Drawing.Color.White
        Me.tabFormControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tabFormControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabFormControl.Image = CType(resources.GetObject("tabFormControl.Image"), System.Drawing.Image)
        Me.tabFormControl.Location = New System.Drawing.Point(229, 86)
        Me.tabFormControl.MessageFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabFormControl.Name = "tabFormControl"
        Me.tabFormControl.SaveReqCancel = "Cancel"
        Me.tabFormControl.SaveReqCaption = "Save changes"
        Me.tabFormControl.SaveReqNo = "&No"
        Me.tabFormControl.SaveReqQuestion = "Save changes to the following items?"
        Me.tabFormControl.SaveReqYes = "&Yes"
        Me.tabFormControl.Size = New System.Drawing.Size(752, 455)
        Me.tabFormControl.TabIndex = 18
        '
        'menuYardViewer
        '
        Me.menuYardViewer.Name = "menuYardViewer"
        Me.menuYardViewer.Size = New System.Drawing.Size(228, 22)
        Me.menuYardViewer.Text = "Yard Viewer"
        '
        'ClientMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(981, 563)
        Me.Controls.Add(Me.tabFormControl)
        Me.Controls.Add(Me.splitParent)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.toolMainFunction)
        Me.Controls.Add(Me.menuMainClient)
        Me.Controls.Add(Me.statusMainClient)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.menuMainClient
        Me.Name = "ClientMain"
        Me.Text = "Port Terminal System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menuMainClient.ResumeLayout(False)
        Me.menuMainClient.PerformLayout()
        Me.statusMainClient.ResumeLayout(False)
        Me.statusMainClient.PerformLayout()
        Me.toolMainFunction.ResumeLayout(False)
        Me.toolMainFunction.PerformLayout()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        Me.toolSideMenu.ResumeLayout(False)
        Me.toolSideMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuHelpContents As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuHelpIndex As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuHelpSearch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tooltipPreview As System.Windows.Forms.ToolTip
    Friend WithEvents stServer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusMainClient As System.Windows.Forms.StatusStrip
    Friend WithEvents menuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSystem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuMainClient As System.Windows.Forms.MenuStrip
    Friend WithEvents menuTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuContainer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCarrier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuVessel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuLoading As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuDischarging As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TruckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuGateIn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuGateOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCreation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuMonitoring As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuGateActivity As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuQuay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BasicDataToolItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuPCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuInformation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuHandling As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SepToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuCarrierRotation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCarrierData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuISOCodes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCountryCodes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuLocationCodes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuHEquipment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuLine As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAgent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuReports As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuTrucking As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents iListMain As System.Windows.Forms.ImageList
    Friend WithEvents menuColorCoding As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolMainFunction As System.Windows.Forms.ToolStrip
    Friend WithEvents toolCreation As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolInformation As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolGateIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolGateOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolLoading As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolDischarging As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolShifting As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents pnlMenu As System.Windows.Forms.Panel
    Friend WithEvents splitParent As System.Windows.Forms.Splitter
    Friend WithEvents toolSideMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents toolHideMenu As System.Windows.Forms.ToolStripButton
    Friend WithEvents treeTaskList As System.Windows.Forms.TreeView
    Friend WithEvents stDatabase As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stUserId As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stDateLog As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stTimeLog As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents toolShowMenu As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents toolHandling As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuShifting As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuApplications As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuLogOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEDI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuVesselVisit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuVesselBuilder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuJobBooking As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuYardActivity As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuStripping As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuStuffing As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuInventory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuContainerUpdate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEmptyDepot As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuFullExport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuImport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuRegistered As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuDelivery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuReceiving As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCustomer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuJobBookingMonitor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolJobBooking As System.Windows.Forms.ToolStripButton
    Friend WithEvents ServiceBillingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolBilling As System.Windows.Forms.ToolStripButton
    Friend WithEvents menuTariffList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuRDTViewer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabFormControl As WinControl.WinControl
    Friend WithEvents menuDelayCodes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuYardViewer As System.Windows.Forms.ToolStripMenuItem

End Class
