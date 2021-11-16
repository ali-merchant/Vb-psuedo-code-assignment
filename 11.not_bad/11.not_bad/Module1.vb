Module Module1
    Sub Main()

        Dim s, newtxt, discard As String
        Dim no, bad, in1, in2 As Integer
        s = ""
        newtxt = ""
        no = 0
        bad = 0

        Console.WriteLine("input string")
        s = LCase(Console.ReadLine())

        no = InStr(1, s, "not")
        Console.WriteLine(no)

        bad = InStr(1, s, "bad")
        bad = bad + 1
        Console.WriteLine(bad)

        in1 = no
        in2 = bad


        newtxt = s.Substring(in2 - in1)

        discard = Replace(s, newtxt, "good")
        Console.WriteLine(discard)



        Console.ReadKey()
    End Sub

End Module