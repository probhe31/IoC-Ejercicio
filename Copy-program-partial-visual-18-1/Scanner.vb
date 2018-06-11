Imports Copy_program_partial_visual_18_1

Public Class Scanner
    Implements IInputData

    Public Function Read() As String Implements IInputData.Read
        Util.OutputInLine("Scanner - Enter String: ")
        Dim result As String = Console.Read()
        Return result
    End Function
End Class
