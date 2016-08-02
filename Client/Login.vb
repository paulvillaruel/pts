Imports System.Data.SqlClient
Imports System.Data
Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Threading
Imports Microsoft.Win32
Imports System.IO
Imports System.Configuration.ConfigurationSettings

Public Class Login

    '
    ' Billing connection
    '

    Public Shared ConnStrBilling
    Public Shared mBillingServer
    Public Shared mBillingDatabase
    Public Shared mBillingUser

    '
    ' PTS Connection properties
    '

    Public Shared ConnStr
    Public Shared mServer
    Public Shared mDatabase
    Public Shared mUser
    Public Shared pSqlEnvironIndex As Integer

    Public Shared mEdiAppPath As String
    Public Shared mVesselVisitAppPath As String
    Public Shared mAJORSAppPath As String
    Public Shared mReportsPath As String
    Public Shared mGraphicsPath As String

    Const sKeyName As String = "Port Terminal System"
    Private sTerminalName As String = ""
    Private sVersion As String = ""

    Public APP_TYPE As String = "PTSWIN"

    Dim kKeyReg As Microsoft.Win32.RegistryKey
    Dim oRegistry As RegistryConfiguration.RegistrySettings
    Dim connSQLEnvironment As SqlConnection


#Region "Ini Reader Changes"



    Public Sub readIniApplicationSettings()

        Dim iniFilePath As String = Application.StartupPath.ToString & "\" & "mpct_pts_settings.ini"
        Dim iniReader As New RegistryConfiguration.Org.IniReader.Files.IniReader(iniFilePath)

        With iniReader

            .Section = "Connections"
            pSqlEnvironIndex = .ReadInteger("SQLVersionIndex")

            '
            ' PTS Connection
            '
            .Section = "Connections\PTS"
            If Not .ReadInteger("AllowNTLog") = 0 Then

                If pSqlEnvironIndex = 2 Then
                    ConnStr = "DRIVER={SQL Native Client};SERVER=" & _
                        Trim(.ReadString("Server")) & ";" & _
                        "DATABASE=" & Trim(.ReadString("Database")) & _
                        ";" & "Integrated Security=True"
                Else
                    ConnStr = "SERVER=" & Trim(.ReadString("Server")) & ";" & _
                    "DATABASE=" & Trim(.ReadString("Database")) & ";" & _
                    "Integrated Security=True"
                End If
            Else
                If pSqlEnvironIndex = 2 Then
                    ConnStr = "DRIVER={SQL Native Client};SERVER=" & Trim(.ReadString("Server")) & ";" & _
                    "DATABASE=" & Trim(.ReadString("Database")) & ";" & "USER=" & Trim(.ReadString("UserId")) & ";" & _
                    "PASSWORD=" & Trim(.ReadString("Password"))

                Else
                    ConnStr = "SERVER=" & Trim(.ReadString("Server")) & ";" & _
                    "DATABASE=" & Trim(.ReadString("Database")) & ";" & "USER=" & _
                    Trim(.ReadString("UserId")) & ";" & _
                    "PASSWORD=" & Trim(.ReadString("Password"))

                End If
            End If


            mServer = Trim(.ReadString("Server"))
            mDatabase = Trim(.ReadString("Database"))


            '
            ' Billing Connection
            '

            .Section = "Connections\Billing"
            mBillingServer = Trim(.ReadString("BillingServer"))
            mBillingDatabase = Trim(.ReadString("BillingDatabase"))

            If Not .ReadInteger("BillingAllowNT") = 0 Then
                ConnStrBilling = "SERVER=" & mBillingServer & ";" & _
                "DATABASE=" & mBillingDatabase & ";" & "Integrated Security=True"
            Else
                ConnStrBilling = "SERVER=" & mBillingServer & ";" & _
                "DATABASE=" & mBillingDatabase & ";" & "USER=" & Trim(.ReadString("BillingUser")) & ";" & _
                "PASSWORD=" & Trim(.ReadString("BillingPassword"))
            End If


            '
            ' Application paths
            '
            .Section = "Applications"
            mVesselVisitAppPath = Trim(.ReadString("VesselVisitManagement"))
            mAJORSAppPath = Trim(.ReadString("AJORS"))
            mReportsPath = Trim(.ReadString("Reporter"))


            '
            ' EDI
            '
            .Section = "\EDI"
            mEdiAppPath = Trim(.ReadString("EDIAppPath"))



            '
            ' APPName
            '

            .Section = "PortTerminalSystem"
            sVersion = Trim(.ReadString("Version"))

            .Section = "Terminal"
            sTerminalName = Trim(.ReadString("PrintTerminalLabel"))


            '
            ' Graphics
            '
            .Section = "Graphics"
            mGraphicsPath = Trim(.ReadString("ImagesPath"))

            '
            'Reset to windows normal size
            '
            Me.Size = New Size(350, 180)


        End With

    End Sub

#End Region

    Public Sub _ReadRegistryApplicationSettings()

        Try

            Dim sKeyNameTemp As String

            oRegistry = New RegistryConfiguration.RegistrySettings

            With oRegistry

                sKeyNameTemp = sKeyName ' & "\Connections"
                sVersion = .GetRegistryValue(sKeyNameTemp, "Version")

                sKeyNameTemp = sKeyName & "\Terminal"
                sTerminalName = .GetRegistryValue(sKeyNameTemp, "PrintTerminalLabel")
                Dim pathLogo As String = .GetRegistryValue(sKeyNameTemp, "CompanyLogo")
                logoTerminal.Image = Image.FromFile(pathLogo)

                sKeyNameTemp = sKeyName & "\Connections"
                pSqlEnvironIndex = CInt(.GetRegistryValue(sKeyNameTemp, "SQLVersionIndex"))

                '
                ' PTS Connection
                '
                sKeyNameTemp = sKeyName & "\Connections\PTS"
                If Not .GetRegistryValue(sKeyNameTemp, "AllowNTLog") = 0 Then
                    If pSqlEnvironIndex = 2 Then
                        ConnStr = "DRIVER={SQL Native Client};SERVER=" & Trim(.GetRegistryValue(sKeyNameTemp, "Server")) & ";" & _
                        "DATABASE=" & Trim(.GetRegistryValue(sKeyNameTemp, "Database")) & ";" & "Integrated Security=True"
                    Else
                        ConnStr = "SERVER=" & Trim(.GetRegistryValue(sKeyNameTemp, "Server")) & ";" & _
                        "DATABASE=" & Trim(.GetRegistryValue(sKeyNameTemp, "Database")) & ";" & "Integrated Security=True"
                    End If
                Else
                    If pSqlEnvironIndex = 2 Then
                        ConnStr = "DRIVER={SQL Native Client};SERVER=" & Trim(.GetRegistryValue(sKeyNameTemp, "Server")) & ";" & _
                        "DATABASE=" & Trim(.GetRegistryValue(sKeyNameTemp, "Database")) & ";" & "USER=" & Trim(.GetRegistryValue(sKeyNameTemp, "UserId")) & ";" & _
                        "PASSWORD=" & Trim(.GetRegistryValue(sKeyNameTemp, "Password"))

                    Else
                        ConnStr = "SERVER=" & Trim(.GetRegistryValue(sKeyNameTemp, "Server")) & ";" & _
                        "DATABASE=" & Trim(.GetRegistryValue(sKeyNameTemp, "Database")) & ";" & "USER=" & Trim(.GetRegistryValue(sKeyNameTemp, "UserId")) & ";" & _
                        "PASSWORD=" & Trim(.GetRegistryValue(sKeyNameTemp, "Password"))

                    End If
                End If


                mServer = Trim(.GetRegistryValue(sKeyNameTemp, "Server"))
                mDatabase = Trim(.GetRegistryValue(sKeyNameTemp, "Database"))


                '
                ' Billing Connection
                '

                sKeyNameTemp = sKeyName & "\Connections\Billing"
                mBillingServer = Trim(.GetRegistryValue(sKeyNameTemp, "BillingServer"))
                mBillingDatabase = Trim(.GetRegistryValue(sKeyNameTemp, "BillingDatabase"))

                If Not .GetRegistryValue(sKeyNameTemp, "BillingAllowNT") = 0 Then
                    ConnStrBilling = "SERVER=" & mBillingServer & ";" & _
                    "DATABASE=" & mBillingDatabase & ";" & "Integrated Security=True"
                Else
                    ConnStrBilling = "SERVER=" & mBillingServer & ";" & _
                    "DATABASE=" & mBillingDatabase & ";" & "USER=" & Trim(.GetRegistryValue(sKeyNameTemp, "BillingUser")) & ";" & _
                    "PASSWORD=" & Trim(.GetRegistryValue(sKeyNameTemp, "BillingPassword"))
                End If


                '
                ' Application paths
                '
                sKeyNameTemp = sKeyName & "\Applications"
                mVesselVisitAppPath = Trim(.GetRegistryValue(sKeyNameTemp, "VesselVisitManagement"))
                mAJORSAppPath = Trim(.GetRegistryValue(sKeyNameTemp, "AJORS"))


                '
                ' EDI
                '
                sKeyNameTemp = sKeyName & "\EDI"
                mEdiAppPath = Trim(.GetRegistryValue(sKeyNameTemp, "EDIAppPath"))

            End With

        Catch ex As Exception
            MsgBox("There is an error while logging in." & vbCrLf & "Reason: " & _
            ex.Message, MsgBoxStyle.Exclamation, "Log-In Error")
        End Try


    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        '
        ' If GroupBox for ChangePassword then ChangePwd Routine
        '

        If groupBoxChangePassword.Visible = True Then

            '
            ' Change password
            '

            Dim retVal As Integer = 0

            If Not (txtNewPassword.Text.Length > 0) Then MsgBox("Please type new password.", vbInformation, "New Password Required") : txtNewPassword.Focus() : Exit Sub
            If Not (txtConfirmPassword.Text.Length > 0) Then MsgBox("Please confirm new password.", vbInformation, "Confirm New Password") : txtConfirmPassword.Focus() : Exit Sub
            If Not (txtConfirmPassword.Text = txtNewPassword.Text) Then MsgBox("New password does not match.", vbInformation, "Confirm New Password") : txtConfirmPassword.Focus() : Exit Sub

            retVal = UserUpdatePassword(tUsername.Text, txtNewPassword.Text)

            If (retVal <> 0) Then
                MsgBox("Password has been reset.", MsgBoxStyle.Exclamation, "Password reset successful")
                enablePasswordChange(False)
                tPassword.Focus()
            End If


        Else

            '
            ' Login
            '
            If Not Len(tUsername.Text) > 0 Or Not Len(tPassword.Text) > 0 Then
                MsgBox("Username or password should  be not left blank.", _
                            MsgBoxStyle.Exclamation, "Log-In Error")

            Else
                Login()
            End If

        End If




    End Sub

    Private Sub Login(Optional ByVal changePassword As Boolean = False)

        Dim fMainPTS As New ClientMain
        Dim isAuthenticated As Boolean = False
        Dim mUserFullName As String = ""

        Try

            If tUsername.Text = "" Or tPassword.Text = "" Then MsgBox("Please provide username and password", MsgBoxStyle.Information, "Log-in Validation") : tUsername.Focus() : Exit Sub


            Dim dtLogin As DataTable : dtLogin = CheckLogin()

            If dtLogin.Rows.Count > 0 Then

                If dtLogin.Rows(0).Item("PWDDTE") Is DBNull.Value And (dtLogin.Rows(0).Item("PASSWORD") = tPassword.Text) Then

                    MsgBox("Your password has expired. Kindly renew your password to activate account.", MsgBoxStyle.Information, "Password Expired")
                    enablePasswordChange()

                Else

                    isAuthenticated = authenticateUser(tPassword.Text.Trim, dtLogin.Rows(0))

                    If isAuthenticated = True Then

                        If changePassword = False Then

                            mUser = Trim(dtLogin.Rows(0).Item("EMPID"))
                            mUserFullName = Trim(dtLogin.Rows(0).Item("NAME"))

                            With fMainPTS
                                .stServer.Text = "Server: " & mServer
                                .stDatabase.Text = "Database: " & mDatabase
                                .stUserId.Text = "User: " & mUserFullName
                                .stDateLog.Text = Format(DateTime.Now, "dd MMM yyyy")
                                .stTimeLog.Text = Format(DateTime.Now, "h:mm tt")
                                .tabFormControl.MessageText = Me.sTerminalName & vbCrLf & sKeyName & " * Ver. " & sVersion
                            End With

                            fMainPTS.Show()

                            Me.Hide()

                        Else

                            enablePasswordChange(True)

                        End If


                    Else

                        MsgBox("Password is incorrect.", MsgBoxStyle.Exclamation, "Invalid Password")
                        tPassword.Clear()
                        tUsername.SelectAll()

                    End If

                End If

            Else

                MsgBox("User does not exist or is locked.", MsgBoxStyle.Exclamation, "Invalid user")
                tPassword.Clear()
                tUsername.SelectAll()

            End If


        Catch ex As Exception
            MsgBox("There is an error while logging in." & vbCrLf & "Reason: " & _
            ex.Message, MsgBoxStyle.Exclamation, "Log-In Error")
        End Try

    End Sub

    Private Sub enablePasswordChange(Optional ByVal isReset As Boolean = True)
        If isReset Then
            Me.Size = New Size(350, 310)
            groupBoxChangePassword.Visible = True
            btnChgPass.Enabled = False
            tPassword.Enabled = False
            tPassword.Clear()
            txtNewPassword.Clear()
            txtConfirmPassword.Clear()
            txtNewPassword.Focus()
        Else
            Me.Size = New Size(350, 180)
            groupBoxChangePassword.Visible = False
            btnChgPass.Enabled = True
            tPassword.Enabled = True
            tUsername.Focus()
        End If
    End Sub


    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click

        If groupBoxChangePassword.Visible = True Then
            enablePasswordChange(False)
        Else
            Global.System.Windows.Forms.Application.Exit()
        End If

    End Sub

    Private Function EstablishConnection(ByVal strConnSQL As String)
        Try
            connSQLEnvironment = New SqlConnection(ConnStr)
            With connSQLEnvironment
                If .State = ConnectionState.Closed Then
                    .Open()
                    Return True
                End If
            End With
        Catch ex As Exception
            MsgBox("System could not log in to the database." & vbCrLf _
            & ex.Message & vbCrLf & "Please contact your system administrator.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, _
            "Server Connection Error")

            Return False
        End Try
    End Function


    '
    'todo: Use
    '
    Private Function CheckLogin() As DataTable

        Dim DSData As New DataSet
        Dim PTSConn As SqlConnection
        Try
            PTSConn = New SqlConnection(ConnStr)
            Dim PTSAdapter As New SqlDataAdapter("SELECT TOP 1 * FROM psusers WHERE EMPID='" & tUsername.Text & "'", PTSConn)
            PTSAdapter.Fill(DSData, "PTSData")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return DSData.Tables("PTSData")

    End Function

    '
    'todo: Verify password
    '
    Private Function authenticateUser(ByVal passWordClearText As String, ByVal rowUserInfo As DataRow) As Boolean

        Dim hashPassword As String = ""
        Dim hashAlgorithmKey As Integer = 0
        Dim hashAlgorithmType As SimpleHash.HashAlgorithOptions

        Dim retVal As String = ""

        If Not rowUserInfo Is Nothing Then

            hashPassword = rowUserInfo.Item("PASSWORD").ToString
            hashAlgorithmKey = Int32.Parse(rowUserInfo.Item("HASHKEY").ToString)
            hashAlgorithmType = CType(hashAlgorithmKey, SimpleHash.HashAlgorithOptions)
            retVal = SimpleHash.VerifyHash(passWordClearText, hashAlgorithmType.ToString, hashPassword)

        End If

        authenticateUser = retVal

    End Function


    Private Sub frmLogin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            readIniApplicationSettings()

        Catch ex As Exception
            MsgBox("There was an error while loading the program." & vbCrLf & _
            ex.Message, MsgBoxStyle.Information, "Error on launching application")
        End Try

    End Sub

    Private Sub btnOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        oRegistry.LauchSettingsEditor()
    End Sub



    '
    ' Update Password
    '
    '

    Private Function UserUpdatePassword(ByVal userId As String, _
                                        ByVal password As String) _
                                        As Integer

        Dim recordUpdate As Integer = 0
        Dim passwordHash As String = ""
        Dim keyHash As Integer = 0

        Try

            keyHash = SimpleHash.GetRandomKey
            passwordHash = SimpleHash.ComputeHash(password, SimpleHash.GetRandomHashKey(keyHash).ToString, Nothing)

            recordUpdate = ExecCommand("[dbo].[bas_UserUpdatePassword]", CommandType.StoredProcedure, _
                        New SqlParameter("@empid", userId), _
                        New SqlParameter("@password", passwordHash), _
                        New SqlParameter("@hashkey", keyHash))

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "User Update Password")
            recordUpdate = -1
        End Try

        Return recordUpdate

    End Function


    Private Function ExecCommand( _
    ByVal commandText As String, _
    ByVal commandType As CommandType, _
    ByVal ParamArray params As System.Data.SqlClient.SqlParameter()) As Integer


        Dim connection As New System.Data.SqlClient.SqlConnection(ConnStr)
        Dim command As New System.Data.SqlClient.SqlCommand(commandText)
        Dim RecordsAffected As Integer = 0

        connection.Open()
        command.Connection = connection
        command.CommandType = commandType
        command.Parameters.AddRange(params)
        RecordsAffected = command.ExecuteNonQuery()

        connection.Close()

        If Not IsNothing(connection) Then connection.Dispose()
        If Not IsNothing(command) Then command.Dispose()
        connection = Nothing
        command = Nothing

        Return RecordsAffected

    End Function



    Private Sub btnChgPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChgPass.Click

        '
        ' Display group box change password
        '

        If Not Len(tUsername.Text) > 0 Or Not Len(tPassword.Text) > 0 Then
            MsgBox("Username or password should  be not left blank.", _
                        MsgBoxStyle.Exclamation, "Log-In Error")

        Else

            Login(changePassword:=True)

        End If

    End Sub

End Class


