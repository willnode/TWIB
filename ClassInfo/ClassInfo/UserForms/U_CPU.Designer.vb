<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class U_CPU
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
        Me.components = New System.ComponentModel.Container()
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CPUCores = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClockCur = New System.Windows.Forms.Label()
        Me.ClockMax = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.InfoThreads = New System.Windows.Forms.Label()
        Me.InfoHandles = New System.Windows.Forms.Label()
        Me.InfoProcess = New System.Windows.Forms.Label()
        Me.Info_Core = New System.Windows.Forms.Label()
        Me.InfoBoot = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Updater = New System.Windows.Forms.Timer(Me.components)
        Me.Updater2 = New System.Windows.Forms.Timer(Me.components)
        Me.TabC = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Inf = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.InF_T = New System.Windows.Forms.ComboBox()
        Me.InF_I = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabC.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ClockCur, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ClockMax, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(286, 124)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.Controls.Add(Me.CPUCores)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(1, 1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel2.Name = "Panel2"
        Me.TableLayoutPanel1.SetRowSpan(Me.Panel2, 3)
        Me.Panel2.Size = New System.Drawing.Size(120, 122)
        Me.Panel2.TabIndex = 0
        '
        'CPUCores
        '
        Me.CPUCores.AutoSize = True
        Me.CPUCores.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CPUCores.ColumnCount = 1
        Me.CPUCores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.CPUCores.Dock = System.Windows.Forms.DockStyle.Top
        Me.CPUCores.Location = New System.Drawing.Point(0, 0)
        Me.CPUCores.Name = "CPUCores"
        Me.CPUCores.RowCount = 1
        Me.CPUCores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.CPUCores.Size = New System.Drawing.Size(120, 30)
        Me.CPUCores.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(125, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Clock Speed"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ClockCur
        '
        Me.ClockCur.AutoSize = True
        Me.ClockCur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClockCur.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClockCur.ForeColor = System.Drawing.Color.White
        Me.ClockCur.Location = New System.Drawing.Point(125, 24)
        Me.ClockCur.Name = "ClockCur"
        Me.ClockCur.Size = New System.Drawing.Size(158, 80)
        Me.ClockCur.TabIndex = 2
        Me.ClockCur.Text = "999.99 GHz"
        Me.ClockCur.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'ClockMax
        '
        Me.ClockMax.AutoSize = True
        Me.ClockMax.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClockMax.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClockMax.ForeColor = System.Drawing.Color.Silver
        Me.ClockMax.Location = New System.Drawing.Point(125, 104)
        Me.ClockMax.Name = "ClockMax"
        Me.ClockMax.Size = New System.Drawing.Size(158, 20)
        Me.ClockMax.TabIndex = 3
        Me.ClockMax.Text = "/ 1000 GHz"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.InfoThreads, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.InfoHandles, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.InfoProcess, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Info_Core, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.InfoBoot, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 3, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(500, 96)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'InfoThreads
        '
        Me.InfoThreads.AutoSize = True
        Me.InfoThreads.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfoThreads.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.InfoThreads.ForeColor = System.Drawing.Color.White
        Me.InfoThreads.Location = New System.Drawing.Point(303, 0)
        Me.InfoThreads.Name = "InfoThreads"
        Me.InfoThreads.Size = New System.Drawing.Size(89, 72)
        Me.InfoThreads.TabIndex = 9
        Me.InfoThreads.Text = "00000"
        Me.InfoThreads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InfoHandles
        '
        Me.InfoHandles.AutoSize = True
        Me.InfoHandles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfoHandles.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.InfoHandles.ForeColor = System.Drawing.Color.White
        Me.InfoHandles.Location = New System.Drawing.Point(398, 0)
        Me.InfoHandles.Name = "InfoHandles"
        Me.InfoHandles.Size = New System.Drawing.Size(99, 72)
        Me.InfoHandles.TabIndex = 8
        Me.InfoHandles.Text = "0000"
        Me.InfoHandles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InfoProcess
        '
        Me.InfoProcess.AutoSize = True
        Me.InfoProcess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfoProcess.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.InfoProcess.ForeColor = System.Drawing.Color.White
        Me.InfoProcess.Location = New System.Drawing.Point(213, 0)
        Me.InfoProcess.Name = "InfoProcess"
        Me.InfoProcess.Size = New System.Drawing.Size(84, 72)
        Me.InfoProcess.TabIndex = 6
        Me.InfoProcess.Text = "0000"
        Me.InfoProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Info_Core
        '
        Me.Info_Core.AutoSize = True
        Me.Info_Core.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Info_Core.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Info_Core.ForeColor = System.Drawing.Color.White
        Me.Info_Core.Location = New System.Drawing.Point(123, 0)
        Me.Info_Core.Name = "Info_Core"
        Me.Info_Core.Size = New System.Drawing.Size(84, 72)
        Me.Info_Core.TabIndex = 4
        Me.Info_Core.Text = "0000"
        Me.Info_Core.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InfoBoot
        '
        Me.InfoBoot.AutoSize = True
        Me.InfoBoot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfoBoot.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.InfoBoot.ForeColor = System.Drawing.Color.White
        Me.InfoBoot.Location = New System.Drawing.Point(3, 0)
        Me.InfoBoot.Name = "InfoBoot"
        Me.InfoBoot.Size = New System.Drawing.Size(114, 72)
        Me.InfoBoot.TabIndex = 3
        Me.InfoBoot.Text = "00/00/0000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:00:00"
        Me.InfoBoot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Last Boot Time"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(213, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 24)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Processes"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(398, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 24)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Handles"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(123, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 24)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Processor"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(303, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 24)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Threads"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoScrollMinSize = New System.Drawing.Size(500, 0)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 151)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(286, 113)
        Me.Panel1.TabIndex = 2
        '
        'Updater
        '
        Me.Updater.Interval = 250
        '
        'Updater2
        '
        Me.Updater2.Interval = 500
        '
        'TabC
        '
        Me.TabC.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabC.Controls.Add(Me.TabPage1)
        Me.TabC.Controls.Add(Me.TabPage2)
        Me.TabC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabC.ItemSize = New System.Drawing.Size(169, 25)
        Me.TabC.Location = New System.Drawing.Point(0, 0)
        Me.TabC.Name = "TabC"
        Me.TabC.SelectedIndex = 0
        Me.TabC.Size = New System.Drawing.Size(300, 300)
        Me.TabC.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabC.TabIndex = 32
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(292, 267)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Performance"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Inf)
        Me.TabPage2.Controls.Add(Me.InF_I)
        Me.TabPage2.Controls.Add(Me.InF_T)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(292, 267)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "System Informations"
        '
        'Inf
        '
        Me.Inf.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Inf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Inf.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.Inf.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewGroup1.Header = "ListViewGroup"
        ListViewGroup1.Name = "ListViewGroup1"
        Me.Inf.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1})
        Me.Inf.Location = New System.Drawing.Point(3, 55)
        Me.Inf.Name = "Inf"
        Me.Inf.Size = New System.Drawing.Size(286, 209)
        Me.Inf.TabIndex = 0
        Me.Inf.UseCompatibleStateImageBehavior = False
        Me.Inf.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Property"
        Me.ColumnHeader1.Width = 89
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Value"
        Me.ColumnHeader2.Width = 180
        '
        'InF_T
        '
        Me.InF_T.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.InF_T.Dock = System.Windows.Forms.DockStyle.Top
        Me.InF_T.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.InF_T.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InF_T.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InF_T.ForeColor = System.Drawing.Color.White
        Me.InF_T.FormattingEnabled = True
        Me.InF_T.ItemHeight = 18
        Me.InF_T.Items.AddRange(New Object() {"Processors", "BIOS"})
        Me.InF_T.Location = New System.Drawing.Point(3, 3)
        Me.InF_T.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.InF_T.Name = "InF_T"
        Me.InF_T.Size = New System.Drawing.Size(286, 26)
        Me.InF_T.TabIndex = 30
        '
        'InF_I
        '
        Me.InF_I.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.InF_I.Dock = System.Windows.Forms.DockStyle.Top
        Me.InF_I.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.InF_I.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InF_I.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InF_I.ForeColor = System.Drawing.Color.White
        Me.InF_I.FormattingEnabled = True
        Me.InF_I.ItemHeight = 18
        Me.InF_I.Location = New System.Drawing.Point(3, 29)
        Me.InF_I.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.InF_I.Name = "InF_I"
        Me.InF_I.Size = New System.Drawing.Size(286, 26)
        Me.InF_I.TabIndex = 31
        '
        'U_CPU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Controls.Add(Me.TabC)
        Me.Name = "U_CPU"
        Me.Size = New System.Drawing.Size(300, 300)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TabC.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ClockCur As System.Windows.Forms.Label
    Friend WithEvents ClockMax As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents InfoThreads As System.Windows.Forms.Label
    Friend WithEvents InfoHandles As System.Windows.Forms.Label
    Friend WithEvents InfoProcess As System.Windows.Forms.Label
    Friend WithEvents Info_Core As System.Windows.Forms.Label
    Friend WithEvents InfoBoot As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Updater As System.Windows.Forms.Timer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CPUCores As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Updater2 As System.Windows.Forms.Timer
    Friend WithEvents TabC As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Inf As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents InF_T As System.Windows.Forms.ComboBox
    Friend WithEvents InF_I As System.Windows.Forms.ComboBox

End Class
