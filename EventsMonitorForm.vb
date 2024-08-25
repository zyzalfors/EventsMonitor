Imports System.Collections.Specialized
Imports System.IO

Public Class EventsMonitorForm

    Private Declare Function AddClipboardFormatListener Lib "user32.dll" (hWnd As IntPtr) As Boolean
    Private Declare Function RemoveClipboardFormatListener Lib "user32.dll" (hWnd As IntPtr) As Boolean
    Public Delegate Function KeyboardHookDelegate(Code As Int32, wParam As Int32, ByRef lParam As KBDLLHOOKSTRUCT) As Int32
    Private ReadOnly KeyboardHookDelegateInst As New KeyboardHookDelegate(AddressOf KeyboardHookProc)
    Public Delegate Function MouseHookDelegate(Code As Int32, wParam As Int32, ByRef lParam As MSLLHOOKSTRUCT) As Int32
    Private ReadOnly MouseHookDelegateInst As New MouseHookDelegate(AddressOf MouseHookProc)
    Private Declare Function SetWindowsHookKB Lib "user32.dll" Alias "SetWindowsHookExA" (idHook As Int32, lpfn As KeyboardHookDelegate, hmod As Int32, dwThreadId As Int32) As Int32
    Private Declare Function SetWindowsHookMS Lib "user32.dll" Alias "SetWindowsHookExA" (idHook As Int32, lpfn As MouseHookDelegate, hmod As Int32, dwThreadId As Int32) As Int32
    Private Declare Function UnhookWindowsHookEx Lib "user32.dll" (idHook As Int32) As Boolean
    Private Declare Function MapVirtualKeyA Lib "user32.dll" (vkCode As Int32, mapType As Int32) As Int32
    Private Const WM_CLIPBOARDUPDATE As Int32 = &H31D
    Private Const WM_LBUTTONDOWN As Int32 = &H201
    Private Const WM_RBUTTONDOWN As Int32 = &H204
    Private Const WM_SYSKEYDOWN As Int32 = &H104
    Private Const WM_KEYDOWN As Int32 = &H100
    Private Const WH_MOUSE_LL As Int32 = 14&
    Private Const WM_MOUSEWHEEL As Int32 = &H20A
    Private Const WM_MOUSEMOVE As Int32 = &H200
    Private Const WH_KEYBOARD_LL As Int32 = 13&
    Private Const MAPVK_VK_TO_CHAR As Int32 = 2&
    Private KBHook As Int32 = 0
    Private MSHook As Int32 = 0
    Private ReadOnly Info As String = "Events Monitor" + Environment.NewLine + "Language: Visual Basic .NET"

    Public Structure KBDLLHOOKSTRUCT
        Public vkCode As Int32
        Public scanCode As Int32
        Public flags As Int32
        Public time As Int32
        Public dwExtraInfo As Int32
    End Structure

    Public Structure POINT
        Public x As Int32
        Public y As Int32
    End Structure

    Public Structure MSLLHOOKSTRUCT
        Public pt As POINT
        Public mouseData As Int32
        Public flags As Int32
        Public time As Int32
        Public dwExtraInfo As Int32
    End Structure

    Private Function BytesToStringified(bytes As Byte()) As String
        Dim stringified As String = ""
        For Each octet In bytes
            stringified += "0x" + Hex(octet) + " "
        Next octet
        Return stringified.Substring(0, stringified.Length - 1)
    End Function

    Private Function ListToStringified(strings As StringCollection) As String
        Dim stringified As String = ""
        For Each value In strings
            stringified += value + Environment.NewLine
        Next value
        Return stringified.Substring(0, stringified.Length - 1)
    End Function

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = WM_CLIPBOARDUPDATE Then
            Dim now As DateTime = DateAndTime.Now.ToLocalTime()
            If My.Computer.Clipboard.ContainsText() Then
                Dim description As String = "Copied text: " + My.Computer.Clipboard.GetText()
                Me.TableGrid.Rows.Add(now, description)
            ElseIf My.Computer.Clipboard.ContainsImage Then
                Dim img As Image = My.Computer.Clipboard.GetImage()
                Dim bytes As Byte() = New ImageConverter().ConvertTo(img, GetType(Byte()))
                Dim description As String = "Copied image: " + BytesToStringified(bytes)
                Me.TableGrid.Rows.Add(now, description)
            ElseIf My.Computer.Clipboard.ContainsFileDropList Then
                Dim description As String = "Copied/cutted: " + ListToStringified(My.Computer.Clipboard.GetFileDropList())
                Me.TableGrid.Rows.Add(now, description)
            End If
        End If
        MyBase.WndProc(m)
    End Sub

    Protected Function KeyboardHookProc(Code As Int32, wParam As Int32, ByRef lParam As KBDLLHOOKSTRUCT) As Int32
        Dim now As DateTime = DateAndTime.Now.ToLocalTime()
        If wParam = WM_KEYDOWN Or wParam = WM_SYSKEYDOWN Then
            Dim vkCode As Int32 = lParam.vkCode
            Dim ch As String = If(MapVirtualKeyA(vkCode, MAPVK_VK_TO_CHAR) = 0, "0x" + Hex(vkCode), "0x" + Hex(vkCode) + " " + Chr(MapVirtualKeyA(vkCode, MAPVK_VK_TO_CHAR)))
            Dim description As String = "Key pressed: " + ch
            Me.TableGrid.Rows.Add(now, description)
        End If
        Return 0
    End Function

    Protected Function MouseHookProc(Code As Int32, wParam As Int32, ByRef lParam As MSLLHOOKSTRUCT) As Int32
        Dim now As DateTime = DateAndTime.Now.ToLocalTime()
        If wParam = WM_LBUTTONDOWN Then
            Dim x As String = lParam.pt.x
            Dim y As String = lParam.pt.y
            Dim description As String = "Mouse left key pressed: (" + x + " , " + y + ")"
            Me.TableGrid.Rows.Add(now, description)
        ElseIf wParam = WM_RBUTTONDOWN Then
            Dim x As String = lParam.pt.x
            Dim y As String = lParam.pt.y
            Dim description As String = "Mouse right key pressed: (" + x + " , " + y + ")"
            Me.TableGrid.Rows.Add(now, description)
        ElseIf wParam = WM_MOUSEWHEEL Then
            Dim x As String = lParam.pt.x
            Dim y As String = lParam.pt.y
            Dim description As String = "Mouse wheel rotated: (" + x + " , " + y + ")"
            Me.TableGrid.Rows.Add(now, description)
        ElseIf wParam = WM_MOUSEMOVE Then
            Dim x As String = lParam.pt.x
            Dim y As String = lParam.pt.y
            Dim description As String = "Mouse cursor moved: (" + x + " , " + y + ")"
            Me.TableGrid.Rows.Add(now, description)
        End If
        Return 0
    End Function

    Private Sub OnRenamed(sender As Object, e As RenamedEventArgs) Handles FileSystemListener.Renamed
        Dim now As DateTime = DateAndTime.Now.ToLocalTime()
        Dim description As String = "Renamed: " + e.OldFullPath + " --> " + e.FullPath
        Me.TableGrid.Rows.Add(now, description)
    End Sub

    Private Sub OnDeleted(sender As Object, e As FileSystemEventArgs) Handles FileSystemListener.Deleted
        Dim now As DateTime = DateAndTime.Now.ToLocalTime()
        Dim description As String = "Deleted: " + e.FullPath
        Me.TableGrid.Rows.Add(now, description)
    End Sub

    Private Sub OnCreated(sender As Object, e As FileSystemEventArgs) Handles FileSystemListener.Created
        Dim now As DateTime = DateAndTime.Now.ToLocalTime()
        Dim description As String = "Created: " + e.FullPath
        Me.TableGrid.Rows.Add(now, description)
    End Sub

    Private Sub OnChanged(sender As Object, e As FileSystemEventArgs) Handles FileSystemListener.Changed
        Dim now As DateTime = DateAndTime.Now.ToLocalTime()
        If e.ChangeType = WatcherChangeTypes.Changed Then
            Dim description As String = "Changed: " + e.FullPath
            Me.TableGrid.Rows.Add(now, description)
        End If
    End Sub

    Public Function FormatPath(path As String) As String
        Return If(path.EndsWith(":"), System.Text.RegularExpressions.Regex.Replace(path + "\", "\\+", "\"), System.Text.RegularExpressions.Regex.Replace(path, "\\+", "\"))
    End Function

    Private Sub StartEndDirMonitoring(sender As Object, e As EventArgs) Handles MonitorDirCheck.Click
        If Me.MonitorDirCheck.Checked Then
            Dim path As String = FormatPath(Me.DirText.Text.Trim())
            If Directory.Exists(path) Then
                Me.FileSystemListener.Path = path
                Me.FileSystemListener.EnableRaisingEvents = True
            Else
                MessageBox.Show("Directory '" + path + "' not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.MonitorDirCheck.Checked = False
            End If
        Else
            Me.FileSystemListener.EnableRaisingEvents = False
        End If
    End Sub

    Private Sub ClearData(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearMenuItem.Click
        Me.TableGrid.Rows.Clear()
        Me.SaveLabel.Enabled = False
        Me.NumEventsLabel.Text = "0"
    End Sub

    Private Sub OpenSaveDialog(sender As Object, e As EventArgs) Handles SaveLabel.Click
        Me.SaveDialog.ShowDialog()
    End Sub

    Private Sub SaveFileOnOK(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveDialog.FileOk
        Dim FilePath As String = Me.SaveDialog.FileName
        Dim rows As DataGridViewRowCollection = Me.TableGrid.Rows
        Using FileWriter As New System.IO.StreamWriter(FilePath)
            FileWriter.WriteLine("Events Monitor" + Environment.NewLine)
            For Each row In rows
                FileWriter.WriteLine(row.Cells(0).Value + Environment.NewLine + row.Cells(1).Value + Environment.NewLine)
            Next row
            FileWriter.Close()
        End Using
        Dim choose As DialogResult = MessageBox.Show("File saved. Do you want to open it?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If choose = DialogResult.Yes Then Process.Start(FilePath)
    End Sub

    Private Sub ShowInfo(sender As Object, e As EventArgs) Handles InfoLabel.Click
        MessageBox.Show(Info, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub OnRowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles TableGrid.RowsAdded
        Me.SaveLabel.Enabled = True
        Me.NumEventsLabel.Text = (Convert.ToUInt64(Me.NumEventsLabel.Text) + 1).ToString()
        Me.TableGrid.FirstDisplayedScrollingRowIndex = Me.TableGrid.Rows.Count - 1
        If Me.WriteOnFileCheck.Checked Then
            Dim row As DataGridViewRow = Me.TableGrid.Rows(e.RowIndex)
            Using writer As New StreamWriter(File.Open("events.txt", FileMode.Append))
                writer.WriteLine(row.Cells(0).Value + Environment.NewLine + row.Cells(1).Value + Environment.NewLine)
                writer.Close()
            End Using
        End If
    End Sub

    Private Sub StartEndClipMonitoring(sender As Object, e As EventArgs) Handles MonitorClipCheck.Click
        If Me.MonitorClipCheck.Checked Then
            AddClipboardFormatListener(MyBase.Handle)
        Else
            RemoveClipboardFormatListener(MyBase.Handle)
        End If
    End Sub

    Private Sub StartEndKeyMonitoring(sender As Object, e As EventArgs) Handles MonitorKeyCheck.Click
        If Me.MonitorKeyCheck.Checked Then
            Me.KBHook = SetWindowsHookKB(WH_KEYBOARD_LL, Me.KeyboardHookDelegateInst, 0, 0)
        Else
            UnhookWindowsHookEx(Me.KBHook)
        End If
    End Sub

    Private Sub StartEndMouseMonitoring(sender As Object, e As EventArgs) Handles MonitorMouseCheck.Click
        If Me.MonitorMouseCheck.Checked Then
            Me.MSHook = SetWindowsHookMS(WH_MOUSE_LL, Me.MouseHookDelegateInst, 0, 0)
        Else
            UnhookWindowsHookEx(Me.MSHook)
        End If
    End Sub

    Private Sub CopySelectedRows(sender As Object, e As EventArgs) Handles CopyMenuItem.Click
        Dim RowsColl As DataGridViewSelectedRowCollection = Me.TableGrid.SelectedRows
        If RowsColl.Count > 0 Then
            Dim RowsList As New StringCollection()
            For Each row In RowsColl
                RowsList.Add(row.Cells(0).Value + "  " + row.Cells(1).Value)
            Next row
            My.Computer.Clipboard.SetText(ListToStringified(RowsList))
        End If
    End Sub

    Private Sub WrapUnwrapText(sender As Object, e As EventArgs) Handles UnwrapCheck.Click
        Dim DataGridViewCellStyle As New System.Windows.Forms.DataGridViewCellStyle With {
            .SelectionBackColor = System.Drawing.Color.DarkBlue,
            .WrapMode = If(Me.UnwrapCheck.Checked, System.Windows.Forms.DataGridViewTriState.[False], System.Windows.Forms.DataGridViewTriState.[True])
        }
        Me.TableGrid.DefaultCellStyle = DataGridViewCellStyle
    End Sub

End Class
