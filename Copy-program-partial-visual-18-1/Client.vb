Public Class Client

    Public Function Write(value As String) As IInputData
        Return New Keyboard()
    End Function

    Public Function Read() As IInputData
        Return New Scanner()
    End Function


End Class
