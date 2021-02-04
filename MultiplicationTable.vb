'Laura Riley
'RCET0265
'Spring 2021
'Multiplication Table
'https://github.com/rilelaur/MultiplicationTable.git

Option Explicit On
Option Strict On
Module MultiplicationTable

    Sub Main()
        Dim userInput As String = " "
        Dim _tableValues As Integer
        Dim tableValue As Integer
        Dim problem As Boolean = True

        'Asks the user for a number and makes sure they enter a valid number
        'If the user enters anything but a number it will tell them they are 
        'wrong and ask for a number
        While problem = True
            Console.WriteLine("Please enter a number.")
            Try
                userInput = Console.ReadLine()
                tableValue = CInt(userInput)
                problem = False
            Catch ex As Exception
                Console.WriteLine($"Please enter a whole number. You entered {userInput}" & vbCrLf)
                problem = True
            End Try
        End While

        'Writes out the multiplication table after the user enters a number
        If problem = False Then
            Console.WriteLine(vbCrLf & $"Here is your {tableValue} by {tableValue} multiplication table." & vbCrLf)
            For i = 1 To (tableValue)
                For j = 1 To (tableValue)
                    _tableValues = (j * i)
                    Console.Write(CStr(_tableValues).PadLeft(5))
                Next
                _tableValues = (i)
                Console.Write(vbCrLf)
            Next
        End If
        Console.Read()
    End Sub

End Module
