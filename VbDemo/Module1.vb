' Author: Jacob Pitsch
' Location: City of Racine
' Date: April 11, 2016

' Summary: demo module for practicing syntax, data structures,
' method invocation, objects, data manipulation, and user input.

Imports System
Module Module1

    Public Sub getInput(r As Rectangle)
        ' Prompt for user input
        Console.Write("Enter length: ")
        r.setLength(Console.ReadLine)
        Console.Write("Enter width: ")
        r.setWidth(Console.ReadLine)
    End Sub

    Public Sub print(r As Rectangle)
        ' Set, print methods
        r.Display()
    End Sub

    Sub Main()
        ' Instantiate new instance of Rectangle
        Dim r = New Rectangle()
        getInput(r)
        print(r)
        ' Array work
        Dim shapes = r.makeArray()
        shapes(0) = r
        Console.ReadLine()
    End Sub

End Module
