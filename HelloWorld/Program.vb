Imports System

Module Program
    Sub Main(args As String())
        Dim currentDate = DateTime.Now
        Console.WriteLine("Cual es tu nombre? ")
        Dim name = Console.ReadLine()
        Console.WriteLine($"Hola, {name}, on {currentDate:d} at {currentDate:t}")
    End Sub
End Module
