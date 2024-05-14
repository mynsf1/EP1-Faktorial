Imports System

Module Program
  Sub Main(args As String())
        Dim cislo As Integer
        Dim faktorial As Integer = 1
        Console.WriteLine(" Výpočet faktoriálu")
        Console.Write(" Zadej číslo pro výpočet faktoriálu: ")
        cislo = Console.ReadLine()

        For i = 1 To cislo
            'faktorial = faktorial * i
            faktorial *= i 'упрощенный вариант
        Next
        Console.WriteLine($" Faktoriál čísla {cislo} je {faktorial}.")

    End Sub
End Module
