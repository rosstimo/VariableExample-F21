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
        Dim userResponse As String

        Const DISCOUNT As Decimal = 0.01@

        myNewVariable = "hello, world!"
        myNewVariable = "Good Bye!"
        myNewVariable &= " Cruel World"

        firstNumber = 5
        secondNumber = 6
        result = firstNumber / secondNumber
        Console.WriteLine("Enter a number")
        userResponse = Console.ReadLine()
        Console.WriteLine(CInt(userResponse) + 5)

        Console.Beep()
    End Sub
End Module
