<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Panel_Sidebar = New System.Windows.Forms.Panel()
        Me.BTN_Side_Settings = New System.Windows.Forms.Button()
        Me.BTN_Side_Logs = New System.Windows.Forms.Button()
        Me.BTN_Side_Items = New System.Windows.Forms.Button()
        Me.BTN_Side_Home = New System.Windows.Forms.Button()
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.Panel_Items = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel_History = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel_Settings = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBX_Dashboard_Controls = New System.Windows.Forms.GroupBox()
        Me.TLP_Home_BTN = New System.Windows.Forms.TableLayoutPanel()
        Me.HOME_BTN_REPORTS = New System.Windows.Forms.Button()
        Me.HOME_BTN_ADDITEM = New System.Windows.Forms.Button()
        Me.HOME_BTN_IN = New System.Windows.Forms.Button()
        Me.HOME_BTN_OUT = New System.Windows.Forms.Button()
        Me.Panel_DayView = New System.Windows.Forms.Panel()
        Me.Panel_DV_Top = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox_INFO = New System.Windows.Forms.GroupBox()
        Me.TLB_QuickInfo = New System.Windows.Forms.TableLayoutPanel()
        Me.TLB_INVENTORY_VALUE = New System.Windows.Forms.TableLayoutPanel()
        Me.TLB_INVENTORY_VALUE_BTN = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TLB_ITEMQTY = New System.Windows.Forms.TableLayoutPanel()
        Me.TLB_ITEMQTY_BTN = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TLB_LOWSTOCK = New System.Windows.Forms.TableLayoutPanel()
        Me.TLB_QuickInfo_BTN = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TLB_VALUEOUT = New System.Windows.Forms.TableLayoutPanel()
        Me.TLB_VALUEOUT_BTN = New System.Windows.Forms.Button()
        Me.APP_LABEL = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel_Home = New System.Windows.Forms.Panel()
        Me.Panel_Sidebar.SuspendLayout()
        Me.Panel_Main.SuspendLayout()
        Me.Panel_Items.SuspendLayout()
        Me.Panel_History.SuspendLayout()
        Me.Panel_Settings.SuspendLayout()
        Me.GBX_Dashboard_Controls.SuspendLayout()
        Me.TLP_Home_BTN.SuspendLayout()
        Me.Panel_DayView.SuspendLayout()
        Me.Panel_DV_Top.SuspendLayout()
        Me.GroupBox_INFO.SuspendLayout()
        Me.TLB_QuickInfo.SuspendLayout()
        Me.TLB_INVENTORY_VALUE.SuspendLayout()
        Me.TLB_ITEMQTY.SuspendLayout()
        Me.TLB_LOWSTOCK.SuspendLayout()
        Me.TLB_VALUEOUT.SuspendLayout()
        Me.Panel_Home.SuspendLayout()
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
        Me.Panel_Sidebar.MaximumSize = New System.Drawing.Size(220, 0)
        Me.Panel_Sidebar.MinimumSize = New System.Drawing.Size(220, 0)
        Me.Panel_Sidebar.Name = "Panel_Sidebar"
        Me.Panel_Sidebar.Size = New System.Drawing.Size(220, 661)
        Me.Panel_Sidebar.TabIndex = 0
        '
        'BTN_Side_Settings
        '
        Me.BTN_Side_Settings.FlatAppearance.BorderSize = 0
        Me.BTN_Side_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BTN_Side_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Side_Settings.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Side_Settings.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_Side_Settings.Location = New System.Drawing.Point(45, 482)
        Me.BTN_Side_Settings.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.BTN_Side_Settings.Name = "BTN_Side_Settings"
        Me.BTN_Side_Settings.Size = New System.Drawing.Size(175, 54)
        Me.BTN_Side_Settings.TabIndex = 3
        Me.BTN_Side_Settings.Text = "SETTINGS"
        Me.BTN_Side_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Side_Settings.UseVisualStyleBackColor = True
        '
        'BTN_Side_Logs
        '
        Me.BTN_Side_Logs.FlatAppearance.BorderSize = 0
        Me.BTN_Side_Logs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BTN_Side_Logs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Side_Logs.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Side_Logs.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_Side_Logs.Location = New System.Drawing.Point(45, 418)
        Me.BTN_Side_Logs.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.BTN_Side_Logs.Name = "BTN_Side_Logs"
        Me.BTN_Side_Logs.Size = New System.Drawing.Size(175, 54)
        Me.BTN_Side_Logs.TabIndex = 2
        Me.BTN_Side_Logs.Text = "LOGS"
        Me.BTN_Side_Logs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Side_Logs.UseVisualStyleBackColor = True
        '
        'BTN_Side_Items
        '
        Me.BTN_Side_Items.FlatAppearance.BorderSize = 0
        Me.BTN_Side_Items.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BTN_Side_Items.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Side_Items.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Side_Items.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_Side_Items.Location = New System.Drawing.Point(45, 354)
        Me.BTN_Side_Items.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.BTN_Side_Items.Name = "BTN_Side_Items"
        Me.BTN_Side_Items.Size = New System.Drawing.Size(175, 54)
        Me.BTN_Side_Items.TabIndex = 1
        Me.BTN_Side_Items.Text = "ITEMS"
        Me.BTN_Side_Items.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Side_Items.UseVisualStyleBackColor = True
        '
        'BTN_Side_Home
        '
        Me.BTN_Side_Home.BackColor = System.Drawing.Color.White
        Me.BTN_Side_Home.FlatAppearance.BorderSize = 0
        Me.BTN_Side_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BTN_Side_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Side_Home.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Side_Home.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_Side_Home.Location = New System.Drawing.Point(45, 290)
        Me.BTN_Side_Home.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.BTN_Side_Home.Name = "BTN_Side_Home"
        Me.BTN_Side_Home.Size = New System.Drawing.Size(175, 54)
        Me.BTN_Side_Home.TabIndex = 0
        Me.BTN_Side_Home.Text = "HOME"
        Me.BTN_Side_Home.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Side_Home.UseVisualStyleBackColor = False
        '
        'Panel_Main
        '
        Me.Panel_Main.Controls.Add(Me.Panel_Home)
        Me.Panel_Main.Controls.Add(Me.Panel_Items)
        Me.Panel_Main.Controls.Add(Me.Panel_History)
        Me.Panel_Main.Controls.Add(Me.Panel_Settings)
        Me.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Main.Location = New System.Drawing.Point(220, 0)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(884, 661)
        Me.Panel_Main.TabIndex = 1
        '
        'Panel_Items
        '
        Me.Panel_Items.Controls.Add(Me.Label3)
        Me.Panel_Items.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Items.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Items.Name = "Panel_Items"
        Me.Panel_Items.Size = New System.Drawing.Size(884, 661)
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
        Me.Panel_History.Size = New System.Drawing.Size(884, 661)
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
        Me.Panel_Settings.Size = New System.Drawing.Size(884, 661)
        Me.Panel_Settings.TabIndex = 0
        Me.Panel_Settings.Visible = False
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
        'GBX_Dashboard_Controls
        '
        Me.GBX_Dashboard_Controls.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GBX_Dashboard_Controls.Controls.Add(Me.TLP_Home_BTN)
        Me.GBX_Dashboard_Controls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GBX_Dashboard_Controls.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBX_Dashboard_Controls.Location = New System.Drawing.Point(18, 290)
        Me.GBX_Dashboard_Controls.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.GBX_Dashboard_Controls.MaximumSize = New System.Drawing.Size(700, 0)
        Me.GBX_Dashboard_Controls.MinimumSize = New System.Drawing.Size(0, 360)
        Me.GBX_Dashboard_Controls.Name = "GBX_Dashboard_Controls"
        Me.GBX_Dashboard_Controls.Size = New System.Drawing.Size(554, 360)
        Me.GBX_Dashboard_Controls.TabIndex = 0
        Me.GBX_Dashboard_Controls.TabStop = False
        Me.GBX_Dashboard_Controls.Text = "QUICK ACTIONS"
        '
        'TLP_Home_BTN
        '
        Me.TLP_Home_BTN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TLP_Home_BTN.ColumnCount = 2
        Me.TLP_Home_BTN.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Home_BTN.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Home_BTN.Controls.Add(Me.HOME_BTN_OUT, 1, 1)
        Me.TLP_Home_BTN.Controls.Add(Me.HOME_BTN_IN, 0, 1)
        Me.TLP_Home_BTN.Controls.Add(Me.HOME_BTN_ADDITEM, 0, 0)
        Me.TLP_Home_BTN.Controls.Add(Me.HOME_BTN_REPORTS, 1, 0)
        Me.TLP_Home_BTN.Location = New System.Drawing.Point(6, 32)
        Me.TLP_Home_BTN.Name = "TLP_Home_BTN"
        Me.TLP_Home_BTN.RowCount = 2
        Me.TLP_Home_BTN.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Home_BTN.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Home_BTN.Size = New System.Drawing.Size(538, 322)
        Me.TLP_Home_BTN.TabIndex = 0
        '
        'HOME_BTN_REPORTS
        '
        Me.HOME_BTN_REPORTS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.HOME_BTN_REPORTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HOME_BTN_REPORTS.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HOME_BTN_REPORTS.Location = New System.Drawing.Point(272, 3)
        Me.HOME_BTN_REPORTS.Name = "HOME_BTN_REPORTS"
        Me.HOME_BTN_REPORTS.Size = New System.Drawing.Size(263, 155)
        Me.HOME_BTN_REPORTS.TabIndex = 2
        Me.HOME_BTN_REPORTS.Text = "REPORTS"
        Me.HOME_BTN_REPORTS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HOME_BTN_REPORTS.UseVisualStyleBackColor = True
        '
        'HOME_BTN_ADDITEM
        '
        Me.HOME_BTN_ADDITEM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.HOME_BTN_ADDITEM.BackgroundImage = CType(resources.GetObject("HOME_BTN_ADDITEM.BackgroundImage"), System.Drawing.Image)
        Me.HOME_BTN_ADDITEM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.HOME_BTN_ADDITEM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HOME_BTN_ADDITEM.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HOME_BTN_ADDITEM.Location = New System.Drawing.Point(3, 3)
        Me.HOME_BTN_ADDITEM.Name = "HOME_BTN_ADDITEM"
        Me.HOME_BTN_ADDITEM.Size = New System.Drawing.Size(263, 155)
        Me.HOME_BTN_ADDITEM.TabIndex = 3
        Me.HOME_BTN_ADDITEM.Text = "ADD NEW ITEM+"
        Me.HOME_BTN_ADDITEM.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HOME_BTN_ADDITEM.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.HOME_BTN_ADDITEM.UseVisualStyleBackColor = True
        '
        'HOME_BTN_IN
        '
        Me.HOME_BTN_IN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.HOME_BTN_IN.BackgroundImage = CType(resources.GetObject("HOME_BTN_IN.BackgroundImage"), System.Drawing.Image)
        Me.HOME_BTN_IN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.HOME_BTN_IN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HOME_BTN_IN.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HOME_BTN_IN.Location = New System.Drawing.Point(3, 164)
        Me.HOME_BTN_IN.Name = "HOME_BTN_IN"
        Me.HOME_BTN_IN.Size = New System.Drawing.Size(263, 155)
        Me.HOME_BTN_IN.TabIndex = 4
        Me.HOME_BTN_IN.Text = "ITEM IN"
        Me.HOME_BTN_IN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HOME_BTN_IN.UseVisualStyleBackColor = True
        '
        'HOME_BTN_OUT
        '
        Me.HOME_BTN_OUT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.HOME_BTN_OUT.BackgroundImage = CType(resources.GetObject("HOME_BTN_OUT.BackgroundImage"), System.Drawing.Image)
        Me.HOME_BTN_OUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.HOME_BTN_OUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HOME_BTN_OUT.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HOME_BTN_OUT.Location = New System.Drawing.Point(272, 164)
        Me.HOME_BTN_OUT.Name = "HOME_BTN_OUT"
        Me.HOME_BTN_OUT.Size = New System.Drawing.Size(263, 155)
        Me.HOME_BTN_OUT.TabIndex = 5
        Me.HOME_BTN_OUT.Text = "ITEM OUT"
        Me.HOME_BTN_OUT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HOME_BTN_OUT.UseVisualStyleBackColor = True
        '
        'Panel_DayView
        '
        Me.Panel_DayView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_DayView.AutoSize = True
        Me.Panel_DayView.Controls.Add(Me.Panel_DV_Top)
        Me.Panel_DayView.Location = New System.Drawing.Point(579, 303)
        Me.Panel_DayView.MinimumSize = New System.Drawing.Size(293, 346)
        Me.Panel_DayView.Name = "Panel_DayView"
        Me.Panel_DayView.Size = New System.Drawing.Size(293, 346)
        Me.Panel_DayView.TabIndex = 2
        '
        'Panel_DV_Top
        '
        Me.Panel_DV_Top.Controls.Add(Me.Label4)
        Me.Panel_DV_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_DV_Top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_DV_Top.Name = "Panel_DV_Top"
        Me.Panel_DV_Top.Size = New System.Drawing.Size(293, 41)
        Me.Panel_DV_Top.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(293, 41)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "DAY OVERVIEW"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox_INFO
        '
        Me.GroupBox_INFO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_INFO.Controls.Add(Me.TLB_QuickInfo)
        Me.GroupBox_INFO.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox_INFO.Location = New System.Drawing.Point(18, 129)
        Me.GroupBox_INFO.Name = "GroupBox_INFO"
        Me.GroupBox_INFO.Size = New System.Drawing.Size(854, 154)
        Me.GroupBox_INFO.TabIndex = 4
        Me.GroupBox_INFO.TabStop = False
        Me.GroupBox_INFO.Text = "AT A GLANCE"
        '
        'TLB_QuickInfo
        '
        Me.TLB_QuickInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLB_QuickInfo.ColumnCount = 4
        Me.TLB_QuickInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLB_QuickInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLB_QuickInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLB_QuickInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLB_QuickInfo.Controls.Add(Me.TLB_VALUEOUT, 3, 0)
        Me.TLB_QuickInfo.Controls.Add(Me.TLB_LOWSTOCK, 2, 0)
        Me.TLB_QuickInfo.Controls.Add(Me.TLB_ITEMQTY, 1, 0)
        Me.TLB_QuickInfo.Controls.Add(Me.TLB_INVENTORY_VALUE, 0, 0)
        Me.TLB_QuickInfo.Location = New System.Drawing.Point(9, 27)
        Me.TLB_QuickInfo.Name = "TLB_QuickInfo"
        Me.TLB_QuickInfo.RowCount = 1
        Me.TLB_QuickInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLB_QuickInfo.Size = New System.Drawing.Size(839, 118)
        Me.TLB_QuickInfo.TabIndex = 3
        '
        'TLB_INVENTORY_VALUE
        '
        Me.TLB_INVENTORY_VALUE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLB_INVENTORY_VALUE.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TLB_INVENTORY_VALUE.ColumnCount = 1
        Me.TLB_INVENTORY_VALUE.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLB_INVENTORY_VALUE.Controls.Add(Me.Label5, 0, 0)
        Me.TLB_INVENTORY_VALUE.Controls.Add(Me.TLB_INVENTORY_VALUE_BTN, 0, 1)
        Me.TLB_INVENTORY_VALUE.Location = New System.Drawing.Point(3, 3)
        Me.TLB_INVENTORY_VALUE.Name = "TLB_INVENTORY_VALUE"
        Me.TLB_INVENTORY_VALUE.RowCount = 2
        Me.TLB_INVENTORY_VALUE.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLB_INVENTORY_VALUE.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLB_INVENTORY_VALUE.Size = New System.Drawing.Size(203, 112)
        Me.TLB_INVENTORY_VALUE.TabIndex = 5
        '
        'TLB_INVENTORY_VALUE_BTN
        '
        Me.TLB_INVENTORY_VALUE_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TLB_INVENTORY_VALUE_BTN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLB_INVENTORY_VALUE_BTN.FlatAppearance.BorderSize = 0
        Me.TLB_INVENTORY_VALUE_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TLB_INVENTORY_VALUE_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TLB_INVENTORY_VALUE_BTN.Font = New System.Drawing.Font("Leelawadee UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLB_INVENTORY_VALUE_BTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TLB_INVENTORY_VALUE_BTN.Location = New System.Drawing.Point(3, 31)
        Me.TLB_INVENTORY_VALUE_BTN.Name = "TLB_INVENTORY_VALUE_BTN"
        Me.TLB_INVENTORY_VALUE_BTN.Size = New System.Drawing.Size(197, 78)
        Me.TLB_INVENTORY_VALUE_BTN.TabIndex = 1
        Me.TLB_INVENTORY_VALUE_BTN.Text = "0"
        Me.TLB_INVENTORY_VALUE_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TLB_INVENTORY_VALUE_BTN.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(197, 28)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "INVENTORY VALUE"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TLB_ITEMQTY
        '
        Me.TLB_ITEMQTY.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLB_ITEMQTY.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TLB_ITEMQTY.ColumnCount = 1
        Me.TLB_ITEMQTY.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLB_ITEMQTY.Controls.Add(Me.Label6, 0, 0)
        Me.TLB_ITEMQTY.Controls.Add(Me.TLB_ITEMQTY_BTN, 0, 1)
        Me.TLB_ITEMQTY.Location = New System.Drawing.Point(212, 3)
        Me.TLB_ITEMQTY.Name = "TLB_ITEMQTY"
        Me.TLB_ITEMQTY.RowCount = 2
        Me.TLB_ITEMQTY.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLB_ITEMQTY.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLB_ITEMQTY.Size = New System.Drawing.Size(203, 112)
        Me.TLB_ITEMQTY.TabIndex = 6
        '
        'TLB_ITEMQTY_BTN
        '
        Me.TLB_ITEMQTY_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TLB_ITEMQTY_BTN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLB_ITEMQTY_BTN.FlatAppearance.BorderSize = 0
        Me.TLB_ITEMQTY_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TLB_ITEMQTY_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TLB_ITEMQTY_BTN.Font = New System.Drawing.Font("Leelawadee UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLB_ITEMQTY_BTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TLB_ITEMQTY_BTN.Location = New System.Drawing.Point(3, 31)
        Me.TLB_ITEMQTY_BTN.Name = "TLB_ITEMQTY_BTN"
        Me.TLB_ITEMQTY_BTN.Size = New System.Drawing.Size(197, 78)
        Me.TLB_ITEMQTY_BTN.TabIndex = 1
        Me.TLB_ITEMQTY_BTN.Text = "0"
        Me.TLB_ITEMQTY_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TLB_ITEMQTY_BTN.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(197, 28)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ITEM COUNT"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TLB_LOWSTOCK
        '
        Me.TLB_LOWSTOCK.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLB_LOWSTOCK.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TLB_LOWSTOCK.ColumnCount = 1
        Me.TLB_LOWSTOCK.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLB_LOWSTOCK.Controls.Add(Me.Label7, 0, 0)
        Me.TLB_LOWSTOCK.Controls.Add(Me.TLB_QuickInfo_BTN, 0, 1)
        Me.TLB_LOWSTOCK.Location = New System.Drawing.Point(421, 3)
        Me.TLB_LOWSTOCK.Name = "TLB_LOWSTOCK"
        Me.TLB_LOWSTOCK.RowCount = 2
        Me.TLB_LOWSTOCK.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLB_LOWSTOCK.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLB_LOWSTOCK.Size = New System.Drawing.Size(203, 112)
        Me.TLB_LOWSTOCK.TabIndex = 7
        '
        'TLB_QuickInfo_BTN
        '
        Me.TLB_QuickInfo_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TLB_QuickInfo_BTN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLB_QuickInfo_BTN.FlatAppearance.BorderSize = 0
        Me.TLB_QuickInfo_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TLB_QuickInfo_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TLB_QuickInfo_BTN.Font = New System.Drawing.Font("Leelawadee UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLB_QuickInfo_BTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TLB_QuickInfo_BTN.Location = New System.Drawing.Point(3, 31)
        Me.TLB_QuickInfo_BTN.Name = "TLB_QuickInfo_BTN"
        Me.TLB_QuickInfo_BTN.Size = New System.Drawing.Size(197, 78)
        Me.TLB_QuickInfo_BTN.TabIndex = 1
        Me.TLB_QuickInfo_BTN.Text = "0"
        Me.TLB_QuickInfo_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TLB_QuickInfo_BTN.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(197, 28)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "LOW STOCK"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TLB_VALUEOUT
        '
        Me.TLB_VALUEOUT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLB_VALUEOUT.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TLB_VALUEOUT.ColumnCount = 1
        Me.TLB_VALUEOUT.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLB_VALUEOUT.Controls.Add(Me.Label8, 0, 0)
        Me.TLB_VALUEOUT.Controls.Add(Me.TLB_VALUEOUT_BTN, 0, 1)
        Me.TLB_VALUEOUT.Location = New System.Drawing.Point(630, 3)
        Me.TLB_VALUEOUT.Name = "TLB_VALUEOUT"
        Me.TLB_VALUEOUT.RowCount = 2
        Me.TLB_VALUEOUT.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLB_VALUEOUT.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLB_VALUEOUT.Size = New System.Drawing.Size(206, 112)
        Me.TLB_VALUEOUT.TabIndex = 8
        '
        'TLB_VALUEOUT_BTN
        '
        Me.TLB_VALUEOUT_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TLB_VALUEOUT_BTN.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TLB_VALUEOUT_BTN.FlatAppearance.BorderSize = 0
        Me.TLB_VALUEOUT_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TLB_VALUEOUT_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TLB_VALUEOUT_BTN.Font = New System.Drawing.Font("Leelawadee UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLB_VALUEOUT_BTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TLB_VALUEOUT_BTN.Location = New System.Drawing.Point(3, 31)
        Me.TLB_VALUEOUT_BTN.Name = "TLB_VALUEOUT_BTN"
        Me.TLB_VALUEOUT_BTN.Size = New System.Drawing.Size(200, 78)
        Me.TLB_VALUEOUT_BTN.TabIndex = 1
        Me.TLB_VALUEOUT_BTN.Text = "0"
        Me.TLB_VALUEOUT_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TLB_VALUEOUT_BTN.UseVisualStyleBackColor = True
        '
        'APP_LABEL
        '
        Me.APP_LABEL.BackColor = System.Drawing.Color.Transparent
        Me.APP_LABEL.Font = New System.Drawing.Font("Bahnschrift SemiBold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.APP_LABEL.ForeColor = System.Drawing.SystemColors.InfoText
        Me.APP_LABEL.Location = New System.Drawing.Point(23, 14)
        Me.APP_LABEL.Name = "APP_LABEL"
        Me.APP_LABEL.Size = New System.Drawing.Size(441, 100)
        Me.APP_LABEL.TabIndex = 15
        Me.APP_LABEL.Text = "JUANCHO'S VARIETY SHOP INVENTORY SYSTEM"
        Me.APP_LABEL.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(200, 28)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ITEMS OUT - WEEK"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel_Home
        '
        Me.Panel_Home.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Home.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel_Home.Controls.Add(Me.APP_LABEL)
        Me.Panel_Home.Controls.Add(Me.GroupBox_INFO)
        Me.Panel_Home.Controls.Add(Me.Panel_DayView)
        Me.Panel_Home.Controls.Add(Me.GBX_Dashboard_Controls)
        Me.Panel_Home.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Home.Name = "Panel_Home"
        Me.Panel_Home.Size = New System.Drawing.Size(884, 661)
        Me.Panel_Home.TabIndex = 3
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel_Sidebar.ResumeLayout(False)
        Me.Panel_Main.ResumeLayout(False)
        Me.Panel_Items.ResumeLayout(False)
        Me.Panel_Items.PerformLayout()
        Me.Panel_History.ResumeLayout(False)
        Me.Panel_History.PerformLayout()
        Me.Panel_Settings.ResumeLayout(False)
        Me.Panel_Settings.PerformLayout()
        Me.GBX_Dashboard_Controls.ResumeLayout(False)
        Me.TLP_Home_BTN.ResumeLayout(False)
        Me.Panel_DayView.ResumeLayout(False)
        Me.Panel_DV_Top.ResumeLayout(False)
        Me.GroupBox_INFO.ResumeLayout(False)
        Me.TLB_QuickInfo.ResumeLayout(False)
        Me.TLB_INVENTORY_VALUE.ResumeLayout(False)
        Me.TLB_ITEMQTY.ResumeLayout(False)
        Me.TLB_LOWSTOCK.ResumeLayout(False)
        Me.TLB_VALUEOUT.ResumeLayout(False)
        Me.Panel_Home.ResumeLayout(False)
        Me.Panel_Home.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Sidebar As Panel
    Friend WithEvents Panel_Main As Panel
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
    Friend WithEvents Panel_Home As Panel
    Friend WithEvents APP_LABEL As Label
    Friend WithEvents GroupBox_INFO As GroupBox
    Friend WithEvents TLB_QuickInfo As TableLayoutPanel
    Friend WithEvents TLB_VALUEOUT As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents TLB_VALUEOUT_BTN As Button
    Friend WithEvents TLB_LOWSTOCK As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents TLB_QuickInfo_BTN As Button
    Friend WithEvents TLB_ITEMQTY As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents TLB_ITEMQTY_BTN As Button
    Friend WithEvents TLB_INVENTORY_VALUE As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents TLB_INVENTORY_VALUE_BTN As Button
    Friend WithEvents Panel_DayView As Panel
    Friend WithEvents Panel_DV_Top As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents GBX_Dashboard_Controls As GroupBox
    Friend WithEvents TLP_Home_BTN As TableLayoutPanel
    Friend WithEvents HOME_BTN_OUT As Button
    Friend WithEvents HOME_BTN_IN As Button
    Friend WithEvents HOME_BTN_ADDITEM As Button
    Friend WithEvents HOME_BTN_REPORTS As Button
End Class
