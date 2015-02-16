Public Class FrmWin

    'Properties of the form that can be set before it can be shown with the correct information
    Public Property Win As Boolean
    Public Property Steps As Short
    Public Property Mode As String
    Public Property Free As Boolean
    Public Property ProperClose As Boolean = True

    Private Sub FrmWin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim FileNo As Short = 0 'Used so it will load the correct lowest number of moved to be shown

        Select Case Mode 'Checks what type of game mode and will set the record number to the correct one
            Case "Game: Easy" : FileNo = 1
            Case "Game: Medium" : FileNo = 2
            Case "Game: Large" : FileNo = 3
            Case "Game: Very Large" : FileNo = 4
        End Select

        lblMode.Text = Mode 'Adds mode to the form

        If Free = True Then : lblSteps.Text = "Steps: ∞" 'Displays the correct number of steps
        Else : lblSteps.Text = "Steps: " & Steps
            HS.SaveOverall(FileNo, Steps, Win) 'When in Challenge mode then the file is updated with the corrct infos
        End If

        If Win = True Then : lblWin.Text = "You Win!" 'Message is shown if you have won or lost depending
        Else : lblWin.Text = "You Lose!"
        End If

        Dim Overall() As OverallScore = LoadOverall() 'Loading in and displaying the correct number of the shortes moves
        lblShortest.Text = "Shortest: " & Overall(FileNo - 1).Lowest
    End Sub

    'Closed the form. When a newgame is clickeed a flag is unset so a new game will start
    Private Sub lblCloseWindow_Click(sender As System.Object, e As System.EventArgs) Handles lblCloseWindow.Click
        Me.Close()
    End Sub
    Private Sub lblClose_Click(sender As System.Object, e As System.EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub
    Private Sub lblNewGame_Click(sender As System.Object, e As System.EventArgs) Handles lblNewGame.Click
        ProperClose = False
        Me.Close()
    End Sub
End Class