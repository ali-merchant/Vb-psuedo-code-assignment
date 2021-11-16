Module pangram

    Sub Main()
        Dim str, Astr As String
        Dim nxt As Char
        Dim ispangram As Boolean

        str = ""
        Astr = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        nxt = ""
        ispangram = True

        Console.Write("Enter string :")
        str = Console.ReadLine
        str = UCase(str)

        For count = 1 To Len(Astr)
            nxt = Mid(Astr, count, 1)
            If InStr(str, nxt) = 0 Then
                ispangram = False
                Exit For

            End If

        Next

        If ispangram = True Then
            Console.WriteLine("string has all the alphabets")
        Else
            Console.WriteLine("string does not have all the alphabets")
        End If
        Console.ReadKey()

    End Sub

End Module

