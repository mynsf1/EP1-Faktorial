Imports System

Module Program
  Sub Main(args As String())
        Dim cislo As Integer
        Dim faktorial As Integer = 1

        Console.Write(" Zadej ��slo: ")
        cislo = Console.ReadLine()

        For i = 1 To cislo
            'faktorial = faktorial * i
            faktorial *= i
        Next
        Console.WriteLine($" Faktorial ��sla {cislo} je {faktorial}.")

    End Sub
End Module
