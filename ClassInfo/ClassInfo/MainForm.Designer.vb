<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.S_Info = New System.Windows.Forms.RadioButton()
        Me.L_Disk = New System.Windows.Forms.Label()
        Me.L_Memo = New System.Windows.Forms.Label()
        Me.L_CPU = New System.Windows.Forms.Label()
        Me.L_Temp = New System.Windows.Forms.Label()
        Me.S_Disk = New System.Windows.Forms.RadioButton()
        Me.S_Memo = New System.Windows.Forms.RadioButton()
        Me.S_CPU = New System.Windows.Forms.RadioButton()
        Me.S_Temp = New System.Windows.Forms.RadioButton()
        Me.L_Batt = New System.Windows.Forms.Label()
        Me.L_Light = New System.Windows.Forms.Label()
        Me.L_Audio = New System.Windows.Forms.Label()
        Me.S_Batt = New System.Windows.Forms.RadioButton()
        Me.S_Light = New System.Windows.Forms.RadioButton()
        Me.S_Audio = New System.Windows.Forms.RadioButton()
        Me.S_WiFi = New System.Windows.Forms.RadioButton()
        Me.L_WiFi = New System.Windows.Forms.Label()
        Me.F_Pin = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Key_Num = New System.Windows.Forms.PictureBox()
        Me.Key_Caps = New System.Windows.Forms.PictureBox()
        Me.Key_Scroll = New System.Windows.Forms.PictureBox()
        Me.UpdaterFlyOut = New System.Windows.Forms.Timer(Me.components)
        Me.F = New System.Windows.Forms.Panel()
        Me.F_Disk = New ClassInfo.U_Disk()
        Me.F_Batt = New ClassInfo.U_Batt()
        Me.F_Audio = New ClassInfo.U_Audio()
        Me.F_Memo = New ClassInfo.U_Memo()
        Me.F_CPU = New ClassInfo.U_CPU()
        Me.F_Temp = New ClassInfo.U_Temp()
        Me.F_Display = New ClassInfo.U_Display()
        Me.F_Info = New ClassInfo.U_Info()
        Me.F_WiFi = New ClassInfo.U_WiFi()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.Key_Num, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Key_Caps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Key_Scroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.F.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.S_Info, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.L_Disk, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.L_Memo, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.L_CPU, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.L_Temp, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.S_Disk, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.S_Memo, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.S_CPU, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.S_Temp, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.L_Batt, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.L_Light, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.L_Audio, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.S_Batt, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.S_Light, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.S_Audio, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.S_WiFi, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.L_WiFi, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.F_Pin, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(346, 250)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'S_Info
        '
        Me.S_Info.Appearance = System.Windows.Forms.Appearance.Button
        Me.S_Info.BackgroundImage = Global.ClassInfo.My.Resources.Resources.Info_Set
        Me.S_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.S_Info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.S_Info.FlatAppearance.BorderSize = 0
        Me.S_Info.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.S_Info.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.S_Info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.S_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.S_Info.Location = New System.Drawing.Point(0, 0)
        Me.S_Info.Margin = New System.Windows.Forms.Padding(0)
        Me.S_Info.Name = "S_Info"
        Me.S_Info.Size = New System.Drawing.Size(86, 40)
        Me.S_Info.TabIndex = 21
        Me.S_Info.Tag = ""
        Me.S_Info.UseVisualStyleBackColor = True
        '
        'L_Disk
        '
        Me.L_Disk.AutoSize = True
        Me.L_Disk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L_Disk.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.L_Disk.ForeColor = System.Drawing.Color.White
        Me.L_Disk.Location = New System.Drawing.Point(258, 231)
        Me.L_Disk.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.L_Disk.Name = "L_Disk"
        Me.L_Disk.Size = New System.Drawing.Size(88, 16)
        Me.L_Disk.TabIndex = 18
        Me.L_Disk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_Memo
        '
        Me.L_Memo.AutoSize = True
        Me.L_Memo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L_Memo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.L_Memo.ForeColor = System.Drawing.Color.White
        Me.L_Memo.Location = New System.Drawing.Point(172, 231)
        Me.L_Memo.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.L_Memo.Name = "L_Memo"
        Me.L_Memo.Size = New System.Drawing.Size(86, 16)
        Me.L_Memo.TabIndex = 17
        Me.L_Memo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_CPU
        '
        Me.L_CPU.AutoSize = True
        Me.L_CPU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L_CPU.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.L_CPU.ForeColor = System.Drawing.Color.White
        Me.L_CPU.Location = New System.Drawing.Point(86, 231)
        Me.L_CPU.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.L_CPU.Name = "L_CPU"
        Me.L_CPU.Size = New System.Drawing.Size(86, 16)
        Me.L_CPU.TabIndex = 16
        Me.L_CPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_Temp
        '
        Me.L_Temp.AutoSize = True
        Me.L_Temp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L_Temp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.L_Temp.ForeColor = System.Drawing.Color.White
        Me.L_Temp.Location = New System.Drawing.Point(0, 231)
        Me.L_Temp.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.L_Temp.Name = "L_Temp"
        Me.L_Temp.Size = New System.Drawing.Size(86, 16)
        Me.L_Temp.TabIndex = 15
        Me.L_Temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'S_Disk
        '
        Me.S_Disk.Appearance = System.Windows.Forms.Appearance.Button
        Me.S_Disk.BackgroundImage = Global.ClassInfo.My.Resources.Resources.Disk_0
        Me.S_Disk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.S_Disk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.S_Disk.FlatAppearance.BorderSize = 0
        Me.S_Disk.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.S_Disk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.S_Disk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.S_Disk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.S_Disk.Location = New System.Drawing.Point(258, 143)
        Me.S_Disk.Margin = New System.Windows.Forms.Padding(0)
        Me.S_Disk.Name = "S_Disk"
        Me.S_Disk.Size = New System.Drawing.Size(88, 88)
        Me.S_Disk.TabIndex = 14
        Me.S_Disk.Tag = ""
        Me.S_Disk.UseVisualStyleBackColor = True
        '
        'S_Memo
        '
        Me.S_Memo.Appearance = System.Windows.Forms.Appearance.Button
        Me.S_Memo.BackgroundImage = Global.ClassInfo.My.Resources.Resources.Memo_0
        Me.S_Memo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.S_Memo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.S_Memo.FlatAppearance.BorderSize = 0
        Me.S_Memo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.S_Memo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.S_Memo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.S_Memo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.S_Memo.Location = New System.Drawing.Point(172, 143)
        Me.S_Memo.Margin = New System.Windows.Forms.Padding(0)
        Me.S_Memo.Name = "S_Memo"
        Me.S_Memo.Size = New System.Drawing.Size(86, 88)
        Me.S_Memo.TabIndex = 13
        Me.S_Memo.Tag = ""
        Me.S_Memo.UseVisualStyleBackColor = True
        '
        'S_CPU
        '
        Me.S_CPU.Appearance = System.Windows.Forms.Appearance.Button
        Me.S_CPU.BackgroundImage = Global.ClassInfo.My.Resources.Resources.Core_0
        Me.S_CPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.S_CPU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.S_CPU.FlatAppearance.BorderSize = 0
        Me.S_CPU.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.S_CPU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.S_CPU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.S_CPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.S_CPU.Location = New System.Drawing.Point(86, 143)
        Me.S_CPU.Margin = New System.Windows.Forms.Padding(0)
        Me.S_CPU.Name = "S_CPU"
        Me.S_CPU.Size = New System.Drawing.Size(86, 88)
        Me.S_CPU.TabIndex = 12
        Me.S_CPU.Tag = ""
        Me.S_CPU.UseVisualStyleBackColor = True
        '
        'S_Temp
        '
        Me.S_Temp.Appearance = System.Windows.Forms.Appearance.Button
        Me.S_Temp.BackgroundImage = Global.ClassInfo.My.Resources.Resources.Temp_0
        Me.S_Temp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.S_Temp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.S_Temp.FlatAppearance.BorderSize = 0
        Me.S_Temp.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.S_Temp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.S_Temp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.S_Temp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.S_Temp.Location = New System.Drawing.Point(0, 143)
        Me.S_Temp.Margin = New System.Windows.Forms.Padding(0)
        Me.S_Temp.Name = "S_Temp"
        Me.S_Temp.Size = New System.Drawing.Size(86, 88)
        Me.S_Temp.TabIndex = 11
        Me.S_Temp.Tag = ""
        Me.S_Temp.UseVisualStyleBackColor = True
        '
        'L_Batt
        '
        Me.L_Batt.AutoSize = True
        Me.L_Batt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L_Batt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.L_Batt.ForeColor = System.Drawing.Color.White
        Me.L_Batt.Location = New System.Drawing.Point(258, 128)
        Me.L_Batt.Margin = New System.Windows.Forms.Padding(0)
        Me.L_Batt.Name = "L_Batt"
        Me.L_Batt.Size = New System.Drawing.Size(88, 15)
        Me.L_Batt.TabIndex = 10
        Me.L_Batt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_Light
        '
        Me.L_Light.AutoSize = True
        Me.L_Light.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L_Light.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.L_Light.ForeColor = System.Drawing.Color.White
        Me.L_Light.Location = New System.Drawing.Point(172, 128)
        Me.L_Light.Margin = New System.Windows.Forms.Padding(0)
        Me.L_Light.Name = "L_Light"
        Me.L_Light.Size = New System.Drawing.Size(86, 15)
        Me.L_Light.TabIndex = 9
        Me.L_Light.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_Audio
        '
        Me.L_Audio.AutoSize = True
        Me.L_Audio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L_Audio.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.L_Audio.ForeColor = System.Drawing.Color.White
        Me.L_Audio.Location = New System.Drawing.Point(86, 128)
        Me.L_Audio.Margin = New System.Windows.Forms.Padding(0)
        Me.L_Audio.Name = "L_Audio"
        Me.L_Audio.Size = New System.Drawing.Size(86, 15)
        Me.L_Audio.TabIndex = 8
        Me.L_Audio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'S_Batt
        '
        Me.S_Batt.Appearance = System.Windows.Forms.Appearance.Button
        Me.S_Batt.BackgroundImage = Global.ClassInfo.My.Resources.Resources.Batt_0
        Me.S_Batt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.S_Batt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.S_Batt.FlatAppearance.BorderSize = 0
        Me.S_Batt.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.S_Batt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.S_Batt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.S_Batt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.S_Batt.Location = New System.Drawing.Point(258, 40)
        Me.S_Batt.Margin = New System.Windows.Forms.Padding(0)
        Me.S_Batt.Name = "S_Batt"
        Me.S_Batt.Size = New System.Drawing.Size(88, 88)
        Me.S_Batt.TabIndex = 7
        Me.S_Batt.Tag = ""
        Me.S_Batt.UseVisualStyleBackColor = True
        '
        'S_Light
        '
        Me.S_Light.Appearance = System.Windows.Forms.Appearance.Button
        Me.S_Light.BackgroundImage = Global.ClassInfo.My.Resources.Resources.Light_0
        Me.S_Light.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.S_Light.Dock = System.Windows.Forms.DockStyle.Fill
        Me.S_Light.FlatAppearance.BorderSize = 0
        Me.S_Light.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.S_Light.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.S_Light.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.S_Light.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.S_Light.Location = New System.Drawing.Point(172, 40)
        Me.S_Light.Margin = New System.Windows.Forms.Padding(0)
        Me.S_Light.Name = "S_Light"
        Me.S_Light.Size = New System.Drawing.Size(86, 88)
        Me.S_Light.TabIndex = 6
        Me.S_Light.Tag = ""
        Me.S_Light.UseVisualStyleBackColor = True
        '
        'S_Audio
        '
        Me.S_Audio.Appearance = System.Windows.Forms.Appearance.Button
        Me.S_Audio.BackgroundImage = CType(resources.GetObject("S_Audio.BackgroundImage"), System.Drawing.Image)
        Me.S_Audio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.S_Audio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.S_Audio.FlatAppearance.BorderSize = 0
        Me.S_Audio.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.S_Audio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.S_Audio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.S_Audio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.S_Audio.Location = New System.Drawing.Point(86, 40)
        Me.S_Audio.Margin = New System.Windows.Forms.Padding(0)
        Me.S_Audio.Name = "S_Audio"
        Me.S_Audio.Size = New System.Drawing.Size(86, 88)
        Me.S_Audio.TabIndex = 5
        Me.S_Audio.Tag = ""
        Me.S_Audio.UseVisualStyleBackColor = True
        '
        'S_WiFi
        '
        Me.S_WiFi.Appearance = System.Windows.Forms.Appearance.Button
        Me.S_WiFi.BackgroundImage = Global.ClassInfo.My.Resources.Resources.WiFi_0
        Me.S_WiFi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.S_WiFi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.S_WiFi.FlatAppearance.BorderSize = 0
        Me.S_WiFi.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.S_WiFi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.S_WiFi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.S_WiFi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.S_WiFi.Location = New System.Drawing.Point(0, 40)
        Me.S_WiFi.Margin = New System.Windows.Forms.Padding(0)
        Me.S_WiFi.Name = "S_WiFi"
        Me.S_WiFi.Size = New System.Drawing.Size(86, 88)
        Me.S_WiFi.TabIndex = 3
        Me.S_WiFi.Tag = ""
        Me.S_WiFi.UseVisualStyleBackColor = True
        '
        'L_WiFi
        '
        Me.L_WiFi.AutoSize = True
        Me.L_WiFi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L_WiFi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.L_WiFi.ForeColor = System.Drawing.Color.White
        Me.L_WiFi.Location = New System.Drawing.Point(0, 128)
        Me.L_WiFi.Margin = New System.Windows.Forms.Padding(0)
        Me.L_WiFi.Name = "L_WiFi"
        Me.L_WiFi.Size = New System.Drawing.Size(86, 15)
        Me.L_WiFi.TabIndex = 4
        Me.L_WiFi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'F_Pin
        '
        Me.F_Pin.Appearance = System.Windows.Forms.Appearance.Button
        Me.F_Pin.AutoSize = True
        Me.F_Pin.BackgroundImage = Global.ClassInfo.My.Resources.Resources.Pin_0
        Me.F_Pin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.F_Pin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.F_Pin.FlatAppearance.BorderSize = 0
        Me.F_Pin.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.F_Pin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.F_Pin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.F_Pin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.F_Pin.Location = New System.Drawing.Point(261, 3)
        Me.F_Pin.Name = "F_Pin"
        Me.F_Pin.Size = New System.Drawing.Size(82, 34)
        Me.F_Pin.TabIndex = 19
        Me.F_Pin.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 2)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.Key_Num, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Key_Caps, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Key_Scroll, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(86, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(172, 40)
        Me.TableLayoutPanel2.TabIndex = 20
        '
        'Key_Num
        '
        Me.Key_Num.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Key_Num.Image = Global.ClassInfo.My.Resources.Resources.Key_Num_0
        Me.Key_Num.Location = New System.Drawing.Point(1, 1)
        Me.Key_Num.Margin = New System.Windows.Forms.Padding(1)
        Me.Key_Num.Name = "Key_Num"
        Me.Key_Num.Size = New System.Drawing.Size(55, 38)
        Me.Key_Num.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Key_Num.TabIndex = 2
        Me.Key_Num.TabStop = False
        '
        'Key_Caps
        '
        Me.Key_Caps.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Key_Caps.Image = Global.ClassInfo.My.Resources.Resources.Key_Caps_0
        Me.Key_Caps.Location = New System.Drawing.Point(58, 1)
        Me.Key_Caps.Margin = New System.Windows.Forms.Padding(1)
        Me.Key_Caps.Name = "Key_Caps"
        Me.Key_Caps.Size = New System.Drawing.Size(55, 38)
        Me.Key_Caps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Key_Caps.TabIndex = 0
        Me.Key_Caps.TabStop = False
        '
        'Key_Scroll
        '
        Me.Key_Scroll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Key_Scroll.Image = Global.ClassInfo.My.Resources.Resources.Key_Scroll_0
        Me.Key_Scroll.Location = New System.Drawing.Point(115, 1)
        Me.Key_Scroll.Margin = New System.Windows.Forms.Padding(1)
        Me.Key_Scroll.Name = "Key_Scroll"
        Me.Key_Scroll.Size = New System.Drawing.Size(56, 38)
        Me.Key_Scroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Key_Scroll.TabIndex = 1
        Me.Key_Scroll.TabStop = False
        '
        'UpdaterFlyOut
        '
        Me.UpdaterFlyOut.Interval = 750
        '
        'F
        '
        Me.F.Controls.Add(Me.F_Disk)
        Me.F.Controls.Add(Me.F_Batt)
        Me.F.Controls.Add(Me.F_Audio)
        Me.F.Controls.Add(Me.F_Memo)
        Me.F.Controls.Add(Me.F_CPU)
        Me.F.Controls.Add(Me.F_Temp)
        Me.F.Controls.Add(Me.F_Display)
        Me.F.Controls.Add(Me.F_Info)
        Me.F.Controls.Add(Me.F_WiFi)
        Me.F.Dock = System.Windows.Forms.DockStyle.Fill
        Me.F.Location = New System.Drawing.Point(0, 0)
        Me.F.Margin = New System.Windows.Forms.Padding(0)
        Me.F.Name = "F"
        Me.F.Size = New System.Drawing.Size(346, 316)
        Me.F.TabIndex = 1
        '
        'F_Disk
        '
        Me.F_Disk.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.F_Disk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.F_Disk.Location = New System.Drawing.Point(0, 0)
        Me.F_Disk.Name = "F_Disk"
        Me.F_Disk.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.F_Disk.Size = New System.Drawing.Size(346, 316)
        Me.F_Disk.TabIndex = 8
        Me.F_Disk.Visible = False
        '
        'F_Batt
        '
        Me.F_Batt.AutoScroll = True
        Me.F_Batt.AutoScrollMinSize = New System.Drawing.Size(0, 350)
        Me.F_Batt.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.F_Batt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.F_Batt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F_Batt.Location = New System.Drawing.Point(0, 0)
        Me.F_Batt.Name = "F_Batt"
        Me.F_Batt.Size = New System.Drawing.Size(346, 316)
        Me.F_Batt.TabIndex = 0
        Me.F_Batt.Visible = False
        '
        'F_Audio
        '
        Me.F_Audio.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.F_Audio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.F_Audio.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.F_Audio.Location = New System.Drawing.Point(0, 0)
        Me.F_Audio.Margin = New System.Windows.Forms.Padding(0)
        Me.F_Audio.Name = "F_Audio"
        Me.F_Audio.Size = New System.Drawing.Size(346, 316)
        Me.F_Audio.TabIndex = 1
        Me.F_Audio.Visible = False
        '
        'F_Memo
        '
        Me.F_Memo.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.F_Memo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.F_Memo.Location = New System.Drawing.Point(0, 0)
        Me.F_Memo.Name = "F_Memo"
        Me.F_Memo.Size = New System.Drawing.Size(346, 316)
        Me.F_Memo.TabIndex = 2
        Me.F_Memo.Visible = False
        '
        'F_CPU
        '
        Me.F_CPU.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.F_CPU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.F_CPU.Location = New System.Drawing.Point(0, 0)
        Me.F_CPU.Name = "F_CPU"
        Me.F_CPU.Size = New System.Drawing.Size(346, 316)
        Me.F_CPU.TabIndex = 3
        Me.F_CPU.Visible = False
        '
        'F_Temp
        '
        Me.F_Temp.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.F_Temp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.F_Temp.Location = New System.Drawing.Point(0, 0)
        Me.F_Temp.Name = "F_Temp"
        Me.F_Temp.Size = New System.Drawing.Size(346, 316)
        Me.F_Temp.TabIndex = 4
        Me.F_Temp.Visible = False
        '
        'F_Display
        '
        Me.F_Display.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.F_Display.Dock = System.Windows.Forms.DockStyle.Fill
        Me.F_Display.Location = New System.Drawing.Point(0, 0)
        Me.F_Display.Name = "F_Display"
        Me.F_Display.Size = New System.Drawing.Size(346, 316)
        Me.F_Display.TabIndex = 5
        Me.F_Display.Visible = False
        '
        'F_Info
        '
        Me.F_Info.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.F_Info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.F_Info.Location = New System.Drawing.Point(0, 0)
        Me.F_Info.Name = "F_Info"
        Me.F_Info.Size = New System.Drawing.Size(346, 316)
        Me.F_Info.TabIndex = 6
        Me.F_Info.Visible = False
        '
        'F_WiFi
        '
        Me.F_WiFi.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.F_WiFi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.F_WiFi.Location = New System.Drawing.Point(0, 0)
        Me.F_WiFi.Name = "F_WiFi"
        Me.F_WiFi.Size = New System.Drawing.Size(346, 316)
        Me.F_WiFi.TabIndex = 7
        Me.F_WiFi.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Panel1MinSize = 70
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.F)
        Me.SplitContainer1.Panel2MinSize = 100
        Me.SplitContainer1.Size = New System.Drawing.Size(346, 570)
        Me.SplitContainer1.SplitterDistance = 250
        Me.SplitContainer1.TabIndex = 8
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(346, 570)
        Me.Controls.Add(Me.SplitContainer1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.ShowInTaskbar = False
        Me.Text = "Main Window"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.Key_Num, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Key_Caps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Key_Scroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.F.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Key_Caps As System.Windows.Forms.PictureBox
    Friend WithEvents Key_Num As System.Windows.Forms.PictureBox
    Friend WithEvents Key_Scroll As System.Windows.Forms.PictureBox
    Friend WithEvents S_WiFi As System.Windows.Forms.RadioButton
    Friend WithEvents S_Batt As System.Windows.Forms.RadioButton
    Friend WithEvents S_Light As System.Windows.Forms.RadioButton
    Friend WithEvents S_Audio As System.Windows.Forms.RadioButton
    Friend WithEvents L_WiFi As System.Windows.Forms.Label
    Friend WithEvents L_Disk As System.Windows.Forms.Label
    Friend WithEvents L_Memo As System.Windows.Forms.Label
    Friend WithEvents L_CPU As System.Windows.Forms.Label
    Friend WithEvents L_Temp As System.Windows.Forms.Label
    Friend WithEvents S_Disk As System.Windows.Forms.RadioButton
    Friend WithEvents S_Memo As System.Windows.Forms.RadioButton
    Friend WithEvents S_CPU As System.Windows.Forms.RadioButton
    Friend WithEvents S_Temp As System.Windows.Forms.RadioButton
    Friend WithEvents L_Batt As System.Windows.Forms.Label
    Friend WithEvents L_Light As System.Windows.Forms.Label
    Friend WithEvents L_Audio As System.Windows.Forms.Label
    Friend WithEvents UpdaterFlyOut As System.Windows.Forms.Timer
    Friend WithEvents F As System.Windows.Forms.Panel
    Friend WithEvents F_Batt As ClassInfo.U_Batt
    Friend WithEvents F_Audio As ClassInfo.U_Audio
    Friend WithEvents F_Memo As ClassInfo.U_Memo
    Friend WithEvents F_Pin As System.Windows.Forms.CheckBox
    Friend WithEvents F_CPU As ClassInfo.U_CPU
    Friend WithEvents F_Temp As ClassInfo.U_Temp
    Friend WithEvents F_Display As ClassInfo.U_Display
    Friend WithEvents F_Info As ClassInfo.U_Info
    Friend WithEvents F_WiFi As ClassInfo.U_WiFi
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents S_Info As System.Windows.Forms.RadioButton
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents F_Disk As ClassInfo.U_Disk

End Class
