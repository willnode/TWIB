<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class U_Disk
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
        Dim CBlendItems5 As ClassControl.cBlendItems = New ClassControl.cBlendItems()
        Dim CFocalPoints5 As ClassControl.cFocalPoints = New ClassControl.cFocalPoints()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(U_Disk))
        Dim ListViewGroup5 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Logical Disk Data", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup6 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Partition Data", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem23 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Label", ""}, -1)
        Dim ListViewItem24 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Free", ""}, -1)
        Dim ListViewItem25 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Total", ""}, -1)
        Dim ListViewItem26 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Drive Type", ""}, -1)
        Dim ListViewItem27 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"System Type", ""}, -1)
        Dim ListViewItem28 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Serial Number", ""}, -1)
        Dim ListViewItem29 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Index", ""}, -1)
        Dim ListViewItem30 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Type", ""}, -1)
        Dim ListViewItem31 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Is Bootable", ""}, -1)
        Dim ListViewItem32 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Is Primary Boot", ""}, -1)
        Dim ListViewItem33 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Is Primary Partition", ""}, -1)
        Dim CBlendItems6 As ClassControl.cBlendItems = New ClassControl.cBlendItems()
        Dim CFocalPoints6 As ClassControl.cFocalPoints = New ClassControl.cFocalPoints()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.UsgP_Prog = New ClassControl.ProgBarPlus()
        Me.UsgP_List = New System.Windows.Forms.ComboBox()
        Me.UsgP = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.UsgP_Map = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Usg_Prog = New ClassControl.ProgBarPlus()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Usg_Used = New System.Windows.Forms.Label()
        Me.Usg_Eject = New System.Windows.Forms.Button()
        Me.Usg_Total = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Dic_Byte = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dic_HDD = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Dic_Cylinder = New System.Windows.Forms.Label()
        Me.Dic_PerCylinder = New System.Windows.Forms.Label()
        Me.Dic_Track = New System.Windows.Forms.Label()
        Me.Dic_PerTrack = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Dic_PerSector = New System.Windows.Forms.Label()
        Me.Dic_Sector = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Dic_PerByte = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Dis_PNP = New System.Windows.Forms.TextBox()
        Me.Dis_Sign = New System.Windows.Forms.TextBox()
        Me.Dis_FirmRev = New System.Windows.Forms.TextBox()
        Me.Dis_SN = New System.Windows.Forms.TextBox()
        Me.Dis_Label = New System.Windows.Forms.Label()
        Me.Dis_Desc = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Dis_IntType = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SMT = New System.Windows.Forms.ListView()
        Me.Idx = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SMT_S = New System.Windows.Forms.Label()
        Me.Disk = New System.Windows.Forms.ComboBox()
        Me.Tim = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.UsgP_Map, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(113, 25)
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(0, 0)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(300, 276)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 28
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.AutoScrollMinSize = New System.Drawing.Size(0, 300)
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(292, 244)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Summary"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.72727!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.27273!))
        Me.TableLayoutPanel1.Controls.Add(Me.UsgP_Prog, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.UsgP_List, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.UsgP, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.UsgP_Map, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 104)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(275, 196)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'UsgP_Prog
        '
        Me.UsgP_Prog.BarBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        CBlendItems5.iColor = New System.Drawing.Color() {System.Drawing.Color.Navy, System.Drawing.Color.Blue}
        CBlendItems5.iPoint = New Single() {0.0!, 1.0!}
        Me.UsgP_Prog.BarColorBlend = CBlendItems5
        Me.UsgP_Prog.BarColorSolid = System.Drawing.Color.Gray
        Me.UsgP_Prog.BarColorSolidB = System.Drawing.Color.White
        Me.UsgP_Prog.BarPadding = New System.Windows.Forms.Padding(0)
        Me.UsgP_Prog.BarStyleDegree = 0
        Me.UsgP_Prog.BarStyleFill = ClassControl.ProgBarPlus.eBarStyle.Solid
        Me.UsgP_Prog.BarStyleTexture = Nothing
        Me.UsgP_Prog.BorderColor = System.Drawing.Color.LightGray
        Me.UsgP_Prog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UsgP_Prog.Corners.All = 0
        Me.UsgP_Prog.CylonMove = 5.0!
        Me.UsgP_Prog.Dock = System.Windows.Forms.DockStyle.Fill
        CFocalPoints5.CenterPoint = CType(resources.GetObject("CFocalPoints5.CenterPoint"), System.Drawing.PointF)
        CFocalPoints5.FocusScales = CType(resources.GetObject("CFocalPoints5.FocusScales"), System.Drawing.PointF)
        Me.UsgP_Prog.FocalPoints = CFocalPoints5
        Me.UsgP_Prog.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.UsgP_Prog.ForeColor = System.Drawing.Color.White
        Me.UsgP_Prog.Location = New System.Drawing.Point(243, 52)
        Me.UsgP_Prog.Margin = New System.Windows.Forms.Padding(0)
        Me.UsgP_Prog.Name = "UsgP_Prog"
        Me.UsgP_Prog.Orientation = ClassControl.ProgBarPlus.eOrientation.Vertical
        Me.UsgP_Prog.ShapeTextFont = New System.Drawing.Font("Arial Black", 30.0!)
        Me.UsgP_Prog.Size = New System.Drawing.Size(32, 144)
        Me.UsgP_Prog.TabIndex = 31
        Me.UsgP_Prog.Text = "ProgBarPlus1"
        Me.UsgP_Prog.TextFormat = "{1} %"
        Me.UsgP_Prog.TextRotate = ClassControl.ProgBarPlus.eRotateText.Right
        Me.UsgP_Prog.TextShadow = True
        Me.UsgP_Prog.TextShadowColor = System.Drawing.Color.Black
        Me.UsgP_Prog.TextShow = ClassControl.ProgBarPlus.eTextShow.FormatString
        '
        'UsgP_List
        '
        Me.UsgP_List.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.UsgP_List, 2)
        Me.UsgP_List.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UsgP_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UsgP_List.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsgP_List.ForeColor = System.Drawing.Color.White
        Me.UsgP_List.FormattingEnabled = True
        Me.UsgP_List.ItemHeight = 15
        Me.UsgP_List.Location = New System.Drawing.Point(1, 28)
        Me.UsgP_List.Margin = New System.Windows.Forms.Padding(1)
        Me.UsgP_List.Name = "UsgP_List"
        Me.UsgP_List.Size = New System.Drawing.Size(273, 23)
        Me.UsgP_List.TabIndex = 3
        '
        'UsgP
        '
        Me.UsgP.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.UsgP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UsgP.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.UsgP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UsgP.ForeColor = System.Drawing.Color.White
        Me.UsgP.FullRowSelect = True
        ListViewGroup5.Header = "Logical Disk Data"
        ListViewGroup5.Name = "ListViewGroup1"
        ListViewGroup6.Header = "Partition Data"
        ListViewGroup6.Name = "ListViewGroup2"
        Me.UsgP.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup5, ListViewGroup6})
        Me.UsgP.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        ListViewItem23.Group = ListViewGroup5
        ListViewItem24.Group = ListViewGroup5
        ListViewItem25.Group = ListViewGroup5
        ListViewItem26.Group = ListViewGroup5
        ListViewItem27.Group = ListViewGroup5
        ListViewItem28.Group = ListViewGroup5
        ListViewItem29.Group = ListViewGroup6
        ListViewItem30.Group = ListViewGroup6
        ListViewItem31.Group = ListViewGroup6
        ListViewItem32.Group = ListViewGroup6
        ListViewItem33.Group = ListViewGroup6
        Me.UsgP.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem23, ListViewItem24, ListViewItem25, ListViewItem26, ListViewItem27, ListViewItem28, ListViewItem29, ListViewItem30, ListViewItem31, ListViewItem32, ListViewItem33})
        Me.UsgP.Location = New System.Drawing.Point(0, 52)
        Me.UsgP.Margin = New System.Windows.Forms.Padding(0)
        Me.UsgP.Name = "UsgP"
        Me.UsgP.Size = New System.Drawing.Size(243, 144)
        Me.UsgP.TabIndex = 4
        Me.UsgP.UseCompatibleStateImageBehavior = False
        Me.UsgP.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Value"
        '
        'UsgP_Map
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.UsgP_Map, 2)
        Me.UsgP_Map.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UsgP_Map.Location = New System.Drawing.Point(0, 0)
        Me.UsgP_Map.Margin = New System.Windows.Forms.Padding(0)
        Me.UsgP_Map.Name = "UsgP_Map"
        Me.UsgP_Map.Size = New System.Drawing.Size(275, 27)
        Me.UsgP_Map.TabIndex = 32
        Me.UsgP_Map.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Usg_Prog, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Usg_Used, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Usg_Eject, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Usg_Total, 1, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(275, 104)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Usg_Prog
        '
        Me.Usg_Prog.BarBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        CBlendItems6.iColor = New System.Drawing.Color() {System.Drawing.Color.Navy, System.Drawing.Color.Blue}
        CBlendItems6.iPoint = New Single() {0.0!, 1.0!}
        Me.Usg_Prog.BarColorBlend = CBlendItems6
        Me.Usg_Prog.BarColorSolid = System.Drawing.Color.Gray
        Me.Usg_Prog.BarColorSolidB = System.Drawing.Color.White
        Me.Usg_Prog.BarPadding = New System.Windows.Forms.Padding(0)
        Me.Usg_Prog.BarStyleDegree = 0
        Me.Usg_Prog.BarStyleFill = ClassControl.ProgBarPlus.eBarStyle.Solid
        Me.Usg_Prog.BarStyleTexture = Nothing
        Me.Usg_Prog.BorderColor = System.Drawing.Color.LightGray
        Me.Usg_Prog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TableLayoutPanel2.SetColumnSpan(Me.Usg_Prog, 2)
        Me.Usg_Prog.Corners.All = 0
        Me.Usg_Prog.CylonMove = 5.0!
        Me.Usg_Prog.Dock = System.Windows.Forms.DockStyle.Fill
        CFocalPoints6.CenterPoint = CType(resources.GetObject("CFocalPoints6.CenterPoint"), System.Drawing.PointF)
        CFocalPoints6.FocusScales = CType(resources.GetObject("CFocalPoints6.FocusScales"), System.Drawing.PointF)
        Me.Usg_Prog.FocalPoints = CFocalPoints6
        Me.Usg_Prog.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Usg_Prog.ForeColor = System.Drawing.Color.White
        Me.Usg_Prog.Location = New System.Drawing.Point(78, 0)
        Me.Usg_Prog.Margin = New System.Windows.Forms.Padding(0)
        Me.Usg_Prog.Name = "Usg_Prog"
        Me.Usg_Prog.ShapeTextFont = New System.Drawing.Font("Arial Black", 30.0!)
        Me.Usg_Prog.Size = New System.Drawing.Size(197, 28)
        Me.Usg_Prog.TabIndex = 30
        Me.Usg_Prog.Text = "ProgBarPlus1"
        Me.Usg_Prog.TextFormat = "{1} %"
        Me.Usg_Prog.TextShadow = True
        Me.Usg_Prog.TextShadowColor = System.Drawing.Color.Black
        Me.Usg_Prog.TextShow = ClassControl.ProgBarPlus.eTextShow.FormatString
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.TableLayoutPanel2.SetRowSpan(Me.Label7, 3)
        Me.Label7.Size = New System.Drawing.Size(78, 104)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Usage"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Usg_Used
        '
        Me.Usg_Used.AutoSize = True
        Me.Usg_Used.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Usg_Used.Font = New System.Drawing.Font("Segoe UI", 17.0!)
        Me.Usg_Used.ForeColor = System.Drawing.Color.White
        Me.Usg_Used.Location = New System.Drawing.Point(78, 28)
        Me.Usg_Used.Margin = New System.Windows.Forms.Padding(0)
        Me.Usg_Used.Name = "Usg_Used"
        Me.Usg_Used.Size = New System.Drawing.Size(144, 61)
        Me.Usg_Used.TabIndex = 24
        Me.Usg_Used.Text = "1000 MB"
        Me.Usg_Used.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Usg_Eject
        '
        Me.Usg_Eject.BackgroundImage = Global.ClassInfo.My.Resources.Resources.Disk_Eject_Off
        Me.Usg_Eject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Usg_Eject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Usg_Eject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Usg_Eject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Usg_Eject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Usg_Eject.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Usg_Eject.ForeColor = System.Drawing.Color.White
        Me.Usg_Eject.Location = New System.Drawing.Point(222, 28)
        Me.Usg_Eject.Margin = New System.Windows.Forms.Padding(0)
        Me.Usg_Eject.Name = "Usg_Eject"
        Me.TableLayoutPanel2.SetRowSpan(Me.Usg_Eject, 2)
        Me.Usg_Eject.Size = New System.Drawing.Size(53, 76)
        Me.Usg_Eject.TabIndex = 29
        Me.Usg_Eject.UseVisualStyleBackColor = True
        Me.Usg_Eject.Visible = False
        '
        'Usg_Total
        '
        Me.Usg_Total.AutoSize = True
        Me.Usg_Total.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Usg_Total.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Usg_Total.ForeColor = System.Drawing.Color.White
        Me.Usg_Total.Location = New System.Drawing.Point(78, 89)
        Me.Usg_Total.Margin = New System.Windows.Forms.Padding(0)
        Me.Usg_Total.Name = "Usg_Total"
        Me.Usg_Total.Size = New System.Drawing.Size(144, 15)
        Me.Usg_Total.TabIndex = 31
        Me.Usg_Total.Text = "/ 1000,00 MB"
        Me.Usg_Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.AutoScrollMinSize = New System.Drawing.Size(0, 400)
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel5)
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(292, 243)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "Static Info"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 246.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Dic_Byte, 0, 9)
        Me.TableLayoutPanel5.Controls.Add(Me.PictureBox2, 0, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Dic_HDD, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.PictureBox1, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.Dic_Cylinder, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.Dic_PerCylinder, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.Dic_Track, 0, 5)
        Me.TableLayoutPanel5.Controls.Add(Me.Dic_PerTrack, 1, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.PictureBox3, 0, 6)
        Me.TableLayoutPanel5.Controls.Add(Me.Dic_PerSector, 1, 6)
        Me.TableLayoutPanel5.Controls.Add(Me.Dic_Sector, 0, 7)
        Me.TableLayoutPanel5.Controls.Add(Me.PictureBox4, 0, 8)
        Me.TableLayoutPanel5.Controls.Add(Me.Dic_PerByte, 1, 8)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 170)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 10
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(269, 230)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'Dic_Byte
        '
        Me.Dic_Byte.AutoSize = True
        Me.TableLayoutPanel5.SetColumnSpan(Me.Dic_Byte, 2)
        Me.Dic_Byte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dic_Byte.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Dic_Byte.ForeColor = System.Drawing.Color.White
        Me.Dic_Byte.Location = New System.Drawing.Point(1, 209)
        Me.Dic_Byte.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Dic_Byte.Name = "Dic_Byte"
        Me.Dic_Byte.Size = New System.Drawing.Size(267, 19)
        Me.Dic_Byte.TabIndex = 20
        Me.Dic_Byte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.ClassInfo.My.Resources.Resources.Too
        Me.PictureBox2.Location = New System.Drawing.Point(0, 101)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.TableLayoutPanel5.SetColumnSpan(Me.Label2, 2)
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 35)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Detailed Capacity"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Dic_HDD
        '
        Me.Dic_HDD.AutoSize = True
        Me.TableLayoutPanel5.SetColumnSpan(Me.Dic_HDD, 2)
        Me.Dic_HDD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dic_HDD.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Dic_HDD.ForeColor = System.Drawing.Color.White
        Me.Dic_HDD.Location = New System.Drawing.Point(1, 37)
        Me.Dic_HDD.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Dic_HDD.Name = "Dic_HDD"
        Me.Dic_HDD.Size = New System.Drawing.Size(267, 19)
        Me.Dic_HDD.TabIndex = 8
        Me.Dic_HDD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.ClassInfo.My.Resources.Resources.Too
        Me.PictureBox1.Location = New System.Drawing.Point(0, 58)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Dic_Cylinder
        '
        Me.Dic_Cylinder.AutoSize = True
        Me.TableLayoutPanel5.SetColumnSpan(Me.Dic_Cylinder, 2)
        Me.Dic_Cylinder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dic_Cylinder.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Dic_Cylinder.ForeColor = System.Drawing.Color.White
        Me.Dic_Cylinder.Location = New System.Drawing.Point(1, 80)
        Me.Dic_Cylinder.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Dic_Cylinder.Name = "Dic_Cylinder"
        Me.Dic_Cylinder.Size = New System.Drawing.Size(267, 19)
        Me.Dic_Cylinder.TabIndex = 10
        Me.Dic_Cylinder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Dic_PerCylinder
        '
        Me.Dic_PerCylinder.AutoSize = True
        Me.Dic_PerCylinder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dic_PerCylinder.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Dic_PerCylinder.ForeColor = System.Drawing.Color.White
        Me.Dic_PerCylinder.Location = New System.Drawing.Point(23, 58)
        Me.Dic_PerCylinder.Margin = New System.Windows.Forms.Padding(0)
        Me.Dic_PerCylinder.Name = "Dic_PerCylinder"
        Me.Dic_PerCylinder.Size = New System.Drawing.Size(246, 20)
        Me.Dic_PerCylinder.TabIndex = 11
        Me.Dic_PerCylinder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Dic_Track
        '
        Me.Dic_Track.AutoSize = True
        Me.TableLayoutPanel5.SetColumnSpan(Me.Dic_Track, 2)
        Me.Dic_Track.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dic_Track.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Dic_Track.ForeColor = System.Drawing.Color.White
        Me.Dic_Track.Location = New System.Drawing.Point(1, 123)
        Me.Dic_Track.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Dic_Track.Name = "Dic_Track"
        Me.Dic_Track.Size = New System.Drawing.Size(267, 19)
        Me.Dic_Track.TabIndex = 13
        Me.Dic_Track.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Dic_PerTrack
        '
        Me.Dic_PerTrack.AutoSize = True
        Me.Dic_PerTrack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dic_PerTrack.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Dic_PerTrack.ForeColor = System.Drawing.Color.White
        Me.Dic_PerTrack.Location = New System.Drawing.Point(23, 101)
        Me.Dic_PerTrack.Margin = New System.Windows.Forms.Padding(0)
        Me.Dic_PerTrack.Name = "Dic_PerTrack"
        Me.Dic_PerTrack.Size = New System.Drawing.Size(246, 20)
        Me.Dic_PerTrack.TabIndex = 14
        Me.Dic_PerTrack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox3.Image = Global.ClassInfo.My.Resources.Resources.Too
        Me.PictureBox3.Location = New System.Drawing.Point(0, 144)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox3.MinimumSize = New System.Drawing.Size(20, 20)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(23, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'Dic_PerSector
        '
        Me.Dic_PerSector.AutoSize = True
        Me.Dic_PerSector.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dic_PerSector.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Dic_PerSector.ForeColor = System.Drawing.Color.White
        Me.Dic_PerSector.Location = New System.Drawing.Point(23, 144)
        Me.Dic_PerSector.Margin = New System.Windows.Forms.Padding(0)
        Me.Dic_PerSector.Name = "Dic_PerSector"
        Me.Dic_PerSector.Size = New System.Drawing.Size(246, 20)
        Me.Dic_PerSector.TabIndex = 16
        Me.Dic_PerSector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Dic_Sector
        '
        Me.Dic_Sector.AutoSize = True
        Me.TableLayoutPanel5.SetColumnSpan(Me.Dic_Sector, 2)
        Me.Dic_Sector.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dic_Sector.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Dic_Sector.ForeColor = System.Drawing.Color.White
        Me.Dic_Sector.Location = New System.Drawing.Point(1, 166)
        Me.Dic_Sector.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Dic_Sector.Name = "Dic_Sector"
        Me.Dic_Sector.Size = New System.Drawing.Size(267, 19)
        Me.Dic_Sector.TabIndex = 17
        Me.Dic_Sector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox4
        '
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox4.Image = Global.ClassInfo.My.Resources.Resources.Too
        Me.PictureBox4.Location = New System.Drawing.Point(0, 187)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox4.MinimumSize = New System.Drawing.Size(20, 20)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(23, 20)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 18
        Me.PictureBox4.TabStop = False
        '
        'Dic_PerByte
        '
        Me.Dic_PerByte.AutoSize = True
        Me.Dic_PerByte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dic_PerByte.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Dic_PerByte.ForeColor = System.Drawing.Color.White
        Me.Dic_PerByte.Location = New System.Drawing.Point(23, 187)
        Me.Dic_PerByte.Margin = New System.Windows.Forms.Padding(0)
        Me.Dic_PerByte.Name = "Dic_PerByte"
        Me.Dic_PerByte.Size = New System.Drawing.Size(246, 20)
        Me.Dic_PerByte.TabIndex = 19
        Me.Dic_PerByte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Dis_PNP, 1, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.Dis_Sign, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Dis_FirmRev, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Dis_SN, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Dis_Label, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Dis_Desc, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Label9, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.Dis_IntType, 1, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 7
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(269, 167)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Dis_PNP
        '
        Me.Dis_PNP.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Dis_PNP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dis_PNP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dis_PNP.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Dis_PNP.ForeColor = System.Drawing.Color.White
        Me.Dis_PNP.Location = New System.Drawing.Point(119, 146)
        Me.Dis_PNP.Name = "Dis_PNP"
        Me.Dis_PNP.ReadOnly = True
        Me.Dis_PNP.Size = New System.Drawing.Size(147, 18)
        Me.Dis_PNP.TabIndex = 11
        '
        'Dis_Sign
        '
        Me.Dis_Sign.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Dis_Sign.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dis_Sign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dis_Sign.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Dis_Sign.ForeColor = System.Drawing.Color.White
        Me.Dis_Sign.Location = New System.Drawing.Point(119, 122)
        Me.Dis_Sign.Name = "Dis_Sign"
        Me.Dis_Sign.ReadOnly = True
        Me.Dis_Sign.Size = New System.Drawing.Size(147, 18)
        Me.Dis_Sign.TabIndex = 10
        '
        'Dis_FirmRev
        '
        Me.Dis_FirmRev.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Dis_FirmRev.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dis_FirmRev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dis_FirmRev.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Dis_FirmRev.ForeColor = System.Drawing.Color.White
        Me.Dis_FirmRev.Location = New System.Drawing.Point(119, 98)
        Me.Dis_FirmRev.Name = "Dis_FirmRev"
        Me.Dis_FirmRev.ReadOnly = True
        Me.Dis_FirmRev.Size = New System.Drawing.Size(147, 18)
        Me.Dis_FirmRev.TabIndex = 9
        '
        'Dis_SN
        '
        Me.Dis_SN.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Dis_SN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dis_SN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dis_SN.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Dis_SN.ForeColor = System.Drawing.Color.White
        Me.Dis_SN.Location = New System.Drawing.Point(119, 74)
        Me.Dis_SN.Name = "Dis_SN"
        Me.Dis_SN.ReadOnly = True
        Me.Dis_SN.Size = New System.Drawing.Size(147, 18)
        Me.Dis_SN.TabIndex = 8
        '
        'Dis_Label
        '
        Me.Dis_Label.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.Dis_Label, 2)
        Me.Dis_Label.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dis_Label.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Dis_Label.ForeColor = System.Drawing.Color.White
        Me.Dis_Label.Location = New System.Drawing.Point(3, 0)
        Me.Dis_Label.Name = "Dis_Label"
        Me.Dis_Label.Size = New System.Drawing.Size(263, 25)
        Me.Dis_Label.TabIndex = 0
        Me.Dis_Label.Text = "Label"
        Me.Dis_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Dis_Desc
        '
        Me.Dis_Desc.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.Dis_Desc, 2)
        Me.Dis_Desc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dis_Desc.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Dis_Desc.ForeColor = System.Drawing.Color.White
        Me.Dis_Desc.Location = New System.Drawing.Point(3, 26)
        Me.Dis_Desc.Margin = New System.Windows.Forms.Padding(3, 1, 3, 2)
        Me.Dis_Desc.Name = "Dis_Desc"
        Me.Dis_Desc.Size = New System.Drawing.Size(263, 19)
        Me.Dis_Desc.TabIndex = 1
        Me.Dis_Desc.Text = "Description"
        Me.Dis_Desc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Interface Type"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 24)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Serial Number"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 24)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Firmware Revision"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 24)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Signature"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(3, 143)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 24)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "PNP Device ID"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Dis_IntType
        '
        Me.Dis_IntType.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Dis_IntType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dis_IntType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dis_IntType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Dis_IntType.ForeColor = System.Drawing.Color.White
        Me.Dis_IntType.Location = New System.Drawing.Point(119, 50)
        Me.Dis_IntType.Name = "Dis_IntType"
        Me.Dis_IntType.ReadOnly = True
        Me.Dis_IntType.Size = New System.Drawing.Size(147, 18)
        Me.Dis_IntType.TabIndex = 7
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.SMT)
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(292, 244)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "S.M.A.R.T Info"
        '
        'SMT
        '
        Me.SMT.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SMT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SMT.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Idx, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader5, Me.ColumnHeader7})
        Me.SMT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SMT.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.SMT.ForeColor = System.Drawing.Color.White
        Me.SMT.FullRowSelect = True
        Me.SMT.Location = New System.Drawing.Point(3, 30)
        Me.SMT.Margin = New System.Windows.Forms.Padding(0)
        Me.SMT.Name = "SMT"
        Me.SMT.Size = New System.Drawing.Size(286, 211)
        Me.SMT.TabIndex = 32
        Me.SMT.UseCompatibleStateImageBehavior = False
        Me.SMT.View = System.Windows.Forms.View.Details
        '
        'Idx
        '
        Me.Idx.Text = "Id"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Name"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Current"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Worst"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Threshold"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Status"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSize = True
        Me.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.SMT_S, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(286, 27)
        Me.TableLayoutPanel4.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 21)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Status :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SMT_S
        '
        Me.SMT_S.AutoSize = True
        Me.SMT_S.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SMT_S.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SMT_S.ForeColor = System.Drawing.Color.White
        Me.SMT_S.Location = New System.Drawing.Point(75, 3)
        Me.SMT_S.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.SMT_S.Name = "SMT_S"
        Me.SMT_S.Size = New System.Drawing.Size(211, 21)
        Me.SMT_S.TabIndex = 29
        Me.SMT_S.Text = "OK"
        Me.SMT_S.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Disk
        '
        Me.Disk.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Disk.Dock = System.Windows.Forms.DockStyle.Top
        Me.Disk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Disk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Disk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Disk.ForeColor = System.Drawing.Color.White
        Me.Disk.FormattingEnabled = True
        Me.Disk.ItemHeight = 15
        Me.Disk.Location = New System.Drawing.Point(0, 1)
        Me.Disk.Margin = New System.Windows.Forms.Padding(0)
        Me.Disk.Name = "Disk"
        Me.Disk.Size = New System.Drawing.Size(300, 23)
        Me.Disk.TabIndex = 2
        '
        'Tim
        '
        Me.Tim.Interval = 5000
        '
        'U_Disk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Disk)
        Me.Name = "U_Disk"
        Me.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Size = New System.Drawing.Size(300, 300)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.UsgP_Map, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Usg_Eject As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Usg_Used As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Disk As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Usg_Prog As ClassControl.ProgBarPlus
    Friend WithEvents Usg_Total As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents UsgP_List As System.Windows.Forms.ComboBox
    Friend WithEvents UsgP_Prog As ClassControl.ProgBarPlus
    Friend WithEvents UsgP As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents SMT As System.Windows.Forms.ListView
    Friend WithEvents UsgP_Map As System.Windows.Forms.PictureBox
    Friend WithEvents Idx As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Tim As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SMT_S As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Dis_Label As System.Windows.Forms.Label
    Friend WithEvents Dis_Desc As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Dis_IntType As System.Windows.Forms.TextBox
    Friend WithEvents Dis_FirmRev As System.Windows.Forms.TextBox
    Friend WithEvents Dis_SN As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Dic_HDD As System.Windows.Forms.Label
    Friend WithEvents Dis_PNP As System.Windows.Forms.TextBox
    Friend WithEvents Dis_Sign As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Dic_Track As System.Windows.Forms.Label
    Friend WithEvents Dic_PerTrack As System.Windows.Forms.Label
    Friend WithEvents Dic_Cylinder As System.Windows.Forms.Label
    Friend WithEvents Dic_PerCylinder As System.Windows.Forms.Label
    Friend WithEvents Dic_Byte As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Dic_PerSector As System.Windows.Forms.Label
    Friend WithEvents Dic_Sector As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Dic_PerByte As System.Windows.Forms.Label

End Class
