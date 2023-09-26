Imports System.Runtime.Remoting.Channels

Module Module1
    'Bradley McNeely
    '9/26/23
    'Basic String Functions and Integers!
    Sub Main()
        Dim Input As String
        Dim city, state As String
        Dim commaLocation, stringLength As Integer
        Console.Write("Please enter a city and state seperated by only a comma (no spaces) >> ")
        Input = Console.ReadLine()
        'our goal is to sperate this into two different string variables (city and state)
        'we assume we have a string in the format city, state
        'find the comma
        commaLocation = Input.IndexOf(",") 'FIND THE COMMA
        Console.WriteLine("the comma is located at position {0}", commaLocation)
        'take the first part of the string up to the comma, that is the city
        city = Input.Substring(0, commaLocation)
        Console.WriteLine("the city is {0}", city)
        stringLength = Input.Length 'FIND THE LENGTH
        Console.WriteLine("the length of the string is {0}", stringLength)
        'take the last part of the string after to comma, that is the state
        state = Input.Substring(commaLocation + 1, stringLength - commaLocation - 1)
        Console.WriteLine("the state is  {0}", state)
        'state = Input.Substring(commaLocation )

        Console.ReadLine()



    End Sub

End Module
