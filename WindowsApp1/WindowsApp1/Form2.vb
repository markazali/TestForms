Imports Newtonsoft.Json
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Collections.Specialized
Public Class Form2

    Public Function jSonGetData(ByVal URL As String) As Dictionary(Of String, Object)
        Dim webClient As New WebClient()
        Dim resByte As Byte()
        Dim resString As String
        Dim reqString() As Byte
        Dim parsedResult As String()


        Dim dictData As New Dictionary(Of String, Object)




        Try

            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(URL), HttpWebRequest)
            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)

            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())

            Dim test As JArray = JArray.Parse(reader.ReadToEnd)


            TextBox1.Clear()




            Dim results As List(Of JToken) = test.Children().ToList

            For Each item As JObject In results
                'Dim jr As JsonReader = item.CreateReader()
                'While jr.Read
                '    TextBox1.AppendText(jr.TokenType.ToString & " " & jr.Value & vbCrLf)

                'End While
                dictData = item.ToObject(Of Dictionary(Of String, Object))
                TextBox1.AppendText(dictData("id") & " " & dictData("body"))
                TextBox1.AppendText(dictData.ContainsKey("testsets"))
                TextBox1.AppendText(vbCrLf & vbCrLf)
            Next




        Catch ex As Exception

        Finally
            webClient.Dispose()
        End Try

    End Function
    Public Function jSonPostData(ByVal URL As String, ByVal dictData As Dictionary(Of String, Object)) As Boolean
        Dim webClient As New WebClient()
        Dim resByte As Byte()
        Dim resString As String
        Dim reqString() As Byte


        'Sample Usage
        '------------

        'Dim jsonPost As New jSon("http://192.168.254.104:8000")
        'Dim dictData As New Dictionary(Of String, Object)
        'dictData.Add("test_key", "test_value")
        'jsonPost.postData(dictData)

        Try
            webClient.Headers("content-type") = "application/json"
            reqString = Encoding.Default.GetBytes(JsonConvert.SerializeObject(dictData, Formatting.Indented))
            resByte = webClient.UploadData(URL, "post", reqString)
            resString = Encoding.Default.GetString(resByte)


            Return True
        Catch ex As Exception
            Return False

        Finally
            webClient.Dispose()
        End Try

    End Function
    Public Function jSonSyncPostData(ByVal URL As String, ByVal blobname As String, ByVal blobstring As String) As Boolean
        Dim webClient As New WebClient()


        Try
            Dim nvc As New NameValueCollection()
            nvc.Add(blobname, blobstring)

            'webClient.Headers("content-type") = "application/json"
            webClient.UploadValues(URL, "POST", nvc)


            Return True
        Catch ex As Exception
            Return False

        Finally
            webClient.Dispose()
        End Try

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        jSonGetData("https://jsonplaceholder.typicode.com/posts/1/comments")
    End Sub
End Class