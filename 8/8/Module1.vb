Module Module1

    Sub Main()
        Dim s, s2, first, nxt, rep As String
        Dim count As Integer
        count = 0


        rep = "*"
        s2 = ""
        s = ""
        first = ""

        Console.WriteLine("input string")
        s = LCase(Console.ReadLine)


        For count = 1 To Len(s)
            nxt = Mid(s, count + 1, 1)
            If nxt = first Then

                nxt = "*"


            End If
            
            first = Left(s, 1)
            s2 = s2 & nxt

        Next

        s2 = first & s2

        Console.WriteLine("new string is :" & s2)
        Console.ReadKey()




    End Sub

End Module
