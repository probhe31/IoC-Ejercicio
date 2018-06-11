Public Class Machine
    Private ReadOnly _ReadService As IInputData
    Private ReadOnly _WriteService As IOutputData

    Public Sub New(readService As IInputData, writeService As IInputData)
        _ReadService = readService
        _WriteService = writeService
    End Sub

    Public Sub Read()
        _ReadService.Read()
    End Sub

    Public Sub Write(value As String)
        _WriteService.Write(value)
    End Sub

End Class
