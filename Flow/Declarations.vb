Imports System.Drawing
Public Module Declarations

    'This file contains the Declarations needed in the running of the DLL File

    Public Structure OverallScore
        'Stores an Overall Highscore for a Grid
        Dim Played As Short 'Number of games played
        Dim Wins As Short 'Number of Wins
        Dim Lowest As Short 'Lowest Number of moves made 
    End Structure

    Public Structure Colours 'Structure to store the 6 Colours of a Palette
        Dim C1 As Color
        Dim C2 As Color
        Dim C3 As Color
        Dim C4 As Color
        Dim C5 As Color
        Dim C6 As Color
    End Structure

    Public Structure SavedColours
        Dim C1 As Integer
        Dim C2 As Integer
        Dim C3 As Integer
        Dim C4 As Integer
        Dim C5 As Integer
        Dim C6 As Integer
    End Structure

    Public Structure Palette 'Structure used to store the required palette to file
        <VBFixedString(10)> Dim Name As String
        Dim Colour As Colours
    End Structure

    Public Structure SavedPalette
        <VBFixedString(10)> Dim Name As String
        Dim Colour As SavedColours
    End Structure


    'Filenames of the HS files are stored here
    Public OHS As String = CurDir() & "\Content\OHS"       'Overall Highscores

    Public PLoc As String = CurDir() & "\Content\P"       'Location of Palette files

End Module