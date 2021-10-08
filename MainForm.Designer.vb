<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.FileSystemWatcher = New System.IO.FileSystemWatcher()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.DateColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirLabel = New System.Windows.Forms.Label()
        Me.DirText = New System.Windows.Forms.TextBox()
        Me.ToolBar = New System.Windows.Forms.ToolStrip()
        Me.SaveLabel = New System.Windows.Forms.ToolStripLabel()
        Me.InfoLabel = New System.Windows.Forms.ToolStripLabel()
        Me.MonitorDirCheck = New System.Windows.Forms.CheckBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.EventsLabel = New System.Windows.Forms.Label()
        Me.NumEventsLabel = New System.Windows.Forms.Label()
        Me.MonitorClipCheck = New System.Windows.Forms.CheckBox()
        Me.MonitorKeyCheck = New System.Windows.Forms.CheckBox()
        Me.MonitorMouseCheck = New System.Windows.Forms.CheckBox()
        CType(Me.FileSystemWatcher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileSystemWatcher
        '
        Me.FileSystemWatcher.EnableRaisingEvents = True
        Me.FileSystemWatcher.IncludeSubdirectories = True
        Me.FileSystemWatcher.NotifyFilter = CType((((((((System.IO.NotifyFilters.FileName Or System.IO.NotifyFilters.DirectoryName) _
            Or System.IO.NotifyFilters.Attributes) _
            Or System.IO.NotifyFilters.Size) _
            Or System.IO.NotifyFilters.LastWrite) _
            Or System.IO.NotifyFilters.LastAccess) _
            Or System.IO.NotifyFilters.CreationTime) _
            Or System.IO.NotifyFilters.Security), System.IO.NotifyFilters)
        Me.FileSystemWatcher.SynchronizingObject = Me
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AllowUserToResizeRows = False
        Me.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGridView.ColumnHeadersHeight = 29
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateColumn, Me.DescColumn})
        Me.DataGridView.Location = New System.Drawing.Point(7, 93)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.RowHeadersWidth = 51
        Me.DataGridView.RowTemplate.Height = 24
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(673, 380)
        Me.DataGridView.TabIndex = 0
        '
        'DateColumn
        '
        Me.DateColumn.FillWeight = 50.69519!
        Me.DateColumn.HeaderText = "Date"
        Me.DateColumn.MaxInputLength = 100
        Me.DateColumn.MinimumWidth = 10
        Me.DateColumn.Name = "DateColumn"
        Me.DateColumn.ReadOnly = True
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
        'DirLabel
        '
        Me.DirLabel.AutoSize = True
        Me.DirLabel.Location = New System.Drawing.Point(5, 35)
        Me.DirLabel.Name = "DirLabel"
        Me.DirLabel.Size = New System.Drawing.Size(136, 17)
        Me.DirLabel.TabIndex = 1
        Me.DirLabel.Text = "Directory to monitor:"
        '
        'DirText
        '
        Me.DirText.Location = New System.Drawing.Point(138, 32)
        Me.DirText.MaxLength = 1000000
        Me.DirText.Name = "DirText"
        Me.DirText.Size = New System.Drawing.Size(356, 22)
        Me.DirText.TabIndex = 2
        Me.DirText.WordWrap = False
        '
        'ToolBar
        '
        Me.ToolBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveLabel, Me.InfoLabel})
        Me.ToolBar.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.Size = New System.Drawing.Size(692, 25)
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
        Me.MonitorDirCheck.Location = New System.Drawing.Point(308, 66)
        Me.MonitorDirCheck.Name = "MonitorDirCheck"
        Me.MonitorDirCheck.Size = New System.Drawing.Size(136, 21)
        Me.MonitorDirCheck.TabIndex = 4
        Me.MonitorDirCheck.Text = "Monitor directory"
        Me.MonitorDirCheck.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(7, 516)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(118, 23)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.DefaultExt = "txt"
        Me.SaveFileDialog.FileName = "data.txt"
        '
        'EventsLabel
        '
        Me.EventsLabel.AutoSize = True
        Me.EventsLabel.Location = New System.Drawing.Point(5, 487)
        Me.EventsLabel.Name = "EventsLabel"
        Me.EventsLabel.Size = New System.Drawing.Size(55, 17)
        Me.EventsLabel.TabIndex = 6
        Me.EventsLabel.Text = "Events:"
        '
        'NumEventsLabel
        '
        Me.NumEventsLabel.AutoSize = True
        Me.NumEventsLabel.Location = New System.Drawing.Point(57, 487)
        Me.NumEventsLabel.Name = "NumEventsLabel"
        Me.NumEventsLabel.Size = New System.Drawing.Size(16, 17)
        Me.NumEventsLabel.TabIndex = 7
        Me.NumEventsLabel.Text = "0"
        '
        'MonitorClipCheck
        '
        Me.MonitorClipCheck.AutoSize = True
        Me.MonitorClipCheck.Location = New System.Drawing.Point(8, 66)
        Me.MonitorClipCheck.Name = "MonitorClipCheck"
        Me.MonitorClipCheck.Size = New System.Drawing.Size(139, 21)
        Me.MonitorClipCheck.TabIndex = 8
        Me.MonitorClipCheck.Text = "Monitor clipboard"
        Me.MonitorClipCheck.UseVisualStyleBackColor = True
        '
        'MonitorKeyCheck
        '
        Me.MonitorKeyCheck.AutoSize = True
        Me.MonitorKeyCheck.Location = New System.Drawing.Point(153, 66)
        Me.MonitorKeyCheck.Name = "MonitorKeyCheck"
        Me.MonitorKeyCheck.Size = New System.Drawing.Size(149, 21)
        Me.MonitorKeyCheck.TabIndex = 9
        Me.MonitorKeyCheck.Text = "Monitor keystrokes"
        Me.MonitorKeyCheck.UseVisualStyleBackColor = True
        '
        'MonitorMouseCheck
        '
        Me.MonitorMouseCheck.AutoSize = True
        Me.MonitorMouseCheck.Location = New System.Drawing.Point(450, 66)
        Me.MonitorMouseCheck.Name = "MonitorMouseCheck"
        Me.MonitorMouseCheck.Size = New System.Drawing.Size(123, 21)
        Me.MonitorMouseCheck.TabIndex = 10
        Me.MonitorMouseCheck.Text = "Monitor mouse"
        Me.MonitorMouseCheck.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 551)
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
        Me.Controls.Add(Me.DataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Events Monitor"
        CType(Me.FileSystemWatcher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolBar.ResumeLayout(False)
        Me.ToolBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FileSystemWatcher As IO.FileSystemWatcher
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents DirLabel As Label
    Friend WithEvents DirText As TextBox
    Friend WithEvents ToolBar As ToolStrip
    Friend WithEvents SaveLabel As ToolStripLabel
    Friend WithEvents MonitorDirCheck As CheckBox
    Friend WithEvents DateColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClearButton As Button
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents EventsLabel As Label
    Friend WithEvents NumEventsLabel As Label
    Friend WithEvents InfoLabel As ToolStripLabel
    Friend WithEvents MonitorClipCheck As CheckBox
    Friend WithEvents MonitorKeyCheck As CheckBox
    Friend WithEvents MonitorMouseCheck As CheckBox
End Class