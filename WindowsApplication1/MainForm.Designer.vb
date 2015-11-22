<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
          Me.Panel1 = New System.Windows.Forms.Panel()
          Me.BtnOpen = New System.Windows.Forms.Button()
          Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
          Me.CloseBtn = New System.Windows.Forms.Button()
          Me.BtnSave = New System.Windows.Forms.Button()
          Me.BtnLogs = New System.Windows.Forms.Button()
          Me.SuspendLayout()
          '
          'Panel1
          '
          Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
          Me.Panel1.Location = New System.Drawing.Point(40, 30)
          Me.Panel1.Name = "Panel1"
          Me.Panel1.Size = New System.Drawing.Size(800, 550)
          Me.Panel1.TabIndex = 0
          '
          'BtnOpen
          '
          Me.BtnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
          Me.BtnOpen.Location = New System.Drawing.Point(158, 605)
          Me.BtnOpen.Name = "BtnOpen"
          Me.BtnOpen.Size = New System.Drawing.Size(75, 36)
          Me.BtnOpen.TabIndex = 1
          Me.BtnOpen.Text = "Open..."
          Me.BtnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
          Me.BtnOpen.UseVisualStyleBackColor = True
          '
          'CloseBtn
          '
          Me.CloseBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
          Me.CloseBtn.Location = New System.Drawing.Point(632, 605)
          Me.CloseBtn.Name = "CloseBtn"
          Me.CloseBtn.Size = New System.Drawing.Size(92, 36)
          Me.CloseBtn.TabIndex = 2
          Me.CloseBtn.Text = "Close"
          Me.CloseBtn.UseVisualStyleBackColor = True
          '
          'BtnSave
          '
          Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
          Me.BtnSave.Location = New System.Drawing.Point(300, 605)
          Me.BtnSave.Name = "BtnSave"
          Me.BtnSave.Size = New System.Drawing.Size(75, 36)
          Me.BtnSave.TabIndex = 3
          Me.BtnSave.Text = "Save"
          Me.BtnSave.UseVisualStyleBackColor = True
          '
          'BtnLogs
          '
          Me.BtnLogs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
          Me.BtnLogs.Location = New System.Drawing.Point(451, 605)
          Me.BtnLogs.Name = "BtnLogs"
          Me.BtnLogs.Size = New System.Drawing.Size(102, 36)
          Me.BtnLogs.TabIndex = 4
          Me.BtnLogs.Text = "View Logs"
          Me.BtnLogs.UseVisualStyleBackColor = True
          '
          'MainForm
          '
          Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
          Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
          Me.ClientSize = New System.Drawing.Size(882, 653)
          Me.Controls.Add(Me.BtnLogs)
          Me.Controls.Add(Me.BtnSave)
          Me.Controls.Add(Me.CloseBtn)
          Me.Controls.Add(Me.BtnOpen)
          Me.Controls.Add(Me.Panel1)
          Me.Name = "MainForm"
          Me.Text = "Form1"
          Me.ResumeLayout(False)

     End Sub
     Friend WithEvents Panel1 As System.Windows.Forms.Panel
     Friend WithEvents BtnOpen As System.Windows.Forms.Button
     Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
     Friend WithEvents CloseBtn As System.Windows.Forms.Button
     Friend WithEvents BtnSave As System.Windows.Forms.Button
     Friend WithEvents BtnLogs As System.Windows.Forms.Button

End Class
