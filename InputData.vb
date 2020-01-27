Module Module1

    Sub Main()
        Call InputData()
        Console.ReadKey()
    End Sub
    Sub InputData()
        Dim CDTitle, CDArtist, CDLocation As String
        FileOpen(1, "C:\FilePractice\MyMusic.txt", OpenMode.Output)
        Console.WriteLine("Input CD Title : ")
        CDTitle = Console.ReadLine()
        Do Until CDTitle = "##"
            Console.WriteLine("Input CD Artist : ")
            CDArtist = Console.ReadLine()
            Console.WriteLine("Input CD Location : ")
            CDLocation = Console.ReadLine()
            Print(1, CDTitle & ":" & CDArtist & ":" & CDLocation)
            Console.WriteLine("Input CD Title : ")
            CDTitle = Console.ReadLine()
        Loop
        FileClose(1)
    End Sub
End Module
