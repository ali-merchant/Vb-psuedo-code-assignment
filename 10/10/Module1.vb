Module Module1

    Sub Main()
        Dim s, r As String


        r = ""
        s = ""

        Console.WriteLine("input string:")
        s = Console.ReadLine()

        r = Right(s, 3)

        If r = "ing" Then
            s = s & "ly"
            Console.WriteLine(s)

        elseIf Len(s) >= 3 Then
            s = s & "ing"
            Console.WriteLine(s)

        ElseIf Len(s) < 3 Then

            Console.WriteLine(s)

        End If



        Console.ReadKey()





    End Sub

End Module
