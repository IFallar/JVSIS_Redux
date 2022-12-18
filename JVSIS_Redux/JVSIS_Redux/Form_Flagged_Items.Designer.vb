<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Flagged_Items
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FS_RS_TBX = New System.Windows.Forms.TextBox()
        Me.DTG_SUGGEST = New System.Windows.Forms.Panel()
        Me.DTG_ITM_RECC = New System.Windows.Forms.DataGridView()
        Me.FS_RS_SUPP = New System.Windows.Forms.TextBox()
        Me.FS_RS_VAR = New System.Windows.Forms.TextBox()
        Me.FS_RS_BRAND = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Flagged_Item_GridView = New System.Windows.Forms.DataGridView()
        Me.FI_BTN_RLV = New System.Windows.Forms.Button()
        Me.FI_BTN_RMV = New System.Windows.Forms.Button()
        Me.FI_BTN_SAVE = New System.Windows.Forms.Button()
        Me.Issue_Box = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RETURN_UNIT = New System.Windows.Forms.NumericUpDown()
        Me.Deduct = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FORM_LABEL = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.DTG_SUGGEST.SuspendLayout()
        CType(Me.DTG_ITM_RECC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Flagged_Item_GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RETURN_UNIT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.FS_RS_TBX)
        Me.Panel3.Controls.Add(Me.DTG_SUGGEST)
        Me.Panel3.Controls.Add(Me.FS_RS_SUPP)
        Me.Panel3.Controls.Add(Me.FS_RS_VAR)
        Me.Panel3.Controls.Add(Me.FS_RS_BRAND)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(12, 251)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(313, 197)
        Me.Panel3.TabIndex = 3
        '
        'FS_RS_TBX
        '
        Me.FS_RS_TBX.Font = New System.Drawing.Font("Leelawadee UI", 11.25!)
        Me.FS_RS_TBX.Location = New System.Drawing.Point(16, 30)
        Me.FS_RS_TBX.Name = "FS_RS_TBX"
        Me.FS_RS_TBX.Size = New System.Drawing.Size(278, 27)
        Me.FS_RS_TBX.TabIndex = 1
        '
        'DTG_SUGGEST
        '
        Me.DTG_SUGGEST.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.DTG_SUGGEST.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DTG_SUGGEST.Controls.Add(Me.DTG_ITM_RECC)
        Me.DTG_SUGGEST.Location = New System.Drawing.Point(16, 63)
        Me.DTG_SUGGEST.Name = "DTG_SUGGEST"
        Me.DTG_SUGGEST.Size = New System.Drawing.Size(278, 15)
        Me.DTG_SUGGEST.TabIndex = 45
        '
        'DTG_ITM_RECC
        '
        Me.DTG_ITM_RECC.AllowUserToAddRows = False
        Me.DTG_ITM_RECC.AllowUserToDeleteRows = False
        Me.DTG_ITM_RECC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DTG_ITM_RECC.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DTG_ITM_RECC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DTG_ITM_RECC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTG_ITM_RECC.ColumnHeadersVisible = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Leelawadee UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DTG_ITM_RECC.DefaultCellStyle = DataGridViewCellStyle7
        Me.DTG_ITM_RECC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DTG_ITM_RECC.Location = New System.Drawing.Point(0, 0)
        Me.DTG_ITM_RECC.MultiSelect = False
        Me.DTG_ITM_RECC.Name = "DTG_ITM_RECC"
        Me.DTG_ITM_RECC.ReadOnly = True
        Me.DTG_ITM_RECC.RowHeadersVisible = False
        Me.DTG_ITM_RECC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTG_ITM_RECC.Size = New System.Drawing.Size(278, 15)
        Me.DTG_ITM_RECC.TabIndex = 0
        '
        'FS_RS_SUPP
        '
        Me.FS_RS_SUPP.Font = New System.Drawing.Font("Leelawadee UI", 11.25!)
        Me.FS_RS_SUPP.Location = New System.Drawing.Point(16, 154)
        Me.FS_RS_SUPP.Name = "FS_RS_SUPP"
        Me.FS_RS_SUPP.ReadOnly = True
        Me.FS_RS_SUPP.Size = New System.Drawing.Size(278, 27)
        Me.FS_RS_SUPP.TabIndex = 41
        '
        'FS_RS_VAR
        '
        Me.FS_RS_VAR.Font = New System.Drawing.Font("Leelawadee UI", 11.25!)
        Me.FS_RS_VAR.Location = New System.Drawing.Point(159, 101)
        Me.FS_RS_VAR.Name = "FS_RS_VAR"
        Me.FS_RS_VAR.ReadOnly = True
        Me.FS_RS_VAR.Size = New System.Drawing.Size(135, 27)
        Me.FS_RS_VAR.TabIndex = 40
        '
        'FS_RS_BRAND
        '
        Me.FS_RS_BRAND.Font = New System.Drawing.Font("Leelawadee UI", 11.25!)
        Me.FS_RS_BRAND.Location = New System.Drawing.Point(16, 101)
        Me.FS_RS_BRAND.Name = "FS_RS_BRAND"
        Me.FS_RS_BRAND.ReadOnly = True
        Me.FS_RS_BRAND.Size = New System.Drawing.Size(133, 27)
        Me.FS_RS_BRAND.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Leelawadee UI", 10.25!)
        Me.Label10.Location = New System.Drawing.Point(12, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 27)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "SUPPLIER:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Leelawadee UI", 10.25!)
        Me.Label3.Location = New System.Drawing.Point(155, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "VARIANT:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Leelawadee UI", 10.25!)
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "BRAND:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 10.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 19)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "ITEM NAME:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Flagged_Item_GridView
        '
        Me.Flagged_Item_GridView.AllowUserToAddRows = False
        Me.Flagged_Item_GridView.AllowUserToDeleteRows = False
        Me.Flagged_Item_GridView.AllowUserToResizeColumns = False
        Me.Flagged_Item_GridView.AllowUserToResizeRows = False
        Me.Flagged_Item_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Flagged_Item_GridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Flagged_Item_GridView.BackgroundColor = System.Drawing.Color.White
        Me.Flagged_Item_GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Flagged_Item_GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Flagged_Item_GridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Flagged_Item_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Flagged_Item_GridView.DefaultCellStyle = DataGridViewCellStyle9
        Me.Flagged_Item_GridView.EnableHeadersVisualStyles = False
        Me.Flagged_Item_GridView.GridColor = System.Drawing.SystemColors.Control
        Me.Flagged_Item_GridView.Location = New System.Drawing.Point(12, 46)
        Me.Flagged_Item_GridView.Name = "Flagged_Item_GridView"
        Me.Flagged_Item_GridView.RowHeadersVisible = False
        Me.Flagged_Item_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Flagged_Item_GridView.Size = New System.Drawing.Size(725, 197)
        Me.Flagged_Item_GridView.TabIndex = 28
        '
        'FI_BTN_RLV
        '
        Me.FI_BTN_RLV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FI_BTN_RLV.Font = New System.Drawing.Font("Leelawadee UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.FI_BTN_RLV.Location = New System.Drawing.Point(607, 252)
        Me.FI_BTN_RLV.Name = "FI_BTN_RLV"
        Me.FI_BTN_RLV.Size = New System.Drawing.Size(130, 32)
        Me.FI_BTN_RLV.TabIndex = 31
        Me.FI_BTN_RLV.Text = "RESOLVE"
        Me.FI_BTN_RLV.UseVisualStyleBackColor = True
        '
        'FI_BTN_RMV
        '
        Me.FI_BTN_RMV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FI_BTN_RMV.Font = New System.Drawing.Font("Leelawadee UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.FI_BTN_RMV.Location = New System.Drawing.Point(471, 252)
        Me.FI_BTN_RMV.Name = "FI_BTN_RMV"
        Me.FI_BTN_RMV.Size = New System.Drawing.Size(130, 32)
        Me.FI_BTN_RMV.TabIndex = 30
        Me.FI_BTN_RMV.Text = "REMOVE"
        Me.FI_BTN_RMV.UseVisualStyleBackColor = True
        '
        'FI_BTN_SAVE
        '
        Me.FI_BTN_SAVE.BackColor = System.Drawing.Color.ForestGreen
        Me.FI_BTN_SAVE.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.FI_BTN_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FI_BTN_SAVE.Font = New System.Drawing.Font("Leelawadee UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.FI_BTN_SAVE.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FI_BTN_SAVE.Location = New System.Drawing.Point(607, 416)
        Me.FI_BTN_SAVE.Name = "FI_BTN_SAVE"
        Me.FI_BTN_SAVE.Size = New System.Drawing.Size(130, 32)
        Me.FI_BTN_SAVE.TabIndex = 29
        Me.FI_BTN_SAVE.Text = "SAVE"
        Me.FI_BTN_SAVE.UseVisualStyleBackColor = False
        '
        'Issue_Box
        '
        Me.Issue_Box.Font = New System.Drawing.Font("Leelawadee UI", 11.25!)
        Me.Issue_Box.Location = New System.Drawing.Point(342, 316)
        Me.Issue_Box.Name = "Issue_Box"
        Me.Issue_Box.Size = New System.Drawing.Size(395, 27)
        Me.Issue_Box.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Leelawadee UI", 10.25!)
        Me.Label4.Location = New System.Drawing.Point(338, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 19)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "ITEM ISSUE:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Leelawadee UI", 10.25!)
        Me.Label5.Location = New System.Drawing.Point(338, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 19)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "UNITS:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RETURN_UNIT
        '
        Me.RETURN_UNIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RETURN_UNIT.Font = New System.Drawing.Font("Leelawadee UI", 11.25!)
        Me.RETURN_UNIT.Location = New System.Drawing.Point(342, 371)
        Me.RETURN_UNIT.Name = "RETURN_UNIT"
        Me.RETURN_UNIT.Size = New System.Drawing.Size(154, 27)
        Me.RETURN_UNIT.TabIndex = 50
        '
        'Deduct
        '
        Me.Deduct.AutoSize = True
        Me.Deduct.Font = New System.Drawing.Font("Leelawadee UI", 10.25!)
        Me.Deduct.Location = New System.Drawing.Point(510, 373)
        Me.Deduct.Name = "Deduct"
        Me.Deduct.Size = New System.Drawing.Size(170, 23)
        Me.Deduct.TabIndex = 51
        Me.Deduct.TabStop = True
        Me.Deduct.Text = "Deduct From Inventory"
        Me.Deduct.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Leelawadee UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(471, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 32)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "RESET"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.FORM_LABEL)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(749, 40)
        Me.Panel1.TabIndex = 53
        '
        'FORM_LABEL
        '
        Me.FORM_LABEL.BackColor = System.Drawing.Color.Transparent
        Me.FORM_LABEL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FORM_LABEL.Font = New System.Drawing.Font("Leelawadee UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FORM_LABEL.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.FORM_LABEL.Location = New System.Drawing.Point(0, 0)
        Me.FORM_LABEL.Name = "FORM_LABEL"
        Me.FORM_LABEL.Size = New System.Drawing.Size(749, 40)
        Me.FORM_LABEL.TabIndex = 16
        Me.FORM_LABEL.Text = "RETURN FORM"
        Me.FORM_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form_Flagged_Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 460)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Deduct)
        Me.Controls.Add(Me.RETURN_UNIT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Issue_Box)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FI_BTN_RLV)
        Me.Controls.Add(Me.FI_BTN_RMV)
        Me.Controls.Add(Me.FI_BTN_SAVE)
        Me.Controls.Add(Me.Flagged_Item_GridView)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Form_Flagged_Items"
        Me.Text = "ITEMS OF CONCERN"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.DTG_SUGGEST.ResumeLayout(False)
        CType(Me.DTG_ITM_RECC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Flagged_Item_GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RETURN_UNIT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents FS_RS_TBX As TextBox
    Friend WithEvents DTG_SUGGEST As Panel
    Friend WithEvents DTG_ITM_RECC As DataGridView
    Friend WithEvents FS_RS_SUPP As TextBox
    Friend WithEvents FS_RS_VAR As TextBox
    Friend WithEvents FS_RS_BRAND As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Flagged_Item_GridView As DataGridView
    Friend WithEvents FI_BTN_RLV As Button
    Friend WithEvents FI_BTN_RMV As Button
    Friend WithEvents FI_BTN_SAVE As Button
    Friend WithEvents Issue_Box As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RETURN_UNIT As NumericUpDown
    Friend WithEvents Deduct As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FORM_LABEL As Label
End Class
