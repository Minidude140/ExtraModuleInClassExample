'Zachary Christensen
'RCET 2265
'Fall 2023
'{Project Name}
'https://github.com/Minidude140


Option Explicit On
Option Strict On

Module MainModule

    Sub Main()
        Dim sumTest As Integer
        sumTest = ExtraModule.SumOf(3, 4)
        Console.Write(sumTest)
        Console.WriteLine()

        Dim productTest As Integer
        productTest = ExampleClass.ProductOf(3, 4)
        Console.Write(productTest)
        Console.WriteLine()

        Console.Read()
    End Sub

End Module
