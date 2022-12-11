<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Item
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FORM_LABEL = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.FI_NUD_ITM_THRESHOLD = New System.Windows.Forms.NumericUpDown()
        Me.FI_NUD_ITM_STOCK = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FI_TBX_ITEM_TOPAY = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.RB_CONSIGNED = New System.Windows.Forms.RadioButton()
        Me.RB_LOANED = New System.Windows.Forms.RadioButton()
        Me.RB_OWNED = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FI_CBX_ITEM_SUPP = New System.Windows.Forms.ComboBox()
        Me.GB_SELL_PRICE = New System.Windows.Forms.GroupBox()
        Me.Manual_CBX = New System.Windows.Forms.CheckBox()
        Me.Price_Manual = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FI_TBX_L_PRICE = New System.Windows.Forms.TextBox()
        Me.FI_TBX_M_PRICE = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.FI_TBX_U_PERCENT = New System.Windows.Forms.TextBox()
        Me.FI_TBX_L_PERCENT = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FI_TBX_ITEM_COST = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FI_CBX_ITM_VARIANT = New System.Windows.Forms.ComboBox()
        Me.FI_CBX_ITM_BRAND = New System.Windows.Forms.ComboBox()
        Me.FI_CBX_ITM_CAT = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FI_TBX_ITM_NAME = New System.Windows.Forms.TextBox()
        Me.FI_BTN_SAVE = New System.Windows.Forms.Button()
        Me.FI_BTN_CANCEL = New System.Windows.Forms.Button()
        Me.FI_BTN_RESET = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.FI_NUD_ITM_THRESHOLD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FI_NUD_ITM_STOCK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.GB_SELL_PRICE.SuspendLayout()
        Me.Price_Manual.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.FORM_LABEL)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(656, 44)
        Me.Panel1.TabIndex = 0
        '
        'FORM_LABEL
        '
        Me.FORM_LABEL.BackColor = System.Drawing.Color.Transparent
        Me.FORM_LABEL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FORM_LABEL.Font = New System.Drawing.Font("Leelawadee UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FORM_LABEL.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.FORM_LABEL.Location = New System.Drawing.Point(0, 0)
        Me.FORM_LABEL.Name = "FORM_LABEL"
        Me.FORM_LABEL.Size = New System.Drawing.Size(656, 44)
        Me.FORM_LABEL.TabIndex = 16
        Me.FORM_LABEL.Text = "ITEM FORM"
        Me.FORM_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(13, 462)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(622, 2)
        Me.Panel2.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Black
        Me.SplitContainer1.Location = New System.Drawing.Point(13, 174)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.FI_NUD_ITM_THRESHOLD)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FI_NUD_ITM_STOCK)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FI_TBX_ITEM_TOPAY)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel2.Controls.Add(Me.FI_CBX_ITEM_SUPP)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GB_SELL_PRICE)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel2.Controls.Add(Me.FI_TBX_ITEM_COST)
        Me.SplitContainer1.Size = New System.Drawing.Size(630, 273)
        Me.SplitContainer1.SplitterDistance = 289
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 2
        '
        'FI_NUD_ITM_THRESHOLD
        '
        Me.FI_NUD_ITM_THRESHOLD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FI_NUD_ITM_THRESHOLD.Font = New System.Drawing.Font("Leelawadee UI", 11.25!)
        Me.FI_NUD_ITM_THRESHOLD.Location = New System.Drawing.Point(102, 45)
        Me.FI_NUD_ITM_THRESHOLD.Name = "FI_NUD_ITM_THRESHOLD"
        Me.FI_NUD_ITM_THRESHOLD.Size = New System.Drawing.Size(166, 27)
        Me.FI_NUD_ITM_THRESHOLD.TabIndex = 6
        '
        'FI_NUD_ITM_STOCK
        '
        Me.FI_NUD_ITM_STOCK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FI_NUD_ITM_STOCK.Font = New System.Drawing.Font("Leelawadee UI", 11.25!)
        Me.FI_NUD_ITM_STOCK.Location = New System.Drawing.Point(102, 12)
        Me.FI_NUD_ITM_STOCK.Name = "FI_NUD_ITM_STOCK"
        Me.FI_NUD_ITM_STOCK.Size = New System.Drawing.Size(166, 27)
        Me.FI_NUD_ITM_STOCK.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Leelawadee UI", 10.25!)
        Me.Label8.Location = New System.Drawing.Point(3, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 19)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "THRESHOLD:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Leelawadee UI", 10.25!)
        Me.Label7.Location = New System.Drawing.Point(38, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 19)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "STOCK:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Leelawadee UI", 10.25!)
        Me.Label6.Location = New System.Drawing.Point(34, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 19)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "TO PAY:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FI_TBX_ITEM_TOPAY
        '
        Me.FI_TBX_ITEM_TOPAY.Font = New System.Drawing.Font("Leelawadee UI", 11.25!)
        Me.FI_TBX_ITEM_TOPAY.Location = New System.Drawing.Point(101, 179)
        Me.FI_TBX_ITEM_TOPAY.Name = "FI_TBX_ITEM_TOPAY"
        Me.FI_TBX_ITEM_TOPAY.ReadOnly = True
        Me.FI_TBX_ITEM_TOPAY.Size = New System.Drawing.Size(167, 27)
        Me.FI_TBX_ITEM_TOPAY.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.RB_CONSIGNED)
        Me.Panel4.Controls.Add(Me.RB_LOANED)
        Me.Panel4.Controls.Add(Me.RB_OWNED)
        Me.Panel4.Location = New System.Drawing.Point(101, 98)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(167, 75)
        Me.Panel4.TabIndex = 6
        '
        'RB_CONSIGNED
        '
        Me.RB_CONSIGNED.AutoSize = True
        Me.RB_CONSIGNED.Font = New System.Drawing.Font("Leelawadee UI", 10.25!)
        Me.RB_CONSIGNED.Location = New System.Drawing.Point(9, 23)
        Me.RB_CONSIGNED.Name = "RB_CONSIGNED"
        Me.RB_CONSIGNED.Size = New System.Drawing.Size(105, 23)
        Me.RB_CONSIGNED.TabIndex = 8
        Me.RB_CONSIGNED.TabStop = True
        Me.RB_CONSIGNED.Text = "CONSIGNED"
        Me.RB_CONSIGNED.UseVisualStyleBackColor = True
        '
        'RB_LOANED
        '
        Me.RB_LOANED.AutoSize = True
        Me.RB_LOANED.Font = New System.Drawing.Font("Leelawadee UI", 10.25!)
        Me.RB_LOANED.Location = New System.Drawing.Point(9, 46)
        Me.RB_LOANED.Name = "RB_LOANED"
        Me.RB_LOANED.Size = New System.Drawing.Size(81, 23)
        Me.RB_LOANED.TabIndex = 9
        Me.RB_LOANED.TabStop = True
        Me.RB_LOANED.Text = "LOANED"
        Me.RB_LOANED.UseVisualStyleBackColor = True
        '
        'RB_OWNED
        '
        Me.RB_OWNED.AutoSize = True
        Me.RB_OWNED.Font = New System.Drawing.Font("Leelawadee UI", 10.25!)
        Me.RB_OWNED.Location = New System.Drawing.Point(9, 0)
        Me.RB_OWNED.Name = "RB_OWNED"
        Me.RB_OWNED.Size = New System.Drawing.Size(78, 23)
        Me.RB_OWNED.TabIndex = 7
        Me.RB_OWNED.TabStop = True
        Me.RB_OWNED.Text = "OWNED"
        Me.RB_OWNED.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Leelawadee UI", 10.25!)
        Me.Label5.Location = New System.Drawing.Point(14, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 41)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "HOLDING STATUS:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FI_CBX_ITEM_SUPP
        '
        Me.FI_CBX_ITEM_SUPP.Font = New System.Drawing.Font("Leelawadee UI", 11.25!)
        Me.FI_CBX_ITEM_SUPP.FormattingEnabled = True
        Me.FI_CBX_ITEM_SUPP.Location = New System.Drawing.Point(104, 11)
        Me.FI_CBX_ITEM_SUPP.Name = "FI_CBX_ITEM_SUPP"
        Me.FI_CBX_ITEM_SUPP.Size = New System.Drawing.Size(220, 28)
        Me.FI_CBX_ITEM_SUPP.TabIndex = 11
        '
        'GB_SELL_PRICE
        '
        Me.GB_SELL_PRICE.Controls.Add(Me.Manual_CBX)
        Me.GB_SELL_PRICE.Controls.Add(Me.Price_Manual)
        Me.GB_SELL_PRICE.Controls.Add(Me.Label14)
        Me.GB_SELL_PRICE.Controls.Add(Me.Label13)
        Me.GB_SELL_PRICE.Controls.Add(Me.FI_TBX_U_PERCENT)
        Me.GB_SELL_PRICE.Controls.Add(Me.FI_TBX_L_PERCENT)
        Me.GB_SELL_PRICE.Enabled = False
        Me.GB_SELL_PRICE.Font = New System.Drawing.Font("Leelawadee UI", 10.25!, System.Drawing.FontStyle.Bold)
        Me.GB_SELL_PRICE.Location = New System.Drawing.Point(11, 98)
        Me.GB_SELL_PRICE.Name = "GB_SELL_PRICE"
        Me.GB_SELL_PRICE.Size = New System.Drawing.Size(313, 172)
        Me.GB_SELL_PRICE.TabIndex = 35
        Me.GB_SELL_PRICE.TabStop = False
        Me.GB_SELL_PRICE.Text = "SELL PRICE:"
        '
        'Manual_CBX
        '
        Me.Manual_CBX.AutoSize = True
        Me.Manual_CBX.Location = New System.Drawing.Point(6, 73)
        Me.Manual_CBX.Name = "Manual_CBX"
        Me.Manual_CBX.Size = New System.Drawing.Size(102, 23)
        Me.Manual_CBX.TabIndex = 15
        Me.Manual_CBX.Text = "Manual Set"
        Me.Manual_CBX.UseVisualStyleBackColor = True
        '
        'Price_Manual
        '
        Me.Price_Manual.Controls.Add(Me.Label12)
        Me.Price_Manual.Controls.Add(Me.FI_TBX_L_PRICE)
        Me.Price_Manual.Controls.Add(Me.FI_TBX_M_PRICE)
        Me.Price_Manual.Controls.Add(Me.Label11)
        Me.Price_Manual.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Price_Manual.Enabled = False
        Me.Price_Manual.Location = New System.Drawing.Point(3, 99)
        Me.Price_Manual.Name = "Price_Manual"
        Me.Price_Manual.Size = New System.Drawing.Size(307, 70)
        Me.Price_Manual.TabIndex = 39
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Leelawadee UI", 10.25!)
        Me.Label12.Location = New System.Drawing.Point(4, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 19)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "MAXIMUM:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FI_TBX_L_PRICE
        '
        Me.FI_TBX_L_PRICE.Font = New System.Drawing.Font("Leelawadee UI", 11.25!)
        Me.FI_TBX_L_PRICE.Location = New System.Drawing.Point(90, 4)
        Me.FI_TBX_L_PRICE.Name = "FI_TBX_L_PRICE"
        Me.FI_TBX_L_PRICE.Size = New System.Drawing.Size(212, 27)
        Me.FI_TBX_L_PRICE.TabIndex = 16
        Me.ToolTip2.SetToolTip(Me.FI_TBX_L_PRICE, "Your set prices are lower that the item's set cost!")
        '
        'FI_TBX_M_PRICE
        '
        Me.FI_TBX_M_PRICE.Font = New System.Drawing.Font("Leelawadee UI", 11.25!)
        Me.FI_TBX_M_PRICE.Location = New System.Drawing.Point(90, 37)
        Me.FI_TBX_M_PRICE.Name = "FI_TBX_M_PRICE"
        Me.FI_TBX_M_PRICE.Size = New System.Drawing.Size(212, 27)
        Me.FI_TBX_M_PRICE.TabIndex = 17
        Me.ToolTip2.SetToolTip(Me.FI_TBX_M_PRICE, "Your set prices are lower that the item's set cost!")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Leelawadee UI", 10.25!)
        Me.Label11.Location = New System.Drawing.Point(8, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 19)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "MINIMUM:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Leelawadee UI", 10.25!)
        Me.Label14.Location = New System.Drawing.Point(11, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 45)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "PERCENT MARGIN:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Leelawadee UI", 10.25!)
        Me.Label13.Location = New System.Drawing.Point(191, 38)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 19)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "-"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FI_TBX_U_PERCENT
        '
        Me.FI_TBX_U_PERCENT.Font = New System.Drawing.Font("Leelawadee UI", 11.25!)
        Me.FI_TBX_U_PERCENT.Location = New System.Drawing.Point(211, 34)
        Me.FI_TBX_U_PERCENT.Name = "FI_TBX_U_PERCENT"
        Me.FI_TBX_U_PERCENT.Size = New System.Drawing.Size(94, 27)
        Me.FI_TBX_U_PERCENT.TabIndex = 14
        Me.FI_TBX_U_PERCENT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FI_TBX_L_PERCENT
        '
        Me.FI_TBX_L_PERCENT.Font = New System.Drawing.Font("Leelawadee UI", 11.25!)
        Me.FI_TBX_L_PERCENT.Location = New System.Drawing.Point(93, 34)
        Me.FI_TBX_L_PERCENT.Name = "FI_TBX_L_PERCENT"
        Me.FI_TBX_L_PERCENT.Size = New System.Drawing.Size(94, 27)
        Me.FI_TBX_L_PERCENT.TabIndex = 13
        Me.FI_TBX_L_PERCENT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Leelawadee UI", 10.25!)
        Me.Label10.Location = New System.Drawing.Point(7, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 27)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "SUPPLIER:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Leelawadee UI", 10.25!)
        Me.Label9.Location = New System.Drawing.Point(10, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 43)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "PURCHASE COST:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FI_TBX_ITEM_COST
        '
        Me.FI_TBX_ITEM_COST.Font = New System.Drawing.Font("Leelawadee UI", 11.25!)
        Me.FI_TBX_ITEM_COST.Location = New System.Drawing.Point(104, 52)
        Me.FI_TBX_ITEM_COST.Name = "FI_TBX_ITEM_COST"
        Me.FI_TBX_ITEM_COST.Size = New System.Drawing.Size(220, 27)
        Me.FI_TBX_ITEM_COST.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.FI_CBX_ITM_VARIANT)
        Me.Panel3.Controls.Add(Me.FI_CBX_ITM_BRAND)
        Me.Panel3.Controls.Add(Me.FI_CBX_ITM_CAT)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.FI_TBX_ITM_NAME)
        Me.Panel3.Location = New System.Drawing.Point(13, 54)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(630, 106)
        Me.Panel3.TabIndex = 1
        '
        'FI_CBX_ITM_VARIANT
        '
        Me.FI_CBX_ITM_VARIANT.Font = New System.Drawing.Font("Leelawadee UI", 11.25!)
        Me.FI_CBX_ITM_VARIANT.FormattingEnabled = True
        Me.FI_CBX_ITM_VARIANT.Location = New System.Drawing.Point(410, 60)
        Me.FI_CBX_ITM_VARIANT.Name = "FI_CBX_ITM_VARIANT"
        Me.FI_CBX_ITM_VARIANT.Size = New System.Drawing.Size(204, 28)
        Me.FI_CBX_ITM_VARIANT.TabIndex = 4
        '
        'FI_CBX_ITM_BRAND
        '
        Me.FI_CBX_ITM_BRAND.Font = New System.Drawing.Font("Leelawadee UI", 11.25!)
        Me.FI_CBX_ITM_BRAND.FormattingEnabled = True
        Me.FI_CBX_ITM_BRAND.Location = New System.Drawing.Point(101, 60)
        Me.FI_CBX_ITM_BRAND.Name = "FI_CBX_ITM_BRAND"
        Me.FI_CBX_ITM_BRAND.Size = New System.Drawing.Size(222, 28)
        Me.FI_CBX_ITM_BRAND.TabIndex = 3
        '
        'FI_CBX_ITM_CAT
        '
        Me.FI_CBX_ITM_CAT.Font = New System.Drawing.Font("Leelawadee UI", 11.25!)
        Me.FI_CBX_ITM_CAT.FormattingEnabled = True
        Me.FI_CBX_ITM_CAT.Location = New System.Drawing.Point(483, 18)
        Me.FI_CBX_ITM_CAT.Name = "FI_CBX_ITM_CAT"
        Me.FI_CBX_ITM_CAT.Size = New System.Drawing.Size(131, 28)
        Me.FI_CBX_ITM_CAT.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Leelawadee UI", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(399, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "CATEGORY:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Leelawadee UI", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(329, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "VARIANT:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Leelawadee UI", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(37, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "BRAND:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(8, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "ITEM NAME:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FI_TBX_ITM_NAME
        '
        Me.FI_TBX_ITM_NAME.Font = New System.Drawing.Font("Leelawadee UI", 11.25!)
        Me.FI_TBX_ITM_NAME.Location = New System.Drawing.Point(101, 19)
        Me.FI_TBX_ITM_NAME.Name = "FI_TBX_ITM_NAME"
        Me.FI_TBX_ITM_NAME.Size = New System.Drawing.Size(285, 27)
        Me.FI_TBX_ITM_NAME.TabIndex = 1
        '
        'FI_BTN_SAVE
        '
        Me.FI_BTN_SAVE.BackColor = System.Drawing.Color.ForestGreen
        Me.FI_BTN_SAVE.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.FI_BTN_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FI_BTN_SAVE.Font = New System.Drawing.Font("Leelawadee UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.FI_BTN_SAVE.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FI_BTN_SAVE.Location = New System.Drawing.Point(500, 470)
        Me.FI_BTN_SAVE.Name = "FI_BTN_SAVE"
        Me.FI_BTN_SAVE.Size = New System.Drawing.Size(135, 47)
        Me.FI_BTN_SAVE.TabIndex = 18
        Me.FI_BTN_SAVE.Text = "SAVE"
        Me.FI_BTN_SAVE.UseVisualStyleBackColor = False
        '
        'FI_BTN_CANCEL
        '
        Me.FI_BTN_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FI_BTN_CANCEL.Font = New System.Drawing.Font("Leelawadee UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.FI_BTN_CANCEL.Location = New System.Drawing.Point(359, 470)
        Me.FI_BTN_CANCEL.Name = "FI_BTN_CANCEL"
        Me.FI_BTN_CANCEL.Size = New System.Drawing.Size(135, 47)
        Me.FI_BTN_CANCEL.TabIndex = 19
        Me.FI_BTN_CANCEL.Text = "CANCEL"
        Me.FI_BTN_CANCEL.UseVisualStyleBackColor = True
        '
        'FI_BTN_RESET
        '
        Me.FI_BTN_RESET.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FI_BTN_RESET.Font = New System.Drawing.Font("Leelawadee UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.FI_BTN_RESET.Location = New System.Drawing.Point(218, 470)
        Me.FI_BTN_RESET.Name = "FI_BTN_RESET"
        Me.FI_BTN_RESET.Size = New System.Drawing.Size(135, 47)
        Me.FI_BTN_RESET.TabIndex = 20
        Me.FI_BTN_RESET.Text = "RESET"
        Me.FI_BTN_RESET.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        Me.ToolTip1.ToolTipTitle = "Warning!"
        '
        'ToolTip2
        '
        Me.ToolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        Me.ToolTip2.ToolTipTitle = "Sell Prices too low"
        '
        'Form_Item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(656, 532)
        Me.Controls.Add(Me.FI_BTN_RESET)
        Me.Controls.Add(Me.FI_BTN_CANCEL)
        Me.Controls.Add(Me.FI_BTN_SAVE)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(672, 571)
        Me.MinimumSize = New System.Drawing.Size(672, 571)
        Me.Name = "Form_Item"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_New_Item"
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.FI_NUD_ITM_THRESHOLD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FI_NUD_ITM_STOCK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GB_SELL_PRICE.ResumeLayout(False)
        Me.GB_SELL_PRICE.PerformLayout()
        Me.Price_Manual.ResumeLayout(False)
        Me.Price_Manual.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FORM_LABEL As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents FI_NUD_ITM_THRESHOLD As NumericUpDown
    Friend WithEvents FI_NUD_ITM_STOCK As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents FI_TBX_ITEM_TOPAY As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents RB_CONSIGNED As RadioButton
    Friend WithEvents RB_LOANED As RadioButton
    Friend WithEvents RB_OWNED As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents FI_CBX_ITEM_SUPP As ComboBox
    Friend WithEvents GB_SELL_PRICE As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents FI_TBX_M_PRICE As TextBox
    Friend WithEvents FI_TBX_L_PRICE As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents FI_TBX_ITEM_COST As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents FI_CBX_ITM_VARIANT As ComboBox
    Friend WithEvents FI_CBX_ITM_BRAND As ComboBox
    Friend WithEvents FI_CBX_ITM_CAT As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FI_TBX_ITM_NAME As TextBox
    Friend WithEvents FI_BTN_SAVE As Button
    Friend WithEvents FI_BTN_CANCEL As Button
    Friend WithEvents FI_BTN_RESET As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents FI_TBX_U_PERCENT As TextBox
    Friend WithEvents FI_TBX_L_PERCENT As TextBox
    Friend WithEvents Manual_CBX As CheckBox
    Friend WithEvents Price_Manual As Panel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
End Class
