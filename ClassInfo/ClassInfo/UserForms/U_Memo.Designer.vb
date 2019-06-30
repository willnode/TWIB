<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class U_Memo
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
        Dim CBlendItems1 As ClassControl.cBlendItems = New ClassControl.cBlendItems()
        Dim CFocalPoints1 As ClassControl.cFocalPoints = New ClassControl.cFocalPoints()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(U_Memo))
        Dim CBlendItems2 As ClassControl.cBlendItems = New ClassControl.cBlendItems()
        Dim CFocalPoints2 As ClassControl.cFocalPoints = New ClassControl.cFocalPoints()
        Dim CBlendItems3 As ClassControl.cBlendItems = New ClassControl.cBlendItems()
        Dim CFocalPoints3 As ClassControl.cFocalPoints = New ClassControl.cFocalPoints()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PagMax = New System.Windows.Forms.Label()
        Me.PagCur = New System.Windows.Forms.Label()
        Me.PagProg = New ClassControl.ProgBarPlus()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.VirMax = New System.Windows.Forms.Label()
        Me.PhyMax = New System.Windows.Forms.Label()
        Me.VirCur = New System.Windows.Forms.Label()
        Me.PhyCur = New System.Windows.Forms.Label()
        Me.VirProg = New ClassControl.ProgBarPlus()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PhyProg = New ClassControl.ProgBarPlus()
        Me.Updater = New System.Windows.Forms.Timer(Me.components)
        Me.topList = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PagMax, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.PagCur, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.PagProg, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.VirMax, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.PhyMax, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.VirCur, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.PhyCur, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.VirProg, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PhyProg, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(300, 242)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PagMax
        '
        Me.PagMax.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PagMax.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PagMax.ForeColor = System.Drawing.Color.LightGray
        Me.PagMax.Location = New System.Drawing.Point(80, 201)
        Me.PagMax.Margin = New System.Windows.Forms.Padding(0)
        Me.PagMax.Name = "PagMax"
        Me.PagMax.Size = New System.Drawing.Size(220, 18)
        Me.PagMax.TabIndex = 12
        Me.PagMax.Text = "/ 1000 MB"
        '
        'PagCur
        '
        Me.PagCur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PagCur.Font = New System.Drawing.Font("Segoe UI", 17.0!)
        Me.PagCur.ForeColor = System.Drawing.Color.White
        Me.PagCur.Location = New System.Drawing.Point(80, 169)
        Me.PagCur.Margin = New System.Windows.Forms.Padding(0)
        Me.PagCur.Name = "PagCur"
        Me.PagCur.Size = New System.Drawing.Size(220, 32)
        Me.PagCur.TabIndex = 11
        Me.PagCur.Text = "1000 MB"
        Me.PagCur.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'PagProg
        '
        Me.PagProg.BarBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.Navy, System.Drawing.Color.Blue}
        CBlendItems1.iPoint = New Single() {0.0!, 1.0!}
        Me.PagProg.BarColorBlend = CBlendItems1
        Me.PagProg.BarColorSolid = System.Drawing.Color.Gray
        Me.PagProg.BarColorSolidB = System.Drawing.Color.White
        Me.PagProg.BarPadding = New System.Windows.Forms.Padding(0)
        Me.PagProg.BarStyleDegree = 0
        Me.PagProg.BarStyleFill = ClassControl.ProgBarPlus.eBarStyle.Solid
        Me.PagProg.BarStyleTexture = Nothing
        Me.PagProg.BorderColor = System.Drawing.Color.LightGray
        Me.PagProg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PagProg.Corners.All = 0
        Me.PagProg.CylonMove = 5.0!
        Me.PagProg.Dock = System.Windows.Forms.DockStyle.Fill
        CFocalPoints1.CenterPoint = CType(resources.GetObject("CFocalPoints1.CenterPoint"), System.Drawing.PointF)
        CFocalPoints1.FocusScales = CType(resources.GetObject("CFocalPoints1.FocusScales"), System.Drawing.PointF)
        Me.PagProg.FocalPoints = CFocalPoints1
        Me.PagProg.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.PagProg.ForeColor = System.Drawing.Color.White
        Me.PagProg.Location = New System.Drawing.Point(80, 146)
        Me.PagProg.Margin = New System.Windows.Forms.Padding(0)
        Me.PagProg.Name = "PagProg"
        Me.PagProg.ShapeTextFont = New System.Drawing.Font("Arial Black", 30.0!)
        Me.PagProg.Size = New System.Drawing.Size(220, 23)
        Me.PagProg.TabIndex = 10
        Me.PagProg.Text = "ProgBarPlus2"
        Me.PagProg.TextFormat = "{1} %"
        Me.PagProg.TextShadow = True
        Me.PagProg.TextShadowColor = System.Drawing.Color.Black
        Me.PagProg.TextShow = ClassControl.ProgBarPlus.eTextShow.FormatString
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 146)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.TableLayoutPanel1.SetRowSpan(Me.Label6, 3)
        Me.Label6.Size = New System.Drawing.Size(80, 73)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Page Memory"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label3, 2)
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 219)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(300, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Top 10 Apps Consumes Memory"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VirMax
        '
        Me.VirMax.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VirMax.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.VirMax.ForeColor = System.Drawing.Color.LightGray
        Me.VirMax.Location = New System.Drawing.Point(80, 128)
        Me.VirMax.Margin = New System.Windows.Forms.Padding(0)
        Me.VirMax.Name = "VirMax"
        Me.VirMax.Size = New System.Drawing.Size(220, 18)
        Me.VirMax.TabIndex = 7
        Me.VirMax.Text = "/ 1000 MB"
        '
        'PhyMax
        '
        Me.PhyMax.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PhyMax.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PhyMax.ForeColor = System.Drawing.Color.LightGray
        Me.PhyMax.Location = New System.Drawing.Point(83, 55)
        Me.PhyMax.Name = "PhyMax"
        Me.PhyMax.Size = New System.Drawing.Size(214, 18)
        Me.PhyMax.TabIndex = 6
        Me.PhyMax.Text = "/ 1000 MB"
        '
        'VirCur
        '
        Me.VirCur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VirCur.Font = New System.Drawing.Font("Segoe UI", 17.0!)
        Me.VirCur.ForeColor = System.Drawing.Color.White
        Me.VirCur.Location = New System.Drawing.Point(80, 96)
        Me.VirCur.Margin = New System.Windows.Forms.Padding(0)
        Me.VirCur.Name = "VirCur"
        Me.VirCur.Size = New System.Drawing.Size(220, 32)
        Me.VirCur.TabIndex = 5
        Me.VirCur.Text = "1000 MB"
        Me.VirCur.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'PhyCur
        '
        Me.PhyCur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PhyCur.Font = New System.Drawing.Font("Segoe UI", 17.0!)
        Me.PhyCur.ForeColor = System.Drawing.Color.White
        Me.PhyCur.Location = New System.Drawing.Point(83, 23)
        Me.PhyCur.Name = "PhyCur"
        Me.PhyCur.Size = New System.Drawing.Size(214, 32)
        Me.PhyCur.TabIndex = 4
        Me.PhyCur.Text = "1000 MB"
        Me.PhyCur.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'VirProg
        '
        Me.VirProg.BarBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.Navy, System.Drawing.Color.Blue}
        CBlendItems2.iPoint = New Single() {0.0!, 1.0!}
        Me.VirProg.BarColorBlend = CBlendItems2
        Me.VirProg.BarColorSolid = System.Drawing.Color.Gray
        Me.VirProg.BarColorSolidB = System.Drawing.Color.White
        Me.VirProg.BarPadding = New System.Windows.Forms.Padding(0)
        Me.VirProg.BarStyleDegree = 0
        Me.VirProg.BarStyleFill = ClassControl.ProgBarPlus.eBarStyle.Solid
        Me.VirProg.BarStyleTexture = Nothing
        Me.VirProg.BorderColor = System.Drawing.Color.LightGray
        Me.VirProg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VirProg.Corners.All = 0
        Me.VirProg.CylonMove = 5.0!
        Me.VirProg.Dock = System.Windows.Forms.DockStyle.Fill
        CFocalPoints2.CenterPoint = CType(resources.GetObject("CFocalPoints2.CenterPoint"), System.Drawing.PointF)
        CFocalPoints2.FocusScales = CType(resources.GetObject("CFocalPoints2.FocusScales"), System.Drawing.PointF)
        Me.VirProg.FocalPoints = CFocalPoints2
        Me.VirProg.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.VirProg.ForeColor = System.Drawing.Color.White
        Me.VirProg.Location = New System.Drawing.Point(80, 73)
        Me.VirProg.Margin = New System.Windows.Forms.Padding(0)
        Me.VirProg.Name = "VirProg"
        Me.VirProg.ShapeTextFont = New System.Drawing.Font("Arial Black", 30.0!)
        Me.VirProg.Size = New System.Drawing.Size(220, 23)
        Me.VirProg.TabIndex = 3
        Me.VirProg.Text = "ProgBarPlus2"
        Me.VirProg.TextFormat = "{1} %"
        Me.VirProg.TextShadow = True
        Me.VirProg.TextShadowColor = System.Drawing.Color.Black
        Me.VirProg.TextShow = ClassControl.ProgBarPlus.eTextShow.FormatString
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.TableLayoutPanel1.SetRowSpan(Me.Label2, 3)
        Me.Label2.Size = New System.Drawing.Size(80, 73)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Virtual Memory"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.TableLayoutPanel1.SetRowSpan(Me.Label1, 3)
        Me.Label1.Size = New System.Drawing.Size(80, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Physical Memory"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PhyProg
        '
        Me.PhyProg.BarBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        CBlendItems3.iColor = New System.Drawing.Color() {System.Drawing.Color.Navy, System.Drawing.Color.Blue}
        CBlendItems3.iPoint = New Single() {0.0!, 1.0!}
        Me.PhyProg.BarColorBlend = CBlendItems3
        Me.PhyProg.BarColorSolid = System.Drawing.Color.Gray
        Me.PhyProg.BarColorSolidB = System.Drawing.Color.White
        Me.PhyProg.BarPadding = New System.Windows.Forms.Padding(0)
        Me.PhyProg.BarStyleDegree = 0
        Me.PhyProg.BarStyleFill = ClassControl.ProgBarPlus.eBarStyle.Solid
        Me.PhyProg.BarStyleTexture = Nothing
        Me.PhyProg.BorderColor = System.Drawing.Color.LightGray
        Me.PhyProg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PhyProg.Corners.All = 0
        Me.PhyProg.CylonMove = 5.0!
        Me.PhyProg.Dock = System.Windows.Forms.DockStyle.Fill
        CFocalPoints3.CenterPoint = CType(resources.GetObject("CFocalPoints3.CenterPoint"), System.Drawing.PointF)
        CFocalPoints3.FocusScales = CType(resources.GetObject("CFocalPoints3.FocusScales"), System.Drawing.PointF)
        Me.PhyProg.FocalPoints = CFocalPoints3
        Me.PhyProg.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.PhyProg.ForeColor = System.Drawing.Color.White
        Me.PhyProg.Location = New System.Drawing.Point(80, 0)
        Me.PhyProg.Margin = New System.Windows.Forms.Padding(0)
        Me.PhyProg.Name = "PhyProg"
        Me.PhyProg.ShapeTextFont = New System.Drawing.Font("Arial Black", 30.0!)
        Me.PhyProg.Size = New System.Drawing.Size(220, 23)
        Me.PhyProg.TabIndex = 2
        Me.PhyProg.Text = "ProgBarPlus1"
        Me.PhyProg.TextFormat = "{1} %"
        Me.PhyProg.TextShadow = True
        Me.PhyProg.TextShadowColor = System.Drawing.Color.Black
        Me.PhyProg.TextShow = ClassControl.ProgBarPlus.eTextShow.FormatString
        '
        'Updater
        '
        Me.Updater.Interval = 2500
        '
        'topList
        '
        Me.topList.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.topList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.topList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader1})
        Me.topList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.topList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.topList.ForeColor = System.Drawing.Color.White
        Me.topList.FullRowSelect = True
        Me.topList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.topList.Location = New System.Drawing.Point(0, 242)
        Me.topList.MultiSelect = False
        Me.topList.Name = "topList"
        Me.topList.Size = New System.Drawing.Size(300, 58)
        Me.topList.TabIndex = 1
        Me.topList.UseCompatibleStateImageBehavior = False
        Me.topList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Process Name"
        Me.ColumnHeader2.Width = 209
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Memory Consumed"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader1.Width = 90
        '
        'U_Memo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Controls.Add(Me.topList)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "U_Memo"
        Me.Size = New System.Drawing.Size(300, 300)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents VirMax As System.Windows.Forms.Label
    Friend WithEvents PhyMax As System.Windows.Forms.Label
    Friend WithEvents VirCur As System.Windows.Forms.Label
    Friend WithEvents PhyCur As System.Windows.Forms.Label
    Friend WithEvents VirProg As ClassControl.ProgBarPlus
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PhyProg As ClassControl.ProgBarPlus
    Friend WithEvents Updater As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents topList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PagMax As System.Windows.Forms.Label
    Friend WithEvents PagCur As System.Windows.Forms.Label
    Friend WithEvents PagProg As ClassControl.ProgBarPlus
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
