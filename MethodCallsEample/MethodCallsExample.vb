'Zachary Christensen
'RCET 2265
'Fall 2023
'Method Call Example
'https://github.com/Minidude140/MethodCallsEample.git


Option Explicit On
Option Strict On

Module MethodCallsExample

    'Sub main always runs.  It will go to the routine called and return to main after sub routine finishes
    Sub Main()
        Dim userMessage As String = "Hello"

        'SayHello()
        ' SumOf(5, 7)
        ' ProductOf(4, 5)

        'Console.WriteLine($"In Main: {userMessage}")
        'SendMessage(userMessage)
        ' Console.WriteLine($"In Main: {userMessage}")
        ' Console.ReadLine()

        'testing random numbers
        Randomize()
        For i = 0 To 100
            Console.WriteLine((CInt(Rnd() * 10)) + 10)
        Next
        Console.ReadLine()

    End Sub

    'in progress random number function within range
    'Function randomIntegerBetween() As Integer
    '    Dim result As Integer
    '    Randomize()
    '    CInt(Rnd())
    '    Return result
    'End Function

    'Basic sub routine says helllo
    Sub SayHello()
        Console.WriteLine("Hello")
    End Sub

    'example with parameters or arguments
    Sub SumOf(firstNumber As Integer, secondNumber As Integer)
        Console.WriteLine(firstNumber + secondNumber)
    End Sub

    'byval saves copy of variable value and releases from memory when done 
    '(above example shows byval Is default in method calls)
    Sub ProductOf(ByVal firstNumber As Integer, ByVal SecondNumber As Integer)
        Console.WriteLine(firstNumber * SecondNumber)
    End Sub

    'by reference doesn't copy input value it can rewrite the original value
    'following example rewrites userMessage value outside of sub routine
    'try running this code as ByVal and ByRef to witness the difference
    Sub SendMessage(ByRef message As String)
        Console.WriteLine($"In SendMessage: {message}.")
        message = "Goodbye."
        Console.WriteLine($"In SendMessage: {message}")
    End Sub

    Function RunningTotal(value As Integer, clear As Boolean) As Integer
        Static total As Integer
        If clear = False Then
            RunningTotal += value
        Else total = 0
        End If
        Return total
    End Function



End Module
