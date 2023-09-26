Module StringRePlace
    'Bradley Mcneely
    '9/26/23
    'String Replace

    Sub main()
        Dim input As String
        Dim newString As String
        Dim originalString As String = "Mr. Klins is the teacher of this class"
        Console.WriteLine(originalString)
        Console.Write("What should we change Mr. Klins' name to? -> ")
        input = Console.ReadLine
        newString = originalString.Replace("Mr. Klins", input) 'STRING REPLACEMENT!!!!! 
        Console.WriteLine("The new string is {0} characters long as is as follows: ", newString.Length)
        Console.WriteLine(newString)
        Console.ReadLine()
    End Sub
End Module
