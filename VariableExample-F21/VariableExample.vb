'Tim Rossiter
'Fall 2021
'Variable and Data Type example
'https://github.com/rosstimo/VariableExample-F21.git

Option Strict On
Option Explicit On

Module VariableExample

    Sub Main()
        Dim myNewVariable As String
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim result As Double
        Dim test As Boolean

        Const DISCOUNT As Decimal = 0.01@

        myNewVariable = "hello, world!"
        myNewVariable = "Good Bye!"
        myNewVariable &= " Cruel World"

        firstNumber = 5
        secondNumber = 6
        result = firstNumber / secondNumber

        'someStuff = "a thing"

        Console.Read()
    End Sub

End Module
