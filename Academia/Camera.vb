Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Drawing

Public Class Camera
    Const WM_CAP As Short = &H400S
    Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30
    Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Const WS_CHILD As Integer = &H40000000
    Const WS_VISIBLE As Integer = &H10000000
    Const SWP_NOMOVE As Short = &H2S
    Const SWP_NOSIZE As Short = 1
    Const SWP_NOZORDER As Short = &H4S
    Const HWND_BOTTOM As Short = 1
    Shared iDevice As Integer = 0
    Shared hHwnd As Integer
    Shared vImagem As PictureBox

    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer
    Private Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer
    Private Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean
    Private Declare Function capCreateCaptureWindowA Lib "avicap32.dll" (ByVal lpszWindowName As String, ByVal dwStyle As Integer, ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Short, ByVal hWndParent As Integer, ByVal nID As Integer) As Integer
    Private Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, ByVal cbVer As Integer) As Boolean

    Public Shared Function CarregarLista(ByVal vLista As ListBox)
        Dim strName As String = Space(100)
        Dim strVer As String = Space(100)
        Dim bReturn As Boolean
        Dim x As Integer = 0

        Try
            Do
                bReturn = capGetDriverDescriptionA(x, strName, 100, strVer, 100)
                If bReturn Then
                    vLista.Items.Add(strName.Trim)
                    x += 1
                End If
            Loop Until bReturn = False
        Catch ex As Exception
            Throw
        End Try
        Return "Câmera Funcionando"
    End Function

    Public Shared Sub LigarCamera(ByVal vImagem2 As PictureBox)
        Dim iHeight As Integer = vImagem2.Height
        Dim iWidth As Integer = vImagem2.Width
        Dim vpassou As Boolean = False

        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640, 480, vImagem2.Handle.ToInt32, 0)

        Do While vpassou = False
            If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then
                SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)
                SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)
                SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)
                SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, vImagem2.Width, vImagem2.Height, SWP_NOMOVE Or SWP_NOZORDER)
                vpassou = True
            End If
        Loop

    End Sub

    Public Shared Sub EncerrarCamera()
        SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0)
        DestroyWindow(hHwnd)
    End Sub

    Public Shared Sub CongelaImagem(ByVal vImagem As PictureBox)
        Dim data As IDataObject
        Dim bmap As Image

        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)
        data = Clipboard.GetDataObject()

        If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Image)
            vImagem.Image = bmap
            EncerrarCamera()
        End If
    End Sub

    Public Shared Function SalvaFoto(ByVal vImagem As PictureBox, ByVal vLocal As String) As String

        Try
            If Not My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\" & vLocal) Then
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\" & vLocal)
            End If

            Dim vFotoCodigo As String = Guid.NewGuid().ToString & ".png"

            vImagem.Image.Save(Application.StartupPath & "\" & vLocal & "\" & vFotoCodigo, Imaging.ImageFormat.Png)

            Return vFotoCodigo
        Catch ex As Exception
            Return MessageBox.Show("Não foi possível fazer o salvamento da imagem. Erro: " & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

End Class