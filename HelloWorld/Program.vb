Imports System

Module Program
    Sub Main(args As String())
        Dim currentDate = DateTime.Now
        Console.WriteLine("What is your name? ")
        Dim name = Console.ReadLine()
        Console.WriteLine($"Hola, {name}, on {currentDate:d} at {currentDate:t}")
    End Sub
End Module
