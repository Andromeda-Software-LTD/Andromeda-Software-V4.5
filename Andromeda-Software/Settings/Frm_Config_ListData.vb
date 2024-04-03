Public NotInheritable Class Frm_Config_ListData
    Public wait As Boolean
    Public Sub New(ByVal ParametersClient As sockets.Frm_Config_Client, ByVal ParametersByte As Byte(),
                   ByVal ParametersObject As Object(), ByVal ParametersTcpClient As Net.Sockets.TcpClient)
        Me.ClassClient = ParametersClient
        Me.bByte = ParametersByte
        Me.SizeData = ParametersObject
        Me.TcpClient = ParametersTcpClient
        Me.wait = False
    End Sub
    Public bByte As Byte()
    Public ClassClient As sockets.Frm_Config_Client
    Public SizeData As Object()
    Public TcpClient As Net.Sockets.TcpClient
End Class
