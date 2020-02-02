Module Module1

    Sub Main()
        Call AddNewScores()
        Console.ReadKey()
    End Sub
    Sub AddNewScores()
        Dim MembershipNumber, FileData, ScoreDate, Score As String
        FileOpen(1, "C:\FilePractice\ScoreDetails.txt", OpenMode.Append)
        Console.WriteLine("Input the date for the scores :")
        ScoreDate = Console.ReadLine
        Console.WriteLine("Input the membership number :")
        MembershipNumber = Console.ReadLine
        Do While MembershipNumber <> "##"
            Console.WriteLine("Input the score :")
            Score = Console.ReadLine
            Do While Score < 50 Or Score > 99
                Console.WriteLine("Enter a valid score from 50 to 99")
                Score = Console.ReadLine
            Loop
            FileData = (MembershipNumber & -ScoreDate & Str(Score))
            WriteLine(1, FileData)
            Console.WriteLine("Enter a membership number :")
            MembershipNumber = Console.ReadLine
        Loop
        FileClose(1)
    End Sub
End Module
