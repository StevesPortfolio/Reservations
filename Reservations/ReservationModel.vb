
'Program Name: Reservations
'Author: Steve Teece
'Version 1.0
'Date Written: 2 April, 2018
'Module: Reservation class
'Purpose: Contain information on seat reservations including passenger name and seat location.
'         Will be stored In a multi-dimensional array of type Reservation

Public Class ReservationModel

    'Auto Implemented properties
    Public Property Passenger As PersonModel
    Public Property SeatRow As Integer
    Public Property SeatColumn As Integer

    'Read Only properties
    Public ReadOnly Property Seat As String
        Get
            Seat = ""                   'Initialize Seat to empty string

            'Convert Seat Row number to letter and append seat column (to give format eg, "A7")
            Seat = ConvertSeatRow(SeatRow) + (SeatColumn + 1).ToString()

            Return Seat

        End Get
    End Property



End Class
