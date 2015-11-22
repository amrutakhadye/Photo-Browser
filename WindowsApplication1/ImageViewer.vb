'Author Name     : Amruta Khadye
'Course Name     : CS 552-D- Windows Interface Design in Visual Basic
'Date of Project : 6/10/2015
'Assignment Name : Project 6 - Photo Browser
'Description     : This class is used to display images. The user can perform various actions on the image, such as save it, 
'                   browser the next image and the previous image. And view the logs

Public Class ImageViewer

     'currentFileExt variable is assigned the extension of the current File later
     Public currentFileExt As String

     'Description: This method is called when the User Control loads
     Private Sub ImageViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
          'On load the Next and Previous buttons back Color is set to transparent.
          BtnNext.BackColor = Drawing.Color.Transparent
          BtnPrevious.BackColor = Drawing.Color.Transparent
          'On load the Next and Previous buttons fore Color is set to transparent.
          BtnNext.ForeColor = Drawing.Color.Transparent
          BtnPrevious.ForeColor = Drawing.Color.Transparent
          'PictureBox is the parent of Next and Previous buttons.
          BtnNext.Parent = PictureBox1
          BtnPrevious.Parent = PictureBox1
          'sets button text to blank when the button is loaded
          BtnPrevious.Text = ""
          BtnNext.Text = ""
     End Sub

     'CurrentImage is a property.It is set when any current image is loaded
     Private CurrentImageValue As String
     Public Property CurrentImage As String
          Get
               Return CurrentImageValue
          End Get
          Set(value As String)
               CurrentImageValue = value
               'The ImageList is iterated on the basis of the index of the currentImage 
               Dim index As Integer = ImageList.IndexOf(CurrentImage)
               enableButtons(index)
               'Displays the FileName.
               Label1.Text = "File Name: " + value
          End Set
     End Property

     'Description: This method enables and disables the Next an previous Buttons.
     Private Sub enableButtons(index As Integer)
          'Initially both the images are enabled and set to true.
          BtnNext.Enabled = True
          BtnPrevious.Enabled = True

          If index = 0 Then
               'Checks if the image is the first image and so there are no previous images.
               'So the previous , PreviousImageToolStripMenuItem and ContextMenuPrevious button is disabled.
               BtnPrevious.Enabled = False
               PreviousImageToolStripMenuItem.Enabled = False
               ContextMenuPrevious.Enabled = False
               If ImageList.Count = 1 Then
                    'Checks if list contains only one image and so there are no next and previous images.
                    'So BtnNext, NextImageToolStripMenuItem , ContextMenuNext button is disabled
                    BtnNext.Enabled = False
                    NextImageToolStripMenuItem.Enabled = False
                    ContextMenuNext.Enabled = False
               End If
          ElseIf index >= ImageList.Count - 1 Then
               'Checks if the image is the last image in the list
               'if its last image, the next button is disabled
               BtnNext.Enabled = False
               NextImageToolStripMenuItem.Enabled = False
               ContextMenuNext.Enabled = False
          Else
               'Checks if there are images after and before the image.
               'So the previous , PreviousImageToolStripMenuItem and ContextMenuPrevious button is enabled.
               'and BtnNext, NextImageToolStripMenuItem , ContextMenuNext button is enabled.
               BtnNext.Enabled = True
               NextImageToolStripMenuItem.Enabled = True
               ContextMenuNext.Enabled = True
               BtnPrevious.Enabled = True
               PreviousImageToolStripMenuItem.Enabled = True
               ContextMenuPrevious.Enabled = True
          End If
     End Sub

     'Description: The imageList is set from the Main form.It contains list of all fileNames which are to be displayed.
     Private ImageListValue As New List(Of String)
     Public Property ImageList As List(Of String)
          Get
               Return ImageListValue
          End Get
          Set(value As List(Of String))
               ImageListValue = value
               'Display the first item in the list
               CurrentImage = ImageListValue(0)
               LogForm.log("Image Displayed : " + CurrentImage)
               'The first image is displayed.
               PictureBox1.Image = Image.FromFile(ImageListValue(0))
               getExtension(CurrentImage)
          End Set
     End Property

     'Description: This method is a default constructor
     Public Sub New()
          InitializeComponent()
     End Sub

     'Description: This method sets the extension of the file.
     Private Sub getExtension(value As String)
          'The last index of the . is obtained.
          Dim dotPosition As Integer = value.LastIndexOf(".")
          'The file name is substring from the index obtained till the end to obtain the extension of the file.
          currentFileExt = value.Substring(dotPosition + 1)
          'The extension is displayed.
          MessageBox.Show(currentFileExt)
     End Sub

     'Description: This method is called when the user clicks the next button,
     'the NextImageToolStripMenuItem button and the ContextMenuNext button.
     Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click, NextImageToolStripMenuItem.Click, ContextMenuNext.Click
          'The index of the image is obtained from the imageList
          Dim index As Integer = ImageList.IndexOf(CurrentImage)
          'It is checked if the index is less then the total no of images in the files.
          'If there are more images in the list after the currentImage, then only the next button is enabled.
          'and next image is displayed.
          If index < ImageList.Count - 1 Then
               'Index is increased by one to show the next image
               index += 1
               'The currentImage is retrived from the list
               CurrentImage = ImageList(index)

               Try
                    'If there is any problem in displaying the image, and an exception is thrown,
                    'The user sees the next image and does not see any error message or image.
                    PictureBox1.Image = Image.FromFile(CurrentImage)
                    getExtension(CurrentImageValue)
                    LogForm.log("Image Displayed : " + CurrentImage)
               Catch ex As Exception
                    LogForm.log("Error in Image display: Image not Displayed")
                    'NextButton click event is performed 
                    BtnNext.PerformClick()
               End Try
          End If
     End Sub

     'Description: This method is called when the user clicks the previous button,
     'the PreviousImageToolStripMenuItem button and the ContextMenuPrevious button.
     Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click, PreviousImageToolStripMenuItem.Click, ContextMenuPrevious.Click
          'The index of the image is obtained from the imageList
          Dim index As Integer = ImageList.IndexOf(CurrentImage)
          'It is checked if the index is zero i.e. its the first image displayed. In which case there are no previous images before first image.
          'If there are more images in the list before the currentImage, then the previous button is enabled.
          'and previous image is displayed.

          If Not index = 0 Then
               'Index is decreased by one to show the previous image
               index -= 1
               'The currentImage is retrived from the list
               CurrentImage = ImageList(index)
               Try
                    'If there is any problem in displaying the image, and an exception is thrown,
                    'The user sees the previous image and does not see any error message or image.
                    PictureBox1.Image = Image.FromFile(CurrentImage)
                    getExtension(CurrentImageValue)
                    LogForm.log("Image Displayed : " + CurrentImage)
               Catch ex As Exception
                    LogForm.log("Error in Image display: Image not Displayed ")
                    'BtnPrevious click event is performed 
                    BtnPrevious.PerformClick()
               End Try
          End If
     End Sub

     'Description: This method is called when the mouse is hover over the pictureBox
     Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
          'The next and previous button foreColor is set to black from transparent
          BtnNext.ForeColor = Color.Black
          BtnPrevious.ForeColor = Color.Black
          'The next and previous button text is set to "<<" and ">>" from ""
          BtnPrevious.Text = "<<"
          BtnNext.Text = ">>"
     End Sub

     'Description: This method is called when the mouse leaves the pictureBox
     Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
          'The next and previous button foreColor is set to transparent from black
          BtnNext.ForeColor = Drawing.Color.Transparent
          BtnPrevious.ForeColor = Drawing.Color.Transparent
          'The next and previous button text is set from "<<" and ">>" to ""
          BtnPrevious.Text = ""
          BtnNext.Text = ""
     End Sub

     'Description: This method is called when the user clicks on the SaveToolStripMenuItem and ContextMenuSaveAs button
     Public Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click, ContextMenuSaveAs.Click
          SaveFile()
     End Sub

     'Description: This method is called when the user clicks on the SaveToolStripMenuItem and ContextMenuSaveAs button
     Private Sub SaveFile()
          'Checks if the image extension is "jpg","bmp","gif" or "png"
          'Based on that it sets the filterIndex , which is as a drop down in the SaveFileDialog box
          If currentFileExt.ToLower = "jpge" Or currentFileExt.ToLower = "jpg" Then
               SaveFileDialog1.FilterIndex = 1
          ElseIf currentFileExt.ToLower = "bmp" Then
               SaveFileDialog1.FilterIndex = 2
          ElseIf currentFileExt.ToLower = "gif" Then
               SaveFileDialog1.FilterIndex = 3
          ElseIf currentFileExt.ToLower = "png" Then
               SaveFileDialog1.FilterIndex = 4
          End If
          If SaveFileDialog1.ShowDialog = DialogResult.OK Then 'If the user presses "Ok" button on the SaveFileDialog
               'Copies the file form the current image to next location
               IO.File.Copy(CurrentImage, SaveFileDialog1.FileName, True)
               LogForm.log("File Saved Source : " + CurrentImage)
               LogForm.log("File Saved Destination:" + SaveFileDialog1.FileName)
          Else
               Exit Sub
          End If
     End Sub

     'Description: This method is called when the user clicks in the close button.
     Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
          MainForm.Close()
     End Sub

     'Description: This method is called when the user clicks in the Open button whic is present on the Main Form.
     Private Sub OpenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem1.Click
          MainForm.BtnOpen.PerformClick()
     End Sub

     'Description: This method is called when the user clicks in the View Logs button.
     Private Sub ViewLogsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewLogsToolStripMenuItem.Click, ContextMenuOpenLogs.Click
          LogForm.ShowDialog()
     End Sub

     'Description: This method is called when the user hovers the mouse on the next button
     Private Sub BtnNext_MouseHover(sender As Object, e As EventArgs) Handles BtnNext.MouseHover
          'The next button foreColor is set to black from transparent and text is set to ">>" from ""
          BtnNext.ForeColor = Color.Black
          BtnNext.Text = ">>"
     End Sub

     'Description: This method is called when the user hovers the mouse on the next button
     Private Sub BtnPrevious_MouseHover(sender As Object, e As EventArgs) Handles BtnPrevious.MouseHover
          'The Previous button foreColor is set to black from transparent and text is set to "<<" from ""
          BtnPrevious.ForeColor = Color.Black
          BtnPrevious.Text = "<<"
     End Sub


End Class
