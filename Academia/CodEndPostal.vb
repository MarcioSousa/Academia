Public Class CodEndPostal
    Public vEndereco As String
    Public vBairro As String
    Public vCidade As String
    Public vUf As String

    Public Function ProcuraCep(vCep As String) As Boolean
        Try
            Dim ds As New DataSet
            Dim xml As String = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", vCep)

            ds.ReadXml(xml)
            If ds.Tables(0).Rows(0)("resultado") Then
                vEndereco = ds.Tables(0).Rows(0)("tipo_logradouro") & " " & ds.Tables(0).Rows(0)("logradouro")
                vBairro = ds.Tables(0).Rows(0)("bairro")
                vCidade = ds.Tables(0).Rows(0)("cidade")
                vUf = ds.Tables(0).Rows(0)("uf")
                Return True
            Else
                MessageBox.Show("Cep não localizado, tente novamente...")
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
