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
        SayHello()
        SumOf(5, 7)
        Console.ReadLine()
    End Sub

    'Basic sub routine says helllo
    Sub SayHello()
        Console.WriteLine("Hello")
    End Sub

    'example with parameters or arguments
    Sub SumOf(firstNumber As Integer, secondNumber As Integer)
        Console.WriteLine(firstNumber + secondNumber)
    End Sub

End Module
