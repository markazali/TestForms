﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBoxProperties = New System.Windows.Forms.ComboBox()
        Me.ButtonToggle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.CheckBoxes = True
        Me.TreeView1.Location = New System.Drawing.Point(12, 59)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(776, 347)
        Me.TreeView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.Location = New System.Drawing.Point(0, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(800, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBoxProperties
        '
        Me.ComboBoxProperties.FormattingEnabled = True
        Me.ComboBoxProperties.Location = New System.Drawing.Point(12, 13)
        Me.ComboBoxProperties.Name = "ComboBoxProperties"
        Me.ComboBoxProperties.Size = New System.Drawing.Size(314, 21)
        Me.ComboBoxProperties.TabIndex = 2
        '
        'ButtonToggle
        '
        Me.ButtonToggle.Location = New System.Drawing.Point(370, 10)
        Me.ButtonToggle.Name = "ButtonToggle"
        Me.ButtonToggle.Size = New System.Drawing.Size(130, 23)
        Me.ButtonToggle.TabIndex = 3
        Me.ButtonToggle.Text = "Expand/Collapse"
        Me.ButtonToggle.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 447)
        Me.Controls.Add(Me.ButtonToggle)
        Me.Controls.Add(Me.ComboBoxProperties)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBoxProperties As ComboBox
    Friend WithEvents ButtonToggle As Button
End Class
