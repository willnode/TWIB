<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class U_Display
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                ALS.CloseCamera()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(U_Display))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GammaLabel = New System.Windows.Forms.Label()
        Me.BrightLabel = New System.Windows.Forms.Label()
        Me.GammaSlider = New ClassControl.ColorSlider()
        Me.BrightSlider = New ClassControl.ColorSlider()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.L_Light = New System.Windows.Forms.Label()
        Me.Updater = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.DH_Enable = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DH_Fixed = New System.Windows.Forms.RadioButton()
        Me.DH_Auto = New System.Windows.Forms.RadioButton()
        Me.DH_FlipX = New System.Windows.Forms.CheckBox()
        Me.DH_FlipY = New System.Windows.Forms.CheckBox()
        Me.DH_Swap = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Fnt_Cont = New ClassControl.ColorSlider()
        Me.Fnt_ContTxt = New System.Windows.Forms.Label()
        Me.Fnt_Type = New System.Windows.Forms.ComboBox()
        Me.Fnt_Orien = New System.Windows.Forms.ComboBox()
        Me.Fnt_Prev = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.ALS_L = New System.Windows.Forms.Label()
        Me.ALS = New Camera_NET.CameraControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ALS_Enable = New System.Windows.Forms.CheckBox()
        Me.Tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ALS_Updater = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GammaLabel, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BrightLabel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GammaSlider, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.BrightSlider, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.L_Light, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(292, 130)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.ClassInfo.My.Resources.Resources.Light_Calibration
        Me.PictureBox1.Location = New System.Drawing.Point(152, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.TableLayoutPanel1.SetRowSpan(Me.PictureBox1, 4)
        Me.PictureBox1.Size = New System.Drawing.Size(140, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.Tip.SetToolTip(Me.PictureBox1, resources.GetString("PictureBox1.ToolTip"))
        '
        'GammaLabel
        '
        Me.GammaLabel.AutoSize = True
        Me.GammaLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GammaLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GammaLabel.ForeColor = System.Drawing.Color.White
        Me.GammaLabel.Location = New System.Drawing.Point(92, 68)
        Me.GammaLabel.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.GammaLabel.Name = "GammaLabel"
        Me.GammaLabel.Size = New System.Drawing.Size(60, 19)
        Me.GammaLabel.TabIndex = 15
        Me.GammaLabel.Text = "1.0 x"
        Me.GammaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BrightLabel
        '
        Me.BrightLabel.AutoSize = True
        Me.BrightLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BrightLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BrightLabel.ForeColor = System.Drawing.Color.White
        Me.BrightLabel.Location = New System.Drawing.Point(92, 3)
        Me.BrightLabel.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.BrightLabel.Name = "BrightLabel"
        Me.BrightLabel.Size = New System.Drawing.Size(60, 19)
        Me.BrightLabel.TabIndex = 14
        Me.BrightLabel.Text = "100 %"
        Me.BrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GammaSlider
        '
        Me.GammaSlider.BackColor = System.Drawing.Color.Transparent
        Me.GammaSlider.BarInnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.GammaSlider.BarOuterColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.GammaSlider.BarPenColor = System.Drawing.Color.Silver
        Me.GammaSlider.BorderRoundRectSize = New System.Drawing.Size(1, 1)
        Me.TableLayoutPanel1.SetColumnSpan(Me.GammaSlider, 2)
        Me.GammaSlider.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GammaSlider.DrawFocusRectangle = False
        Me.GammaSlider.DrawSemitransparentThumb = False
        Me.GammaSlider.ElapsedInnerColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GammaSlider.ElapsedOuterColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GammaSlider.LargeChange = CType(5UI, UInteger)
        Me.GammaSlider.Location = New System.Drawing.Point(0, 90)
        Me.GammaSlider.Margin = New System.Windows.Forms.Padding(0)
        Me.GammaSlider.Maximum = 80
        Me.GammaSlider.Minimum = 5
        Me.GammaSlider.Name = "GammaSlider"
        Me.GammaSlider.Size = New System.Drawing.Size(152, 40)
        Me.GammaSlider.SmallChange = CType(1UI, UInteger)
        Me.GammaSlider.TabIndex = 13
        Me.GammaSlider.Text = "Gamma"
        Me.GammaSlider.ThumbInnerColor = System.Drawing.Color.LightGray
        Me.GammaSlider.ThumbOuterColor = System.Drawing.Color.LightGray
        Me.GammaSlider.ThumbPenColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.GammaSlider.ThumbRoundRectSize = New System.Drawing.Size(1, 1)
        Me.GammaSlider.ThumbSize = 17
        Me.Tip.SetToolTip(Me.GammaSlider, "Adjust Gamma for current display")
        Me.GammaSlider.Value = 40
        '
        'BrightSlider
        '
        Me.BrightSlider.BackColor = System.Drawing.Color.Transparent
        Me.BrightSlider.BarInnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BrightSlider.BarOuterColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BrightSlider.BarPenColor = System.Drawing.Color.Silver
        Me.BrightSlider.BorderRoundRectSize = New System.Drawing.Size(1, 1)
        Me.TableLayoutPanel1.SetColumnSpan(Me.BrightSlider, 2)
        Me.BrightSlider.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BrightSlider.DrawFocusRectangle = False
        Me.BrightSlider.DrawSemitransparentThumb = False
        Me.BrightSlider.ElapsedInnerColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BrightSlider.ElapsedOuterColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BrightSlider.LargeChange = CType(5UI, UInteger)
        Me.BrightSlider.Location = New System.Drawing.Point(0, 25)
        Me.BrightSlider.Margin = New System.Windows.Forms.Padding(0)
        Me.BrightSlider.Maximum = 10
        Me.BrightSlider.Minimum = 1
        Me.BrightSlider.Name = "BrightSlider"
        Me.BrightSlider.Size = New System.Drawing.Size(152, 40)
        Me.BrightSlider.SmallChange = CType(1UI, UInteger)
        Me.BrightSlider.TabIndex = 12
        Me.BrightSlider.Text = "Brightness"
        Me.BrightSlider.ThumbInnerColor = System.Drawing.Color.LightGray
        Me.BrightSlider.ThumbOuterColor = System.Drawing.Color.LightGray
        Me.BrightSlider.ThumbPenColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BrightSlider.ThumbRoundRectSize = New System.Drawing.Size(1, 1)
        Me.BrightSlider.ThumbSize = 17
        Me.Tip.SetToolTip(Me.BrightSlider, "Adjust brighness on your current display")
        Me.BrightSlider.Value = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Gamma"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'L_Light
        '
        Me.L_Light.AutoSize = True
        Me.L_Light.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L_Light.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.L_Light.ForeColor = System.Drawing.Color.White
        Me.L_Light.Location = New System.Drawing.Point(0, 3)
        Me.L_Light.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.L_Light.Name = "L_Light"
        Me.L_Light.Size = New System.Drawing.Size(92, 19)
        Me.L_Light.TabIndex = 10
        Me.L_Light.Text = "Brightness"
        Me.L_Light.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Updater
        '
        Me.Updater.Interval = 1000
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.DH_Enable, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DH_Fixed, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.DH_Auto, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.DH_FlipX, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.DH_FlipY, 2, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.DH_Swap, 2, 6)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(292, 267)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'DH_Enable
        '
        Me.DH_Enable.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.DH_Enable, 3)
        Me.DH_Enable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DH_Enable.ForeColor = System.Drawing.Color.White
        Me.DH_Enable.Location = New System.Drawing.Point(0, 29)
        Me.DH_Enable.Margin = New System.Windows.Forms.Padding(0)
        Me.DH_Enable.Name = "DH_Enable"
        Me.DH_Enable.Size = New System.Drawing.Size(292, 19)
        Me.DH_Enable.TabIndex = 32
        Me.DH_Enable.Text = "Enable Mouse Hook"
        Me.DH_Enable.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label3, 3)
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 2)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(292, 25)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Mouse Hook"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Tip.SetToolTip(Me.Label3, resources.GetString("Label3.ToolTip"))
        '
        'DH_Fixed
        '
        Me.DH_Fixed.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.DH_Fixed, 2)
        Me.DH_Fixed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DH_Fixed.Enabled = False
        Me.DH_Fixed.ForeColor = System.Drawing.Color.White
        Me.DH_Fixed.Location = New System.Drawing.Point(28, 76)
        Me.DH_Fixed.Name = "DH_Fixed"
        Me.DH_Fixed.Size = New System.Drawing.Size(261, 19)
        Me.DH_Fixed.TabIndex = 37
        Me.DH_Fixed.Text = "Fixed Options"
        Me.DH_Fixed.UseVisualStyleBackColor = True
        '
        'DH_Auto
        '
        Me.DH_Auto.AutoSize = True
        Me.DH_Auto.Checked = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.DH_Auto, 2)
        Me.DH_Auto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DH_Auto.Enabled = False
        Me.DH_Auto.ForeColor = System.Drawing.Color.White
        Me.DH_Auto.Location = New System.Drawing.Point(28, 51)
        Me.DH_Auto.Name = "DH_Auto"
        Me.DH_Auto.Size = New System.Drawing.Size(261, 19)
        Me.DH_Auto.TabIndex = 36
        Me.DH_Auto.TabStop = True
        Me.DH_Auto.Text = "Automatically Based on Display Rotation"
        Me.DH_Auto.UseVisualStyleBackColor = True
        '
        'DH_FlipX
        '
        Me.DH_FlipX.AutoSize = True
        Me.DH_FlipX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DH_FlipX.Enabled = False
        Me.DH_FlipX.ForeColor = System.Drawing.Color.White
        Me.DH_FlipX.Location = New System.Drawing.Point(50, 98)
        Me.DH_FlipX.Margin = New System.Windows.Forms.Padding(0)
        Me.DH_FlipX.Name = "DH_FlipX"
        Me.DH_FlipX.Size = New System.Drawing.Size(242, 19)
        Me.DH_FlipX.TabIndex = 33
        Me.DH_FlipX.Text = "Invert X"
        Me.DH_FlipX.UseVisualStyleBackColor = True
        '
        'DH_FlipY
        '
        Me.DH_FlipY.AutoSize = True
        Me.DH_FlipY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DH_FlipY.Enabled = False
        Me.DH_FlipY.ForeColor = System.Drawing.Color.White
        Me.DH_FlipY.Location = New System.Drawing.Point(50, 117)
        Me.DH_FlipY.Margin = New System.Windows.Forms.Padding(0)
        Me.DH_FlipY.Name = "DH_FlipY"
        Me.DH_FlipY.Size = New System.Drawing.Size(242, 19)
        Me.DH_FlipY.TabIndex = 34
        Me.DH_FlipY.Text = "Invert Y"
        Me.DH_FlipY.UseVisualStyleBackColor = True
        '
        'DH_Swap
        '
        Me.DH_Swap.AutoSize = True
        Me.DH_Swap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DH_Swap.Enabled = False
        Me.DH_Swap.ForeColor = System.Drawing.Color.White
        Me.DH_Swap.Location = New System.Drawing.Point(50, 136)
        Me.DH_Swap.Margin = New System.Windows.Forms.Padding(0)
        Me.DH_Swap.Name = "DH_Swap"
        Me.DH_Swap.Size = New System.Drawing.Size(242, 19)
        Me.DH_Swap.TabIndex = 35
        Me.DH_Swap.Text = "Swap XY"
        Me.DH_Swap.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(113, 25)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(0, 0)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(300, 300)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 27
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(292, 267)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tuning"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Fnt_Cont, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Fnt_ContTxt, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Fnt_Type, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Fnt_Orien, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Fnt_Prev, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 171)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(292, 96)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Fnt_Cont
        '
        Me.Fnt_Cont.BackColor = System.Drawing.Color.Transparent
        Me.Fnt_Cont.BarInnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Fnt_Cont.BarOuterColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Fnt_Cont.BarPenColor = System.Drawing.Color.Silver
        Me.Fnt_Cont.BorderRoundRectSize = New System.Drawing.Size(1, 1)
        Me.TableLayoutPanel3.SetColumnSpan(Me.Fnt_Cont, 2)
        Me.Fnt_Cont.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fnt_Cont.DrawFocusRectangle = False
        Me.Fnt_Cont.DrawSemitransparentThumb = False
        Me.Fnt_Cont.ElapsedInnerColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Fnt_Cont.ElapsedOuterColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Fnt_Cont.LargeChange = CType(5UI, UInteger)
        Me.Fnt_Cont.Location = New System.Drawing.Point(0, 50)
        Me.Fnt_Cont.Margin = New System.Windows.Forms.Padding(0)
        Me.Fnt_Cont.Maximum = 220
        Me.Fnt_Cont.Minimum = 100
        Me.Fnt_Cont.Name = "Fnt_Cont"
        Me.Fnt_Cont.Size = New System.Drawing.Size(292, 46)
        Me.Fnt_Cont.SmallChange = CType(1UI, UInteger)
        Me.Fnt_Cont.TabIndex = 30
        Me.Fnt_Cont.Text = "ClearType Contrast"
        Me.Fnt_Cont.ThumbInnerColor = System.Drawing.Color.LightGray
        Me.Fnt_Cont.ThumbOuterColor = System.Drawing.Color.LightGray
        Me.Fnt_Cont.ThumbPenColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Fnt_Cont.ThumbRoundRectSize = New System.Drawing.Size(1, 1)
        Me.Fnt_Cont.ThumbSize = 17
        Me.Tip.SetToolTip(Me.Fnt_Cont, "Adjust this control to control how Contrast of ClearType fonts drawed")
        Me.Fnt_Cont.Value = 100
        '
        'Fnt_ContTxt
        '
        Me.Fnt_ContTxt.AutoSize = True
        Me.Fnt_ContTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fnt_ContTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Fnt_ContTxt.ForeColor = System.Drawing.Color.White
        Me.Fnt_ContTxt.Location = New System.Drawing.Point(0, 28)
        Me.Fnt_ContTxt.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.Fnt_ContTxt.Name = "Fnt_ContTxt"
        Me.Fnt_ContTxt.Size = New System.Drawing.Size(165, 19)
        Me.Fnt_ContTxt.TabIndex = 29
        Me.Fnt_ContTxt.Text = "12,00 x"
        Me.Fnt_ContTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fnt_Type
        '
        Me.Fnt_Type.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Fnt_Type.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fnt_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Fnt_Type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Fnt_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fnt_Type.ForeColor = System.Drawing.Color.White
        Me.Fnt_Type.FormattingEnabled = True
        Me.Fnt_Type.ItemHeight = 15
        Me.Fnt_Type.Items.AddRange(New Object() {"None", "Standard", "ClearType"})
        Me.Fnt_Type.Location = New System.Drawing.Point(166, 1)
        Me.Fnt_Type.Margin = New System.Windows.Forms.Padding(1)
        Me.Fnt_Type.Name = "Fnt_Type"
        Me.Fnt_Type.Size = New System.Drawing.Size(125, 23)
        Me.Fnt_Type.TabIndex = 26
        Me.Tip.SetToolTip(Me.Fnt_Type, "The type of Font Smoothing will be used," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "selecting other than ClearType will dis" & _
        "abling ClearType Features")
        '
        'Fnt_Orien
        '
        Me.Fnt_Orien.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Fnt_Orien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fnt_Orien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Fnt_Orien.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Fnt_Orien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fnt_Orien.ForeColor = System.Drawing.Color.White
        Me.Fnt_Orien.FormattingEnabled = True
        Me.Fnt_Orien.ItemHeight = 15
        Me.Fnt_Orien.Items.AddRange(New Object() {"BGR (Rarely Used)", "RGB"})
        Me.Fnt_Orien.Location = New System.Drawing.Point(166, 26)
        Me.Fnt_Orien.Margin = New System.Windows.Forms.Padding(1)
        Me.Fnt_Orien.Name = "Fnt_Orien"
        Me.Fnt_Orien.Size = New System.Drawing.Size(125, 23)
        Me.Fnt_Orien.TabIndex = 28
        Me.Tip.SetToolTip(Me.Fnt_Orien, "the Orientation of drawing ClearType fonts.")
        '
        'Fnt_Prev
        '
        Me.Fnt_Prev.AutoSize = True
        Me.Fnt_Prev.BackColor = System.Drawing.Color.White
        Me.Fnt_Prev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fnt_Prev.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fnt_Prev.Location = New System.Drawing.Point(3, 0)
        Me.Fnt_Prev.Name = "Fnt_Prev"
        Me.Fnt_Prev.Size = New System.Drawing.Size(159, 25)
        Me.Fnt_Prev.TabIndex = 31
        Me.Fnt_Prev.Text = "Font Smoothing"
        Me.Fnt_Prev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Tip.SetToolTip(Me.Fnt_Prev, "Font Smoothing for adjusting ClearType settings on windows")
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(292, 267)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Mouse Hook"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.AutoScrollMinSize = New System.Drawing.Size(0, 350)
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(292, 267)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Auto Bright"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.ALS_L, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.ALS, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.ALS_Enable, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(269, 344)
        Me.TableLayoutPanel4.TabIndex = 30
        '
        'ALS_L
        '
        Me.ALS_L.AutoSize = True
        Me.ALS_L.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ALS_L.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ALS_L.ForeColor = System.Drawing.Color.White
        Me.ALS_L.Location = New System.Drawing.Point(210, 34)
        Me.ALS_L.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.ALS_L.Name = "ALS_L"
        Me.ALS_L.Size = New System.Drawing.Size(59, 19)
        Me.ALS_L.TabIndex = 32
        Me.ALS_L.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ALS
        '
        Me.TableLayoutPanel4.SetColumnSpan(Me.ALS, 2)
        Me.ALS.DirectShowLogFilepath = ""
        Me.ALS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ALS.Location = New System.Drawing.Point(3, 59)
        Me.ALS.Name = "ALS"
        Me.ALS.Size = New System.Drawing.Size(263, 285)
        Me.ALS.TabIndex = 28
        '
        'Label2
        '
        Me.TableLayoutPanel4.SetColumnSpan(Me.Label2, 2)
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 3)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 25)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Auto Adaptive Brightness"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Tip.SetToolTip(Me.Label2, "Here you can use your built-in Camera as a Ambient Light Sensors (ALS). very usef" & _
        "ul for Windows that doesn't have ALS Sensors installed")
        '
        'ALS_Enable
        '
        Me.ALS_Enable.AutoSize = True
        Me.ALS_Enable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ALS_Enable.ForeColor = System.Drawing.Color.White
        Me.ALS_Enable.Location = New System.Drawing.Point(0, 31)
        Me.ALS_Enable.Margin = New System.Windows.Forms.Padding(0)
        Me.ALS_Enable.Name = "ALS_Enable"
        Me.ALS_Enable.Size = New System.Drawing.Size(210, 25)
        Me.ALS_Enable.TabIndex = 31
        Me.ALS_Enable.Text = "Enable Auto Adaptive Brightness"
        Me.ALS_Enable.UseVisualStyleBackColor = True
        '
        'Tip
        '
        Me.Tip.AutoPopDelay = 10000
        Me.Tip.InitialDelay = 500
        Me.Tip.ReshowDelay = 100
        '
        'ALS_Updater
        '
        Me.ALS_Updater.Enabled = True
        Me.ALS_Updater.Interval = 1500
        '
        'U_Display
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "U_Display"
        Me.Size = New System.Drawing.Size(300, 300)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents L_Light As System.Windows.Forms.Label
    Friend WithEvents GammaSlider As ClassControl.ColorSlider
    Friend WithEvents BrightSlider As ClassControl.ColorSlider
    Friend WithEvents Updater As System.Windows.Forms.Timer
    Friend WithEvents GammaLabel As System.Windows.Forms.Label
    Friend WithEvents BrightLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Fnt_Cont As ClassControl.ColorSlider
    Friend WithEvents Fnt_ContTxt As System.Windows.Forms.Label
    Friend WithEvents Fnt_Type As System.Windows.Forms.ComboBox
    Friend WithEvents Fnt_Orien As System.Windows.Forms.ComboBox
    Friend WithEvents Fnt_Prev As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Tip As System.Windows.Forms.ToolTip
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ALS_Enable As System.Windows.Forms.CheckBox
    Friend WithEvents ALS_Updater As System.Windows.Forms.Timer
    Friend WithEvents ALS As Camera_NET.CameraControl
    Friend WithEvents DH_Enable As System.Windows.Forms.CheckBox
    Friend WithEvents DH_Swap As System.Windows.Forms.CheckBox
    Friend WithEvents DH_FlipY As System.Windows.Forms.CheckBox
    Friend WithEvents DH_FlipX As System.Windows.Forms.CheckBox
    Friend WithEvents DH_Auto As System.Windows.Forms.RadioButton
    Friend WithEvents DH_Fixed As System.Windows.Forms.RadioButton
    Friend WithEvents ALS_L As System.Windows.Forms.Label
End Class
