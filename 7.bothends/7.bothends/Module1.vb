Module Module1

    Sub Main()
        Dim s, first, second As String
        s = ""
        first = ""
        second = ""

        Console.Write("input string :")
        s = Console.ReadLine


        If Len(s) > 4 Then
            first = (Left(s, 2))

            second = (Right(s, 2))

            Console.WriteLine(first & second)
            Console.ReadKey()

        Else
            s = "s"
            Console.WriteLine(s)
            Console.ReadKey()

        End If


    End Sub
End Module
