Module Module1

    Sub Main()
        Dim s1, news1, s2, news2, f1, f2, r, r2 As String
        s1 = ""
        s2 = ""
        r = ""
        r2 = ""
        news1 = ""
        news2 = ""
        f1 = ""
        f2 = ""


        Console.WriteLine("input word 1 ")
        s1 = Console.ReadLine


        Console.WriteLine("input word 2 ")
        s2 = Console.ReadLine


        f1 = Left(s1, 2)
        r = Right(s1, Len(s1) - 2)


        f2 = Left(s2, 2)
        r2 = Right(s2, Len(s2) - 2)


        news1 = f1 & r2
        news2 = f2 & r

        Console.WriteLine("new string is:" & news2 & " " & news1)
        Console.ReadKey()











    End Sub

End Module
