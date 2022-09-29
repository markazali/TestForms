Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dt As DataTable = Me.GetData("SELECT divisionno, division 
        FROM divisions 
        where deleted = 0 
        and propertyno =" & 1 & " order by division")
        Me.PopulateTreeView(dt, 0, Nothing, 1)



    End Sub

    Private Sub PopulateTreeView(dtParent As DataTable,
                                 parentId As Integer,
                                 treeNode As TreeNode,
                                 ByVal leveltype As Integer)

        Try



            If leveltype = 1 Then

                For Each row As DataRow In dtParent.Rows
                    Dim child As New TreeNode() With {
                 .Text = "Division: " & row("division").ToString(),
                 .Tag = row("divisionno")
                }
                    If parentId = 0 Then
                        TreeView1.Nodes.Add(child)
                        Dim dtChild As DataTable = Me.GetData("SELECT departmentno, department 
                    FROM departments 
                    WHERE deleted = 0 
                    and divisionno= " & child.Tag & " order by department")
                        PopulateTreeView(dtChild, Convert.ToInt32(child.Tag), child, 2)
                    Else
                        treeNode.Nodes.Add(child)
                    End If
                Next

            ElseIf leveltype = 2 Then

                For Each row As DataRow In dtParent.Rows
                    Dim child As New TreeNode() With {
                 .Text = "Department: " & row("department").ToString(),
                 .Tag = row("departmentno")
                }

                    treeNode.Nodes.Add(child)
                    Dim dtChild As DataTable = Me.GetData("SELECT jobno, job 
                    FROM jobs 
                    WHERE deleted = 0  and departmentno = " & child.Tag & " order by job")
                    PopulateTreeView(dtChild, Convert.ToInt32(child.Tag), child, 3)


                Next

            ElseIf leveltype = 3 Then

                For Each row As DataRow In dtParent.Rows
                    Dim child As New TreeNode() With {
                 .Text = "Job: " & row("job").ToString() & " (" & row("jobno").ToString() & ")",
                 .Tag = row("jobno")
                }
                    treeNode.Nodes.Add(child)
                Next




            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick

        Try


            For Each x In e.Node.Nodes
                x.checked = e.Node.Checked

                For Each y In DirectCast(x, TreeNode).Nodes
                    y.checked = DirectCast(x, TreeNode).Checked
                Next

            Next

        Catch ex As Exception

        End Try




    End Sub

    Private Function GetData(query As String) As DataTable

        Try


            Dim dt As New DataTable()
            Dim constr As String = "Data Source=(local);Initial Catalog=mark_multi_uniform_net;Integrated Security=true"
            Using con As New SqlConnection(constr)
                Using cmd As New SqlCommand(query)
                    Using sda As New SqlDataAdapter()
                        cmd.CommandType = CommandType.Text
                        cmd.Connection = con
                        sda.SelectCommand = cmd
                        sda.Fill(dt)
                    End Using
                End Using
                Return dt
            End Using

        Catch ex As Exception

        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try



            For Each x In TreeView1.Nodes 'div
                For Each y In x.Nodes 'dept

                    For Each z In y.nodes
                        If z.checked Then
                            MsgBox(z.text)
                        End If
                    Next

                Next
            Next
        Catch ex As Exception

        End Try
    End Sub


End Class
