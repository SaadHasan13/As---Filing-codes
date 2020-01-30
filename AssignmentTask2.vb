Module Module1

    Sub Main()
        Dim MemberName, IDNumber As String
        Dim C As Integer

        FileOpen(1, "C:\FilePractice\ClubMembers.txt", OpenMode.Input)


        For C = 1 To 5
            Console.WriteLine("Enter a member's name :" & MemberName)
            Console.WriteLine("Enter the member's Id number :" & IDNumber)
            Input(1, MemberName)
            Input(1, IDNumber)
        Next

        FileClose(1)
        Console.ReadKey()
    End Sub

End Module
