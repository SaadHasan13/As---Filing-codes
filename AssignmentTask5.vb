Module Module1

    Sub Main()
        Dim MemberName, IDNumber, TelephoneNo, JoiningDate, SearchName As String
        Dim C As Integer
        Dim MemberFound As Boolean
        MemberFound = False
        FileOpen(1, "C:\FilePractice\ClubMembers.txt", OpenMode.Output)


        For C = 1 To 5
            Console.WriteLine("Enter a member's name :")
            MemberName = Console.ReadLine
            Console.WriteLine("Enter the member's Id number :")
            IDNumber = Console.ReadLine
            Console.WriteLine("Enter your telephone no. : ")
            TelephoneNo = Console.ReadLine
            Console.WriteLine("Enter date of joining the club :")
            JoiningDate = Console.ReadLine
            WriteLine(1, MemberName)
            WriteLine(1, IDNumber)
            WriteLine(1, TelephoneNo)
            WriteLine(1, JoiningDate)
        Next

        FileClose(1)
        FileOpen(1, "C:\FilePractice\ClubMembers.txt", OpenMode.Input)
        FileOpen(2, "C:\FilePractice\UpdatedClubRecord.txt", OpenMode.Output)

        While Not EOF(1)
            Input(1, MemberName)
            Input(1, IDNumber)
            Input(1, TelephoneNo)
            Input(1, JoiningDate)
            If MemberName <> SearchName Then
                WriteLine(2, MemberName)
                WriteLine(2, IDNumber)
                WriteLine(2, TelephoneNo)
                WriteLine(2, JoiningDate)
            ElseIf MemberName = SearchName Then
                MemberFound = True
            End If
        End While
        FileClose(1)
        FileClose(2)
        My.Computer.FileSystem.DeleteFile("C:\FilePractice\ClubMembers.txt")
        My.Computer.FileSystem.RenameFile("C:\FilePractice\UpdatedClubRecord.txt", "ClubMembers.txt")
        If MemberFound = False Then Console.WriteLine("Record not found.")

        Console.ReadKey()
    End Sub

End Module
