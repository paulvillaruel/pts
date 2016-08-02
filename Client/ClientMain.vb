Imports System.Windows.Forms
Imports System.data.SqlClient
Imports VB = Microsoft.VisualBasic
Imports System.Diagnostics
Imports WinControl


Public Class ClientMain

    '
    'ClientMain
    '
    'Rewritten: 1 October 2007 1009
    'Paul Jeremy N. Villaruel
    '
    'Revise: Tab MDI form
    'Paul Jeremy N. Villaruel
    '

    ' Inheritance from Windows
    Inherits System.Windows.Forms.Form
    Private m_ChildFormNumber As Integer = 0
    Public YardGatesApplication As New Gates.clsYardGates
    Public SystemCoreApplication As New Core.clsMain
    Private isClosing As Boolean = False
    Private Invoicing As Invoicing.Invoice
    Private m_rdtViewer As RDTViewer
    Private m_YardViewer As YardOutLook.YardViewer


    Public applicationMast As String = ""

    ' Nodes and tab children
    Private allNodes As List(Of TreeNode)
    Private thisAction As NodeAction

    'Node Action Enums
    Private Enum NodeAction
        None
        CREATION
        PCHECK
        INFORMATION
        JOBBOOKING
        JOBBOOKINGMONITOR
        HANDLING
        SHIFTING
        DISCHARGING
        LOADING
        GATEIN
        GATEOUT
        YARDMOVEMENT
        YARDINVENTORY
        STATISTICS
        MONITORING
        GATEACTIVITY
        QUAY
        STRIPPING
        STUFFING
        DELIVERY
        RECEIVING
        CONTAINERUPDATE
        ISOCODES
        COUNTRYCODES
        LOCATIONCODES
        HEQUIPMENT
        LINE
        AGENT
        CUSTOMER
        TRUCKING
        COLORCODING
        USER
        SYSTEMOPTIONS
        EDI
        VESSELVISIT
        AJORS
        REPORTS
        VESSELBUILDER
        CARRIERROTATION
        CARRIERDATA
        EMPTYDEPOT
        FULLEXPORT
        IMPORT
        REGISTERED
        TARIFFLIST
        BILLING
        RDTVIEWER
        HELP
        ABOUT
        DELAYCODES
        YARDVIEWER
    End Enum

    'NodeInfo class
    Private Class NodeInfo

        Public Property NodeAction() As NodeAction
            Get
                Return m_NodeAction
            End Get
            Set(ByVal value As NodeAction)
                m_NodeAction = Value
            End Set
        End Property
        Private m_NodeAction As NodeAction

        Public Property Params() As Object()
            Get
                Return m_Params
            End Get
            Set(ByVal value As Object())
                m_Params = Value
            End Set
        End Property
        Private m_Params As Object()

        Public Property Form() As Form
            Get
                Return m_Form
            End Get
            Set(ByVal value As Form)
                m_Form = Value
            End Set
        End Property
        Private m_Form As Form

        Public Sub New()
            NodeAction = NodeAction.None
            Params = Nothing
            Form = Nothing
        End Sub

        Public Sub New(ByVal nodeAction__1 As NodeAction)
            NodeAction = nodeAction__1
            Params = Nothing
            Form = Nothing
        End Sub
    End Class

    'Method invocation for Wintab controller main
    Private Sub showTabForm(ByVal targetForm As Windows.Forms.Form, _
                            ByVal node As TreeNode)

        Dim nodeInfo As NodeInfo = TryCast(node.Tag, NodeInfo)

        If Not nodeInfo Is Nothing Then

            If Not targetForm Is Nothing Then

                Dim itfWin As IWinControllable = TryCast(targetForm, IWinControllable)
                If Not itfWin Is Nothing Then
                    itfWin.WinInfo = New WinInfo()
                    itfWin.WinInfo.TreeNode = node
                End If

                AddHandler targetForm.FormClosed, AddressOf childFormClosed
                nodeInfo.Form = targetForm

                tabFormControl.AddForm(targetForm, "", iListMain.Images("application_side_list.png"))

            End If
        End If

    End Sub

    'childFormClosed event
    Private Sub childFormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)

        Dim itfWin As IWinControllable = TryCast(sender, IWinControllable)
        Dim treeNode As TreeNode = If(itfWin Is Nothing OrElse itfWin.WinInfo Is Nothing, Nothing, itfWin.WinInfo.TreeNode)
        If treeNode Is Nothing Then
            For Each node As TreeNode In allNodes
                Dim nodeInfo As NodeInfo = TryCast(node.Tag, NodeInfo)
                If nodeInfo IsNot Nothing AndAlso nodeInfo.Form Is sender Then
                    nodeInfo.Form = Nothing
                    Exit For
                End If
            Next
        Else
            Dim nodeInfo As NodeInfo = TryCast(treeNode.Tag, NodeInfo)
            If nodeInfo IsNot Nothing Then
                nodeInfo.Form = Nothing
            End If
        End If
    End Sub


    Private Sub initializeNodeActions()
        allNodes.Clear()
        Dim nodTable As New TreeNode

        'Dim values = [Enum].GetValues(GetType(NodeAction))()

        '        For Each value As NodeAction In values

        nodTable.Nodes.Add(New TreeNode("CREATION")) : nodTable.Tag = New NodeInfo(NodeAction.CREATION) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("PCHECK")) : nodTable.Tag = New NodeInfo(NodeAction.PCHECK) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("INFORMATION")) : nodTable.Tag = New NodeInfo(NodeAction.INFORMATION) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("JOBBOOKING")) : nodTable.Tag = New NodeInfo(NodeAction.JOBBOOKING) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("JOBBOOKINGMONITOR")) : nodTable.Tag = New NodeInfo(NodeAction.JOBBOOKINGMONITOR) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("HANDLING")) : nodTable.Tag = New NodeInfo(NodeAction.HANDLING) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("SHIFTING")) : nodTable.Tag = New NodeInfo(NodeAction.SHIFTING) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("DISCHARGING")) : nodTable.Tag = New NodeInfo(NodeAction.DISCHARGING) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("LOADING")) : nodTable.Tag = New NodeInfo(NodeAction.LOADING) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("GATEIN")) : nodTable.Tag = New NodeInfo(NodeAction.GATEIN) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("GATEOUT")) : nodTable.Tag = New NodeInfo(NodeAction.GATEOUT) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("YARDMOVEMENT")) : nodTable.Tag = New NodeInfo(NodeAction.YARDMOVEMENT) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("YARDINVENTORY")) : nodTable.Tag = New NodeInfo(NodeAction.YARDINVENTORY) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("STATISTICS")) : nodTable.Tag = New NodeInfo(NodeAction.STATISTICS) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("MONITORING")) : nodTable.Tag = New NodeInfo(NodeAction.MONITORING) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("GATEACTIVITY")) : nodTable.Tag = New NodeInfo(NodeAction.GATEACTIVITY) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("QUAY")) : nodTable.Tag = New NodeInfo(NodeAction.QUAY) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("STRIPPING")) : nodTable.Tag = New NodeInfo(NodeAction.STRIPPING) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("STUFFING")) : nodTable.Tag = New NodeInfo(NodeAction.STUFFING) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("DELIVERY")) : nodTable.Tag = New NodeInfo(NodeAction.DELIVERY) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("RECEIVING")) : nodTable.Tag = New NodeInfo(NodeAction.RECEIVING) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("CONTAINERUPDATE")) : nodTable.Tag = New NodeInfo(NodeAction.CONTAINERUPDATE) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("ISOCODES")) : nodTable.Tag = New NodeInfo(NodeAction.ISOCODES) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("COUNTRYCODES")) : nodTable.Tag = New NodeInfo(NodeAction.COUNTRYCODES) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("LOCATIONCODES")) : nodTable.Tag = New NodeInfo(NodeAction.LOCATIONCODES) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("HEQUIPMENT")) : nodTable.Tag = New NodeInfo(NodeAction.HEQUIPMENT) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("LINE")) : nodTable.Tag = New NodeInfo(NodeAction.LINE) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("AGENT")) : nodTable.Tag = New NodeInfo(NodeAction.AGENT) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("CUSTOMER")) : nodTable.Tag = New NodeInfo(NodeAction.CUSTOMER) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("TRUCKING")) : nodTable.Tag = New NodeInfo(NodeAction.TRUCKING) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("COLORCODING")) : nodTable.Tag = New NodeInfo(NodeAction.COLORCODING) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("USER")) : nodTable.Tag = New NodeInfo(NodeAction.USER) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("SYSTEMOPTIONS")) : nodTable.Tag = New NodeInfo(NodeAction.SYSTEMOPTIONS) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("EDI")) : nodTable.Tag = New NodeInfo(NodeAction.EDI) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("VESSELVISIT")) : nodTable.Tag = New NodeInfo(NodeAction.VESSELVISIT) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("AJORS")) : nodTable.Tag = New NodeInfo(NodeAction.AJORS) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("REPORTS")) : nodTable.Tag = New NodeInfo(NodeAction.REPORTS) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("VESSELBUILDER")) : nodTable.Tag = New NodeInfo(NodeAction.VESSELBUILDER) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("CARRIERROTATION")) : nodTable.Tag = New NodeInfo(NodeAction.CARRIERROTATION) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("CARRIERDATA")) : nodTable.Tag = New NodeInfo(NodeAction.CARRIERDATA) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("EMPTYDEPOT")) : nodTable.Tag = New NodeInfo(NodeAction.EMPTYDEPOT) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("FULLEXPORT")) : nodTable.Tag = New NodeInfo(NodeAction.FULLEXPORT) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("IMPORT")) : nodTable.Tag = New NodeInfo(NodeAction.IMPORT) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("REGISTERED")) : nodTable.Tag = New NodeInfo(NodeAction.REGISTERED) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("TARIFFLIST")) : nodTable.Tag = New NodeInfo(NodeAction.TARIFFLIST) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("BILLING")) : nodTable.Tag = New NodeInfo(NodeAction.BILLING) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("RDTVIEWER")) : nodTable.Tag = New NodeInfo(NodeAction.RDTVIEWER) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("YARDVIEWER")) : nodTable.Tag = New NodeInfo(NodeAction.YARDVIEWER) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("HELP")) : nodTable.Tag = New NodeInfo(NodeAction.HELP) : allNodes.Add(nodTable)
        nodTable.Nodes.Add(New TreeNode("ABOUT")) : nodTable.Tag = New NodeInfo(NodeAction.ABOUT) : allNodes.Add(nodTable)


    End Sub

    Public Sub OpenMain()
        Me.Show()
    End Sub


    Public Sub New()
        InitializeComponent()
    End Sub



    Private Sub ClientMain_Load(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles Me.Load
        Me.IsMdiContainer = True

        allNodes = New List(Of TreeNode)()
        initializeNodeActions()

        ' tabFormControl.MessageText = applicationMast

    End Sub


    Private Sub ClientMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim frmLogIn As New Login

        ' To do:
        ' Yes: User log off
        ' No: Application exit
        ' Cancel : Do nothing

        If isClosing Then
            Return
        End If

        If MessageBox.Show("Are you sure you want to log off and exit from the program?", _
        "Logging off from PTS", _
        MessageBoxButtons.YesNo, _
        MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            '
            ' Write codes to log off here
            '
            isClosing = True
            Me.Hide()


            Dim processesReporter() As Process = Process.GetProcessesByName("Reporter")
            Dim processesVesselVisit() As Process = Process.GetProcessesByName("VesselVisitManagement")

            For Each pR As Process In processesReporter
                pR.Kill()
                pR.WaitForExit()
            Next

            For Each pV As Process In processesVesselVisit
                pV.Kill()
                pV.WaitForExit()
            Next

            Global.System.Windows.Forms.Application.Exit()

        Else

            e.Cancel = True

        End If
    End Sub


    ' Shortcut keydown events
    Private Sub frmData_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown


        Select Case e.KeyCode

            Case Keys.F1
                toolCreation.PerformClick()

            Case Keys.F2
                toolInformation.PerformClick()

            Case Keys.F3
                toolBilling.PerformClick()

            Case Keys.F5
                toolGateIn.PerformClick()

            Case Keys.F6
                toolGateOut.PerformClick()

            Case Keys.F8
                Me.toolJobBooking.PerformClick()

            Case Keys.F9
                toolLoading.PerformClick()

            Case Keys.F10
                toolDischarging.PerformClick()

            Case Keys.F11
                Me.toolShifting.PerformClick()

            Case Keys.F12
                Me.toolHandling.PerformClick()

        End Select

    End Sub


    '
    ' Catch the mouse up event of treeview
    ' then get the node of mouse event args by point X,Y
    '
    Private Sub treeTaskList_MouseUp(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.MouseEventArgs) Handles treeTaskList.MouseUp

        Dim nodeSelect As TreeNode = _
        treeTaskList.GetNodeAt(e.X, e.Y)

        GetChildFunction(VB.Mid(nodeSelect.Name, _
        5, Len(nodeSelect.Name) - 4).ToUpper)

    End Sub

    Private Function isUserAuthorized(ByVal moduleId As String, ByVal userId As String) As Integer

        Dim PTSConn As SqlConnection
        Dim retVal As Integer = 0

        Try

            PTSConn = New SqlConnection(Login.ConnStr)
            Dim commandPTS As New SqlCommand("bas_isUserAuthorized", PTSConn)
            PTSConn.Open()
            With commandPTS
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@moduleId", moduleId)
                .Parameters.AddWithValue("@userId", userId)
                .Parameters.AddWithValue("@ipAddr", Environment.MachineName.ToString)
                .Parameters.AddWithValue("@appType", Login.APP_TYPE.ToString)
                retVal = .ExecuteScalar()
            End With
            PTSConn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return retVal

    End Function

    '
    ' Method: GetChildFunction
    ' 

    Private Sub GetChildFunction(ByVal strModule As String)

        Dim thisForm As Form = Nothing
        Dim thisNode As TreeNode

        If isUserAuthorized(strModule, Login.mUser) = 0 Then _
            MsgBox("Access Denied. Please contact systems administrator.", _
                vbExclamation, "Access Denied") : Exit Sub

        Try

            Me.Cursor = Cursors.AppStarting
            Select Case strModule

                'CONTAINER

                Case Is = "CREATION"

                    thisForm = SystemCoreApplication.CallCoreModule( _
                    Core.clsMain.CoreModules.ContainerCreation, _
                    Login.ConnStr, Login.mUser, Me)


                Case Is = "PCHECK"

                    thisForm = SystemCoreApplication.CallCoreModule( _
                    Core.clsMain.CoreModules.PCheck, _
                    Login.ConnStr, Login.mUser, Me)

                Case Is = "INFORMATION"

                    With YardGatesApplication
                        .BillingConnectionString = _
                        Login.ConnStrBilling
                        .PTSConnectionString = Login.ConnStr
                        .SystemUserId = Login.mUser
                        .InitializeTerminalDefault()
                        thisForm = .CallYardGatesModule( _
                       Gates.clsYardGates.YardGateModule.ContainerInformation, Me)
                    End With

                Case Is = "JOBBOOKING"
                    With YardGatesApplication
                        .BillingConnectionString = Login.ConnStrBilling
                        .PTSConnectionString = Login.ConnStr
                        .SystemUserId = Login.mUser
                        .InitializeTerminalDefault()
                        thisForm = .CallYardGatesModule( _
                        Gates.clsYardGates.YardGateModule.JobBooking, Me)
                    End With

                Case Is = "JOBBOOKINGMONITOR"
                    With YardGatesApplication
                        .BillingConnectionString = Login.ConnStrBilling
                        .PTSConnectionString = Login.ConnStr
                        .SystemUserId = Login.mUser
                        .InitializeTerminalDefault()
                        thisForm = .CallYardGatesModule( _
                        Gates.clsYardGates.YardGateModule.JobBookingMonitor, Me)
                    End With



                Case Is = "HANDLING"


                    With YardGatesApplication
                        .BillingConnectionString = Login.ConnStrBilling
                        .PTSConnectionString = Login.ConnStr
                        .SystemUserId = Login.mUser
                        .InitializeTerminalDefault()
                        thisForm = .CallYardGatesModule( _
                        Gates.clsYardGates.YardGateModule.ContainerHandling, Me)
                    End With

                    'CARRIER

                    'VESSEL

                Case Is = "SHIFTING"

                    thisForm = SystemCoreApplication.CallCoreModule( _
                    Core.clsMain.CoreModules.VesselShifting, _
                    Login.ConnStr, Login.mUser, Me)

                Case Is = "DISCHARGING"

                    thisForm = SystemCoreApplication.CallCoreModule( _
                    Core.clsMain.CoreModules.VesselDischarging, _
                    Login.ConnStr, Login.mUser, Me)

                Case Is = "LOADING"

                    thisForm = SystemCoreApplication.CallCoreModule( _
                    Core.clsMain.CoreModules.VesselLoading, _
                    Login.ConnStr, Login.mUser, Me)


                Case Is = "GATEIN"

                    With YardGatesApplication
                        .BillingConnectionString = Login.ConnStrBilling
                        .PTSConnectionString = Login.ConnStr
                        .SystemUserId = Login.mUser
                        .InitializeTerminalDefault()
                        thisForm = .CallYardGatesModule(Gates.clsYardGates.YardGateModule.GateIn, Me)
                    End With

                Case Is = "GATEOUT"

                    With YardGatesApplication
                        .BillingConnectionString = Login.ConnStrBilling
                        .PTSConnectionString = Login.ConnStr
                        .SystemUserId = Login.mUser
                        .InitializeTerminalDefault()
                        thisForm = .CallYardGatesModule(Gates.clsYardGates.YardGateModule.GateOut, Me)
                    End With

                    'REPORTS
                Case Is = "YARDMOVEMENT"
                Case Is = "YARDINVENTORY"

                    With YardGatesApplication
                        .BillingConnectionString = Login.ConnStrBilling
                        .PTSConnectionString = Login.ConnStr
                        .SystemUserId = Login.mUser
                        .InitializeTerminalDefault()
                        thisForm = .CallYardGatesModule(Gates.clsYardGates.YardGateModule.YardInventory, Me)
                    End With

                Case Is = "STATISTICS"

                    'TOOLS
                Case Is = "MONITORING"
                Case Is = "GATEACTIVITY"
                Case Is = "QUAY"


                Case Is = "STRIPPING"
                    With YardGatesApplication
                        .BillingConnectionString = Login.ConnStrBilling
                        .PTSConnectionString = Login.ConnStr
                        .SystemUserId = Login.mUser
                        .InitializeTerminalDefault()
                        thisForm = .CallYardGatesModule(Gates.clsYardGates.YardGateModule.Stripping, Me)
                    End With

                Case Is = "STUFFING"
                    With YardGatesApplication
                        .BillingConnectionString = Login.ConnStrBilling
                        .PTSConnectionString = Login.ConnStr
                        .SystemUserId = Login.mUser
                        .InitializeTerminalDefault()
                        thisForm = .CallYardGatesModule(Gates.clsYardGates.YardGateModule.Stuffing, Me)
                    End With


                Case Is = "DELIVERY"
                    With YardGatesApplication
                        .BillingConnectionString = Login.ConnStrBilling
                        .PTSConnectionString = Login.ConnStr
                        .SystemUserId = Login.mUser
                        .InitializeTerminalDefault()
                        thisForm = .CallYardGatesModule(Gates.clsYardGates.YardGateModule.Delivery, Me)
                    End With

                Case Is = "RECEIVING"
                    With YardGatesApplication
                        .BillingConnectionString = Login.ConnStrBilling
                        .PTSConnectionString = Login.ConnStr
                        .SystemUserId = Login.mUser
                        .InitializeTerminalDefault()
                        thisForm = .CallYardGatesModule(Gates.clsYardGates.YardGateModule.Receiving, Me)
                    End With



                    'BASICDATA

                Case Is = "CONTAINERUPDATE"

                    '
                    ' allow modid:CONTAINEREXUPDATE
                    '

                    Dim boolContainerIsExecuted As Boolean = False
                    boolContainerIsExecuted = isUserAuthorized("CONTAINEREXUPDATE", Login.mUser)

                    thisForm = SystemCoreApplication.CallCoreModule( _
                    Core.clsMain.CoreModules.ContainerUpdate, _
                    Login.ConnStr, Login.mUser, Me, IncludeExeContainers:=boolContainerIsExecuted)


                Case Is = "ISOCODES"
                Case Is = "COUNTRYCODES"
                Case Is = "LOCATIONCODES"
                Case Is = "HEQUIPMENT"

                Case Is = "LINE"

                    thisForm = SystemCoreApplication.CallCoreModule( _
                    Core.clsMain.CoreModules.Lines, _
                    Login.ConnStr, Login.mUser, Me)

                Case Is = "AGENT"

                    thisForm = SystemCoreApplication.CallCoreModule( _
                    Core.clsMain.CoreModules.Agent, _
                    Login.ConnStr, Login.mUser, Me)


                Case Is = "CUSTOMER"

                    thisForm = SystemCoreApplication.CallCoreModule( _
                    Core.clsMain.CoreModules.Customer, _
                    Login.ConnStr, Login.mUser, Me)

                Case Is = "TRUCKING"

                    thisForm = SystemCoreApplication.CallCoreModule( _
                    Core.clsMain.CoreModules.TruckDriver, _
                    Login.ConnStr, Login.mUser, Me)

                Case Is = "COLORCODING"

                    thisForm = SystemCoreApplication.CallCoreModule( _
                    Core.clsMain.CoreModules.ColorCoding, _
                    Login.ConnStr, Login.mUser, Me)

                Case Is = "USER"

                    thisForm = SystemCoreApplication.CallCoreModule( _
                    Core.clsMain.CoreModules.Users, _
                    Login.ConnStr, Login.mUser, Me)

                Case Is = "SYSTEMOPTIONS"

                    'APPLICATIONS"

                Case Is = "EDI", "VESSELVISIT", "AJORS", "REPORTS" _
                   : LaunchApplicationByProcess(strModule)

                Case Is = "VESSELBUILDER", "CARRIERROTATION", "CARRIERDATA"

                    thisForm = SystemCoreApplication.CallCoreModule( _
                    Core.clsMain.CoreModules.VesselBuilder, _
                    Login.ConnStr, Login.mUser, Me)

                Case Is = "EMPTYDEPOT"

                    thisForm = SystemCoreApplication.CallCoreModule( _
                    Core.clsMain.CoreModules.DepotListEmpty, _
                    Login.ConnStr, Login.mUser, Me)

                Case Is = "FULLEXPORT"

                    thisForm = SystemCoreApplication.CallCoreModule( _
                    Core.clsMain.CoreModules.DepotListFull, _
                    Login.ConnStr, Login.mUser, Me)

                Case Is = "IMPORT"

                    thisForm = SystemCoreApplication.CallCoreModule( _
                    Core.clsMain.CoreModules.Import, _
                    Login.ConnStr, Login.mUser, Me)

                Case Is = "REGISTERED"

                    thisForm = SystemCoreApplication.CallCoreModule( _
                    Core.clsMain.CoreModules.Registered, _
                    Login.ConnStr, Login.mUser, Me)

                Case Is = "TARIFFLIST"

                    thisForm = SystemCoreApplication.CallCoreModule( _
                    Core.clsMain.CoreModules.TariffList, _
                    Login.ConnStr, Login.mUser, Me)

                Case Is = "BILLING"

                    Invoicing = New Invoicing.Invoice

                    'With Invoicing
                    '    .BillingConnectionString = Login.ConnStr
                    '    .UserId = Login.mUser
                    '    .MdiParent = Me
                    '    .Show()
                    '    .WindowState = FormWindowState.Minimized
                    '    .WindowState = FormWindowState.Maximized
                    'End With

                    Invoicing.BillingConnectionString = Login.ConnStr
                    Invoicing.UserId = Login.mUser
                    thisForm = Invoicing


                Case Is = "RDTVIEWER"

                    m_rdtViewer = New RDTViewer
                    thisForm = m_rdtViewer

                    'With m_rdtViewer
                    '    .MdiParent = Me
                    '    .Show()
                    'End With

                    ' method passing formControl to WinFormTabControl

                    'Dim rdtNode As TreeNode = New TreeNode("RDT Viewer")
                    'rdtNode.Tag = New NodeInfo(NodeAction.Action1)
                    'showTabForm(m_rdtViewer, rdtNode)

                Case Is = "YARDVIEWER"

                    m_YardViewer = New YardOutLook.YardViewer
                    m_YardViewer.YardViewerConnectionString = Login.ConnStr
                    m_YardViewer.GraphicsDirectoryPath = Login.mGraphicsPath

                    thisForm = m_YardViewer


                Case Is = "HELP"
                    MsgBox("To request for help documentation or technical support, please call IT Department.", MsgBoxStyle.Information, "Help")

                Case Is = "ABOUT"
                    Dim about As New UIAbout
                    about.ShowDialog()

                Case Is = "EXIT", "LOGOUT"

                    ClientMain_FormClosing(Me, Nothing)


                Case Is = "DELAYCODES"

                    thisForm = SystemCoreApplication.CallCoreModule( _
                    Core.clsMain.CoreModules.DelayCodes, _
                    Login.ConnStr, Login.mUser, Me)

            End Select


            thisAction = DirectCast([Enum].Parse(GetType(NodeAction), strModule), NodeAction)
            thisNode = New TreeNode(strModule)
            thisNode.Tag = New NodeInfo(thisAction)

            If Not (thisNode Is Nothing And (thisForm Is Nothing And thisForm.Text = "")) Then
                showTabForm(thisForm, thisNode)
            End If

        Catch nullRefEx As NullReferenceException

        Catch sysArgEx As System.ArgumentException

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error opening module")
        End Try

        Me.Cursor = Cursors.Default

    End Sub




    '
    ' Use process to open the program, retrieve file
    '
    Private Sub LaunchApplicationByProcess( _
    ByVal strAppName As String)

        Dim appFileExists As Boolean
        Dim appFilePathExecutable As String = ""
        Dim openFileDialogExecutable As New OpenFileDialog

        Select Case strAppName
            Case "EDI" : appFilePathExecutable = Login.mEdiAppPath
            Case "VESSELVISIT" : appFilePathExecutable = Login.mVesselVisitAppPath
            Case "AJORS" : appFilePathExecutable = Login.mAJORSAppPath
            Case "REPORTS" : appFilePathExecutable = Login.mReportsPath
            Case Else
        End Select

        appFileExists = My.Computer.FileSystem.FileExists(appFilePathExecutable)

        If appFileExists Then
            Process.Start(appFilePathExecutable)
        Else

            With openFileDialogExecutable
                .Filter = "Executable file (*.exe)|*.exe|All files (*.*)|*.*"
                .Title = "Open the executable file..."
            End With

            If openFileDialogExecutable.ShowDialog() _
            = Windows.Forms.DialogResult.OK Then
                Process.Start(openFileDialogExecutable.FileName)
            End If
        End If

    End Sub


    '
    ' Handler sub that will effect all calling buttons, menu
    '

    Private Sub MenuItemClient_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles _
        menuLogOut.Click, _
        menuExit.Click, _
        menuCreation.Click, _
        menuPCheck.Click, _
        menuInformation.Click, _
        menuHandling.Click, _
        menuShifting.Click, _
        menuLoading.Click, _
        menuDischarging.Click, _
        menuGateIn.Click, _
        menuGateOut.Click, _
 _
 _
        menuGateActivity.Click, _
        menuQuay.Click, _
        menuCarrierRotation.Click, _
        menuCarrierData.Click, _
        menuISOCodes.Click, _
        menuCountryCodes.Click, _
        menuLocationCodes.Click, _
        menuHEquipment.Click, _
        menuLine.Click, _
        menuAgent.Click, _
        menuTrucking.Click, _
        menuColorCoding.Click, _
        menuUser.Click, _
        menuEDI.Click, _
        menuVesselVisit.Click, _
        menuVesselBuilder.Click, _
        menuJobBooking.Click, _
        menuHelpContents.Click, _
        menuHelpIndex.Click, _
        menuAbout.Click, _
        toolCreation.Click, _
        toolInformation.Click, _
        toolGateIn.Click, _
        toolGateOut.Click, _
        toolLoading.Click, _
        toolDischarging.Click, _
        toolShifting.Click, _
        toolHandling.Click, _
        toolJobBooking.Click, _
        menuStripping.Click, _
        menuStuffing.Click, _
        menuContainerUpdate.Click, _
        menuEmptyDepot.Click, _
        menuFullExport.Click, _
        menuCustomer.Click, menuTariffList.Click, toolBilling.Click, _
        menuRDTViewer.Click, menuDelayCodes.Click, menuYardViewer.Click

        GetChildFunction(VB.Mid(sender.Name, 5, Len(sender.Name) - 4).ToUpper)

    End Sub



    Private Sub toolHideMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolHideMenu.Click
        pnlMenu.Visible = False
        toolShowMenu.Visible = True
    End Sub


    Private Sub toolShowMenu_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolShowMenu.ButtonClick
        pnlMenu.Visible = True
        toolShowMenu.Visible = False
    End Sub




End Class
