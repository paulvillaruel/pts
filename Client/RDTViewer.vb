Imports System.Data.SqlClient

Public Class RDTViewer

    Private Function returnURL() As String

        Dim PTSConn As SqlConnection
        Dim retVal As String = ""
        Dim sqlQuery As String = "SELECT VALUE FROM CONSTANT WHERE TYPE = 'APP' AND SUBTYPE = 'RDT_HOST'"

        Try

            PTSConn = New SqlConnection(Login.ConnStr)
            Dim commandPTS As New SqlCommand(sqlQuery, PTSConn)
            PTSConn.Open()
            With commandPTS
                .CommandType = CommandType.Text
                retVal = .ExecuteScalar()
            End With
            PTSConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return retVal

    End Function

    Private Sub RDTBrowser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim url As String() = {}
        Dim hostUrl As String = ""

        Try
            hostUrl = returnURL()
            url = hostUrl.Split("/")
            rdtWebBrowser.Navigate(returnURL)
            Me.Text = "RDT Viewer [" & url(2) & "]"
        Catch ex As System.UriFormatException
            Me.Text = "RDT Viewer [" & ex.Message & "]"
        End Try

    End Sub

End Class