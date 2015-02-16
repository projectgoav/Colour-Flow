Imports System.Drawing
Public Module Palettes

#Region "Palette Functions"

    Public Function Load_Palette(ByVal ID As Short) As Palette
        'This sub reads in a saves Palette from file
        Dim NewPalette As New SavedPalette

        FileOpen(1, PLoc, OpenMode.Random, , , Len(NewPalette))

        FileGet(1, NewPalette, ID) 'Will read in the palette of the selected ID number (record number) 

        FileClose(1)

        Dim ReturnPath As Palette = Decode(NewPalette) 'Decodes the file format into a way the program understands it.

        Return ReturnPath
    End Function

    Public Sub Save_Palette(ByVal Palette As Palette)
        'This sub will save the select palette to file
        Dim ID As Short = GetRecord(Palette.Name)
        Dim Save As SavedPalette = Encode(Palette) 'Encodes the passed in palette into a format that csn be saved and loaded into the program as needed

        FileOpen(1, PLoc, OpenMode.Random, , , Len(Save))

        FilePut(1, Save, ID)

        FileClose(1)
    End Sub

    Public Sub DeleteRecord(ByVal Name As String)
        'This sub will delete a record from file and clear up the file so it's removed
        Dim Result As Integer = MsgBox("Do you wish to delete palette?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "ColourFlow : Delete")
        If Result = vbNo Then : Return : End If 'Check with user to make sure they wish to delete the palette

        Dim Total As Short = GetTotalRecords() 'Gets the number of records
        Dim Palette(Total) As SavedPalette
        Dim Current As New SavedPalette
        Dim count As Short = 1
        Dim found As Boolean = False
        Dim Nowrite As Boolean = False



        FileOpen(1, PLoc, OpenMode.Random, , , Len(Current))

        For count = 1 To Total
            FileGet(1, Palette(count), count) 'Reads in all the palettes into a variable
        Next

        FileClose(1) : Kill(PLoc) 'Closes file and deletes it from the hard drives
        FileOpen(1, PLoc, OpenMode.Random, , , Len(Current)) 'Creates a new one

        For count = 1 To Total
            If Palette(count).Name = Name Then : found = True : Nowrite = True : End If 'Cycles through the entire file and checks if the current value is the one to be deleted

            If Nowrite = False Then
                If found = True Then : FilePut(1, Palette(count), count - 1) 'If the palette has been deleted, the palette is put in a special way so there are no gaps.
                Else : FilePut(1, Palette(count), count) 'Else it's put back where it came out the file
                End If
            End If

            Nowrite = False
        Next

        FileClose(1)
    End Sub

#End Region

#Region "File Functions"

    Public Function Load_List() As String()
        'This will load all the names of the palettes into an array
        Dim Count As Short = 0 'Counting variable
        Dim Total As Short = GetTotalRecords() 'Getting the total number of records
        Dim Palette As New SavedPalette 'Temporary Variable for Data to be loaded into
        Dim List(Total) As String 'Variable that will store all the palette names

        If Total = 0 Then : Return Nothing
        Else
            FileOpen(1, PLoc, OpenMode.Random, , , Len(Palette))

            For Count = 1 To Total
                FileGet(1, Palette, Count) 'Getting the current record
                List(Count) = Palette.Name 'Adding the name to the list
            Next

            FileClose(1)

            SortList(List, Total)   'Functions sorts the list into alphabetical order

            Return List
        End If
    End Function

    Private Function GetTotalRecords() As Short
        'This function will get the total number of records in the file
        Dim Length As Short = 0 'Length to calculate record count
        Dim Palette As New SavedPalette

        FileOpen(1, PLoc, OpenMode.Random, , , Len(Palette))

        Length = LOF(1) / Len(Palette) 'Calculating the record count

        FileClose(1)

        Return Length 'Returns the number of records in the file
    End Function

    Public Function GetRecord(ByVal Name As String, Optional ByVal ID_Only As Boolean = False) As Short
        'This will check where the file should be placed when saving it to file
        Dim Record As Short = 0 'The value of record that will be returned
        Dim Palette As New SavedPalette 'The object into which the data is read into
        Dim Length As Short = GetTotalRecords() 'Used in counting loop
        Dim Count As Short = 1 'Counting variable
        Dim NameLength As Short = Name.Length
        Dim Leftover As Short = 10 - Name.Length

        'This adds leading spaces to the name, so it will be understood properly by the filehandling
        If Leftover < 10 Then
            For Count = 1 To Leftover
                Name += " "
            Next
        End If

        Count = 1

        FileOpen(1, PLoc, OpenMode.Random, , , Len(Palette))

        Do Until (Record = Count) Or (Count = Length + 1) 'Reading in each palette to check it's name. If there isn't a name already in the file then it'll be added to the end
            FileGet(1, Palette, Count)

            If Palette.Name = Name Then : Record = Count 'Else, if filename already exists then it'll be overwritten
            Else : Count += 1 : End If
        Loop

        FileClose(1)

        If ID_Only = False Then
            If Count = Length + 1 Then : Record = Length + 1 : End If 'Checking when the record isn't already there and given a new place in the file
        End If


        Return Record
    End Function

    Private Sub SortList(ByRef List() As String, ByVal Total As Short)
        'This function sorts the list of palettes into Alphabetical order
        Dim Outer As Short = 0
        Dim Inner As Short = 0
        Dim Temp As String = ""

        For Outer = 1 To Total
            For Inner = Outer + 1 To Total 'Checks each value
                If List(Outer) > List(Inner) Then 'If one if greater then the other then they are swaped
                    Temp = List(Outer)
                    List(Outer) = List(Inner)
                    List(Inner) = Temp 'The values are swapped and then the list is returned as being sorted
                End If
            Next
        Next
    End Sub

    Public Function CheckName(ByVal name As String) As Boolean
        'This functions checks if a palette of the same name has already been saved in the file
        Dim Found As Boolean = False
        Dim count As Short = 1
        Dim Total As Short = GetTotalRecords()
        Dim Current As New SavedPalette

        FileOpen(1, PLoc, OpenMode.Random, , , Len(Current))

        Do Until ((Found = True) Or (count > Total)) 'Checking all of the records, or until it has found a palette with the same name

            FileGet(1, Current, count)
            If Current.Name = name Then : Found = True
            Else : count += 1
            End If

        Loop

        FileClose(1)

        If Found = True Then : Return True 'If the palette has been found then the function will return true - there is one already
        Else : Return False 'Else, there is none and so a palette can be created
        End If
    End Function

#End Region

#Region "Colour Sorting"

    Private Function Encode(ByVal Palette As Palette) As SavedPalette
        'This function changes the Known Colour Name to an ARGB value so it can be written to file and read back in properly
        Dim NewPalette As New SavedPalette

        NewPalette.Name = Palette.Name
        NewPalette.Colour.C1 = Palette.Colour.C1.ToArgb()
        NewPalette.Colour.C2 = Palette.Colour.C2.ToArgb()
        NewPalette.Colour.C3 = Palette.Colour.C3.ToArgb()
        NewPalette.Colour.C4 = Palette.Colour.C4.ToArgb()
        NewPalette.Colour.C5 = Palette.Colour.C5.ToArgb()
        NewPalette.Colour.C6 = Palette.Colour.C6.ToArgb()

        Return NewPalette
    End Function

    Private Function Decode(ByVal Palette As SavedPalette) As Palette
        'This function decodes the ARGB values and puts them back into a Known Colour the computer can deal with
        Dim NewPalette As New Palette

        NewPalette.Name = Palette.Name
        NewPalette.Colour.C1 = Color.FromArgb(Palette.Colour.C1)
        NewPalette.Colour.C2 = Color.FromArgb(Palette.Colour.C2)
        NewPalette.Colour.C3 = Color.FromArgb(Palette.Colour.C3)
        NewPalette.Colour.C4 = Color.FromArgb(Palette.Colour.C4)
        NewPalette.Colour.C5 = Color.FromArgb(Palette.Colour.C5)
        NewPalette.Colour.C6 = Color.FromArgb(Palette.Colour.C6)

        Return NewPalette
    End Function

#End Region

End Module