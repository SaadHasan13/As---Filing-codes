Module Module1

    Sub Main()
        Dim MemberName, IdNumber, SearchName As String
        Dim MemberFound As Boolean
        MemberFound = False
        Console.WriteLine("Enter name to search for : ")
        SearchName = Console.ReadLine
        FileOpen(1, "C:\FilePractice\ClubMembers.txt", OpenMode.Input)

        While Not EOF(1) And MemberFound = False
            Input(1, MemberName)
            Input(1, IdNumber)

            If MemberName = SearchName Then
                MemberFound = True

                Console.WriteLine("Id number :" & IdNumber)
            End If
        End While
        FileClose(1)
        If MemberFound = False Then Console.WriteLine("Record not found.")
        Console.ReadKey()

    End Sub

End Module
