<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Stock_DB
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FS_RS_TBX = New System.Windows.Forms.TextBox()
        Me.DTG_SUGGEST = New System.Windows.Forms.Panel()
        Me.DTG_ITM_RECC = New System.Windows.Forms.DataGridView()
        Me.FS_RS_SUPP = New System.Windows.Forms.TextBox()
        Me.FS_RS_VAR = New System.Windows.Forms.TextBox()
        Me.FS_RS_BRAND = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.New_QTY = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Cur_Stock = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FI_BTN_CANCEL = New System.Windows.Forms.Button()
        Me.FI_BTN_SAVE = New System.Windows.Forms.Button()
        Me.FSHS_ADD_BTN = New System.Windows.Forms.Button()
        Me.FSHS_MIN_BTN = New System.Windows.Forms.Button()
        Me.QTY_HOLDER = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.FORM_LABEL = New System.Windows.Forms.Label()
        Me.Panel_Num_Controls = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.DTG_SUGGEST.SuspendLayout()
        CType(Me.DTG_ITM_RECC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel_Num_Controls.SuspendLayout()
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
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.New_QTY)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Cur_Stock)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(11, 54)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(513, 197)
        Me.Panel3.TabIndex = 2
        '
        'FS_RS_TBX
        '
        Me.FS_RS_TBX.Font = New System.Drawing.Font("Leelawadee UI", 11.25!)
        Me.FS_RS_TBX.Location = New System.Drawing.Point(13, 30)
        Me.FS_RS_TBX.Name = "FS_RS_TBX"
        Me.FS_RS_TBX.Size = New System.Drawing.Size(332, 27)
        Me.FS_RS_TBX.TabIndex = 1
        '
        'DTG_SUGGEST
        '
        Me.DTG_SUGGEST.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.DTG_SUGGEST.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DTG_SUGGEST.Controls.Add(Me.DTG_ITM_RECC)
        Me.DTG_SUGGEST.Location = New System.Drawing.Point(13, 63)
        Me.DTG_SUGGEST.Name = "DTG_SUGGEST"
        Me.DTG_SUGGEST.Size = New System.Drawing.Size(332, 15)
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Leelawadee UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DTG_ITM_RECC.DefaultCellStyle = DataGridViewCellStyle2
        Me.DTG_ITM_RECC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DTG_ITM_RECC.Location = New System.Drawing.Point(0, 0)
        Me.DTG_ITM_RECC.MultiSelect = False
        Me.DTG_ITM_RECC.Name = "DTG_ITM_RECC"
        Me.DTG_ITM_RECC.ReadOnly = True
        Me.DTG_ITM_RECC.RowHeadersVisible = False
        Me.DTG_ITM_RECC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTG_ITM_RECC.Size = New System.Drawing.Size(332, 15)
        Me.DTG_ITM_RECC.TabIndex = 0
        '
        'FS_RS_SUPP
        '
        Me.FS_RS_SUPP.Font = New System.Drawing.Font("Leelawadee UI", 11.25!)
        Me.FS_RS_SUPP.Location = New System.Drawing.Point(13, 154)
        Me.FS_RS_SUPP.Name = "FS_RS_SUPP"
        Me.FS_RS_SUPP.ReadOnly = True
        Me.FS_RS_SUPP.Size = New System.Drawing.Size(332, 27)
        Me.FS_RS_SUPP.TabIndex = 41
        '
        'FS_RS_VAR
        '
        Me.FS_RS_VAR.Font = New System.Drawing.Font("Leelawadee UI", 11.25!)
        Me.FS_RS_VAR.Location = New System.Drawing.Point(184, 103)
        Me.FS_RS_VAR.Name = "FS_RS_VAR"
        Me.FS_RS_VAR.ReadOnly = True
        Me.FS_RS_VAR.Size = New System.Drawing.Size(161, 27)
        Me.FS_RS_VAR.TabIndex = 40
        '
        'FS_RS_BRAND
        '
        Me.FS_RS_BRAND.Font = New System.Drawing.Font("Leelawadee UI", 11.25!)
        Me.FS_RS_BRAND.Location = New System.Drawing.Point(13, 103)
        Me.FS_RS_BRAND.Name = "FS_RS_BRAND"
        Me.FS_RS_BRAND.ReadOnly = True
        Me.FS_RS_BRAND.Size = New System.Drawing.Size(159, 27)
        Me.FS_RS_BRAND.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Leelawadee UI", 10.25!)
        Me.Label4.Location = New System.Drawing.Point(371, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 19)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "NEW QUANTITY:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'New_QTY
        '
        Me.New_QTY.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.New_QTY.Font = New System.Drawing.Font("Leelawadee UI", 16.0!)
        Me.New_QTY.Location = New System.Drawing.Point(375, 144)
        Me.New_QTY.Name = "New_QTY"
        Me.New_QTY.ReadOnly = True
        Me.New_QTY.Size = New System.Drawing.Size(128, 36)
        Me.New_QTY.TabIndex = 37
        Me.New_QTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(355, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 172)
        Me.Panel2.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Leelawadee UI", 10.25!)
        Me.Label10.Location = New System.Drawing.Point(9, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 27)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "SUPPLIER:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cur_Stock
        '
        Me.Cur_Stock.Font = New System.Drawing.Font("Leelawadee UI", 16.0!)
        Me.Cur_Stock.Location = New System.Drawing.Point(375, 30)
        Me.Cur_Stock.Name = "Cur_Stock"
        Me.Cur_Stock.ReadOnly = True
        Me.Cur_Stock.Size = New System.Drawing.Size(128, 36)
        Me.Cur_Stock.TabIndex = 35
        Me.Cur_Stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Leelawadee UI", 10.25!)
        Me.Label7.Location = New System.Drawing.Point(371, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 28)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "CURRENT STOCK:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Leelawadee UI", 10.25!)
        Me.Label3.Location = New System.Drawing.Point(180, 81)
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
        Me.Label2.Location = New System.Drawing.Point(9, 81)
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
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 19)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "ITEM NAME:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FI_BTN_CANCEL
        '
        Me.FI_BTN_CANCEL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FI_BTN_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FI_BTN_CANCEL.Font = New System.Drawing.Font("Leelawadee UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.FI_BTN_CANCEL.Location = New System.Drawing.Point(288, 270)
        Me.FI_BTN_CANCEL.Name = "FI_BTN_CANCEL"
        Me.FI_BTN_CANCEL.Size = New System.Drawing.Size(115, 40)
        Me.FI_BTN_CANCEL.TabIndex = 4
        Me.FI_BTN_CANCEL.Text = "CANCEL"
        Me.FI_BTN_CANCEL.UseVisualStyleBackColor = True
        '
        'FI_BTN_SAVE
        '
        Me.FI_BTN_SAVE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FI_BTN_SAVE.BackColor = System.Drawing.Color.ForestGreen
        Me.FI_BTN_SAVE.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.FI_BTN_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FI_BTN_SAVE.Font = New System.Drawing.Font("Leelawadee UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.FI_BTN_SAVE.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FI_BTN_SAVE.Location = New System.Drawing.Point(409, 270)
        Me.FI_BTN_SAVE.Name = "FI_BTN_SAVE"
        Me.FI_BTN_SAVE.Size = New System.Drawing.Size(115, 40)
        Me.FI_BTN_SAVE.TabIndex = 3
        Me.FI_BTN_SAVE.Text = "SAVE"
        Me.FI_BTN_SAVE.UseVisualStyleBackColor = False
        '
        'FSHS_ADD_BTN
        '
        Me.FSHS_ADD_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FSHS_ADD_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FSHS_ADD_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FSHS_ADD_BTN.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSHS_ADD_BTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FSHS_ADD_BTN.Location = New System.Drawing.Point(178, 0)
        Me.FSHS_ADD_BTN.Name = "FSHS_ADD_BTN"
        Me.FSHS_ADD_BTN.Size = New System.Drawing.Size(37, 40)
        Me.FSHS_ADD_BTN.TabIndex = 42
        Me.FSHS_ADD_BTN.Text = "+"
        Me.FSHS_ADD_BTN.UseVisualStyleBackColor = False
        '
        'FSHS_MIN_BTN
        '
        Me.FSHS_MIN_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FSHS_MIN_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FSHS_MIN_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FSHS_MIN_BTN.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSHS_MIN_BTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FSHS_MIN_BTN.Location = New System.Drawing.Point(1, 0)
        Me.FSHS_MIN_BTN.Name = "FSHS_MIN_BTN"
        Me.FSHS_MIN_BTN.Size = New System.Drawing.Size(37, 39)
        Me.FSHS_MIN_BTN.TabIndex = 41
        Me.FSHS_MIN_BTN.Text = "-"
        Me.FSHS_MIN_BTN.UseVisualStyleBackColor = False
        '
        'QTY_HOLDER
        '
        Me.QTY_HOLDER.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.QTY_HOLDER.Font = New System.Drawing.Font("Leelawadee UI", 18.0!)
        Me.QTY_HOLDER.Location = New System.Drawing.Point(44, 0)
        Me.QTY_HOLDER.Name = "QTY_HOLDER"
        Me.QTY_HOLDER.Size = New System.Drawing.Size(128, 39)
        Me.QTY_HOLDER.TabIndex = 2
        Me.QTY_HOLDER.Text = "0"
        Me.QTY_HOLDER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(12, 262)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(513, 2)
        Me.Panel1.TabIndex = 21
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Controls.Add(Me.FORM_LABEL)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(534, 44)
        Me.Panel5.TabIndex = 46
        '
        'FORM_LABEL
        '
        Me.FORM_LABEL.BackColor = System.Drawing.Color.Transparent
        Me.FORM_LABEL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FORM_LABEL.Font = New System.Drawing.Font("Leelawadee UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FORM_LABEL.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.FORM_LABEL.Location = New System.Drawing.Point(0, 0)
        Me.FORM_LABEL.Name = "FORM_LABEL"
        Me.FORM_LABEL.Size = New System.Drawing.Size(534, 44)
        Me.FORM_LABEL.TabIndex = 16
        Me.FORM_LABEL.Text = "ITEM FORM"
        Me.FORM_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel_Num_Controls
        '
        Me.Panel_Num_Controls.Controls.Add(Me.QTY_HOLDER)
        Me.Panel_Num_Controls.Controls.Add(Me.FSHS_MIN_BTN)
        Me.Panel_Num_Controls.Controls.Add(Me.FSHS_ADD_BTN)
        Me.Panel_Num_Controls.Enabled = False
        Me.Panel_Num_Controls.Location = New System.Drawing.Point(11, 271)
        Me.Panel_Num_Controls.Name = "Panel_Num_Controls"
        Me.Panel_Num_Controls.Size = New System.Drawing.Size(216, 39)
        Me.Panel_Num_Controls.TabIndex = 47
        '
        'Form_Stock_DB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(534, 318)
        Me.Controls.Add(Me.Panel_Num_Controls)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FI_BTN_CANCEL)
        Me.Controls.Add(Me.FI_BTN_SAVE)
        Me.Controls.Add(Me.Panel3)
        Me.MaximumSize = New System.Drawing.Size(550, 530)
        Me.MinimumSize = New System.Drawing.Size(550, 357)
        Me.Name = "Form_Stock_DB"
        Me.Text = "Form_Stock_DB"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.DTG_SUGGEST.ResumeLayout(False)
        CType(Me.DTG_ITM_RECC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel_Num_Controls.ResumeLayout(False)
        Me.Panel_Num_Controls.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents FI_BTN_CANCEL As Button
    Friend WithEvents FI_BTN_SAVE As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Cur_Stock As TextBox
    Friend WithEvents New_QTY As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FSHS_ADD_BTN As Button
    Friend WithEvents FSHS_MIN_BTN As Button
    Friend WithEvents QTY_HOLDER As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DTG_SUGGEST As Panel
    Friend WithEvents DTG_ITM_RECC As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents FORM_LABEL As Label
    Friend WithEvents FS_RS_TBX As TextBox
    Friend WithEvents FS_RS_SUPP As TextBox
    Friend WithEvents FS_RS_VAR As TextBox
    Friend WithEvents FS_RS_BRAND As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel_Num_Controls As Panel
End Class
