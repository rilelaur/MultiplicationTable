Module MultiplicationTable

    Sub Main()
        Dim userInput As String = " "
        Dim _tableValues As Integer
        Dim tableValue As Integer
        Dim problem As Boolean = True

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
