<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageViewer
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
          Me.Label1 = New System.Windows.Forms.Label()
          Me.BtnPrevious = New System.Windows.Forms.Button()
          Me.BtnNext = New System.Windows.Forms.Button()
          Me.PictureBox1 = New System.Windows.Forms.PictureBox()
          Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
          Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
          Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
          Me.OpenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
          Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
          Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
          Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
          Me.NextImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
          Me.PreviousImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
          Me.ViewLogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
          Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
          Me.ContextMenuNext = New System.Windows.Forms.ToolStripMenuItem()
          Me.ContextMenuPrevious = New System.Windows.Forms.ToolStripMenuItem()
          Me.ContextMenuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
          Me.ContextMenuOpenLogs = New System.Windows.Forms.ToolStripMenuItem()
          CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
          Me.MenuStrip1.SuspendLayout()
          Me.ContextMenuStrip1.SuspendLayout()
          Me.SuspendLayout()
          '
          'Label1
          '
          Me.Label1.AutoSize = True
          Me.Label1.Location = New System.Drawing.Point(25, 45)
          Me.Label1.Name = "Label1"
          Me.Label1.Size = New System.Drawing.Size(75, 17)
          Me.Label1.TabIndex = 4
          Me.Label1.Text = "FileName: "
          '
          'BtnPrevious
          '
          Me.BtnPrevious.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
          Me.BtnPrevious.BackColor = System.Drawing.Color.Transparent
          Me.BtnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
          Me.BtnPrevious.FlatAppearance.BorderSize = 0
          Me.BtnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
          Me.BtnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
          Me.BtnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
          Me.BtnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
          Me.BtnPrevious.ForeColor = System.Drawing.Color.Black
          Me.BtnPrevious.Location = New System.Drawing.Point(30, 225)
          Me.BtnPrevious.Name = "BtnPrevious"
          Me.BtnPrevious.Size = New System.Drawing.Size(75, 51)
          Me.BtnPrevious.TabIndex = 6
          Me.BtnPrevious.Text = "<"
          Me.BtnPrevious.UseVisualStyleBackColor = False
          '
          'BtnNext
          '
          Me.BtnNext.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
          Me.BtnNext.BackColor = System.Drawing.Color.Transparent
          Me.BtnNext.FlatAppearance.BorderSize = 0
          Me.BtnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
          Me.BtnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
          Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
          Me.BtnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
          Me.BtnNext.ForeColor = System.Drawing.Color.Black
          Me.BtnNext.Location = New System.Drawing.Point(800, 225)
          Me.BtnNext.Name = "BtnNext"
          Me.BtnNext.Size = New System.Drawing.Size(81, 51)
          Me.BtnNext.TabIndex = 7
          Me.BtnNext.Text = ">"
          Me.BtnNext.UseVisualStyleBackColor = True
          '
          'PictureBox1
          '
          Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
          Me.PictureBox1.Location = New System.Drawing.Point(28, 65)
          Me.PictureBox1.Name = "PictureBox1"
          Me.PictureBox1.Size = New System.Drawing.Size(892, 436)
          Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
          Me.PictureBox1.TabIndex = 8
          Me.PictureBox1.TabStop = False
          '
          'SaveFileDialog1
          '
          Me.SaveFileDialog1.Filter = "jpeg Image|*.jpg|bitmap Image|*.bmp|gif Image|*.gif|png Image|*.png"
          '
          'MenuStrip1
          '
          Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ViewToolStripMenuItem})
          Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
          Me.MenuStrip1.Name = "MenuStrip1"
          Me.MenuStrip1.Size = New System.Drawing.Size(978, 28)
          Me.MenuStrip1.TabIndex = 9
          Me.MenuStrip1.Text = "MenuStrip1"
          '
          'OpenToolStripMenuItem
          '
          Me.OpenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem1, Me.SaveToolStripMenuItem, Me.CloseToolStripMenuItem})
          Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
          Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
          Me.OpenToolStripMenuItem.Text = "&File"
          '
          'OpenToolStripMenuItem1
          '
          Me.OpenToolStripMenuItem1.Name = "OpenToolStripMenuItem1"
          Me.OpenToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
          Me.OpenToolStripMenuItem1.Size = New System.Drawing.Size(213, 24)
          Me.OpenToolStripMenuItem1.Text = "&Open Folder"
          '
          'SaveToolStripMenuItem
          '
          Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
          Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
          Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(213, 24)
          Me.SaveToolStripMenuItem.Text = "&Save"
          '
          'CloseToolStripMenuItem
          '
          Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
          Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
          Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(213, 24)
          Me.CloseToolStripMenuItem.Text = "&Close"
          '
          'ViewToolStripMenuItem
          '
          Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NextImageToolStripMenuItem, Me.PreviousImageToolStripMenuItem, Me.ViewLogsToolStripMenuItem})
          Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
          Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
          Me.ViewToolStripMenuItem.Text = "&View"
          '
          'NextImageToolStripMenuItem
          '
          Me.NextImageToolStripMenuItem.Name = "NextImageToolStripMenuItem"
          Me.NextImageToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Right), System.Windows.Forms.Keys)
          Me.NextImageToolStripMenuItem.Size = New System.Drawing.Size(246, 24)
          Me.NextImageToolStripMenuItem.Text = "&Next Image"
          '
          'PreviousImageToolStripMenuItem
          '
          Me.PreviousImageToolStripMenuItem.Name = "PreviousImageToolStripMenuItem"
          Me.PreviousImageToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Left), System.Windows.Forms.Keys)
          Me.PreviousImageToolStripMenuItem.Size = New System.Drawing.Size(246, 24)
          Me.PreviousImageToolStripMenuItem.Text = "&Previous Image"
          '
          'ViewLogsToolStripMenuItem
          '
          Me.ViewLogsToolStripMenuItem.Name = "ViewLogsToolStripMenuItem"
          Me.ViewLogsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
          Me.ViewLogsToolStripMenuItem.Size = New System.Drawing.Size(246, 24)
          Me.ViewLogsToolStripMenuItem.Text = "&View Logs"
          '
          'ContextMenuStrip1
          '
          Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContextMenuNext, Me.ContextMenuPrevious, Me.ContextMenuSaveAs, Me.ContextMenuOpenLogs})
          Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
          Me.ContextMenuStrip1.Size = New System.Drawing.Size(247, 100)
          '
          'ContextMenuNext
          '
          Me.ContextMenuNext.Name = "ContextMenuNext"
          Me.ContextMenuNext.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Right), System.Windows.Forms.Keys)
          Me.ContextMenuNext.Size = New System.Drawing.Size(246, 24)
          Me.ContextMenuNext.Text = "Next Image"
          '
          'ContextMenuPrevious
          '
          Me.ContextMenuPrevious.Name = "ContextMenuPrevious"
          Me.ContextMenuPrevious.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Left), System.Windows.Forms.Keys)
          Me.ContextMenuPrevious.Size = New System.Drawing.Size(246, 24)
          Me.ContextMenuPrevious.Text = "Previous Image"
          '
          'ContextMenuSaveAs
          '
          Me.ContextMenuSaveAs.Name = "ContextMenuSaveAs"
          Me.ContextMenuSaveAs.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
          Me.ContextMenuSaveAs.Size = New System.Drawing.Size(246, 24)
          Me.ContextMenuSaveAs.Text = "Save As."
          '
          'ContextMenuOpenLogs
          '
          Me.ContextMenuOpenLogs.Name = "ContextMenuOpenLogs"
          Me.ContextMenuOpenLogs.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
          Me.ContextMenuOpenLogs.Size = New System.Drawing.Size(246, 24)
          Me.ContextMenuOpenLogs.Text = "View Logs"
          '
          'ImageViewer
          '
          Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
          Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
          Me.AutoSize = True
          Me.BackColor = System.Drawing.Color.Transparent
          Me.ContextMenuStrip = Me.ContextMenuStrip1
          Me.Controls.Add(Me.PictureBox1)
          Me.Controls.Add(Me.BtnNext)
          Me.Controls.Add(Me.BtnPrevious)
          Me.Controls.Add(Me.Label1)
          Me.Controls.Add(Me.MenuStrip1)
          Me.Name = "ImageViewer"
          Me.Size = New System.Drawing.Size(978, 550)
          CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
          Me.MenuStrip1.ResumeLayout(False)
          Me.MenuStrip1.PerformLayout()
          Me.ContextMenuStrip1.ResumeLayout(False)
          Me.ResumeLayout(False)
          Me.PerformLayout()

     End Sub
     Friend WithEvents Label1 As System.Windows.Forms.Label
     Friend WithEvents BtnPrevious As System.Windows.Forms.Button
     Friend WithEvents BtnNext As System.Windows.Forms.Button
     Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
     Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
     Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
     Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
     Friend WithEvents OpenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
     Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
     Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
     Friend WithEvents NextImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
     Friend WithEvents PreviousImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
     Friend WithEvents ViewLogsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
     Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
     Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
     Friend WithEvents ContextMenuNext As System.Windows.Forms.ToolStripMenuItem
     Friend WithEvents ContextMenuPrevious As System.Windows.Forms.ToolStripMenuItem
     Friend WithEvents ContextMenuSaveAs As System.Windows.Forms.ToolStripMenuItem
     Friend WithEvents ContextMenuOpenLogs As System.Windows.Forms.ToolStripMenuItem

End Class
