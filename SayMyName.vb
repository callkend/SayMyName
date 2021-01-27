'Kendall Callister
'RCET0265
'Spring 2021
'Say My Name
'https://github.com/callkend/SayMyName.git

Option Explicit On
Option Strict On

Module SayMyName

    Sub Main()
        Dim firstName As String

        Console.WriteLine("What is your name?")
        firstName = Console.ReadLine()

        If firstName = "Joe" Or firstName = "Emily" Then
            Console.WriteLine("Hello, " + firstName)
        ElseIf firstName = "Kendall" Then
            Console.WriteLine($"Get Good {firstName}")
        Else
            Console.WriteLine("Hello")
        End If
        Console.ReadLine()

    End Sub

End Module
