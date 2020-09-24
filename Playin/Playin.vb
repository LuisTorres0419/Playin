Module Playin

    Sub Main()
        TestList()
        Console.ReadLine()
    End Sub

    Sub TestList()
        Dim names As New List(Of String)

        names.Add("Joe")
        names.Add("Tim")
        names.Add("Frank")
        names.Add("Mary")
        names.Add("Sally")

        Console.WriteLine(names.Count)
        names.Insert(3, "Bill")
        Console.WriteLine(names.Item(3))
        Console.WriteLine(names.Contains("Jimmy"))

        For Each name In names
            Console.WriteLine(name)
            Console.WriteLine(names.IndexOf(name))

        Next

        'Console.WriteLine(names.Item())
    End Sub


End Module
