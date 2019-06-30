<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class U_WiFi
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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Bytes Total", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Unicast Packets", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Non-Unicast Packet", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Bytes Sent", "", ""}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Bytes Received", "", ""}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Bytes Total", "", ""}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"U. Packet Sent", "", ""}, -1)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"U. Packet Received", "", ""}, -1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"U. Packet Total", "", ""}, -1)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"N. Packet Sent", "", ""}, -1)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"N. Packet Received", "", ""}, -1)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"N. Packet Total", "", ""}, -1)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DisSet = New System.Windows.Forms.Button()
        Me.NetPacketSpd = New System.Windows.Forms.Label()
        Me.NetPacket = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NetUpSpd = New System.Windows.Forms.Label()
        Me.NetDownSpd = New System.Windows.Forms.Label()
        Me.NetDown = New System.Windows.Forms.Label()
        Me.NetUp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NetType = New System.Windows.Forms.ComboBox()
        Me.NetSelect = New System.Windows.Forms.ComboBox()
        Me.Updater = New System.Windows.Forms.Timer(Me.components)
        Me.TabC = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Net = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabC.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DisSet, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.NetPacketSpd, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.NetPacket, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.NetUpSpd, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.NetDownSpd, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.NetDown, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.NetUp, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NetType, 0, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(286, 235)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'DisSet
        '
        Me.DisSet.AutoSize = True
        Me.DisSet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DisSet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DisSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.DisSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DisSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisSet.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DisSet.ForeColor = System.Drawing.Color.White
        Me.DisSet.Location = New System.Drawing.Point(83, 203)
        Me.DisSet.Margin = New System.Windows.Forms.Padding(0)
        Me.DisSet.Name = "DisSet"
        Me.DisSet.Size = New System.Drawing.Size(203, 32)
        Me.DisSet.TabIndex = 30
        Me.DisSet.Text = "Manage Connections"
        Me.DisSet.UseVisualStyleBackColor = True
        '
        'NetPacketSpd
        '
        Me.NetPacketSpd.AutoSize = True
        Me.NetPacketSpd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NetPacketSpd.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.NetPacketSpd.ForeColor = System.Drawing.Color.Gainsboro
        Me.NetPacketSpd.Location = New System.Drawing.Point(84, 179)
        Me.NetPacketSpd.Margin = New System.Windows.Forms.Padding(1)
        Me.NetPacketSpd.Name = "NetPacketSpd"
        Me.NetPacketSpd.Size = New System.Drawing.Size(201, 23)
        Me.NetPacketSpd.TabIndex = 38
        Me.NetPacketSpd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NetPacket
        '
        Me.NetPacket.AutoEllipsis = True
        Me.NetPacket.AutoSize = True
        Me.NetPacket.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NetPacket.Font = New System.Drawing.Font("Segoe UI", 17.0!)
        Me.NetPacket.ForeColor = System.Drawing.Color.White
        Me.NetPacket.Location = New System.Drawing.Point(84, 136)
        Me.NetPacket.Margin = New System.Windows.Forms.Padding(1)
        Me.NetPacket.Name = "NetPacket"
        Me.NetPacket.Size = New System.Drawing.Size(201, 41)
        Me.NetPacket.TabIndex = 37
        Me.NetPacket.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1, 136)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1)
        Me.Label2.Name = "Label2"
        Me.TableLayoutPanel1.SetRowSpan(Me.Label2, 2)
        Me.Label2.Size = New System.Drawing.Size(81, 66)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Packets Total"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NetUpSpd
        '
        Me.NetUpSpd.AutoSize = True
        Me.NetUpSpd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NetUpSpd.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.NetUpSpd.ForeColor = System.Drawing.Color.Gainsboro
        Me.NetUpSpd.Location = New System.Drawing.Point(84, 43)
        Me.NetUpSpd.Margin = New System.Windows.Forms.Padding(1)
        Me.NetUpSpd.Name = "NetUpSpd"
        Me.NetUpSpd.Size = New System.Drawing.Size(201, 23)
        Me.NetUpSpd.TabIndex = 35
        Me.NetUpSpd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NetDownSpd
        '
        Me.NetDownSpd.AutoSize = True
        Me.NetDownSpd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NetDownSpd.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.NetDownSpd.ForeColor = System.Drawing.Color.Gainsboro
        Me.NetDownSpd.Location = New System.Drawing.Point(84, 111)
        Me.NetDownSpd.Margin = New System.Windows.Forms.Padding(1)
        Me.NetDownSpd.Name = "NetDownSpd"
        Me.NetDownSpd.Size = New System.Drawing.Size(201, 23)
        Me.NetDownSpd.TabIndex = 34
        Me.NetDownSpd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NetDown
        '
        Me.NetDown.AutoSize = True
        Me.NetDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NetDown.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.NetDown.ForeColor = System.Drawing.Color.White
        Me.NetDown.Location = New System.Drawing.Point(84, 68)
        Me.NetDown.Margin = New System.Windows.Forms.Padding(1)
        Me.NetDown.Name = "NetDown"
        Me.NetDown.Size = New System.Drawing.Size(201, 41)
        Me.NetDown.TabIndex = 33
        Me.NetDown.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'NetUp
        '
        Me.NetUp.AutoSize = True
        Me.NetUp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NetUp.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.NetUp.ForeColor = System.Drawing.Color.White
        Me.NetUp.Location = New System.Drawing.Point(84, 1)
        Me.NetUp.Margin = New System.Windows.Forms.Padding(1)
        Me.NetUp.Name = "NetUp"
        Me.NetUp.Size = New System.Drawing.Size(201, 40)
        Me.NetUp.TabIndex = 32
        Me.NetUp.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1)
        Me.Label1.Name = "Label1"
        Me.TableLayoutPanel1.SetRowSpan(Me.Label1, 2)
        Me.Label1.Size = New System.Drawing.Size(81, 66)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Bytes Down"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1, 1)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1)
        Me.Label3.Name = "Label3"
        Me.TableLayoutPanel1.SetRowSpan(Me.Label3, 2)
        Me.Label3.Size = New System.Drawing.Size(81, 65)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Bytes Up"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NetType
        '
        Me.NetType.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NetType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NetType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NetType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.NetType.ForeColor = System.Drawing.Color.White
        Me.NetType.FormattingEnabled = True
        Me.NetType.ItemHeight = 18
        Me.NetType.Items.AddRange(New Object() {"Byte/s", "Bit/s"})
        Me.NetType.Location = New System.Drawing.Point(0, 206)
        Me.NetType.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.NetType.Name = "NetType"
        Me.NetType.Size = New System.Drawing.Size(83, 26)
        Me.NetType.TabIndex = 39
        '
        'NetSelect
        '
        Me.NetSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NetSelect.Dock = System.Windows.Forms.DockStyle.Top
        Me.NetSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NetSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NetSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetSelect.ForeColor = System.Drawing.Color.White
        Me.NetSelect.FormattingEnabled = True
        Me.NetSelect.ItemHeight = 18
        Me.NetSelect.Location = New System.Drawing.Point(0, 0)
        Me.NetSelect.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.NetSelect.Name = "NetSelect"
        Me.NetSelect.Size = New System.Drawing.Size(300, 26)
        Me.NetSelect.TabIndex = 29
        '
        'Updater
        '
        Me.Updater.Interval = 750
        '
        'TabC
        '
        Me.TabC.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabC.Controls.Add(Me.TabPage1)
        Me.TabC.Controls.Add(Me.TabPage2)
        Me.TabC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabC.ItemSize = New System.Drawing.Size(169, 25)
        Me.TabC.Location = New System.Drawing.Point(0, 26)
        Me.TabC.Name = "TabC"
        Me.TabC.SelectedIndex = 0
        Me.TabC.Size = New System.Drawing.Size(300, 274)
        Me.TabC.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabC.TabIndex = 31
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(292, 241)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Summary"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Net)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(292, 241)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detail"
        '
        'Net
        '
        Me.Net.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Net.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Net.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader2})
        Me.Net.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Net.ForeColor = System.Drawing.Color.White
        ListViewGroup1.Header = "Bytes Total"
        ListViewGroup1.Name = "ListViewGroup1"
        ListViewGroup2.Header = "Unicast Packets"
        ListViewGroup2.Name = "ListViewGroup2"
        ListViewGroup3.Header = "Non-Unicast Packet"
        ListViewGroup3.Name = "ListViewGroup3"
        Me.Net.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
        ListViewItem1.Group = ListViewGroup1
        ListViewItem2.Group = ListViewGroup1
        ListViewItem3.Group = ListViewGroup1
        ListViewItem4.Group = ListViewGroup2
        ListViewItem5.Group = ListViewGroup2
        ListViewItem6.Group = ListViewGroup2
        ListViewItem7.Group = ListViewGroup3
        ListViewItem8.Group = ListViewGroup3
        ListViewItem9.Group = ListViewGroup3
        Me.Net.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9})
        Me.Net.Location = New System.Drawing.Point(3, 3)
        Me.Net.Margin = New System.Windows.Forms.Padding(0)
        Me.Net.Name = "Net"
        Me.Net.Size = New System.Drawing.Size(286, 235)
        Me.Net.TabIndex = 0
        Me.Net.UseCompatibleStateImageBehavior = False
        Me.Net.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Property"
        Me.ColumnHeader1.Width = 116
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.DisplayIndex = 2
        Me.ColumnHeader3.Text = "Total"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.DisplayIndex = 1
        Me.ColumnHeader2.Text = "Speed"
        Me.ColumnHeader2.Width = 156
        '
        'U_WiFi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Controls.Add(Me.TabC)
        Me.Controls.Add(Me.NetSelect)
        Me.Name = "U_WiFi"
        Me.Size = New System.Drawing.Size(300, 300)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabC.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NetSelect As System.Windows.Forms.ComboBox
    Friend WithEvents NetUpSpd As System.Windows.Forms.Label
    Friend WithEvents NetDownSpd As System.Windows.Forms.Label
    Friend WithEvents NetDown As System.Windows.Forms.Label
    Friend WithEvents NetUp As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Updater As System.Windows.Forms.Timer
    Friend WithEvents NetPacketSpd As System.Windows.Forms.Label
    Friend WithEvents NetPacket As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DisSet As System.Windows.Forms.Button
    Friend WithEvents TabC As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Net As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents NetType As System.Windows.Forms.ComboBox

End Class
