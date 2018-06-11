Imports Copy_program_partial_visual_18_1

Public Class Keyboard
    Implements IInputData

    Public Function Read() As String Implements IInputData.Read
        Util.OutputInLine("Keyboard - Enter String: ")
        Dim result As String = Console.Read()
        Return result

    End Function

End Class
