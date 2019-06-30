<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DockForm
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.L_CPU = New ClassControl.VerticalLabel()
        Me.L_Temp = New ClassControl.VerticalLabel()
        Me.L_Batt = New ClassControl.VerticalLabel()
        Me.L_Memo = New ClassControl.VerticalLabel()
        Me.L_Light = New ClassControl.VerticalLabel()
        Me.S_Memo = New System.Windows.Forms.Label()
        Me.S_CPU = New System.Windows.Forms.Label()
        Me.S_Temp = New System.Windows.Forms.Label()
        Me.S_Batt = New System.Windows.Forms.Label()
        Me.S_Light = New System.Windows.Forms.Label()
        Me.S_Audio = New System.Windows.Forms.Label()
        Me.S_WiFi = New System.Windows.Forms.Label()
        Me.L_WiFi = New ClassControl.VerticalLabel()
        Me.L_Audio = New ClassControl.VerticalLabel()
        Me.Tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Updater = New System.Windows.Forms.Timer(Me.components)
        Me.L_Disk = New ClassControl.VerticalLabel()
        Me.S_Disk = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.L_Disk, 0, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.S_Disk, 0, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.L_CPU, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.L_Temp, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.L_Batt, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.L_Memo, 0, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.L_Light, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.S_Memo, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.S_CPU, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.S_Temp, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.S_Batt, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.S_Light, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.S_Audio, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.S_WiFi, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.L_WiFi, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.L_Audio, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 16
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50329!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(30, 573)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'L_CPU
        '
        Me.L_CPU.BackColor = System.Drawing.Color.Transparent
        Me.L_CPU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L_CPU.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.L_CPU.ForeColor = System.Drawing.Color.White
        Me.L_CPU.Location = New System.Drawing.Point(0, 385)
        Me.L_CPU.Margin = New System.Windows.Forms.Padding(0)
        Me.L_CPU.Name = "L_CPU"
        Me.L_CPU.Orientation = ClassControl.ProgBarPlus.eRotateText.Right
        Me.L_CPU.Size = New System.Drawing.Size(30, 41)
        Me.L_CPU.TabIndex = 27
        Me.L_CPU.Tag = "-1"
        Me.L_CPU.Text = "100 %"
        '
        'L_Temp
        '
        Me.L_Temp.BackColor = System.Drawing.Color.Transparent
        Me.L_Temp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L_Temp.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.L_Temp.ForeColor = System.Drawing.Color.White
        Me.L_Temp.Location = New System.Drawing.Point(0, 314)
        Me.L_Temp.Margin = New System.Windows.Forms.Padding(0)
        Me.L_Temp.Name = "L_Temp"
        Me.L_Temp.Orientation = ClassControl.ProgBarPlus.eRotateText.Right
        Me.L_Temp.Size = New System.Drawing.Size(30, 41)
        Me.L_Temp.TabIndex = 26
        Me.L_Temp.Tag = "-1"
        Me.L_Temp.Text = "100 %"
        '
        'L_Batt
        '
        Me.L_Batt.BackColor = System.Drawing.Color.Transparent
        Me.L_Batt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L_Batt.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.L_Batt.ForeColor = System.Drawing.Color.White
        Me.L_Batt.Location = New System.Drawing.Point(0, 243)
        Me.L_Batt.Margin = New System.Windows.Forms.Padding(0)
        Me.L_Batt.Name = "L_Batt"
        Me.L_Batt.Orientation = ClassControl.ProgBarPlus.eRotateText.Right
        Me.L_Batt.Size = New System.Drawing.Size(30, 41)
        Me.L_Batt.TabIndex = 25
        Me.L_Batt.Tag = "-1"
        Me.L_Batt.Text = "100 %"
        '
        'L_Memo
        '
        Me.L_Memo.BackColor = System.Drawing.Color.Transparent
        Me.L_Memo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L_Memo.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.L_Memo.ForeColor = System.Drawing.Color.White
        Me.L_Memo.Location = New System.Drawing.Point(0, 456)
        Me.L_Memo.Margin = New System.Windows.Forms.Padding(0)
        Me.L_Memo.Name = "L_Memo"
        Me.L_Memo.Orientation = ClassControl.ProgBarPlus.eRotateText.Right
        Me.L_Memo.Size = New System.Drawing.Size(30, 41)
        Me.L_Memo.TabIndex = 24
        Me.L_Memo.Tag = "-1"
        Me.L_Memo.Text = "100 %"
        '
        'L_Light
        '
        Me.L_Light.BackColor = System.Drawing.Color.Transparent
        Me.L_Light.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L_Light.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.L_Light.ForeColor = System.Drawing.Color.White
        Me.L_Light.Location = New System.Drawing.Point(0, 172)
        Me.L_Light.Margin = New System.Windows.Forms.Padding(0)
        Me.L_Light.Name = "L_Light"
        Me.L_Light.Orientation = ClassControl.ProgBarPlus.eRotateText.Right
        Me.L_Light.Size = New System.Drawing.Size(30, 41)
        Me.L_Light.TabIndex = 23
        Me.L_Light.Tag = "-1"
        Me.L_Light.Text = "100 %"
        '
        'S_Memo
        '
        Me.S_Memo.BackColor = System.Drawing.Color.Transparent
        Me.S_Memo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.S_Memo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.S_Memo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.S_Memo.Location = New System.Drawing.Point(0, 426)
        Me.S_Memo.Margin = New System.Windows.Forms.Padding(0)
        Me.S_Memo.Name = "S_Memo"
        Me.S_Memo.Size = New System.Drawing.Size(30, 30)
        Me.S_Memo.TabIndex = 21
        Me.S_Memo.Tag = ""
        '
        'S_CPU
        '
        Me.S_CPU.BackColor = System.Drawing.Color.Transparent
        Me.S_CPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.S_CPU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.S_CPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.S_CPU.Location = New System.Drawing.Point(0, 355)
        Me.S_CPU.Margin = New System.Windows.Forms.Padding(0)
        Me.S_CPU.Name = "S_CPU"
        Me.S_CPU.Size = New System.Drawing.Size(30, 30)
        Me.S_CPU.TabIndex = 20
        Me.S_CPU.Tag = ""
        '
        'S_Temp
        '
        Me.S_Temp.BackColor = System.Drawing.Color.Transparent
        Me.S_Temp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.S_Temp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.S_Temp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.S_Temp.Location = New System.Drawing.Point(0, 284)
        Me.S_Temp.Margin = New System.Windows.Forms.Padding(0)
        Me.S_Temp.Name = "S_Temp"
        Me.S_Temp.Size = New System.Drawing.Size(30, 30)
        Me.S_Temp.TabIndex = 19
        Me.S_Temp.Tag = ""
        '
        'S_Batt
        '
        Me.S_Batt.BackColor = System.Drawing.Color.Transparent
        Me.S_Batt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.S_Batt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.S_Batt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.S_Batt.Location = New System.Drawing.Point(0, 213)
        Me.S_Batt.Margin = New System.Windows.Forms.Padding(0)
        Me.S_Batt.Name = "S_Batt"
        Me.S_Batt.Size = New System.Drawing.Size(30, 30)
        Me.S_Batt.TabIndex = 18
        Me.S_Batt.Tag = ""
        '
        'S_Light
        '
        Me.S_Light.BackColor = System.Drawing.Color.Transparent
        Me.S_Light.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.S_Light.Dock = System.Windows.Forms.DockStyle.Fill
        Me.S_Light.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.S_Light.Location = New System.Drawing.Point(0, 142)
        Me.S_Light.Margin = New System.Windows.Forms.Padding(0)
        Me.S_Light.Name = "S_Light"
        Me.S_Light.Size = New System.Drawing.Size(30, 30)
        Me.S_Light.TabIndex = 17
        Me.S_Light.Tag = ""
        '
        'S_Audio
        '
        Me.S_Audio.BackColor = System.Drawing.Color.Transparent
        Me.S_Audio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.S_Audio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.S_Audio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.S_Audio.Location = New System.Drawing.Point(0, 71)
        Me.S_Audio.Margin = New System.Windows.Forms.Padding(0)
        Me.S_Audio.Name = "S_Audio"
        Me.S_Audio.Size = New System.Drawing.Size(30, 30)
        Me.S_Audio.TabIndex = 16
        Me.S_Audio.Tag = ""
        '
        'S_WiFi
        '
        Me.S_WiFi.BackColor = System.Drawing.Color.Transparent
        Me.S_WiFi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.S_WiFi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.S_WiFi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.S_WiFi.Location = New System.Drawing.Point(0, 0)
        Me.S_WiFi.Margin = New System.Windows.Forms.Padding(0)
        Me.S_WiFi.Name = "S_WiFi"
        Me.S_WiFi.Size = New System.Drawing.Size(30, 30)
        Me.S_WiFi.TabIndex = 15
        Me.S_WiFi.Tag = ""
        '
        'L_WiFi
        '
        Me.L_WiFi.BackColor = System.Drawing.Color.Transparent
        Me.L_WiFi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L_WiFi.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.L_WiFi.ForeColor = System.Drawing.Color.White
        Me.L_WiFi.Location = New System.Drawing.Point(0, 30)
        Me.L_WiFi.Margin = New System.Windows.Forms.Padding(0)
        Me.L_WiFi.Name = "L_WiFi"
        Me.L_WiFi.Orientation = ClassControl.ProgBarPlus.eRotateText.Right
        Me.L_WiFi.Size = New System.Drawing.Size(30, 41)
        Me.L_WiFi.TabIndex = 0
        Me.L_WiFi.Tag = "-1"
        Me.L_WiFi.Text = "100"
        '
        'L_Audio
        '
        Me.L_Audio.BackColor = System.Drawing.Color.Transparent
        Me.L_Audio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L_Audio.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.L_Audio.ForeColor = System.Drawing.Color.White
        Me.L_Audio.Location = New System.Drawing.Point(0, 101)
        Me.L_Audio.Margin = New System.Windows.Forms.Padding(0)
        Me.L_Audio.Name = "L_Audio"
        Me.L_Audio.Orientation = ClassControl.ProgBarPlus.eRotateText.Right
        Me.L_Audio.Size = New System.Drawing.Size(30, 41)
        Me.L_Audio.TabIndex = 22
        Me.L_Audio.Tag = "-1"
        Me.L_Audio.Text = "100 %"
        '
        'Updater
        '
        Me.Updater.Enabled = True
        Me.Updater.Interval = 1000
        '
        'L_Disk
        '
        Me.L_Disk.BackColor = System.Drawing.Color.Transparent
        Me.L_Disk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L_Disk.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.L_Disk.ForeColor = System.Drawing.Color.White
        Me.L_Disk.Location = New System.Drawing.Point(0, 527)
        Me.L_Disk.Margin = New System.Windows.Forms.Padding(0)
        Me.L_Disk.Name = "L_Disk"
        Me.L_Disk.Orientation = ClassControl.ProgBarPlus.eRotateText.Right
        Me.L_Disk.Size = New System.Drawing.Size(30, 46)
        Me.L_Disk.TabIndex = 29
        Me.L_Disk.Tag = "-1"
        Me.L_Disk.Text = "100 %"
        '
        'S_Disk
        '
        Me.S_Disk.BackColor = System.Drawing.Color.Transparent
        Me.S_Disk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.S_Disk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.S_Disk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.S_Disk.Location = New System.Drawing.Point(0, 497)
        Me.S_Disk.Margin = New System.Windows.Forms.Padding(0)
        Me.S_Disk.Name = "S_Disk"
        Me.S_Disk.Size = New System.Drawing.Size(30, 30)
        Me.S_Disk.TabIndex = 28
        Me.S_Disk.Tag = ""
        '
        'DockForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(30, 573)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(-30, -30)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DockForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Main Window"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents L_WiFi As ClassControl.VerticalLabel
    Friend WithEvents S_Memo As System.Windows.Forms.Label
    Friend WithEvents S_CPU As System.Windows.Forms.Label
    Friend WithEvents S_Temp As System.Windows.Forms.Label
    Friend WithEvents S_Batt As System.Windows.Forms.Label
    Friend WithEvents S_Light As System.Windows.Forms.Label
    Friend WithEvents S_Audio As System.Windows.Forms.Label
    Friend WithEvents S_WiFi As System.Windows.Forms.Label
    Friend WithEvents L_CPU As ClassControl.VerticalLabel
    Friend WithEvents L_Temp As ClassControl.VerticalLabel
    Friend WithEvents L_Batt As ClassControl.VerticalLabel
    Friend WithEvents L_Memo As ClassControl.VerticalLabel
    Friend WithEvents L_Light As ClassControl.VerticalLabel
    Friend WithEvents L_Audio As ClassControl.VerticalLabel
    Friend WithEvents Tip As System.Windows.Forms.ToolTip
    Friend WithEvents Updater As System.Windows.Forms.Timer
    Friend WithEvents L_Disk As ClassControl.VerticalLabel
    Friend WithEvents S_Disk As System.Windows.Forms.Label
End Class
