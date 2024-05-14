Imports System

Module Program
  Sub Main(args As String())
        Dim cislo As Integer
        Dim faktorial As Integer = 1

        Console.Write(" Zadej èíslo: ")
        cislo = Console.ReadLine()

        For i = 1 To cislo
            'faktorial = faktorial * i
            faktorial *= i
        Next
        Console.WriteLine($" Faktorial èísla {cislo} je {faktorial}.")

    End Sub
End Module
