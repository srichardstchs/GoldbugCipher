Imports System
Imports System.IO

Module Program
    Sub Main()
        ' Specify the input file
        Dim filePath As String = "C:\Users\srichards\OneDrive - Trinity Catholic High School\y10\GOLD BUG - CODE CRACKING\frequencyAnalysis\"
        Dim inputFile As String = filePath & "encrypted_story.txt"

        ' Dictionary to store the frequency of each character
        Dim charFrequency As New Dictionary(Of Char, Integer)

        Try
            ' Read the entire content of the file
            Dim text As String = File.ReadAllText(inputFile)

            ' Count the frequency of each character
            For Each ch As Char In text
                If charFrequency.ContainsKey(ch) Then
                    charFrequency(ch) += 1
                Else
                    charFrequency(ch) = 1
                End If
            Next

            ' Print the character frequencies
            Console.WriteLine("Character frequencies in the file:")
            For Each kvp As KeyValuePair(Of Char, Integer) In charFrequency
                Console.WriteLine(kvp.Key & ": " & kvp.Value)
            Next

        Catch ex As FileNotFoundException
            Console.WriteLine("The file " & inputFile & " does not exist.")
        Catch ex As Exception
            Console.WriteLine("An error occurred: " & ex.Message)
        End Try

        ' Pause the console so the user can see the output
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
