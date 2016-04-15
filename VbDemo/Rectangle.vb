' Author: Jacob Pitsch
' Location: City of Racine
' Date: April 11, 2016

' Summary: A Rectangle class representing the geometric
' shape of the rectangle with logical functions and variables.

Public Class Rectangle
    Private length As Double
    Private width As Double

    '' Parameterized constructor 
    'Public Sub New(ByVal x As Double, y As Double)
    '    length = x
    '    width = y
    'End Sub

    ' Setter function for length
    Public Sub setLength(len As Double)
        length = len
    End Sub

    ' Setter for width
    Public Sub setWidth(wid As Double)
        width = wid
    End Sub

    ' Getter function for width
    Public Function getWidth() As Double
        Return length
    End Function

    ' Getter function for length
    Public Function getLength() As Double
        Return width
    End Function

    ' Create a sample array of shapes
    Public Function makeArray() As Rectangle()
        Dim shapes(5) As Rectangle
        Return shapes
    End Function

    ' Returns the area of the rectangle: a = l*w
    Public Function GetArea() As Double
        GetArea = length * width
    End Function

    ' Returns the perimeter of the rectangle: p=2l+2w
    Public Function GetPerimeter() As Double
        GetPerimeter = (length * 2) + (width * 2)
    End Function

    ' Returns distance from opposite corners: a^2 + b^2 = c^2
    Public Function GetDiagonal() As Double
        GetDiagonal = (length * length) + (width * width)
    End Function

    ' Print subroutine for pertinent information
    Public Sub Display()
        Console.WriteLine("Length: {0}", length)
        Console.WriteLine("Width: {0}", width)
        Console.WriteLine("Area: {0}", GetArea())
        Console.WriteLine("Perimeter: {0}", GetPerimeter())
        Console.WriteLine("Hypotenuse: {0}", GetDiagonal())
    End Sub

End Class