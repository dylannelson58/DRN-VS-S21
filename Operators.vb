'Dylan Nelson
'ISU RCET 2021 Spring
'01-15-2020
'
Module Operators

    Sub Main()
        Console.WriteLine(2 + 2)
        Console.WriteLine(40 + 40)
        Console.WriteLine(27 / 3)   'Regular division
        Console.WriteLine(1 Mod 2)  'Integer division
        Console.WriteLine(1 \ 2)    'Remainder only divison

        Console.WriteLine("Dylan" & " Ray" & " Nelson")   'concatenates strings together
        Console.WriteLine("adding" + " words")           'adds the words together similiar to line above
        'Console.WriteLine(123 + "strings")             'This does not work use & in this case

        Console.WriteLine(3 > 4)    'Comparison
        Console.WriteLine(3 < 4)
        Console.WriteLine(3 = 4)
        Console.WriteLine(3 <> 4)

        Console.WriteLine("A" > "B")        'Comparison is using the Ascii values of the numbers
        Console.WriteLine("A" < "B")
        Console.WriteLine("A" > "a")
        Console.WriteLine("AAA" > "ABA")    'Code looks at characters left to right for values


        Console.Beep(130, 100)
        Console.Beep(262, 100)
        Console.Beep(330, 100)
        Console.Beep(392, 100)
        Console.Beep(523, 100)
        Console.Beep(660, 100)
        Console.Beep(784, 300)
        Console.Beep(660, 300)
        Console.Beep(146, 100)
        Console.Beep(262, 100)
        Console.Beep(311, 100)
        Console.Beep(415, 100)
        Console.Beep(523, 100)
        Console.Beep(622, 100)
        Console.Beep(831, 300)
        Console.Beep(622, 300)
        Console.Beep(155, 100)
        Console.Beep(294, 100)
        Console.Beep(349, 100)
        Console.Beep(466, 100)
        Console.Beep(588, 100)
        Console.Beep(699, 100)
        Console.Beep(933, 300)
        Console.Beep(933, 100)
        Console.Beep(933, 100)
        Console.Beep(933, 100)
        Console.Beep(1047, 400)
        Console.ReadLine()
    End Sub

End Module
