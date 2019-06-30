<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        Dim CBlendItems1 As ClassControl.cBlendItems = New ClassControl.cBlendItems()
        Dim CFocalPoints1 As ClassControl.cFocalPoints = New ClassControl.cFocalPoints()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.V = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tim = New System.Windows.Forms.Timer(Me.components)
        Me.ldPntGrp = New ClassControl.ProgBarPlus()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.ClassInfo.My.Resources.Resources.Icon
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'V
        '
        Me.V.BackColor = System.Drawing.Color.Transparent
        Me.V.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.V.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.V.ForeColor = System.Drawing.Color.White
        Me.V.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.V.Location = New System.Drawing.Point(120, 92)
        Me.V.Name = "V"
        Me.V.Size = New System.Drawing.Size(250, 28)
        Me.V.TabIndex = 3
        Me.V.Text = "V0.0"
        Me.V.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(120, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 70)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "TWIB Tool"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(120, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Loading ..."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tim
        '
        Me.Tim.Interval = 10
        '
        'ldPntGrp
        '
        Me.ldPntGrp.BarBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(87, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0.0!, 1.0!}
        Me.ldPntGrp.BarColorBlend = CBlendItems1
        Me.ldPntGrp.BarColorSolid = System.Drawing.Color.LightGray
        Me.ldPntGrp.BarColorSolidB = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.ldPntGrp.BarPadding = New System.Windows.Forms.Padding(0)
        Me.ldPntGrp.BarStyleDegree = 90
        Me.ldPntGrp.BarStyleFill = ClassControl.ProgBarPlus.eBarStyle.Solid
        Me.ldPntGrp.BarStyleTexture = Nothing
        Me.ldPntGrp.BorderColor = System.Drawing.Color.Transparent
        Me.ldPntGrp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ldPntGrp.BorderWidth = 0
        Me.ldPntGrp.Corners.All = 0
        Me.ldPntGrp.CylonMove = 5.0!
        Me.ldPntGrp.Dock = System.Windows.Forms.DockStyle.Bottom
        CFocalPoints1.CenterPoint = CType(resources.GetObject("CFocalPoints1.CenterPoint"), System.Drawing.PointF)
        CFocalPoints1.FocusScales = CType(resources.GetObject("CFocalPoints1.FocusScales"), System.Drawing.PointF)
        Me.ldPntGrp.FocalPoints = CFocalPoints1
        Me.ldPntGrp.Location = New System.Drawing.Point(0, 120)
        Me.ldPntGrp.Margin = New System.Windows.Forms.Padding(0)
        Me.ldPntGrp.Max = 9
        Me.ldPntGrp.Name = "ldPntGrp"
        Me.ldPntGrp.ShapeTextFont = New System.Drawing.Font("Arial Black", 30.0!)
        Me.ldPntGrp.Size = New System.Drawing.Size(370, 8)
        Me.ldPntGrp.TabIndex = 6
        Me.ldPntGrp.TextFormat = "Process {1}% Done"
        Me.ldPntGrp.Value = 1
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(370, 128)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.V)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ldPntGrp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Splash"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Splash"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents V As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tim As System.Windows.Forms.Timer
    Friend WithEvents ldPntGrp As ClassControl.ProgBarPlus
End Class
