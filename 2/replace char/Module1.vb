Module Module1

    Sub Main()
        Dim Str, str2 As String
        Dim del, rep, nxt As Char
        Str = ""
        str2 = ""
        del = ""
        rep = ""
        nxt = ""






        Console.Write("Enter string :")
        Str = Console.ReadLine

        Console.Write("enter char to remove:")
        del = Console.ReadLine

        Console.Write("enter char to replace:")
        rep = Console.ReadLine

        For count = 1 To Len(Str)
            nxt = Mid(Str, count, 1)
            If nxt = del Then
                nxt = rep

            End If
            Str2 = str2 & nxt
        Next


        Console.WriteLine("new string is :" & str2)
        Console.ReadKey()




    End Sub

End Module
