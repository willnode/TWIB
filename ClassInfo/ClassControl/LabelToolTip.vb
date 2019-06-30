Imports System.ComponentModel
Imports System.Runtime.InteropServices

'Public Class LabelToolTip
'    Inherits Label
'    '    Private _Enabled As Boolean = True
'    Private _Text As String
'    Private _ToolTip As ToolTip
'    Private Sub LabelToolTip_Click(sender As Object, e As EventArgs) Handles Me.Click
'        If Not _ToolTip.Active Then
'            Security.Permissions.UIPermission()
'            _ToolTip.Active = True
'        Else
'            _ToolTip.Active = False
'        End If
'    End Sub

'    Private Sub LabelToolTip_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
'        _ToolTip.RemoveAll()
'    End Sub

'    ''' <summary>Gets or sets the text associated with this control.</summary>
'    ''' <returns>The text associated with this control.</returns>
'    ''' <filterpriority>1</filterpriority>
'    <Bindable(True), Localizable(True), DispId(-517), Category("Appearance")>
'    Public Property TextTooltip As String
'        Get
'            Return _Text
'        End Get
'        Set(value As String)
'            _Text = value
'            _ToolTip.SetToolTip(Me, _Text)
'        End Set
'    End Property
'    Public Sub New()
'        _ToolTip = New ToolTip
'        _ToolTip.ToolTipTitle = Text
'        _ToolTip.AutoPopDelay = 30
'        Cursor = Cursors.Help
'        _ToolTip.SetToolTip(Me, _Text)
'    End Sub

'    Private Sub LabelToolTip_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
'        _ToolTip.ToolTipTitle = Text
'    End Sub
'End Class
