﻿'Kendall Callister
'RCET0265
'Spring 2021
'Say My Name
'https://github.com/callkend/SayMyName.git

Option Explicit On
Option Strict On


Module SayMyName

    Sub Main()
        Dim firstName As String
        Dim lastName As String

        Console.WriteLine("What is your first name?")
        firstName = Console.ReadLine()
        Console.WriteLine("What is your last name?")
        lastName = Console.ReadLine()
        Console.WriteLine("Hello, " + firstName + " " + lastName)
        Console.ReadLine()

    End Sub

End Module
