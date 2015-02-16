Imports System.Windows.Forms
Public Class FrmMode

    Property Mode As Integer = 0 'Property of the form that is changed and so can be read once the form has been closed.
    'Will setup a new game based on what has been defined here.

    Property Free As Boolean = False 'Property read to check if this is a free mode or not

    Dim Boxes(4) As PictureBox

#Region "GUI"

#Region "Mode Labels"
    'This is some simple GUI code that will deal with the displaying of some constant boxes next to labels are they are clicked
    Private Sub lbl1_MouseEnter(sender As Object, e As System.EventArgs) Handles lbl1.MouseEnter
        pbF.Visible = True
    End Sub
    Private Sub lbl2_MouseEnter(sender As Object, e As System.EventArgs) Handles lbl2.MouseEnter
        pbc.Visible = True
    End Sub
    Private Sub LableLeave(sender As Object, e As System.EventArgs) Handles lbl1.MouseLeave, lbl2.MouseLeave
        pbF.Visible = False
        pbc.Visible = False
    End Sub
#End Region

#Region "Mode GUI"
    'This area deals with displaying a coloured box next to a lable on the form
    Private Sub lblE_MouseEnter(sender As Object, e As System.EventArgs) Handles lblE.MouseEnter
        ChangeBox(Boxes, 0)
    End Sub
    Private Sub lblM_MouseEnter(sender As Object, e As System.EventArgs) Handles lblM.MouseEnter
        ChangeBox(Boxes, 1)
    End Sub
    Private Sub lblL_MouseEnter(sender As Object, e As System.EventArgs) Handles lblL.MouseEnter
        ChangeBox(Boxes, 2)
    End Sub
    Private Sub lblVL_MouseEnter(sender As Object, e As System.EventArgs) Handles lblVL.MouseEnter
        ChangeBox(Boxes, 3)
    End Sub

    Private Sub ChangeBox(ByRef boxes() As PictureBox, ByVal Num As Short)
        boxes(Num).Visible = True 'Sets the box required to visible
    End Sub

#End Region

    Private Sub LabelLeave(sender As Object, e As System.EventArgs) Handles lblE.MouseLeave, lblM.MouseLeave, lblL.MouseLeave, lblVL.MouseLeave
        'Will hide all the pictureboxes on the form
        Boxes(0).Visible = False
        Boxes(1).Visible = False
        Boxes(2).Visible = False
        Boxes(3).Visible = False
    End Sub

    Private Sub FrmMode_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'A check is performed to make sure they don't just close the window and then a warning is displayed if they are playing free mode
        If Free = True Then
            MsgBox("Please Note: In Free Mode your score will not be recorded and this will not count as a played game." & vbNewLine & "This is a Challenge Mode only feature!", MsgBoxStyle.Exclamation, "ColourFlow : Free Mode Warning")
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Adding the picture boxes to the variable
        Boxes(0) = pb1
        Boxes(1) = pb2
        Boxes(2) = pb3
        Boxes(3) = pb4
    End Sub

    Private Sub lblClose_Click(sender As System.Object, e As System.EventArgs) Handles lblClose.Click
        Free = False 'Telling form it was an exit, not the start of a game so the warning isn't shown then closes the form
        Me.Close()
    End Sub

#Region "Advanced GUI"
    'Here the various boxes and label changing is done for the Challenge and Free Mode Labels
    Private Sub lbl2_Click(sender As System.Object, e As System.EventArgs) Handles lbl2.Click
        If lbl2.Text = "Back" Then
            ChallengePannel.Visible = False
            pbFree.Visible = False
            lbl2.Text = "Challenge Mode"
        Else
            Free = False
            ChallengePannel.Visible = True
            PBChallenge.Visible = True
            lbl1.Text = "Back"
        End If

    End Sub
    Private Sub lbl1_Click(sender As System.Object, e As System.EventArgs) Handles lbl1.Click
        If PBChallenge.Visible = True Then
            PBChallenge.Visible = False
            ChallengePannel.Visible = False
            lbl1.Text = "Free Mode"
        Else
            Free = True
            ChallengePannel.Visible = True
            pbFree.Visible = True
            lbl2.Text = "Back"
        End If
    End Sub

#End Region

#Region "Board Type Clicks"
    'Here the correct mode is set and then the form will close starting a new game.
    Private Sub lblVL_Click(sender As System.Object, e As System.EventArgs) Handles lblVL.Click
        Mode = 4
        Me.Close()
    End Sub
    Private Sub lblL_Click(sender As System.Object, e As System.EventArgs) Handles lblL.Click
        Mode = 3
        Me.Close()
    End Sub
    Private Sub lblM_Click(sender As System.Object, e As System.EventArgs) Handles lblM.Click
        Mode = 2
        Me.Close()
    End Sub
    Private Sub lblE_Click(sender As System.Object, e As System.EventArgs) Handles lblE.Click
        Mode = 1
        Me.Close()
    End Sub

#End Region

#End Region

    Private Sub lblHelp_Click(sender As System.Object, e As System.EventArgs) Handles lblHelp.Click
        'Displays help to the user
        MsgBox("Free Mode: Free Mode allows users to play the game with no move limit" & vbNewLine & "Your score will not be saved!", MsgBoxStyle.Information, "ColourFlow : Help")
        MsgBox("Challenge Mode: Challenge mode means player has to complete the grid with a set number of moves." & vbNewLine & "You score will be saved!", MsgBoxStyle.Information, "ColourFlow : Help")
        MsgBox("There are 4 boards to choose from. Easy is the easist and Very Large being the hardest." & vbNewLine & "Select a Mode then a Board type from the window to start the game" & vbNewLine & vbNewLine & "Board Types:" & vbNewLine & "Easy : 20 moves" & vbNewLine & "Medium : 30 moves" & vbNewLine & "Large : 40 moves" & vbNewLine & "Very Large : 50 moves", MsgBoxStyle.Information, "ColourFlow : Help")
    End Sub
End Class