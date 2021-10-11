Imports System

Module Program
    Dim Area As Integer
    Dim Lato As Integer
    Sub Main()
        Dim scelta As String = "Si"
        While scelta = "Si" Or scelta = "SI" Or scelta = "si"
            Console.Write("• Inserisci il Lato di Un Quadrato: ")
            Lato = Console.ReadLine
            Console.Clear()
            Call CalcolaQuadrato()
            Console.WriteLine("• L'area del Quadrato è " & Area)
            Console.WriteLine("Vuoi Continuare? Si o No?")
            scelta = Console.ReadLine()
            Console.Clear()
        End While
    End Sub
    Sub CalcolaQuadrato()
        Area = Lato * Lato
    End Sub
End Module
