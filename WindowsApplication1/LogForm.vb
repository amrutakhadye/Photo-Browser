'Author Name     : Amruta Khadye
'Course Name     : CS 552-D- Windows Interface Design in Visual Basic
'Date of Project : 6/10/2015
'Assignment Name : Project 6 - Photo Browser
'Description     : This Class is used to generate the log files

Public Class LogForm
     'Sets the file Path in the temp file.
     Dim FilePath As String = Path.GetTempPath() + "Project6Log.txt"

     'Description: This method logs all the activites and is called from through out the application to maintain logs.
     Public Sub log(fileContent As String)
          Dim sw As IO.StreamWriter
          'Checks if the file already exists.
          If Not File.Exists(FilePath) Then
               'if it does not exists, Create a file to write to logs. 
               sw = File.CreateText(FilePath)
          End If
          sw = File.AppendText(FilePath)
          'The date and time stamp of the activity is logged along with the file content
          sw.WriteLine(DateTime.Now.ToLongDateString() + vbTab + DateTime.Now.ToLongTimeString() + " - " + fileContent)
          sw.Close()
     End Sub

     'Description: This method is called when the user loads the LogForm form.
     Private Sub LogForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

          logTxt.Clear()
          logTxt.ScrollBars = ScrollBars.Vertical
          Dim sr As New IO.StreamReader(FilePath)
          'Reads the file till the end of stream
          While Not sr.EndOfStream
               'Reads each line and adds a carriage character later.
               Dim s As String = sr.ReadLine
               logTxt.Text &= s & vbCrLf
          End While
          sr.Close()
     End Sub

     'Description: This method is called when the close button is clicked.
     Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
          Me.Close()
     End Sub
End Class