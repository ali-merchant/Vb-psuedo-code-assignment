Module Module1

    Sub Main()
        Dim s As String = ""
        Dim c As Char = ""
        Dim ic, count As Integer
        ic = 0
        count = 0

        Console.WriteLine("Enter string to process")
        s = Console.ReadLine


        For ic = 1 To Len(s)

            c = UCase(Mid(s, ic, 1))
            If c >= "A" And c <= "Z" Then
                count = count + 1

            End If
        Next
        
        Console.WriteLine("total alphabets:" & count)
        Console.ReadKey()






    End Sub

End Module
