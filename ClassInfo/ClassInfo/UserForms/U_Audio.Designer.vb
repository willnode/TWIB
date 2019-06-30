<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class U_Audio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(U_Audio))
        Dim CBlendItems2 As ClassControl.cBlendItems = New ClassControl.cBlendItems()
        Dim CFocalPoints2 As ClassControl.cFocalPoints = New ClassControl.cFocalPoints()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.RPeak = New ClassControl.ProgBarPlus()
        Me.VolSlider = New ClassControl.ColorSlider()
        Me.LPeak = New ClassControl.ProgBarPlus()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Updater = New System.Windows.Forms.Timer(Me.components)
        Me.WavL = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.WavL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 4)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Speaker's Volume"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.WavL, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.RPeak, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.VolSlider, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LPeak, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(300, 300)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'RPeak
        '
        Me.RPeak.BarBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.Navy, System.Drawing.Color.Blue}
        CBlendItems1.iPoint = New Single() {0.0!, 1.0!}
        Me.RPeak.BarColorBlend = CBlendItems1
        Me.RPeak.BarColorSolid = System.Drawing.Color.LightGray
        Me.RPeak.BarColorSolidB = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RPeak.BarPadding = New System.Windows.Forms.Padding(0)
        Me.RPeak.BarStyleDegree = 0
        Me.RPeak.BarStyleFill = ClassControl.ProgBarPlus.eBarStyle.Solid
        Me.RPeak.BarStyleTexture = Nothing
        Me.RPeak.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RPeak.BorderWidth = 0
        Me.TableLayoutPanel1.SetColumnSpan(Me.RPeak, 2)
        Me.RPeak.Corners.All = 0
        Me.RPeak.CylonMove = 5.0!
        Me.RPeak.Dock = System.Windows.Forms.DockStyle.Fill
        CFocalPoints1.CenterPoint = CType(resources.GetObject("CFocalPoints1.CenterPoint"), System.Drawing.PointF)
        CFocalPoints1.FocusScales = CType(resources.GetObject("CFocalPoints1.FocusScales"), System.Drawing.PointF)
        Me.RPeak.FocalPoints = CFocalPoints1
        Me.RPeak.Location = New System.Drawing.Point(148, 63)
        Me.RPeak.Margin = New System.Windows.Forms.Padding(0)
        Me.RPeak.Name = "RPeak"
        Me.RPeak.ShapeTextFont = New System.Drawing.Font("Arial Black", 30.0!)
        Me.RPeak.Size = New System.Drawing.Size(152, 18)
        Me.RPeak.TabIndex = 5
        Me.RPeak.TextFormat = "Process {1}% Done"
        '
        'VolSlider
        '
        Me.VolSlider.BackColor = System.Drawing.Color.Transparent
        Me.VolSlider.BarInnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.VolSlider.BarOuterColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.VolSlider.BarPenColor = System.Drawing.Color.Silver
        Me.VolSlider.BorderRoundRectSize = New System.Drawing.Size(1, 1)
        Me.TableLayoutPanel1.SetColumnSpan(Me.VolSlider, 2)
        Me.VolSlider.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VolSlider.DrawFocusRectangle = False
        Me.VolSlider.DrawSemitransparentThumb = False
        Me.VolSlider.ElapsedInnerColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VolSlider.ElapsedOuterColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VolSlider.LargeChange = CType(5UI, UInteger)
        Me.VolSlider.Location = New System.Drawing.Point(33, 28)
        Me.VolSlider.Name = "VolSlider"
        Me.VolSlider.Size = New System.Drawing.Size(230, 32)
        Me.VolSlider.SmallChange = CType(1UI, UInteger)
        Me.VolSlider.TabIndex = 4
        Me.VolSlider.ThumbInnerColor = System.Drawing.Color.LightGray
        Me.VolSlider.ThumbOuterColor = System.Drawing.Color.LightGray
        Me.VolSlider.ThumbPenColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.VolSlider.ThumbRoundRectSize = New System.Drawing.Size(1, 1)
        Me.VolSlider.ThumbSize = 17
        '
        'LPeak
        '
        Me.LPeak.BarBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.Navy, System.Drawing.Color.Blue}
        CBlendItems2.iPoint = New Single() {0.0!, 1.0!}
        Me.LPeak.BarColorBlend = CBlendItems2
        Me.LPeak.BarColorSolid = System.Drawing.Color.LightGray
        Me.LPeak.BarColorSolidB = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LPeak.BarPadding = New System.Windows.Forms.Padding(0)
        Me.LPeak.BarStyleDegree = 0
        Me.LPeak.BarStyleFill = ClassControl.ProgBarPlus.eBarStyle.Solid
        Me.LPeak.BarStyleTexture = Nothing
        Me.LPeak.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LPeak.BorderWidth = 0
        Me.TableLayoutPanel1.SetColumnSpan(Me.LPeak, 2)
        Me.LPeak.Corners.All = 0
        Me.LPeak.CylonMove = 5.0!
        Me.LPeak.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LPeak.FillDirection = ClassControl.ProgBarPlus.eFillDirection.Down_Left
        CFocalPoints2.CenterPoint = CType(resources.GetObject("CFocalPoints2.CenterPoint"), System.Drawing.PointF)
        CFocalPoints2.FocusScales = CType(resources.GetObject("CFocalPoints2.FocusScales"), System.Drawing.PointF)
        Me.LPeak.FocalPoints = CFocalPoints2
        Me.LPeak.Location = New System.Drawing.Point(0, 63)
        Me.LPeak.Margin = New System.Windows.Forms.Padding(0)
        Me.LPeak.Name = "LPeak"
        Me.LPeak.ShapeTextFont = New System.Drawing.Font("Arial Black", 30.0!)
        Me.LPeak.Size = New System.Drawing.Size(148, 18)
        Me.LPeak.TabIndex = 2
        Me.LPeak.TextFormat = "Process {1}% Done"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label2, 4)
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(294, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Microphone's Audio Noise Level"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Updater
        '
        Me.Updater.Interval = 50
        '
        'WavL
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.WavL, 4)
        Me.WavL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WavL.Location = New System.Drawing.Point(0, 108)
        Me.WavL.Margin = New System.Windows.Forms.Padding(0)
        Me.WavL.Name = "WavL"
        Me.WavL.Size = New System.Drawing.Size(300, 192)
        Me.WavL.TabIndex = 4
        Me.WavL.TabStop = False
        '
        'U_Audio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "U_Audio"
        Me.Size = New System.Drawing.Size(300, 300)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.WavL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LPeak As ClassControl.ProgBarPlus
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Updater As System.Windows.Forms.Timer
    Friend WithEvents VolSlider As ClassControl.ColorSlider
    Friend WithEvents RPeak As ClassControl.ProgBarPlus
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents WavL As System.Windows.Forms.PictureBox

End Class
