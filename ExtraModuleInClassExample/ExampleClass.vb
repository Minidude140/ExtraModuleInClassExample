Public Class ExampleClass
    ''' <summary>
    ''' Returns the Product of two numbers
    ''' </summary>
    ''' <param name="firstNumber"></param>
    ''' <param name="secondNumber"></param>
    ''' <returns></returns>
    Public Shared Function ProductOf(firstNumber%, secondNumber%) As Integer
        SendMessage(firstNumber, secondNumber)
        Return firstNumber * secondNumber
    End Function

    Public Shared Sub SendMessage(firstNumber As Integer, secondNumber As Integer)
        Console.WriteLine("This is a product of " + CStr(firstNumber) + " and " + CStr(secondNumber))
        ' Console.WriteLine()
    End Sub
End Class
