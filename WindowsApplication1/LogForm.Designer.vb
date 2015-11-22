<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogForm
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
          Me.logTxt = New System.Windows.Forms.TextBox()
          Me.BtnClose = New System.Windows.Forms.Button()
          Me.SuspendLayout()
          '
          'logTxt
          '
          Me.logTxt.Location = New System.Drawing.Point(12, 41)
          Me.logTxt.Multiline = True
          Me.logTxt.Name = "logTxt"
          Me.logTxt.ReadOnly = True
          Me.logTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both
          Me.logTxt.Size = New System.Drawing.Size(762, 591)
          Me.logTxt.TabIndex = 0
          '
          'BtnClose
          '
          Me.BtnClose.Location = New System.Drawing.Point(337, 669)
          Me.BtnClose.Name = "BtnClose"
          Me.BtnClose.Size = New System.Drawing.Size(75, 23)
          Me.BtnClose.TabIndex = 1
          Me.BtnClose.Text = "Close"
          Me.BtnClose.UseVisualStyleBackColor = True
          '
          'LogForm
          '
          Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
          Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
          Me.ClientSize = New System.Drawing.Size(794, 750)
          Me.Controls.Add(Me.BtnClose)
          Me.Controls.Add(Me.logTxt)
          Me.Name = "LogForm"
          Me.Text = "LogsForm"
          Me.ResumeLayout(False)
          Me.PerformLayout()

     End Sub
     Friend WithEvents logTxt As System.Windows.Forms.TextBox
     Friend WithEvents BtnClose As System.Windows.Forms.Button
End Class
