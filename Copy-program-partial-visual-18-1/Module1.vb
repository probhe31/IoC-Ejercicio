Module Module1

    Sub Main()

        Dim injector As New Client
        Dim writeObject = injector.Write("test")
        Dim readObject = injector.Read()
        Dim machine As New Machine(writeObject, readObject)

        machine.Write("test")
        machine.Read()

    End Sub

End Module
