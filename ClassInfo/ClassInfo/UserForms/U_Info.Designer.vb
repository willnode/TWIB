<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class U_Info
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(U_Info))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.V = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.O_Close = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_donate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_home = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.O_ClrPck = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "About TWIB Tool"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(3, 64)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextBox1.Size = New System.Drawing.Size(286, 178)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        Me.TextBox1.WordWrap = False
        '
        'V
        '
        Me.V.Dock = System.Windows.Forms.DockStyle.Top
        Me.V.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.V.ForeColor = System.Drawing.Color.White
        Me.V.Location = New System.Drawing.Point(3, 39)
        Me.V.Name = "V"
        Me.V.Size = New System.Drawing.Size(286, 25)
        Me.V.TabIndex = 32
        Me.V.Text = "Ver. 1.0"
        Me.V.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ItemSize = New System.Drawing.Size(113, 25)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(300, 300)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 33
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(292, 267)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Options"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.O_Close, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.O_ClrPck, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 163.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(292, 267)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'O_Close
        '
        Me.O_Close.BackgroundImage = Global.ClassInfo.My.Resources.Resources.Info_Close
        Me.O_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.O_Close.Dock = System.Windows.Forms.DockStyle.Fill
        Me.O_Close.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.O_Close.FlatAppearance.BorderSize = 0
        Me.O_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.O_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.O_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.O_Close.ForeColor = System.Drawing.Color.White
        Me.O_Close.Location = New System.Drawing.Point(241, 3)
        Me.O_Close.Name = "O_Close"
        Me.O_Close.Size = New System.Drawing.Size(48, 43)
        Me.O_Close.TabIndex = 3
        Me.O_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.O_Close.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.btn_donate)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(292, 267)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Support"
        '
        'btn_donate
        '
        Me.btn_donate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_donate.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_donate.FlatAppearance.BorderSize = 2
        Me.btn_donate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_donate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_donate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_donate.ForeColor = System.Drawing.Color.White
        Me.btn_donate.Image = Global.ClassInfo.My.Resources.Resources.btn_donate
        Me.btn_donate.Location = New System.Drawing.Point(3, 124)
        Me.btn_donate.Name = "btn_donate"
        Me.btn_donate.Size = New System.Drawing.Size(286, 140)
        Me.btn_donate.TabIndex = 2
        Me.btn_donate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_donate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(286, 79)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Do you like this Program?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If yes, Please support us by Donating us some fund." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A" & _
    "ny value will greatly appreciated."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 42)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Support for Us."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.btn_home)
        Me.TabPage2.Controls.Add(Me.V)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(292, 267)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "About"
        '
        'btn_home
        '
        Me.btn_home.ActiveLinkColor = System.Drawing.Color.Blue
        Me.btn_home.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_home.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic)
        Me.btn_home.LinkColor = System.Drawing.Color.Gainsboro
        Me.btn_home.Location = New System.Drawing.Point(3, 242)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(286, 22)
        Me.btn_home.TabIndex = 33
        Me.btn_home.TabStop = True
        Me.btn_home.Text = "twibtool.wordpress.com"
        Me.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_home.VisitedLinkColor = System.Drawing.Color.DarkGray
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(232, 49)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Options"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(232, 35)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Toolbar Color"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'O_ClrPck
        '
        Me.O_ClrPck.BackColor = Global.ClassInfo.My.MySettings.Default.ToolBarColor
        Me.O_ClrPck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.O_ClrPck.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.ClassInfo.My.MySettings.Default, "ToolBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.O_ClrPck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.O_ClrPck.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.O_ClrPck.FlatAppearance.BorderSize = 0
        Me.O_ClrPck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.O_ClrPck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.O_ClrPck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.O_ClrPck.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.O_ClrPck.ForeColor = System.Drawing.Color.White
        Me.O_ClrPck.Location = New System.Drawing.Point(241, 52)
        Me.O_ClrPck.Name = "O_ClrPck"
        Me.O_ClrPck.Size = New System.Drawing.Size(48, 29)
        Me.O_ClrPck.TabIndex = 6
        Me.O_ClrPck.Text = "Pick..."
        Me.O_ClrPck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.O_ClrPck.UseVisualStyleBackColor = False
        '
        'U_Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "U_Info"
        Me.Size = New System.Drawing.Size(300, 300)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents V As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btn_donate As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_home As System.Windows.Forms.LinkLabel
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents O_Close As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents O_ClrPck As System.Windows.Forms.Button

End Class
