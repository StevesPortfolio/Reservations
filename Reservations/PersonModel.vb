
'Program Name: Reservations
'Author: Steve Teece
'Version 1.0
'Date Written: 2 April, 2018
'Module: Person class
'Purpose: Person class for Airline Reservations assignment. Written to make handling reservations easier.

Public Class PersonModel

    'Auto implemented properties
    Public Property Firstname As String
    Public Property Lastname As String

    'Read Only properties
    Private _fullName As String
    Public ReadOnly Property FullName() As String
        Get
            Return Firstname + " " + Lastname
        End Get

    End Property


End Class
