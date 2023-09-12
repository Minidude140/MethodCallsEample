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
        Dim numberCheck As Integer
        Dim min As Integer = 10
        Dim max As Integer = 20

        'SayHello()
        ' SumOf(5, 7)
        ' ProductOf(4, 5)

        'Console.WriteLine($"In Main: {userMessage}")
        'SendMessage(userMessage)
        ' Console.WriteLine($"In Main: {userMessage}")
        ' Console.ReadLine()

        'testing random numbers
        'randomize()
        'for i = 0 to 100
        '    console.writeline((cint(rnd() * 10)) + 10)
        'next
        'console.readline()

        'test loop
        For i = 0 To 1000
            numberCheck = randomintegerbetween(min, max)
            Console.WriteLine(numberCheck)
            If numberCheck < min Or numberCheck > max Then
                Console.WriteLine("Oops Out of Range!!!")
                i = 1000

            End If
        Next

        Console.Read()
    End Sub

    'in progress random number function within range
    ''' <summary>
    ''' Random integer between min and max, inclusive.
    ''' max must be greater than min
    ''' </summary>
    ''' <param name="min"></param>
    ''' <param name="max"></param>
    ''' <returns>Random integer between min and max</returns>
    Function randomintegerbetween(min As Integer, max As Integer) As Integer
        Dim result As Integer
        Randomize()
        result = CInt(Rnd() * (max - min)) + min

        Return result
    End Function

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
