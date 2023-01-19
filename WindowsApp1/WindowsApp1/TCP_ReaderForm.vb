Imports System.Net.Sockets
Imports System.Text

Public Class TCP_ReaderForm

    Dim networkStream As System.Net.Sockets.NetworkStream
    Dim tcpClient As System.Net.Sockets.TcpClient
    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click


        Try

            tcpClient = New System.Net.Sockets.TcpClient()
            tcpClient.Connect(TextBoxIP.Text, TextBoxPort.Text)
            ' AddHandler tcpClient., AddressOf DataHandler

            networkStream = tcpClient.GetStream()

            If networkStream.CanWrite Then 'And networkStream.CanRead Then
                Dim sendBytes As [Byte]() = System.Text.Encoding.ASCII.GetBytes("00090010" & vbCr)
                networkStream.Write(sendBytes, 0, sendBytes.Length)

                'Dim buffer(256) As Byte
                Dim bytes(tcpClient.ReceiveBufferSize) As Byte
                'networkStream.Read(bytes, 0, CInt(tcpClient.ReceiveBufferSize))
                networkStream.BeginRead(bytes, 0, CInt(tcpClient.ReceiveBufferSize), AddressOf TCPIP_DataArrival, bytes)
            Else
                If Not networkStream.CanRead Then
                    tcpClient.Close()
                Else
                    If Not networkStream.CanWrite Then
                        tcpClient.Close()
                    End If
                End If
            End If

        Catch ex As Exception
        End Try
    End Sub
    Private Sub TCPIP_DataArrival(ByVal AR As IAsyncResult)

        Try
            If Not networkStream.CanRead Then Exit Sub
            'If Not networkStream.DataAvailable Then Exit Sub

            Dim buffer() As Byte = AR.AsyncState
            Dim bytesRead As Integer = networkStream.EndRead(AR)
            Dim Message As String = System.Text.Encoding.ASCII.GetString(buffer, 0, bytesRead)

            'split message in case we get more than 1 in buffer (e.g. "(chip1) (chip2) (chip3)"
            Dim bufferarray As String() = Message.Split()
            For Each s As String In bufferarray
                If s <> "" Then
                    If TextBoxResponse.InvokeRequired Then
                        TextBoxResponse.Invoke(
                        Sub()
                            TextBoxResponse.AppendText(Now & " " & s & vbCrLf)
                        End Sub)
                    Else
                        TextBoxResponse.AppendText(Now & " " & s & vbCrLf)
                    End If
                End If

            Next



            networkStream.BeginRead(buffer, 0, buffer.Length, AddressOf TCPIP_DataArrival, buffer)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub TCP_ReaderForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.ipaddress = TextBoxIP.Text
        My.Settings.ipport = TextBoxPort.Text
    End Sub

    Private Sub TCP_ReaderForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBoxIP.Text = My.Settings.ipaddress
        TextBoxPort.Text = My.Settings.ipport
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'start the reads when the button is pressed
            Dim ns As NetworkStream = tcpClient.GetStream
            ns.Write(Encoding.ASCII.GetBytes("s"), 0, Encoding.ASCII.GetBytes("s").Length)

        Catch ex As Exception

        End Try


    End Sub
End Class