Module Module1

    Sub Main()
        Dim Names As String
        FileOpen(1, "C:\FilePractice\sRec.txt", OpenMode.Output)
        For c = 1 To 5
            Console.WriteLine("Enter student name: ")
            Names = Console.ReadLine()
            WriteLine(1, Names)
        Next
        FileClose(1)
        Console.ReadKey()

    End Sub

End Module
