Public Class U_Batt
    Dim lastdata As New ClassInfo.Info.Battery.BatteryDesc
    Public Sub RefreshInfo()
        If BatSelect.Items.Count > 0 Then
            Dim x As Info.Battery.BatteryDesc = Info.Battery.GetBatteryDesc(BatSelect.SelectedIndex)
            Dim isCharge = x.isCharging
            BattChargeCurr.Text = x.RemainingMAh.ToString("#,#") & " mWh"
            BattChargeTotal.Text = "/" & x.FullChargedCapacity.ToString("#,#") & " mWh"
            BattChargeRate.Text = If(isCharge, x.ChargeRate.ToString("#,#"), x.DischargeRate) & " mW"
            BattDesignedCharge.Text = x.DesignedCapacity.ToString("#,#") & " mWh"

            BattProgress.Value = x.RemainingMAh / x.FullChargedCapacity * 100
            BattStatus.Text = If(isCharge, "Charging", If(((x.ChargeRate = 0) AndAlso (x.DischargeRate = 0)), "Charged Full", ""))
            BattVoltage.Text = x.Voltage.ToString("0.00") & " V"
            BattWearLevel.Text = (100 - (x.FullChargedCapacity / x.DesignedCapacity) * 100).ToString("0.00") & " %"
            RefreshRemNotation(x)
            lastdata = x
        Else
            BattChargeCurr.Text = "----"
            BattChargeTotal.Text = "/ 0 mWh"
            BattChargeRate.Text = " 0 mW"
            BattChargeRate_.Text = "Discharge Rate"
            BattTime.Text = "--:--:--"
            BattTime_.Text = "Energy Availability"
            BattVoltage.Text = "????"
            BattWearLevel.Text = "--- %"
        End If

    End Sub
    Public Sub RefreshRemNotation(Data As ClassInfo.Info.Battery.BatteryDesc)
        Dim x = Data
        Dim y As TimeSpan
        If x.isCharging Then
            Dim z = (x.FullChargedCapacity * (100 - BattTime_S.Value) / 100)
            y = CalculateTime(x.FullChargedCapacity - (x.RemainingMAh + z), x.ChargeRate)
            BattTime_.Text = "Full Remaining Time"
            BattChargeRate_.Text = "Charge Rate"
            BattTime_L.Text = (BattTime_S.Value) & " %"
        Else
            Dim z = (x.FullChargedCapacity * (100 - BattTime_S.Value) / 100)
            y = If(x.DischargeRate <> 0, CalculateTime(x.RemainingMAh - z, x.DischargeRate), TimeSpan.FromSeconds(0))
            BattTime_.Text = "Remaining Time Left"
            BattChargeRate_.Text = "Discharge Rate"
            BattTime_L.Text = 100 - BattTime_S.Value & " %"
        End If
        BattTime.Text = If(y.TotalSeconds > 0, y.ToString, "--:--:--")
    End Sub
    Public Sub RefreshBatList()
        BatSelect.Items.Clear()
        BatSelect.Items.AddRange(Info.Battery.GetBatteryNames)
        If BatSelect.Items.Count > 0 Then BatSelect.SelectedIndex = 0
    End Sub
    Public Function CalculateTime(ByVal Current As Single, ByVal Speed As Single) As TimeSpan
        Dim hourRatio = Current / Speed
        hourRatio *= 3600
        Return New TimeSpan(0, 0, hourRatio)
    End Function
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler Info.Battery.BatteryHook.BatteryChange, AddressOf Updater_Tick
        RefreshBatList()
        RefreshInfo()
        Splash.AddLoadPoint()
    End Sub

    Private Sub Updater_Tick(WithPower As Boolean)
        If WithPower Then RefreshBatList()
        If Visible Then RefreshInfo()
    End Sub

    Private Sub BattMeasure_CheckedChanged(sender As Object, e As EventArgs)
        RefreshInfo()
    End Sub

    Private Sub U_Batt_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then RefreshInfo()
    End Sub

    Private Sub Tip_Popup(sender As Object, e As PopupEventArgs) Handles Tip.Popup
        Tip.ToolTipTitle = e.AssociatedControl.Text
    End Sub

   
    Private Sub BattTime_Click(sender As Object, e As EventArgs) Handles BattTime.Click
        BattTime_P.Visible = Not BattTime_P.Visible
    End Sub

    Private Sub BattTime_S_Scroll(sender As Object, e As ScrollEventArgs) Handles BattTime_S.Scroll
        RefreshRemNotation(lastdata)
    End Sub

    Private Sub BattRep_Click(sender As Object, e As EventArgs) Handles BattRep.Click
        Dim x = "POWERCFG.exe /BATTERYREPORT /OUTPUT " & Chr(&H22) & IO.Path.GetTempPath & "batteryreport.html" & Chr(&H22)
        Shell(x, AppWinStyle.MinimizedNoFocus, True)
        Process.Start(IO.Path.GetTempPath & "batteryreport.html", AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub BatRef_Click(sender As Object, e As EventArgs) Handles BatRef.Click
        RefreshBatList()
        RefreshInfo()
    End Sub
End Class
