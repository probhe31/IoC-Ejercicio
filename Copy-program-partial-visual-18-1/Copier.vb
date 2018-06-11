Imports Copy_program_partial_visual_18_1

Public Class Copier

    Private outputData As IOutputData

    Public Sub New(oputputData As IOutputData)
        Me.outputData = oputputData
    End Sub

    Public Sub Copy(inputData As IInputData)
        Dim inputValue As String = inputData.Read()

        While Not (inputValue.Equals("-1"))
            outputData.Write(inputValue)
        End While

    End Sub

End Class
