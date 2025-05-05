Imports MySql.Data.MySqlClient
Module dbconnection
    Public conn As New MySqlConnection
    Dim result As Boolean
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public dr As MySqlDataReader
    Public i As Integer

    Public Function dbconn() As Boolean
        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "server=localhost;username=root;password=;port=3306;database=farmaciadeguanzon"
                conn.Open()
                result = True
            End If
        Catch ex As Exception
            result = False
            MsgBox("Server Not Connected!", vbExclamation)
        End Try
        Return result
    End Function

    Public Function GetOrderNo() As String
        Dim nextOrderNo As String = ""
        Try
            conn.Open()
            ' Adjusted query to use Product_ID for ordering
            Dim query As String = "SELECT `OrderNo` FROM `tblpos` ORDER BY `Product_ID` DESC LIMIT 1"
            cmd = New MySqlCommand(query, conn)
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                ' Attempt to convert OrderNo to a Long and increment it
                Dim currentOrderNo As Long
                If Long.TryParse(dr("OrderNo").ToString(), currentOrderNo) Then
                    nextOrderNo = (currentOrderNo + 1).ToString()
                Else
                    Throw New Exception("OrderNo is not a valid number.")
                End If
            Else
                ' Default value if no rows are found
                nextOrderNo = Date.Now.ToString("yyyy") & "1"
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            ' Default value in case of failure
            nextOrderNo = Date.Now.ToString("yyyy") & "1"

        Finally
            ' Ensure the connection is closed
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

        Return nextOrderNo
    End Function


End Module
