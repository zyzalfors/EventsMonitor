<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EventsMonitorForm
    Inherits System.Windows.Forms.Form

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FileSystemListener = New System.IO.FileSystemWatcher()
        Me.TableGrid = New System.Windows.Forms.DataGridView()
        Me.TimestampColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirLabel = New System.Windows.Forms.Label()
        Me.DirText = New System.Windows.Forms.TextBox()
        Me.ToolBar = New System.Windows.Forms.ToolStrip()
        Me.SaveLabel = New System.Windows.Forms.ToolStripLabel()
        Me.InfoLabel = New System.Windows.Forms.ToolStripLabel()
        Me.MonitorDirCheck = New System.Windows.Forms.CheckBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.EventsLabel = New System.Windows.Forms.Label()
        Me.NumEventsLabel = New System.Windows.Forms.Label()
        Me.MonitorClipCheck = New System.Windows.Forms.CheckBox()
        Me.MonitorKeyCheck = New System.Windows.Forms.CheckBox()
        Me.MonitorMouseCheck = New System.Windows.Forms.CheckBox()
        Me.WriteOnFileCheck = New System.Windows.Forms.CheckBox()
        Me.UnwrapCheck = New System.Windows.Forms.CheckBox()
        CType(Me.FileSystemListener, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenu.SuspendLayout()
        Me.ToolBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileSystemListener
        '
        Me.FileSystemListener.EnableRaisingEvents = True
        Me.FileSystemListener.IncludeSubdirectories = True
        Me.FileSystemListener.NotifyFilter = CType((((((((System.IO.NotifyFilters.FileName Or System.IO.NotifyFilters.DirectoryName) _
            Or System.IO.NotifyFilters.Attributes) _
            Or System.IO.NotifyFilters.Size) _
            Or System.IO.NotifyFilters.LastWrite) _
            Or System.IO.NotifyFilters.LastAccess) _
            Or System.IO.NotifyFilters.CreationTime) _
            Or System.IO.NotifyFilters.Security), System.IO.NotifyFilters)
        Me.FileSystemListener.SynchronizingObject = Me
        '
        'TableGrid
        '
        Me.TableGrid.AllowUserToAddRows = False
        Me.TableGrid.AllowUserToDeleteRows = False
        Me.TableGrid.AllowUserToResizeRows = False
        Me.TableGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TableGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TableGrid.BackgroundColor = System.Drawing.SystemColors.Window
        Me.TableGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TableGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TableGrid.ColumnHeadersHeight = 29
        Me.TableGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TimestampColumn, Me.DescColumn})
        Me.TableGrid.ContextMenuStrip = Me.ContextMenu
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TableGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.TableGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.TableGrid.Location = New System.Drawing.Point(10, 90)
        Me.TableGrid.Name = "TableGrid"
        Me.TableGrid.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TableGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.TableGrid.RowHeadersWidth = 51
        Me.TableGrid.RowTemplate.Height = 24
        Me.TableGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TableGrid.Size = New System.Drawing.Size(780, 400)
        Me.TableGrid.TabIndex = 0
        '
        'TimestampColumn
        '
        Me.TimestampColumn.FillWeight = 50.69519!
        Me.TimestampColumn.HeaderText = "Timestamp"
        Me.TimestampColumn.MaxInputLength = 100
        Me.TimestampColumn.MinimumWidth = 10
        Me.TimestampColumn.Name = "TimestampColumn"
        Me.TimestampColumn.ReadOnly = True
        '
        'DescColumn
        '
        Me.DescColumn.FillWeight = 189.3048!
        Me.DescColumn.HeaderText = "Description"
        Me.DescColumn.MaxInputLength = 1000000
        Me.DescColumn.MinimumWidth = 6
        Me.DescColumn.Name = "DescColumn"
        Me.DescColumn.ReadOnly = True
        '
        'ContextMenu
        '
        Me.ContextMenu.AllowMerge = False
        Me.ContextMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyMenuItem, Me.ClearMenuItem})
        Me.ContextMenu.Name = "ContextMenu"
        Me.ContextMenu.Size = New System.Drawing.Size(113, 52)
        '
        'CopyMenuItem
        '
        Me.CopyMenuItem.Name = "CopyMenuItem"
        Me.CopyMenuItem.Size = New System.Drawing.Size(112, 24)
        Me.CopyMenuItem.Text = "Copy"
        '
        'ClearMenuItem
        '
        Me.ClearMenuItem.Name = "ClearMenuItem"
        Me.ClearMenuItem.Size = New System.Drawing.Size(112, 24)
        Me.ClearMenuItem.Text = "Clear"
        '
        'DirLabel
        '
        Me.DirLabel.AutoSize = True
        Me.DirLabel.Location = New System.Drawing.Point(10, 30)
        Me.DirLabel.Name = "DirLabel"
        Me.DirLabel.Size = New System.Drawing.Size(136, 17)
        Me.DirLabel.TabIndex = 1
        Me.DirLabel.Text = "Directory to monitor:"
        '
        'DirText
        '
        Me.DirText.Location = New System.Drawing.Point(111, 27)
        Me.DirText.MaxLength = 1000000
        Me.DirText.Name = "DirText"
        Me.DirText.Size = New System.Drawing.Size(360, 22)
        Me.DirText.TabIndex = 2
        Me.DirText.WordWrap = False
        '
        'ToolBar
        '
        Me.ToolBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveLabel, Me.InfoLabel})
        Me.ToolBar.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.Size = New System.Drawing.Size(800, 25)
        Me.ToolBar.TabIndex = 3
        Me.ToolBar.Text = "ToolBar"
        '
        'SaveLabel
        '
        Me.SaveLabel.Enabled = False
        Me.SaveLabel.Name = "SaveLabel"
        Me.SaveLabel.Size = New System.Drawing.Size(40, 22)
        Me.SaveLabel.Text = "Save"
        '
        'InfoLabel
        '
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(35, 22)
        Me.InfoLabel.Text = "Info"
        '
        'MonitorDirCheck
        '
        Me.MonitorDirCheck.AutoSize = True
        Me.MonitorDirCheck.Location = New System.Drawing.Point(500, 60)
        Me.MonitorDirCheck.Name = "MonitorDirCheck"
        Me.MonitorDirCheck.Size = New System.Drawing.Size(136, 21)
        Me.MonitorDirCheck.TabIndex = 4
        Me.MonitorDirCheck.Text = "Monitor directory"
        Me.MonitorDirCheck.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(10, 540)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(190, 40)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SaveDialog
        '
        Me.SaveDialog.DefaultExt = "txt"
        Me.SaveDialog.FileName = "events.txt"
        '
        'EventsLabel
        '
        Me.EventsLabel.AutoSize = True
        Me.EventsLabel.Location = New System.Drawing.Point(10, 510)
        Me.EventsLabel.Name = "EventsLabel"
        Me.EventsLabel.Size = New System.Drawing.Size(55, 17)
        Me.EventsLabel.TabIndex = 6
        Me.EventsLabel.Text = "Events:"
        Me.EventsLabel.UseMnemonic = False
        '
        'NumEventsLabel
        '
        Me.NumEventsLabel.AutoSize = True
        Me.NumEventsLabel.Location = New System.Drawing.Point(50, 510)
        Me.NumEventsLabel.Name = "NumEventsLabel"
        Me.NumEventsLabel.Size = New System.Drawing.Size(16, 17)
        Me.NumEventsLabel.TabIndex = 7
        Me.NumEventsLabel.Text = "0"
        '
        'MonitorClipCheck
        '
        Me.MonitorClipCheck.AutoSize = True
        Me.MonitorClipCheck.Location = New System.Drawing.Point(644, 60)
        Me.MonitorClipCheck.Name = "MonitorClipCheck"
        Me.MonitorClipCheck.Size = New System.Drawing.Size(139, 21)
        Me.MonitorClipCheck.TabIndex = 8
        Me.MonitorClipCheck.Text = "Monitor clipboard"
        Me.MonitorClipCheck.UseVisualStyleBackColor = True
        '
        'MonitorKeyCheck
        '
        Me.MonitorKeyCheck.AutoSize = True
        Me.MonitorKeyCheck.Location = New System.Drawing.Point(644, 30)
        Me.MonitorKeyCheck.Name = "MonitorKeyCheck"
        Me.MonitorKeyCheck.Size = New System.Drawing.Size(149, 21)
        Me.MonitorKeyCheck.TabIndex = 9
        Me.MonitorKeyCheck.Text = "Monitor keystrokes"
        Me.MonitorKeyCheck.UseVisualStyleBackColor = True
        '
        'MonitorMouseCheck
        '
        Me.MonitorMouseCheck.AutoSize = True
        Me.MonitorMouseCheck.Location = New System.Drawing.Point(500, 30)
        Me.MonitorMouseCheck.Name = "MonitorMouseCheck"
        Me.MonitorMouseCheck.Size = New System.Drawing.Size(123, 21)
        Me.MonitorMouseCheck.TabIndex = 10
        Me.MonitorMouseCheck.Text = "Monitor mouse"
        Me.MonitorMouseCheck.UseVisualStyleBackColor = True
        '
        'WriteOnFileCheck
        '
        Me.WriteOnFileCheck.AutoSize = True
        Me.WriteOnFileCheck.Location = New System.Drawing.Point(10, 60)
        Me.WriteOnFileCheck.Name = "WriteOnFileCheck"
        Me.WriteOnFileCheck.Size = New System.Drawing.Size(105, 21)
        Me.WriteOnFileCheck.TabIndex = 11
        Me.WriteOnFileCheck.Text = "Write on file"
        Me.WriteOnFileCheck.UseVisualStyleBackColor = True
        '
        'UnwrapCheck
        '
        Me.UnwrapCheck.AutoSize = True
        Me.UnwrapCheck.Location = New System.Drawing.Point(154, 60)
        Me.UnwrapCheck.Name = "UnwrapCheck"
        Me.UnwrapCheck.Size = New System.Drawing.Size(104, 21)
        Me.UnwrapCheck.TabIndex = 12
        Me.UnwrapCheck.Text = "Unwrap text"
        Me.UnwrapCheck.UseVisualStyleBackColor = True
        '
        'EventsMonitorForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(800, 590)
        Me.Controls.Add(Me.UnwrapCheck)
        Me.Controls.Add(Me.WriteOnFileCheck)
        Me.Controls.Add(Me.MonitorMouseCheck)
        Me.Controls.Add(Me.MonitorKeyCheck)
        Me.Controls.Add(Me.MonitorClipCheck)
        Me.Controls.Add(Me.NumEventsLabel)
        Me.Controls.Add(Me.EventsLabel)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.MonitorDirCheck)
        Me.Controls.Add(Me.ToolBar)
        Me.Controls.Add(Me.DirText)
        Me.Controls.Add(Me.DirLabel)
        Me.Controls.Add(Me.TableGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "EventsMonitorForm"
        Me.ShowIcon = False
        Me.Text = "Events Monitor"
        CType(Me.FileSystemListener, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenu.ResumeLayout(False)
        Me.ToolBar.ResumeLayout(False)
        Me.ToolBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents FileSystemListener As IO.FileSystemWatcher
    Friend WithEvents TableGrid As DataGridView
    Friend WithEvents DirLabel As Label
    Friend WithEvents DirText As TextBox
    Friend WithEvents ToolBar As ToolStrip
    Friend WithEvents SaveLabel As ToolStripLabel
    Friend WithEvents MonitorDirCheck As CheckBox
    Friend WithEvents TimestampColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClearButton As Button
    Friend WithEvents SaveDialog As SaveFileDialog
    Friend WithEvents EventsLabel As Label
    Friend WithEvents NumEventsLabel As Label
    Friend WithEvents InfoLabel As ToolStripLabel
    Friend WithEvents MonitorClipCheck As CheckBox
    Friend WithEvents MonitorKeyCheck As CheckBox
    Friend WithEvents MonitorMouseCheck As CheckBox
    Friend WithEvents ContextMenu As ContextMenuStrip
    Friend WithEvents CopyMenuItem As ToolStripMenuItem
    Friend WithEvents ClearMenuItem As ToolStripMenuItem
    Friend WithEvents WriteOnFileCheck As CheckBox
    Friend WithEvents UnwrapCheck As CheckBox

End Class
