Imports System.IO
Public Module HS

#Region "Saving"
    'Region for Subs dealing with the saving of High Score Data
    Private Sub CheckMoves(ByRef Board As OverallScore, ByVal Moves As Short)
        'This sub checks the lowest value of moves to see if it is indeed the lowest
        If Moves < Board.Lowest Then 'Checking to see if the lowest moves for that board is greater than the moves taken by the user.
            Board.Lowest = Moves 'If so then the Lowest value is set to the new lowest
        End If

    End Sub

    Public Sub SaveOverall(ByVal Board As Short, ByVal Moves As Short, ByVal Win As Boolean)
        'This sub will update the Overall Highscores file depending on the board that has been played

        Dim Score As New OverallScore 'Variable used to socre and write data to file.

        FileOpen(1, OHS, OpenMode.Random, , , Len(Score)) 'Opening the file

        FileGet(1, Score, Board) 'Reading in the current Board data

        CheckMoves(Score, Moves) 'Checking if this is the lowest number of moves

        Score.Played += 1   'Adds 1 to game total

        If Win = True Then : Score.Wins += 1 : End If 'If this is a win then win count is incremented

        FilePut(1, Score, Board)    'Writting to file

        FileClose(1) 'Closing the file

    End Sub

    Public Sub Reset(ByVal Board As Short, Optional ByVal Creation As Boolean = False)
        'This sub will reset the High Scores of the the board selected
        Dim response As Short


        'Checks if the player wants a complete reset of the scores, and if then then will reset them all
        If Board = 0 Then
            'Checking user does infact want to clear highscores
            If Creation = False Then
                response = MsgBox("Are you sure you wish to clear High Score data?", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo, "ColourFlow : Reset High Scores")
            End If
            If ((response = vbYes) Or (Creation = True)) Then 'If they do, then the score is reset

                For count As Integer = 1 To 4
                    Dim HS As New OverallScore

                    FileOpen(1, OHS, OpenMode.Random, , , Len(HS)) 'Opening file

                    HS.Played = 0 'Restting all values
                    HS.Wins = 0

                    Select Case count 'Adds the default number of moves per game
                        Case 1 : HS.Lowest = 27
                        Case 2 : HS.Lowest = 39
                        Case 3 : HS.Lowest = 51
                        Case 4 : HS.Lowest = 63
                    End Select

                    FilePut(1, HS, count) 'Writting to file

                    FileClose(1) 'Closing
                Next
            End If


        Else
            'Checking user does infact want to clear highscores
            response = MsgBox("Are you sure you wish to clear High Score data?", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo, "ColourFlow : Reset High Scores")

            If response = vbYes Then 'If they do, then the score is reset

                Dim HS As New OverallScore

                FileOpen(1, OHS, OpenMode.Random, , , Len(HS)) 'Opening file

                HS.Played = 0 'Restting all values
                HS.Wins = 0

                Select Case Board 'Adds the default number of moves pe rgame
                    Case 1 : HS.Lowest = 27
                    Case 2 : HS.Lowest = 39
                    Case 3 : HS.Lowest = 51
                    Case 4 : HS.Lowest = 63
                End Select

                FilePut(1, HS, Board) 'Writting to file

                FileClose(1) 'Closing

            End If

        End If

    End Sub

#End Region

#Region "Loading"

    Public Function LoadOverall() As OverallScore()
        'Sub deals with the loading of the Overall HighScores into the Game
        Dim Overall(4) As OverallScore 'Array to store all 4 overall scores
        Dim CurrentScore As New OverallScore 'Array to store current overall score that has been read in
        Dim index As Short = 1 'Used to load the files

        FileOpen(1, OHS, OpenMode.Random, , , Len(CurrentScore)) 'Opening the file

        For index = 1 To 4
            FileGet(1, Overall(index - 1), index)
        Next

        FileClose(1)

        Return Overall

    End Function

    Public Function CalculateTotals(ByVal Overall() As OverallScore) As Short()
        'This will calculate some of the overal stats that might be required on the Overall Form
        Dim Results(3) As Short 'The array that will be returned
        Dim index As Short = 0 'A simple counitng variable

        'Position 0 : Total Games
        Results(0) = 0 'Restting value

        For index = 0 To 4
            Results(0) += Overall(index).Played 'Counting the total number of games played
        Next

        'Position 1: Total Wins
        Results(1) = 0 'Restting value

        For index = 0 To 4
            Results(1) += Overall(index).Wins 'Counting to total number of wins
        Next

        'Position 2: Win/Loss Ratio
        If Results(0) = 0 Then : Results(2) = 0
        Else
            Results(2) = GetWinPercentage(Results(1), Results(0))
        End If

        Return Results
    End Function

    Public Function GetWinPercentage(ByVal wins As Short, ByVal games As Short) As Double
        'Works out the percentage of games won depending on how many games have been played
        Dim result As Double = 0

        If games = 0 Then : Return 0  'Makes sure not to divide by 0
        Else
            result = (wins / games) * 100

            result = Math.Round(result, 0)

            Return result
        End If
    End Function

    Public Sub CheckFile()
        'A small check that is performed on the main form to check if a file does exist. if not it wil create it as this prevents errors
        If (File.Exists(OHS)) Then
        Else
            Reset(0, True) 'Resetting all entire highscores
        End If
    End Sub

#End Region

End Module