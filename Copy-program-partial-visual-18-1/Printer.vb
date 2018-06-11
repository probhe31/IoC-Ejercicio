Imports Copy_program_partial_visual_18_1

Public Class Printer
    Implements IOutputData

    Public Sub Write(value As String) Implements IOutputData.Write
        Util.Output(" *Printer: " + value)
    End Sub
End Class
