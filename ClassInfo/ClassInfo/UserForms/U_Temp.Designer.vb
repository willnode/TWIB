<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class U_Temp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(U_Temp))
        Me.WarnInfo = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tempDegree = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tempCur = New System.Windows.Forms.Label()
        Me.tempThrot = New System.Windows.Forms.Label()
        Me.tempCritic = New System.Windows.Forms.Label()
        Me.tempUpdate = New System.Windows.Forms.Label()
        Me.tempProg = New ClassControl.ProgBarPlus()
        Me.Updater = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WarnInfo
        '
        Me.WarnInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WarnInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.WarnInfo.ForeColor = System.Drawing.Color.White
        Me.WarnInfo.Location = New System.Drawing.Point(0, 209)
        Me.WarnInfo.Name = "WarnInfo"
        Me.WarnInfo.Size = New System.Drawing.Size(300, 91)
        Me.WarnInfo.TabIndex = 0
        Me.WarnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tempDegree, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tempCur, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tempThrot, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tempCritic, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tempUpdate, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tempProg, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(300, 209)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 30)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Refresh Every"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Visible = False
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 83)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Current Temp"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(73, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ACPI Thermal Data"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tempDegree
        '
        Me.tempDegree.Appearance = System.Windows.Forms.Appearance.Button
        Me.tempDegree.AutoSize = True
        Me.tempDegree.Checked = True
        Me.tempDegree.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tempDegree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tempDegree.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tempDegree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.tempDegree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.tempDegree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tempDegree.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tempDegree.ForeColor = System.Drawing.Color.White
        Me.tempDegree.Location = New System.Drawing.Point(3, 3)
        Me.tempDegree.Name = "tempDegree"
        Me.tempDegree.Size = New System.Drawing.Size(64, 30)
        Me.tempDegree.TabIndex = 0
        Me.tempDegree.Text = "ºC"
        Me.tempDegree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tempDegree.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 30)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Throttling Point"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 30)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Critical Point"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tempCur
        '
        Me.tempCur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tempCur.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.tempCur.ForeColor = System.Drawing.Color.White
        Me.tempCur.Location = New System.Drawing.Point(73, 36)
        Me.tempCur.Name = "tempCur"
        Me.tempCur.Size = New System.Drawing.Size(187, 83)
        Me.tempCur.TabIndex = 6
        Me.tempCur.Text = "0000 ºC"
        Me.tempCur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tempCur.UseMnemonic = False
        '
        'tempThrot
        '
        Me.tempThrot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tempThrot.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tempThrot.ForeColor = System.Drawing.Color.Gainsboro
        Me.tempThrot.Location = New System.Drawing.Point(73, 119)
        Me.tempThrot.Name = "tempThrot"
        Me.tempThrot.Size = New System.Drawing.Size(187, 30)
        Me.tempThrot.TabIndex = 7
        Me.tempThrot.Text = "000 ºC"
        Me.tempThrot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tempThrot.UseMnemonic = False
        '
        'tempCritic
        '
        Me.tempCritic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tempCritic.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tempCritic.ForeColor = System.Drawing.Color.Gainsboro
        Me.tempCritic.Location = New System.Drawing.Point(73, 149)
        Me.tempCritic.Name = "tempCritic"
        Me.tempCritic.Size = New System.Drawing.Size(187, 30)
        Me.tempCritic.TabIndex = 8
        Me.tempCritic.Text = "000 ºC"
        Me.tempCritic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tempCritic.UseMnemonic = False
        '
        'tempUpdate
        '
        Me.tempUpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tempUpdate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tempUpdate.ForeColor = System.Drawing.Color.Gainsboro
        Me.tempUpdate.Location = New System.Drawing.Point(73, 179)
        Me.tempUpdate.Name = "tempUpdate"
        Me.tempUpdate.Size = New System.Drawing.Size(187, 30)
        Me.tempUpdate.TabIndex = 9
        Me.tempUpdate.Text = "000 Seconds"
        Me.tempUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tempUpdate.UseMnemonic = False
        Me.tempUpdate.Visible = False
        '
        'tempProg
        '
        Me.tempProg.BarBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.Navy, System.Drawing.Color.Blue}
        CBlendItems1.iPoint = New Single() {0.0!, 1.0!}
        Me.tempProg.BarColorBlend = CBlendItems1
        Me.tempProg.BarColorSolid = System.Drawing.Color.DarkGray
        Me.tempProg.BarColorSolidB = System.Drawing.Color.Empty
        Me.tempProg.BarPadding = New System.Windows.Forms.Padding(0)
        Me.tempProg.BarStyleDegree = 0
        Me.tempProg.BarStyleFill = ClassControl.ProgBarPlus.eBarStyle.Solid
        Me.tempProg.BarStyleTexture = Nothing
        Me.tempProg.BorderColor = System.Drawing.Color.DarkGray
        Me.tempProg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tempProg.Corners.All = 0
        Me.tempProg.CylonMove = 5.0!
        Me.tempProg.Dock = System.Windows.Forms.DockStyle.Fill
        CFocalPoints1.CenterPoint = CType(resources.GetObject("CFocalPoints1.CenterPoint"), System.Drawing.PointF)
        CFocalPoints1.FocusScales = CType(resources.GetObject("CFocalPoints1.FocusScales"), System.Drawing.PointF)
        Me.tempProg.FocalPoints = CFocalPoints1
        Me.tempProg.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.tempProg.ForeColor = System.Drawing.Color.White
        Me.tempProg.Location = New System.Drawing.Point(263, 0)
        Me.tempProg.Margin = New System.Windows.Forms.Padding(0)
        Me.tempProg.Max = 120
        Me.tempProg.Min = -20
        Me.tempProg.Name = "tempProg"
        Me.tempProg.Orientation = ClassControl.ProgBarPlus.eOrientation.Vertical
        Me.TableLayoutPanel1.SetRowSpan(Me.tempProg, 5)
        Me.tempProg.ShapeTextFont = New System.Drawing.Font("Arial Black", 30.0!)
        Me.tempProg.Size = New System.Drawing.Size(37, 209)
        Me.tempProg.TabIndex = 10
        Me.tempProg.TextFormat = ""
        Me.tempProg.TextShadowColor = System.Drawing.Color.Black
        '
        'Updater
        '
        Me.Updater.Interval = 1000
        '
        'U_Temp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Controls.Add(Me.WarnInfo)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "U_Temp"
        Me.Size = New System.Drawing.Size(300, 300)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WarnInfo As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tempDegree As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tempCur As System.Windows.Forms.Label
    Friend WithEvents tempThrot As System.Windows.Forms.Label
    Friend WithEvents tempCritic As System.Windows.Forms.Label
    Friend WithEvents tempUpdate As System.Windows.Forms.Label
    Friend WithEvents tempProg As ClassControl.ProgBarPlus
    Friend WithEvents Updater As System.Windows.Forms.Timer

End Class
