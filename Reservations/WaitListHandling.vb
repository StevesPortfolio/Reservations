Imports System.IO

'Program Name: Reservations
'Author: Steve Teece
'Version 1.0
'Date Written: 2 April, 2018
'Module: WaitList Handling
'Purpose: Functions and subroutines to manage the reservation waiting list

Module WaitListHandling

    Public Const WaitFile As String = "WaitingList.csv"
    Public WaitList As New List(Of PersonModel)()


    Public Function GetWaitingList() As List(Of PersonModel)

        Dim output = New List(Of PersonModel)

        'If Waiting List file exists
        Try
            'Create StreamReader
            Dim sr = New StreamReader(WaitFile)

            Do While sr.Peek() >= 0
                'Read a single line, inflate to person, and add to list
                output.Add(InflateWaitingListRecord(sr.ReadLine()))
            Loop

            'Don't forget to close the file
            sr.Close()

        Catch ex As FileNotFoundException
            'Display error message
            MessageBox.Show("Waiting List file cannot be found. A new Waiting List file has been created.",
                            "File Not Found Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            Dim sw = New StreamWriter(WaitFile)
            sw.Close()
        End Try
        Return output

    End Function

    ''' <summary>
    ''' Save changes to the Waiting List, overwriting the old file
    ''' </summary>
    Public Sub SaveWaitingList()

        Dim sw = New StreamWriter(WaitFile)
        Dim line As String = ""

        For Each p As PersonModel In WaitList
            'Convert person to line of text
            line = DeflatePersonToWaitingList(p)
            'Write line of text
            sw.WriteLine(line)
        Next

        'Don;t forget to close the file
        sw.Close()

        'Repopulate the waiting list with new data
        'PopulateWaitingList()


    End Sub

    ''' <summary>
    ''' Adds a person to the waiting list
    ''' </summary>
    ''' <param name="p">Person to be added to the waiting list as PersonModel type</param>
    Public Sub AddToWaitingList(p As PersonModel)

        'Add person to WaitList array
        WaitList.Add(p)

        ' Create stream writer in append mode to add to end of file
        Dim sw = New StreamWriter(WaitFile, True)


        'Deflate p from Person type to comma separated string
        Dim line As String = ""
        line = DeflatePersonToWaitingList(p)
        'Write line to end of file
        sw.WriteLine(line)

        'Don't forget to close the file
        sw.Close()


    End Sub

    ''' <summary>
    ''' Deflate Person to string for saving to CSV file
    ''' </summary>
    ''' <param name="p">Person as Person type</param>
    ''' <returns>String in format "firstname,lastname"</returns>
    Private Function DeflatePersonToWaitingList(p As PersonModel) As String
        'Waiting file format:
        'FirstName,LastName

        Dim output As String = ""
        output = p.Firstname.ToString() & "," & p.Lastname.ToString()
        Return output

    End Function


    ''' <summary>
    ''' Inflate a single line from the waiting list into a Person type
    ''' </summary>
    ''' <param name="line">string of person on waiting list in format of "firstname,lastname"</param>
    ''' <returns>Person on waiting list as type Person</returns>
    Private Function InflateWaitingListRecord(line As String) As PersonModel
        'Waiting List record format
        '0 = FirstName
        '1 = Surname

        Dim tempPerson() As String ' Create temporary variable to hold data after splitting
        Dim output = New PersonModel() 'Create new empty Person type

        tempPerson = Split(line, ","c)

        'Populate Person type
        output.Firstname = tempPerson(0)
        output.Lastname = tempPerson(1)

        Return output

    End Function

End Module
