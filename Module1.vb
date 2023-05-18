Module Module1

    Sub Main()
        Dim num1 As Integer
        Dim num2 As Integer
        Dim LF1 As Integer = 0
        Dim LF2 As Integer = 0
        Dim count As Integer = 2
        Dim found As Boolean = False


        Console.WriteLine("what is your first number?") 'ask user input 1
        num1 = Console.ReadLine()


        Console.WriteLine(" what is your second number") 'ask user input 2
        num2 = Console.ReadLine()

        Do Until found = True 'find the lowest factor of the first value
            If num1 Mod count = 0 Then
                LF1 = count
                found = True

            Else
                count = count + 1

            End If

        Loop


        count = 2   'resets count

        Do Until found = True 'find the lowest factor of the second value   
            If num2 Mod count = 0 Then ' mod finds the remainder so it means that its fully divided.
                LF2 = count
                found = True

            Else
                count = count + 1

            End If

        Loop

        Dim HF1 = num1 / LF1
        Dim HF2 = num2 / LF2
        Dim HCF As Integer = 1


        If HF1 > HF2 Then   'The smaller number cannot be divided by the higher factor.
            count = HF2 ' we use this as it is smaller

            Do Until HCF <> 1 Or count = 1 'The loop continues until, HCF is found at which point count = 1 or HCF is a number higher than 1 meaning that HCF = 1
                If num1 Mod count = 0 And num2 Mod count = 0 Then
                    HCF = count
                Else
                    count = count - 1

                End If
            Loop

        Else

            count = HF1
            Do Until HCF <> 1 Or count = 1
                If num1 Mod count = 0 And num2 Mod count = 0 Then
                    HCF = count
                Else
                    count = count - 1

                End If
            Loop

        End If

        Console.WriteLine("the highest common factor is: " & HCF) ' output
        Console.ReadLine()

    End Sub

End Module
