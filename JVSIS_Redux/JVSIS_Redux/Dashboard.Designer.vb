<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.Panel_Sidebar = New System.Windows.Forms.Panel()
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.Panel_Home = New System.Windows.Forms.Panel()
        Me.Panel_Items = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel_History = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel_Settings = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_Side_Home = New System.Windows.Forms.Button()
        Me.BTN_Side_Items = New System.Windows.Forms.Button()
        Me.BTN_Side_Logs = New System.Windows.Forms.Button()
        Me.BTN_Side_Settings = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel_Sidebar.SuspendLayout()
        Me.Panel_Main.SuspendLayout()
        Me.Panel_Home.SuspendLayout()
        Me.Panel_Items.SuspendLayout()
        Me.Panel_History.SuspendLayout()
        Me.Panel_Settings.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Sidebar
        '
        Me.Panel_Sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel_Sidebar.Controls.Add(Me.BTN_Side_Settings)
        Me.Panel_Sidebar.Controls.Add(Me.BTN_Side_Logs)
        Me.Panel_Sidebar.Controls.Add(Me.BTN_Side_Items)
        Me.Panel_Sidebar.Controls.Add(Me.BTN_Side_Home)
        Me.Panel_Sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Sidebar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel_Sidebar.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Sidebar.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Sidebar.Name = "Panel_Sidebar"
        Me.Panel_Sidebar.Size = New System.Drawing.Size(228, 661)
        Me.Panel_Sidebar.TabIndex = 0
        '
        'Panel_Main
        '
        Me.Panel_Main.Controls.Add(Me.Panel_Home)
        Me.Panel_Main.Controls.Add(Me.Panel_Items)
        Me.Panel_Main.Controls.Add(Me.Panel_History)
        Me.Panel_Main.Controls.Add(Me.Panel_Settings)
        Me.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Main.Location = New System.Drawing.Point(228, 0)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(876, 661)
        Me.Panel_Main.TabIndex = 1
        '
        'Panel_Home
        '
        Me.Panel_Home.Controls.Add(Me.GroupBox1)
        Me.Panel_Home.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Home.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Home.Name = "Panel_Home"
        Me.Panel_Home.Size = New System.Drawing.Size(876, 661)
        Me.Panel_Home.TabIndex = 3
        Me.Panel_Home.Visible = False
        '
        'Panel_Items
        '
        Me.Panel_Items.Controls.Add(Me.Label3)
        Me.Panel_Items.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Items.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Items.Name = "Panel_Items"
        Me.Panel_Items.Size = New System.Drawing.Size(876, 661)
        Me.Panel_Items.TabIndex = 2
        Me.Panel_Items.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ITEMS"
        '
        'Panel_History
        '
        Me.Panel_History.Controls.Add(Me.Label2)
        Me.Panel_History.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_History.Location = New System.Drawing.Point(0, 0)
        Me.Panel_History.Name = "Panel_History"
        Me.Panel_History.Size = New System.Drawing.Size(876, 661)
        Me.Panel_History.TabIndex = 1
        Me.Panel_History.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "HISTORY"
        '
        'Panel_Settings
        '
        Me.Panel_Settings.Controls.Add(Me.Label1)
        Me.Panel_Settings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Settings.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Settings.Name = "Panel_Settings"
        Me.Panel_Settings.Size = New System.Drawing.Size(876, 661)
        Me.Panel_Settings.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SETTINGS"
        '
        'BTN_Side_Home
        '
        Me.BTN_Side_Home.BackColor = System.Drawing.Color.White
        Me.BTN_Side_Home.FlatAppearance.BorderSize = 0
        Me.BTN_Side_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Side_Home.Font = New System.Drawing.Font("Leelawadee UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Side_Home.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_Side_Home.Location = New System.Drawing.Point(45, 290)
        Me.BTN_Side_Home.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.BTN_Side_Home.Name = "BTN_Side_Home"
        Me.BTN_Side_Home.Size = New System.Drawing.Size(183, 54)
        Me.BTN_Side_Home.TabIndex = 0
        Me.BTN_Side_Home.Text = "HOME"
        Me.BTN_Side_Home.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Side_Home.UseVisualStyleBackColor = False
        '
        'BTN_Side_Items
        '
        Me.BTN_Side_Items.FlatAppearance.BorderSize = 0
        Me.BTN_Side_Items.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Side_Items.Font = New System.Drawing.Font("Leelawadee UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Side_Items.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_Side_Items.Location = New System.Drawing.Point(45, 354)
        Me.BTN_Side_Items.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.BTN_Side_Items.Name = "BTN_Side_Items"
        Me.BTN_Side_Items.Size = New System.Drawing.Size(183, 54)
        Me.BTN_Side_Items.TabIndex = 1
        Me.BTN_Side_Items.Text = "ITEMS"
        Me.BTN_Side_Items.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Side_Items.UseVisualStyleBackColor = True
        '
        'BTN_Side_Logs
        '
        Me.BTN_Side_Logs.FlatAppearance.BorderSize = 0
        Me.BTN_Side_Logs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Side_Logs.Font = New System.Drawing.Font("Leelawadee UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Side_Logs.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_Side_Logs.Location = New System.Drawing.Point(45, 418)
        Me.BTN_Side_Logs.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.BTN_Side_Logs.Name = "BTN_Side_Logs"
        Me.BTN_Side_Logs.Size = New System.Drawing.Size(183, 54)
        Me.BTN_Side_Logs.TabIndex = 2
        Me.BTN_Side_Logs.Text = "LOGS"
        Me.BTN_Side_Logs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Side_Logs.UseVisualStyleBackColor = True
        '
        'BTN_Side_Settings
        '
        Me.BTN_Side_Settings.FlatAppearance.BorderSize = 0
        Me.BTN_Side_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Side_Settings.Font = New System.Drawing.Font("Leelawadee UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Side_Settings.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_Side_Settings.Location = New System.Drawing.Point(45, 482)
        Me.BTN_Side_Settings.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.BTN_Side_Settings.Name = "BTN_Side_Settings"
        Me.BTN_Side_Settings.Size = New System.Drawing.Size(183, 54)
        Me.BTN_Side_Settings.TabIndex = 3
        Me.BTN_Side_Settings.Text = "SETTINGS"
        Me.BTN_Side_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Side_Settings.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 290)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(549, 371)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ACTIONS"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1104, 661)
        Me.Controls.Add(Me.Panel_Main)
        Me.Controls.Add(Me.Panel_Sidebar)
        Me.Name = "Dashboard"
        Me.Text = "Form1"
        Me.Panel_Sidebar.ResumeLayout(False)
        Me.Panel_Main.ResumeLayout(False)
        Me.Panel_Home.ResumeLayout(False)
        Me.Panel_Items.ResumeLayout(False)
        Me.Panel_Items.PerformLayout()
        Me.Panel_History.ResumeLayout(False)
        Me.Panel_History.PerformLayout()
        Me.Panel_Settings.ResumeLayout(False)
        Me.Panel_Settings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Sidebar As Panel
    Friend WithEvents Panel_Main As Panel
    Friend WithEvents Panel_Home As Panel
    Friend WithEvents Panel_Items As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel_History As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel_Settings As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_Side_Settings As Button
    Friend WithEvents BTN_Side_Logs As Button
    Friend WithEvents BTN_Side_Items As Button
    Friend WithEvents BTN_Side_Home As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
