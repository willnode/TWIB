Imports System.Xml
Public Class U_Disk
    Dim Drives As New C_Disk
    Private Const WM_DEVICECHANGE As Integer = &H219

  
#Region "SMART"
    Public Sub NormalizeSMARTList()
        Try
            SMT.BeginUpdate()
            SMT.Items.Clear()
            SMT.Items.Add("00").SubItems.AddRange({"---", "---", "---", "---", ""})
            Dim xml As New XmlDocument
            xml.LoadXml(My.Resources.HDDSMART)
            Dim node = xml.SelectSingleNode("/SMARTAttributes")
            For Each I As XmlNode In node.ChildNodes
                SMT.Items.Add(I.Attributes("id").Value).SubItems.AddRange({I.Attributes("Name").Value, "", "", "", ""})
            Next
            For Each I As ListViewItem In SMT.Items
                I.ForeColor = Color.Gray
            Next
            SMT.Columns(0).AutoResize(2)
            SMT.Columns(1).AutoResize(2)
            SMT.Columns(2).AutoResize(2)
            SMT.Columns(3).AutoResize(2)
            SMT.Columns(4).AutoResize(2)
            SMT.Columns(5).AutoResize(1)
            SMT.Items(0).Remove()
            SMT.EndUpdate()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SMARTUpdate(sender As Object, e As EventArgs) Handles Tim.Tick
        If (TabControl1.SelectedIndex = 2 And Disk.SelectedIndex > -1) AndAlso CrtDrv.SMART.Supported Then
            Drives.RefreshSMART(CrtDrv.Index)
            SMT.BeginUpdate()

            For i = 0 To (CrtDrv.SMART.Attributes.Count - 1)
                With CrtDrv.SMART.Attributes(i)
                    Dim ii = 0
r:
                    Dim hx As Integer
                    If i + ii < SMT.Items.Count Then
                        hx = CLng("&H" & SMT.Items(i + ii).Text)
                    Else
                        GoTo s
                    End If
                    If hx = .Idx Then
                        SMT.Items(i + ii).SubItems(2).Text = .Current
                        SMT.Items(i + ii).SubItems(3).Text = .Worst
                        SMT.Items(i + ii).SubItems(4).Text = .Threshold
                        SMT.Items(i + ii).SubItems(5).Text = If(.isOK, "Good", "Bad")
                        SMT.Items(i + ii).ForeColor = If(.isOK, Color.White, Color.IndianRed)
                    Else
                        ii += 1 : GoTo r
                    End If
s:
                End With
            Next
            SMT.EndUpdate()


        End If
    End Sub
#End Region
    Public Sub RefreshDisk()
        If Drives.Drives.Length <> Helper.WmiGetRowCount("root/CIMV2", "Win32_DiskDrive") Then
            Drives.RefreshDrives()
            Disk.BeginUpdate() : Disk.Items.Clear()
            For Each I As C_Disk.DriveInfo In Drives.Drives
                Disk.Items.Add(I.Caption)
            Next
            If Disk.Items.Count > 0 Then Disk.SelectedIndex = 0
            Disk.EndUpdate()
        End If
    End Sub

    
    Public Function CrtDrv() As C_Disk.DriveInfo
        Return Drives.Drives(Disk.SelectedIndex)
    End Function

    Private Sub U_Disk_Load(sender As Object, e As EventArgs) Handles Me.Load
       
    End Sub

    Private Sub U_Disk_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        On Error Resume Next
        Tim.Enabled = Visible
    End Sub
  
    Private Sub Disk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Disk.SelectedIndexChanged
        If Disk.SelectedIndex > -1 Then
            'ParititonInfo
            UsgP_List.BeginUpdate()
            UsgP_List.Items.Clear()
            Dim szused As Long
            For Each I As C_Disk.PartitionInfo In CrtDrv.Partitions
                For Each J As C_Disk.DiskInfo In I.Disks
                    UsgP_List.Items.Add(J)
                    szused += J.TotalSpace - J.FreeSpace
                Next
            Next
            If UsgP_List.Items.Count > 0 Then UsgP_List.SelectedIndex = 0
            UsgP_List.EndUpdate()
            Usg_Used.Text = Helper.FixBytes(szused, 2)
            Usg_Total.Text = "/ " & Helper.FixBytes(CrtDrv.SizeDetails.TotalBytes, 2)
            Usg_Prog.Value = szused / CrtDrv.SizeDetails.TotalBytes * 100
            'Disk Detail
            Dis_Desc.Text = CrtDrv.Description
            Dis_FirmRev.Text = CrtDrv.FirmwareRevision
            Dis_IntType.Text = CrtDrv.InterfaceType
            Dis_Label.Text = CrtDrv.Caption
            Dis_PNP.Text = CrtDrv.PNPID
            Dis_Sign.Text = CrtDrv.Signature
            Dis_SN.Text = Trim(CrtDrv.SerialNumber)
            'Disk Size Detail
            Dic_HDD.Text = CrtDrv.Caption
            Dic_PerCylinder.Text = "x " & CrtDrv.SizeDetails.TotalCylinders
            Dic_Cylinder.Text = CrtDrv.SizeDetails.TotalCylinders.ToString("#,#0") & " Cylinders"

            Dic_PerTrack.Text = "x " & CrtDrv.SizeDetails._TrackPerCylinder
            Dic_Track.Text = CrtDrv.SizeDetails.TotalTracks.ToString("#,#0") & " Tracks"

            Dic_PerSector.Text = "x " & CrtDrv.SizeDetails._SectorsPerTrack
            Dic_Sector.Text = CrtDrv.SizeDetails.TotalSectors.ToString("#,#0") & " Sectors"

            Dic_PerByte.Text = "x " & CrtDrv.SizeDetails._BytesPerSector
            Dic_Byte.Text = CrtDrv.SizeDetails.TotalBytes.ToString("#,#0") & " Bytes"
            'S.M.A.R.T
            NormalizeSMARTList()
            SMARTUpdate(sender, e)
            If CrtDrv.SMART.Supported Then
                If CrtDrv.SMART.isStatusOK Then
                    SMT_S.Text = "GOOD" : SMT_S.ForeColor = Color.LightGreen
                Else
                    SMT_S.Text = "BAD" : SMT_S.ForeColor = Color.LightCoral
                End If
            Else
                SMT_S.Text = "Not Supported" : SMT_S.ForeColor = Color.LightGray
            End If
        End If
    End Sub

    Private Sub UsgP_List_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UsgP_List.SelectedIndexChanged
        Try
            If UsgP_List.SelectedIndex > -1 Then
                With CType(UsgP_List.SelectedItem, C_Disk.DiskInfo)
                    UsgP.BeginUpdate()
                    UsgP.Items(0).SubItems(1).Text = .Label
                    UsgP.Items(1).SubItems(1).Text = Helper.FixBytes(.FreeSpace, 2)
                    UsgP.Items(2).SubItems(1).Text = Helper.FixBytes(.TotalSpace, 2)
                    UsgP.Items(3).SubItems(1).Text = .DriveType.ToString
                    UsgP.Items(4).SubItems(1).Text = .FileSystem
                    UsgP.Items(5).SubItems(1).Text = .SerialNumber
                    UsgP.Items(6).SubItems(1).Text = .Partition.Index
                    UsgP.Items(7).SubItems(1).Text = .Partition.Type
                    UsgP.Items(8).SubItems(1).Text = If(.Partition.isBootable, "Yes", "No")
                    UsgP.Items(9).SubItems(1).Text = If(.Partition.isPrimartyBoot, "Yes", "No")
                    UsgP.Items(10).SubItems(1).Text = If(.Partition.isPrimaryPartition, "Yes", "No")
                    UsgP.Columns(0).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
                    UsgP.Columns(1).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
                    UsgP.EndUpdate()
                    UsgP_Prog.Value = (.TotalSpace - .FreeSpace) / .TotalSpace * 100
                End With
            End If
        Catch
        End Try
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        NormalizeSMARTList()
        Me.RefreshDisk()
        Splash.AddLoadPoint()
    End Sub
End Class


