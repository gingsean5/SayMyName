﻿
Option Strict On
Option Explicit On
'Sean Gingerich
'RCET0265
'Fall 2020
'Say My Name
'https://github.com/gingsean5/SayMyName
Module SayMyNameSol

    Sub Main()
        Dim userName As String

        'While problem = True
        Console.WriteLine("What is your name?")
        userName = Console.ReadLine()
        Console.WriteLine($"You have a beautiful name, {userName}. ")
        Console.Read()
    End Sub

End Module
