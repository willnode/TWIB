<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErrorForm
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
        Me.Titl = New System.Windows.Forms.Label()
        Me.Titl2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.B_Close = New System.Windows.Forms.Button()
        Me.Txt = New System.Windows.Forms.TextBox()
        Me.B_Restart = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Titl
        '
        Me.Titl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.Titl, 2)
        Me.Titl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Titl.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Titl.ForeColor = System.Drawing.Color.White
        Me.Titl.Location = New System.Drawing.Point(0, 0)
        Me.Titl.Margin = New System.Windows.Forms.Padding(0)
        Me.Titl.Name = "Titl"
        Me.Titl.Size = New System.Drawing.Size(480, 42)
        Me.Titl.TabIndex = 0
        Me.Titl.Text = "TWIB Tool Error"
        Me.Titl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Titl2
        '
        Me.Titl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.Titl2, 2)
        Me.Titl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Titl2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titl2.ForeColor = System.Drawing.Color.White
        Me.Titl2.Location = New System.Drawing.Point(0, 42)
        Me.Titl2.Margin = New System.Windows.Forms.Padding(0)
        Me.Titl2.Name = "Titl2"
        Me.Titl2.Size = New System.Drawing.Size(480, 42)
        Me.Titl2.TabIndex = 1
        Me.Titl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.B_Close, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Titl, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Txt, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Titl2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.B_Restart, 1, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(480, 360)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'B_Close
        '
        Me.B_Close.Dock = System.Windows.Forms.DockStyle.Fill
        Me.B_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_Close.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.B_Close.ForeColor = System.Drawing.Color.White
        Me.B_Close.Location = New System.Drawing.Point(0, 318)
        Me.B_Close.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.B_Close.Name = "B_Close"
        Me.B_Close.Size = New System.Drawing.Size(239, 42)
        Me.B_Close.TabIndex = 4
        Me.B_Close.Text = "Close this Program"
        Me.B_Close.UseVisualStyleBackColor = True
        '
        'Txt
        '
        Me.Txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.Txt, 2)
        Me.Txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Txt.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.Txt.ForeColor = System.Drawing.Color.White
        Me.Txt.Location = New System.Drawing.Point(0, 84)
        Me.Txt.Margin = New System.Windows.Forms.Padding(0)
        Me.Txt.Multiline = True
        Me.Txt.Name = "Txt"
        Me.Txt.ReadOnly = True
        Me.Txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt.Size = New System.Drawing.Size(480, 234)
        Me.Txt.TabIndex = 2
        '
        'B_Restart
        '
        Me.B_Restart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.B_Restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_Restart.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.B_Restart.ForeColor = System.Drawing.Color.White
        Me.B_Restart.Location = New System.Drawing.Point(241, 318)
        Me.B_Restart.Margin = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.B_Restart.Name = "B_Restart"
        Me.B_Restart.Size = New System.Drawing.Size(239, 42)
        Me.B_Restart.TabIndex = 3
        Me.B_Restart.Text = "Restart this Program"
        Me.B_Restart.UseVisualStyleBackColor = True
        '
        'ErrorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(480, 360)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ErrorForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Titl As System.Windows.Forms.Label
    Friend WithEvents Titl2 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Txt As System.Windows.Forms.TextBox
    Friend WithEvents B_Close As System.Windows.Forms.Button
    Friend WithEvents B_Restart As System.Windows.Forms.Button
End Class
