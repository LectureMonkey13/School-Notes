Module Module1

    Sub Main()
        'Use this area to play different subs
        Part6()

    End Sub

    Sub Part2()
        Console.ForegroundColor = ConsoleColor.Red 'Text Colour
        Console.BackgroundColor = ConsoleColor.White 'Background Colour
        Console.WriteLine("Hello World")
        Console.ReadKey()

    End Sub
    Sub Part3()
        Dim Username As String 'One line of text
        Dim Letter As Char ' One letter
        Dim Age As Integer 'A whole number
        Dim Footsize As Double 'A decimal or fraction number
        Dim Happy As Boolean 'True or False

        Username = "Will"
        Letter = "W"
        Age = "14"
        Footsize = "11.5"
        Happy = True

        Console.WriteLine(Username)
        Console.WriteLine(Letter)
        Console.WriteLine(Age)
        Console.WriteLine(Footsize)
        Console.WriteLine(Happy)
        Console.ReadKey()
    End Sub
    Sub Part4()
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        a = 5
        b = 10
        c = a * b
        Console.WriteLine(c)
        Console.ReadKey()

    End Sub
    Sub Part5()
        Dim litres As Double
        litres = 5 / 3
        Console.WriteLine("You have " + "{0:F2}" + " litres in the tank", litres) 'Will write the variable to 2dp
        Console.ReadKey()

    End Sub
    Sub Part6()
        Dim y As String
        Dim x As Integer
        y = "There are 4 Words"
        y = Len(x)
        Console.WriteLine(Len(x)) 'Outputs amount of words string
        Console.ReadKey()

        y = InStr("Hello", "o")
        Console.WriteLine(InStr("Hello", "o")) 'Returns the index value of the first character in a substring z in x

        Console.ReadKey()
    End Sub
End Module
