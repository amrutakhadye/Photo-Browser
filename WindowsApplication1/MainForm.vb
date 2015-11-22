'Author Name     : Amruta Khadye
'Course Name     : CS 552-D- Windows Interface Design in Visual Basic
'Date of Project : 6/10/2015
'Assignment Name : Project 6 - Photo Browser
'Description     : The project has a open button which is used to open folders and display pictures in the 
'                   window. The user can perform various actions on the image, such as save it, 
'                   browser the next image and the previous image. And view the logs

Public Class MainForm

     'imageViewObj is a object of the class ImageViewer
     Dim imageViewObj As New ImageViewer

     'Description: This method is called when the user clicks open button
     Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click
          OpenImage()
     End Sub

     'Description: This method from the BtnOpen_Click method
     Private Sub OpenImage()
          If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
               LogForm.log("Open Folder Button Clicked")
               imageViewObj.ImageList.Clear()
               Dim imageList As New List(Of String)
               'The files in the path selected on the Folder Browser Dialog Box  are iterated
               For Each s In Directory.GetFiles(FolderBrowserDialog1.SelectedPath)
                    'The extension of the fileName is comapared.
                    'If the extension endswith jpg, it is a JPGE image
                    'If the extension endswith bmp, it is a Bitmap image
                    'If the extension endswith gif, it is a gif image
                    'If the extension endswith png, it is a png image
                    'If the image has any of the above extensions, then it is added to the list
                    'Otherwise the file is skiped and not added to the list
                    If s.ToLower.EndsWith("jpg") Or s.ToLower.EndsWith("bmp") Or s.ToLower.EndsWith("gif") Or s.ToLower.EndsWith("png") Then
                         imageList.Add(s)
                    End If
               Next
               'if folder does not have any images, the list will have no images in it.
               'if the list is empty, then display error message to user.
               If imageList.Count = 0 Then
                    MessageBox.Show("No Images Found. Please select another Folder")
                    FolderBrowserDialog1.ShowDialog()
               Else
                    'If the ImageList has images in it.
                    LogForm.log("Folder Path : " + FolderBrowserDialog1.SelectedPath)
                    imageViewObj.ImageList = imageList
                    'The imageViewer object's anchor is set. 
                    'So when the size of the panel changes the imageViews size also changes
                    imageViewObj.Anchor = AnchorStyles.Bottom And AnchorStyles.Left And AnchorStyles.Right And AnchorStyles.Top
                    imageViewObj.Dock = DockStyle.Fill
                    Panel1.Controls.Add(imageViewObj)
                    'The Save and Log buttons are enabled when the Image from the imageViewer is displayed.
                    BtnSave.Visible = True
                    BtnLogs.Visible = True
                    'This is a handler which calls the method maximedWindow when the user double clicks the pictureBox
                    AddHandler imageViewObj.PictureBox1.DoubleClick, AddressOf maximizedWindow
               End If
          End If
     End Sub

     'Description: This method is called when the close button is clicked.
     Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
          LogForm.log("Application Closed")
          Me.Close()
     End Sub

     'Description: This method is called when the user double clicks on the pictureBox
     Private Sub maximizedWindow()
          'It is checked if the window is in the normal state or is maximized
          If Me.WindowState = FormWindowState.Normal Then
               'If the window is in the normal state, the window is maximized
               Me.WindowState = FormWindowState.Maximized
          Else
               'If the window is in the maximized state, the window is brought back to normal size
               Me.WindowState = FormWindowState.Normal
          End If
     End Sub

     'Description: This method is called when the Main form loads.
     Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
          LogForm.log("Application Open")
          'The Save button and View log button will also appear when the imageViewer has images.
          BtnSave.Visible = False
          BtnLogs.Visible = False
     End Sub

     'Description: This method is called when the Save button is clicked.
     Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
          'the ImageViewer method SaveToolStripMenuItem is called by performing the click through which the action is performed
          imageViewObj.SaveToolStripMenuItem.PerformClick()
     End Sub

     'Description: This method is called when the View Log method is called.
     Private Sub BtnLogs_Click(sender As Object, e As EventArgs) Handles BtnLogs.Click
          LogForm.ShowDialog()
     End Sub
End Class