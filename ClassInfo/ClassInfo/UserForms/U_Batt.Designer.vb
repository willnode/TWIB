<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class U_Batt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(U_Batt))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BatRef = New System.Windows.Forms.Button()
        Me.BatSelect = New System.Windows.Forms.ComboBox()
        Me.BattProgress = New ClassControl.ProgBarPlus()
        Me.BattStatus = New System.Windows.Forms.Label()
        Me.BattChargeTotal = New System.Windows.Forms.Label()
        Me.BattChargeCurr = New System.Windows.Forms.Label()
        Me.BattVoltage = New System.Windows.Forms.Label()
        Me.BattChargeRate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BattTime = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BattChargeRate_ = New System.Windows.Forms.Label()
        Me.BattTime_ = New System.Windows.Forms.Label()
        Me.BattWearLevel = New System.Windows.Forms.Label()
        Me.BattDesignedCharge = New System.Windows.Forms.Label()
        Me.Tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BattTime_L = New System.Windows.Forms.Label()
        Me.BattTime_P = New System.Windows.Forms.Panel()
        Me.BattTime_S = New ClassControl.ColorSlider()
        Me.BattRep = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.BattTime_P.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BatRef, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BatSelect, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BattProgress, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BattStatus, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.BattChargeTotal, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BattChargeCurr, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.71429!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(215, 158)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'BatRef
        '
        Me.BatRef.AutoSize = True
        Me.BatRef.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BatRef.BackgroundImage = Global.ClassInfo.My.Resources.Resources.Info_Refresh
        Me.BatRef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BatRef.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BatRef.FlatAppearance.BorderSize = 0
        Me.BatRef.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BatRef.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BatRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BatRef.ForeColor = System.Drawing.Color.White
        Me.BatRef.Location = New System.Drawing.Point(0, 0)
        Me.BatRef.Margin = New System.Windows.Forms.Padding(0)
        Me.BatRef.Name = "BatRef"
        Me.BatRef.Size = New System.Drawing.Size(45, 36)
        Me.BatRef.TabIndex = 32
        Me.Tip.SetToolTip(Me.BatRef, "Refresh Battery Information")
        Me.BatRef.UseVisualStyleBackColor = True
        '
        'BatSelect
        '
        Me.BatSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BatSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BatSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BatSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BatSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatSelect.ForeColor = System.Drawing.Color.White
        Me.BatSelect.FormattingEnabled = True
        Me.BatSelect.ItemHeight = 18
        Me.BatSelect.Location = New System.Drawing.Point(45, 2)
        Me.BatSelect.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.BatSelect.Name = "BatSelect"
        Me.BatSelect.Size = New System.Drawing.Size(170, 26)
        Me.BatSelect.TabIndex = 30
        Me.Tip.SetToolTip(Me.BatSelect, "Select Battery")
        '
        'BattProgress
        '
        Me.BattProgress.BarBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.Black}
        CBlendItems1.iPoint = New Single() {0.0!, 1.0!}
        Me.BattProgress.BarColorBlend = CBlendItems1
        Me.BattProgress.BarColorSolid = System.Drawing.Color.DarkGray
        Me.BattProgress.BarColorSolidB = System.Drawing.Color.White
        Me.BattProgress.BarPadding = New System.Windows.Forms.Padding(0)
        Me.BattProgress.BarStyleDegree = 270
        Me.BattProgress.BarStyleFill = ClassControl.ProgBarPlus.eBarStyle.Solid
        Me.BattProgress.BarStyleTexture = Nothing
        Me.BattProgress.BorderColor = System.Drawing.Color.Gainsboro
        Me.BattProgress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BattProgress.Corners.All = 0
        Me.BattProgress.CylonMove = 5.0!
        Me.BattProgress.Dock = System.Windows.Forms.DockStyle.Fill
        CFocalPoints1.CenterPoint = CType(resources.GetObject("CFocalPoints1.CenterPoint"), System.Drawing.PointF)
        CFocalPoints1.FocusScales = CType(resources.GetObject("CFocalPoints1.FocusScales"), System.Drawing.PointF)
        Me.BattProgress.FocalPoints = CFocalPoints1
        Me.BattProgress.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BattProgress.ForeColor = System.Drawing.Color.White
        Me.BattProgress.Location = New System.Drawing.Point(3, 39)
        Me.BattProgress.Name = "BattProgress"
        Me.BattProgress.Orientation = ClassControl.ProgBarPlus.eOrientation.Vertical
        Me.TableLayoutPanel1.SetRowSpan(Me.BattProgress, 3)
        Me.BattProgress.ShapeText = ""
        Me.BattProgress.ShapeTextFont = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BattProgress.ShapeTextRotate = ClassControl.ProgBarPlus.eRotateText.Right
        Me.BattProgress.Size = New System.Drawing.Size(39, 116)
        Me.BattProgress.TabIndex = 0
        Me.BattProgress.Text = "ProgBarPlus1"
        Me.BattProgress.TextFormat = "{0} %"
        Me.BattProgress.TextRotate = ClassControl.ProgBarPlus.eRotateText.Right
        Me.BattProgress.TextShadow = True
        Me.BattProgress.TextShadowColor = System.Drawing.Color.Black
        Me.BattProgress.TextShow = ClassControl.ProgBarPlus.eTextShow.FormatString
        '
        'BattStatus
        '
        Me.BattStatus.AutoSize = True
        Me.BattStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BattStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BattStatus.ForeColor = System.Drawing.Color.White
        Me.BattStatus.Location = New System.Drawing.Point(48, 127)
        Me.BattStatus.Name = "BattStatus"
        Me.BattStatus.Size = New System.Drawing.Size(164, 31)
        Me.BattStatus.TabIndex = 3
        Me.Tip.SetToolTip(Me.BattStatus, "current battery status")
        '
        'BattChargeTotal
        '
        Me.BattChargeTotal.AutoSize = True
        Me.BattChargeTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BattChargeTotal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BattChargeTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BattChargeTotal.Location = New System.Drawing.Point(45, 105)
        Me.BattChargeTotal.Margin = New System.Windows.Forms.Padding(0)
        Me.BattChargeTotal.Name = "BattChargeTotal"
        Me.BattChargeTotal.Size = New System.Drawing.Size(170, 22)
        Me.BattChargeTotal.TabIndex = 2
        Me.Tip.SetToolTip(Me.BattChargeTotal, "value of current maximum capacity can be stored" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'BattChargeCurr
        '
        Me.BattChargeCurr.AutoSize = True
        Me.BattChargeCurr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BattChargeCurr.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.BattChargeCurr.ForeColor = System.Drawing.Color.White
        Me.BattChargeCurr.Location = New System.Drawing.Point(48, 36)
        Me.BattChargeCurr.Name = "BattChargeCurr"
        Me.BattChargeCurr.Size = New System.Drawing.Size(164, 69)
        Me.BattChargeCurr.TabIndex = 10
        Me.BattChargeCurr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Tip.SetToolTip(Me.BattChargeCurr, "the current capacity on your current battery")
        '
        'BattVoltage
        '
        Me.BattVoltage.AutoSize = True
        Me.BattVoltage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BattVoltage.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BattVoltage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BattVoltage.Location = New System.Drawing.Point(250, 0)
        Me.BattVoltage.Margin = New System.Windows.Forms.Padding(0)
        Me.BattVoltage.Name = "BattVoltage"
        Me.BattVoltage.Size = New System.Drawing.Size(120, 59)
        Me.BattVoltage.TabIndex = 6
        Me.BattVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BattChargeRate
        '
        Me.BattChargeRate.AutoSize = True
        Me.BattChargeRate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BattChargeRate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BattChargeRate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BattChargeRate.Location = New System.Drawing.Point(130, 0)
        Me.BattChargeRate.Margin = New System.Windows.Forms.Padding(0)
        Me.BattChargeRate.Name = "BattChargeRate"
        Me.BattChargeRate.Size = New System.Drawing.Size(120, 59)
        Me.BattChargeRate.TabIndex = 4
        Me.BattChargeRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(370, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Designed Capacity"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Tip.SetToolTip(Me.Label1, "Maximum capacity of your current battery when fabricated" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoScrollMinSize = New System.Drawing.Size(600, 0)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 158)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 100)
        Me.Panel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BattTime, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.BattChargeRate_, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.BattTime_, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.BattWearLevel, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BattDesignedCharge, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.BattChargeRate, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BattVoltage, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.08434!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.91566!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(600, 83)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'BattTime
        '
        Me.BattTime.AutoSize = True
        Me.BattTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BattTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BattTime.FlatAppearance.BorderSize = 0
        Me.BattTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BattTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BattTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BattTime.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BattTime.ForeColor = System.Drawing.Color.White
        Me.BattTime.Location = New System.Drawing.Point(0, 0)
        Me.BattTime.Margin = New System.Windows.Forms.Padding(0)
        Me.BattTime.Name = "BattTime"
        Me.BattTime.Size = New System.Drawing.Size(130, 59)
        Me.BattTime.TabIndex = 32
        Me.Tip.SetToolTip(Me.BattTime, "Remaining time Left on your current Battery" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Click to see more options)")
        Me.BattTime.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(490, 59)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Wear Level"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Tip.SetToolTip(Me.Label6, "Percentage of how much your battery losses it's capacity since it was fabricated." & _
        "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(250, 59)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 24)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Current Voltage"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Tip.SetToolTip(Me.Label5, "Current tension in voltage of your current battery" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'BattChargeRate_
        '
        Me.BattChargeRate_.AutoSize = True
        Me.BattChargeRate_.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BattChargeRate_.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BattChargeRate_.ForeColor = System.Drawing.Color.White
        Me.BattChargeRate_.Location = New System.Drawing.Point(130, 59)
        Me.BattChargeRate_.Margin = New System.Windows.Forms.Padding(0)
        Me.BattChargeRate_.Name = "BattChargeRate_"
        Me.BattChargeRate_.Size = New System.Drawing.Size(120, 24)
        Me.BattChargeRate_.TabIndex = 10
        Me.BattChargeRate_.Text = "Discharge Rate"
        Me.BattChargeRate_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Tip.SetToolTip(Me.BattChargeRate_, "Current speed of current charge or discharge per hour" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'BattTime_
        '
        Me.BattTime_.AutoSize = True
        Me.BattTime_.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BattTime_.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BattTime_.ForeColor = System.Drawing.Color.White
        Me.BattTime_.Location = New System.Drawing.Point(0, 59)
        Me.BattTime_.Margin = New System.Windows.Forms.Padding(0)
        Me.BattTime_.Name = "BattTime_"
        Me.BattTime_.Size = New System.Drawing.Size(130, 24)
        Me.BattTime_.TabIndex = 9
        Me.BattTime_.Text = "Remaining Time Left"
        Me.BattTime_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Tip.SetToolTip(Me.BattTime_, "Remaining time to Charged full when charging or Remaining time to Battery capacit" & _
        "y become empty" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'BattWearLevel
        '
        Me.BattWearLevel.AutoSize = True
        Me.BattWearLevel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BattWearLevel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BattWearLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BattWearLevel.Location = New System.Drawing.Point(490, 0)
        Me.BattWearLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.BattWearLevel.Name = "BattWearLevel"
        Me.BattWearLevel.Size = New System.Drawing.Size(110, 59)
        Me.BattWearLevel.TabIndex = 8
        Me.BattWearLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BattDesignedCharge
        '
        Me.BattDesignedCharge.AutoSize = True
        Me.BattDesignedCharge.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BattDesignedCharge.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BattDesignedCharge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BattDesignedCharge.Location = New System.Drawing.Point(370, 0)
        Me.BattDesignedCharge.Margin = New System.Windows.Forms.Padding(0)
        Me.BattDesignedCharge.Name = "BattDesignedCharge"
        Me.BattDesignedCharge.Size = New System.Drawing.Size(120, 59)
        Me.BattDesignedCharge.TabIndex = 7
        Me.BattDesignedCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tip
        '
        Me.Tip.AutoPopDelay = 10000
        Me.Tip.InitialDelay = 500
        Me.Tip.ReshowDelay = 100
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 24)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Calculate remaining time until it Reached : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Tip.SetToolTip(Me.Label2, "Remaining time to Charged full when charging or Remaining time to Battery capacit" & _
        "y become empty" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'BattTime_L
        '
        Me.BattTime_L.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BattTime_L.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BattTime_L.ForeColor = System.Drawing.Color.White
        Me.BattTime_L.Location = New System.Drawing.Point(164, 0)
        Me.BattTime_L.Margin = New System.Windows.Forms.Padding(0)
        Me.BattTime_L.Name = "BattTime_L"
        Me.BattTime_L.Size = New System.Drawing.Size(51, 25)
        Me.BattTime_L.TabIndex = 37
        Me.BattTime_L.Text = "100 %"
        Me.BattTime_L.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Tip.SetToolTip(Me.BattTime_L, "Remaining time to Charged full when charging or Remaining time to Battery capacit" & _
        "y become empty" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'BattTime_P
        '
        Me.BattTime_P.Controls.Add(Me.BattTime_L)
        Me.BattTime_P.Controls.Add(Me.BattTime_S)
        Me.BattTime_P.Controls.Add(Me.Label2)
        Me.BattTime_P.Dock = System.Windows.Forms.DockStyle.Top
        Me.BattTime_P.Location = New System.Drawing.Point(0, 258)
        Me.BattTime_P.Name = "BattTime_P"
        Me.BattTime_P.Size = New System.Drawing.Size(215, 58)
        Me.BattTime_P.TabIndex = 2
        Me.BattTime_P.Visible = False
        '
        'BattTime_S
        '
        Me.BattTime_S.BackColor = System.Drawing.Color.Transparent
        Me.BattTime_S.BarInnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BattTime_S.BarOuterColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BattTime_S.BarPenColor = System.Drawing.Color.Silver
        Me.BattTime_S.BorderRoundRectSize = New System.Drawing.Size(1, 1)
        Me.BattTime_S.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BattTime_S.DrawFocusRectangle = False
        Me.BattTime_S.DrawSemitransparentThumb = False
        Me.BattTime_S.ElapsedInnerColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BattTime_S.ElapsedOuterColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BattTime_S.LargeChange = CType(5UI, UInteger)
        Me.BattTime_S.Location = New System.Drawing.Point(0, 24)
        Me.BattTime_S.Margin = New System.Windows.Forms.Padding(0)
        Me.BattTime_S.Name = "BattTime_S"
        Me.BattTime_S.Size = New System.Drawing.Size(215, 34)
        Me.BattTime_S.SmallChange = CType(1UI, UInteger)
        Me.BattTime_S.TabIndex = 35
        Me.BattTime_S.Text = "Brighness"
        Me.BattTime_S.ThumbInnerColor = System.Drawing.Color.LightGray
        Me.BattTime_S.ThumbOuterColor = System.Drawing.Color.LightGray
        Me.BattTime_S.ThumbPenColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BattTime_S.ThumbRoundRectSize = New System.Drawing.Size(1, 1)
        Me.BattTime_S.ThumbSize = 17
        Me.BattTime_S.Value = 100
        '
        'BattRep
        '
        Me.BattRep.AutoSize = True
        Me.BattRep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BattRep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BattRep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BattRep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BattRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BattRep.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BattRep.ForeColor = System.Drawing.Color.White
        Me.BattRep.Location = New System.Drawing.Point(0, 316)
        Me.BattRep.Margin = New System.Windows.Forms.Padding(0)
        Me.BattRep.Name = "BattRep"
        Me.BattRep.Size = New System.Drawing.Size(215, 34)
        Me.BattRep.TabIndex = 31
        Me.BattRep.Text = "Generate Report"
        Me.BattRep.UseVisualStyleBackColor = True
        '
        'U_Batt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(0, 350)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Controls.Add(Me.BattRep)
        Me.Controls.Add(Me.BattTime_P)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "U_Batt"
        Me.Size = New System.Drawing.Size(215, 300)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.BattTime_P.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BattChargeRate As System.Windows.Forms.Label
    Friend WithEvents BattProgress As ClassControl.ProgBarPlus
    Friend WithEvents BattStatus As System.Windows.Forms.Label
    Friend WithEvents BattChargeTotal As System.Windows.Forms.Label
    Friend WithEvents BattVoltage As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BattChargeRate_ As System.Windows.Forms.Label
    Friend WithEvents BattTime_ As System.Windows.Forms.Label
    Friend WithEvents BattWearLevel As System.Windows.Forms.Label
    Friend WithEvents BattDesignedCharge As System.Windows.Forms.Label
    Friend WithEvents BattChargeCurr As System.Windows.Forms.Label
    Friend WithEvents Tip As System.Windows.Forms.ToolTip
    Friend WithEvents BatSelect As System.Windows.Forms.ComboBox
    Friend WithEvents BattTime_P As System.Windows.Forms.Panel
    Friend WithEvents BattTime_S As ClassControl.ColorSlider
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BattTime_L As System.Windows.Forms.Label
    Friend WithEvents BattRep As System.Windows.Forms.Button
    Friend WithEvents BattTime As System.Windows.Forms.Button
    Friend WithEvents BatRef As System.Windows.Forms.Button

End Class
