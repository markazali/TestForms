<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TCP_ReaderForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBoxIP = New System.Windows.Forms.TextBox()
        Me.TextBoxPort = New System.Windows.Forms.TextBox()
        Me.LabelIP = New System.Windows.Forms.Label()
        Me.LabelPort = New System.Windows.Forms.Label()
        Me.TextBoxResponse = New System.Windows.Forms.TextBox()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxIP
        '
        Me.TextBoxIP.Location = New System.Drawing.Point(16, 38)
        Me.TextBoxIP.Name = "TextBoxIP"
        Me.TextBoxIP.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxIP.TabIndex = 0
        '
        'TextBoxPort
        '
        Me.TextBoxPort.Location = New System.Drawing.Point(16, 80)
        Me.TextBoxPort.Name = "TextBoxPort"
        Me.TextBoxPort.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPort.TabIndex = 1
        '
        'LabelIP
        '
        Me.LabelIP.AutoSize = True
        Me.LabelIP.Location = New System.Drawing.Point(13, 22)
        Me.LabelIP.Name = "LabelIP"
        Me.LabelIP.Size = New System.Drawing.Size(58, 13)
        Me.LabelIP.TabIndex = 2
        Me.LabelIP.Text = "IP Address"
        '
        'LabelPort
        '
        Me.LabelPort.AutoSize = True
        Me.LabelPort.Location = New System.Drawing.Point(13, 64)
        Me.LabelPort.Name = "LabelPort"
        Me.LabelPort.Size = New System.Drawing.Size(26, 13)
        Me.LabelPort.TabIndex = 3
        Me.LabelPort.Text = "Port"
        '
        'TextBoxResponse
        '
        Me.TextBoxResponse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxResponse.Location = New System.Drawing.Point(21, 163)
        Me.TextBoxResponse.Multiline = True
        Me.TextBoxResponse.Name = "TextBoxResponse"
        Me.TextBoxResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxResponse.Size = New System.Drawing.Size(745, 285)
        Me.TextBoxResponse.TabIndex = 4
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Location = New System.Drawing.Point(201, 38)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(75, 23)
        Me.ButtonConnect.TabIndex = 5
        Me.ButtonConnect.Text = "Connect"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(201, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Start Read"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TCP_ReaderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 469)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonConnect)
        Me.Controls.Add(Me.LabelPort)
        Me.Controls.Add(Me.LabelIP)
        Me.Controls.Add(Me.TextBoxPort)
        Me.Controls.Add(Me.TextBoxIP)
        Me.Controls.Add(Me.TextBoxResponse)
        Me.Name = "TCP_ReaderForm"
        Me.Text = "TCP_ReaderForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxIP As TextBox
    Friend WithEvents TextBoxPort As TextBox
    Friend WithEvents LabelIP As Label
    Friend WithEvents LabelPort As Label
    Friend WithEvents TextBoxResponse As TextBox
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents Button1 As Button
End Class
