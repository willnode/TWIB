<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClrDialog
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
        Me.R = New ClassControl.ColorSlider()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.G = New ClassControl.ColorSlider()
        Me.B = New ClassControl.ColorSlider()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.P = New System.Windows.Forms.Label()
        Me.B_OK = New System.Windows.Forms.Button()
        Me.O_Cancel = New System.Windows.Forms.Button()
        Me.O_Pick = New System.Windows.Forms.Button()
        Me.T = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'R
        '
        Me.R.BackColor = System.Drawing.Color.Transparent
        Me.R.BarInnerColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.R.BarOuterColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.R.BorderRoundRectSize = New System.Drawing.Size(1, 1)
        Me.TableLayoutPanel1.SetColumnSpan(Me.R, 2)
        Me.R.Dock = System.Windows.Forms.DockStyle.Fill
        Me.R.DrawFocusRectangle = False
        Me.R.DrawSemitransparentThumb = False
        Me.R.ElapsedInnerColor = System.Drawing.Color.Red
        Me.R.ElapsedOuterColor = System.Drawing.Color.Red
        Me.R.LargeChange = CType(5UI, UInteger)
        Me.R.Location = New System.Drawing.Point(36, 31)
        Me.R.Margin = New System.Windows.Forms.Padding(0)
        Me.R.Maximum = 255
        Me.R.Name = "R"
        Me.R.Size = New System.Drawing.Size(255, 69)
        Me.R.SmallChange = CType(1UI, UInteger)
        Me.R.TabIndex = 14
        Me.R.Text = "Gamma"
        Me.R.ThumbInnerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.R.ThumbOuterColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.R.ThumbPenColor = System.Drawing.Color.Maroon
        Me.R.ThumbRoundRectSize = New System.Drawing.Size(1, 1)
        Me.R.ThumbSize = 17
        Me.R.Value = 40
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.R, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.G, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.B, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.P, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.B_OK, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.O_Cancel, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.O_Pick, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.T, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(438, 278)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'G
        '
        Me.G.BackColor = System.Drawing.Color.Transparent
        Me.G.BarInnerColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.G.BarOuterColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.G.BarPenColor = System.Drawing.Color.Silver
        Me.G.BorderRoundRectSize = New System.Drawing.Size(1, 1)
        Me.TableLayoutPanel1.SetColumnSpan(Me.G, 2)
        Me.G.Dock = System.Windows.Forms.DockStyle.Fill
        Me.G.DrawFocusRectangle = False
        Me.G.DrawSemitransparentThumb = False
        Me.G.ElapsedInnerColor = System.Drawing.Color.Lime
        Me.G.ElapsedOuterColor = System.Drawing.Color.Lime
        Me.G.LargeChange = CType(5UI, UInteger)
        Me.G.Location = New System.Drawing.Point(36, 100)
        Me.G.Margin = New System.Windows.Forms.Padding(0)
        Me.G.Maximum = 255
        Me.G.Name = "G"
        Me.G.Size = New System.Drawing.Size(255, 69)
        Me.G.SmallChange = CType(1UI, UInteger)
        Me.G.TabIndex = 15
        Me.G.Text = "Gamma"
        Me.G.ThumbInnerColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.G.ThumbOuterColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.G.ThumbPenColor = System.Drawing.Color.Green
        Me.G.ThumbRoundRectSize = New System.Drawing.Size(1, 1)
        Me.G.ThumbSize = 17
        Me.G.Value = 40
        '
        'B
        '
        Me.B.BackColor = System.Drawing.Color.Transparent
        Me.B.BarInnerColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B.BarOuterColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B.BarPenColor = System.Drawing.Color.Silver
        Me.B.BorderRoundRectSize = New System.Drawing.Size(1, 1)
        Me.TableLayoutPanel1.SetColumnSpan(Me.B, 2)
        Me.B.Dock = System.Windows.Forms.DockStyle.Fill
        Me.B.DrawFocusRectangle = False
        Me.B.DrawSemitransparentThumb = False
        Me.B.ElapsedInnerColor = System.Drawing.Color.Blue
        Me.B.ElapsedOuterColor = System.Drawing.Color.Blue
        Me.B.LargeChange = CType(5UI, UInteger)
        Me.B.Location = New System.Drawing.Point(36, 169)
        Me.B.Margin = New System.Windows.Forms.Padding(0)
        Me.B.Maximum = 255
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(255, 69)
        Me.B.SmallChange = CType(1UI, UInteger)
        Me.B.TabIndex = 16
        Me.B.Text = "Gamma"
        Me.B.ThumbInnerColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.B.ThumbOuterColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.B.ThumbPenColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B.ThumbRoundRectSize = New System.Drawing.Size(1, 1)
        Me.B.ThumbSize = 17
        Me.B.Value = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 69)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "R"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 69)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "G"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 69)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "B"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'P
        '
        Me.P.AutoSize = True
        Me.P.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P.Location = New System.Drawing.Point(294, 31)
        Me.P.Name = "P"
        Me.TableLayoutPanel1.SetRowSpan(Me.P, 3)
        Me.P.Size = New System.Drawing.Size(141, 207)
        Me.P.TabIndex = 20
        '
        'B_OK
        '
        Me.B_OK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.B_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_OK.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.B_OK.ForeColor = System.Drawing.Color.White
        Me.B_OK.Location = New System.Drawing.Point(39, 241)
        Me.B_OK.Name = "B_OK"
        Me.B_OK.Size = New System.Drawing.Size(124, 34)
        Me.B_OK.TabIndex = 21
        Me.B_OK.Text = "OK"
        Me.B_OK.UseVisualStyleBackColor = True
        '
        'O_Cancel
        '
        Me.O_Cancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.O_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.O_Cancel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.O_Cancel.ForeColor = System.Drawing.Color.White
        Me.O_Cancel.Location = New System.Drawing.Point(169, 241)
        Me.O_Cancel.Name = "O_Cancel"
        Me.O_Cancel.Size = New System.Drawing.Size(119, 34)
        Me.O_Cancel.TabIndex = 22
        Me.O_Cancel.Text = "Cancel"
        Me.O_Cancel.UseVisualStyleBackColor = True
        '
        'O_Pick
        '
        Me.O_Pick.Dock = System.Windows.Forms.DockStyle.Fill
        Me.O_Pick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.O_Pick.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.O_Pick.ForeColor = System.Drawing.Color.White
        Me.O_Pick.Location = New System.Drawing.Point(294, 241)
        Me.O_Pick.Name = "O_Pick"
        Me.O_Pick.Size = New System.Drawing.Size(141, 34)
        Me.O_Pick.TabIndex = 23
        Me.O_Pick.Text = "Pick from Screen"
        Me.O_Pick.UseVisualStyleBackColor = True
        '
        'T
        '
        Me.T.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.T.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.T.Dock = System.Windows.Forms.DockStyle.Fill
        Me.T.Font = New System.Drawing.Font("Consolas", 13.0!)
        Me.T.ForeColor = System.Drawing.Color.White
        Me.T.Location = New System.Drawing.Point(291, 5)
        Me.T.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.T.Name = "T"
        Me.T.ReadOnly = True
        Me.T.Size = New System.Drawing.Size(147, 21)
        Me.T.TabIndex = 24
        Me.T.Text = "#FFFFFF"
        Me.T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ClrDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(438, 278)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ClrDialog"
        Me.ShowInTaskbar = False
        Me.Text = "Pick A Color..."
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents R As ClassControl.ColorSlider
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents G As ClassControl.ColorSlider
    Friend WithEvents B As ClassControl.ColorSlider
    Friend WithEvents O_Pick As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents P As System.Windows.Forms.Label
    Friend WithEvents B_OK As System.Windows.Forms.Button
    Friend WithEvents O_Cancel As System.Windows.Forms.Button
    Friend WithEvents T As System.Windows.Forms.TextBox
End Class
