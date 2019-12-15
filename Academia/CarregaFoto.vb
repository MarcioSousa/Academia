Public Class CarregaFoto

    Public Shared Function carregaFoto(nomefoto As String, vLocal As String) As Image

        If Not My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\" & vLocal) Then
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\" & vLocal)
        End If

        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\" & vLocal & "\" & nomefoto) Then
            Return Image.FromFile(Application.StartupPath & "\" & vLocal & "\" & nomefoto)
        Else
            Return Image.FromFile(Application.StartupPath & "\semimagem.png")
        End If

    End Function

End Class
