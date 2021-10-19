# Airline Reservation Program

Simple Airline Reservation system written in Visual Basic as part of Certificate IV Programming course through NSW TAFE.

__Specifications given__

Write a reservation system for an airline flight. Assume the airplane has 40 seats. Use an array of string to maintain a seating chart. In addition, create an array to be used as a waiting list in case the plane is full.
The waiting list should be “first come, first served”, that is people who are added early to the list get priority over people who are added later.
Allow the user the following three options:

1. Quit (end the program)
2. Add a passenger to the flight or waiting list.
   1. Request the passenger’s name.
   2. Display a chart of the seats in the airplane.
   3. If seats are available, let the passenger chose a seat. Add the passenger to the seating chart.
   4. If no seats are available, place the passenger on the waiting list.
3. Remove a passenger from the flight.
   1. Request the passenger’s name.
   2. Search the seating chart for the passenger’s name and delete it.
   3. If the waiting list is empty, update the array so the seat is available.
   4. If the waiting list is not empty, remove the person from the list, and give him or her the newly vacated seat.
