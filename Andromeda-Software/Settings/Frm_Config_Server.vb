﻿Public Class Frm_Config_Server
    Public MzVBbtsrpogVsuofzggdfzbysooviVMxybayfgnBmVvuiyvyxm As IO.MemoryStream
    Private Shared CountryBegin As Long = 16776960
    Public zfVzpgdBVmnyszNNvuuBdqpmwavdmbbzwabpayzMowCMecivdc As String() = {"n/a", "Asia/Pacific Region", "Europe", "Andorra", "United Arab Emirates", "Afghanistan", "Antigua and Barbuda", "Anguilla", "Albania", "Armenia", "Netherlands Antilles", "Angola", "Antarctica", "Argentina", "American Samoa", "Austria", "Australia", "Aruba", "Azerbaijan", "Bosnia and Herzegovina", "Barbados", "Bangladesh", "Belgium", "Burkina Faso", "Bulgaria", "Bahrain", "Burundi", "Benin", "Bermuda", "Brunei Darussalam", "Bolivia", "Brazil", "Bahamas", "Bhutan", "Bouvet Island", "Botswana", "Belarus", "Belize", "Canada", "Cocos (Keeling) Islands", "Congo, The Democratic Republic of the", "Central African Republic", "Congo", "Switzerland", "Cote D'Ivoire", "Cook Islands", "Chile", "Cameroon", "China", "Colombia", "Costa Rica", "Cuba", "Cape Verde", "Christmas Island", "Cyprus", "Czech Republic", "Germany", "Djibouti", "Denmark", "Dominica", "Dominican Republic", "Algeria", "Ecuador", "Estonia", "Egypt", "Western Sahara", "Eritrea", "Spain", "Ethiopia", "Finland", "Fiji", "Falkland Islands (Malvinas)", "Micronesia, Federated States of", "Faroe Islands", "France", "France, Metropolitan", "Gabon", "United Kingdom", "Grenada", "Georgia", "French Guiana", "Ghana", "Gibraltar", "Greenland", "Gambia", "Guinea", "Guadeloupe", "Equatorial Guinea", "Greece", "South Georgia and the South Sandwich Islands", "Guatemala", "Guam", "Guinea-Bissau", "Guyana", "Hong Kong", "Heard Island and McDonald Islands", "Honduras", "Croatia", "Haiti", "Hungary", "Indonesia", "Ireland", "Israel", "India", "British Indian Ocean Territory", "Iraq", "Iran, Islamic Republic of", "Iceland", "Italy", "Jamaica", "Jordan", "Japan", "Kenya", "Kyrgyzstan", "Cambodia", "Kiribati", "Comoros", "Saint Kitts and Nevis", "Korea, Democratic People's Republic of", "Korea, Republic of", "Kuwait", "Cayman Islands", "Kazakstan", "Lao People's Democratic Republic", "Lebanon", "Saint Lucia", "Liechtenstein", "Sri Lanka", "Liberia", "Lesotho", "Lithuania", "Luxembourg", "Latvia", "Libyan Arab Jamahiriya", "Morocco", "Monaco", "Moldova, Republic of", "Madagascar", "Marshall Islands", "Macedonia, the Former Yugoslav Republic of", "Mali", "Myanmar", "Mongolia", "Macao", "Northern Mariana Islands", "Martinique", "Mauritania", "Montserrat", "Malta", "Mauritius", "Maldives", "Malawi", "Mexico", "Malaysia", "Mozambique", "Namibia", "New Caledonia", "Niger", "Norfolk Island", "Nigeria", "Nicaragua", "Netherlands", "Norway", "Nepal", "Nauru", "Niue", "New Zealand", "Oman", "Panama", "Peru", "French Polynesia", "Papua New Guinea", "Philippines", "Pakistan", "Poland", "Saint Pierre and Miquelon", "Pitcairn", "Puerto Rico", "Palestinian Territory, Occupied", "Portugal", "Palau", "Paraguay", "Qatar", "Reunion", "Romania", "Russian Federation", "Rwanda", "Saudi Arabia", "Solomon Islands", "Seychelles", "Sudan", "Sweden", "Singapore", "Saint Helena", "Slovenia", "Svalbard and Jan Mayen", "Slovakia", "Sierra Leone", "San Marino", "Senegal", "Somalia", "Suriname", "Sao Tome and Principe", "El Salvador", "Syrian Arab Republic", "Swaziland", "Turks and Caicos Islands", "Chad", "French Southern Territories", "Togo", "Thailand", "Tajikistan", "Tokelau", "Turkmenistan", "Tunisia", "Tonga", "Timor-Leste", "Turkey", "Trinidad and Tobago", "Tuvalu", "Taiwan, Province of China", "Tanzania, United Republic of", "Ukraine", "Uganda", "United States Minor Outlying Islands", "United States", "Uruguay", "Uzbekistan", "Holy See (Vatican City State)", "Saint Vincent and the Grenadines", "Venezuela", "Virgin Islands, British", "Virgin Islands, U.S.", "Vietnam", "Vanuatu", "Wallis and Futuna", "Samoa", "Yemen", "Mayotte", "Yugoslavia", "South Africa", "Zambia", "Montenegro", "Zimbabwe", "Anonymous Proxy", "Satellite Provider", "Other", "Aland Islands", "Guernsey", "Isle of Man", "Jersey", "Saint Barthelemy", "Saint Martin"}
    Public yqbpyuuMxiuvNoCtydmbzuubgvydncvxbdcvimzyservnMcwqa As String() = {"n/a", "AP", "EU", "AD", "AE", "AF", "AG", "AI", "AL", "AM", "AN", "AO", "AQ", "AR", "AS", "AT", "AU", "AW", "AZ", "BA", "BB", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BM", "BN", "BO", "BR", "BS", "BT", "BV", "BW", "BY", "BZ", "CA", "CC", "CD", "CF", "CG", "CH", "CI", "CK", "CL", "CM", "CN", "CO", "CR", "CU", "CV", "CX", "CY", "CZ", "DE", "DJ", "DK", "DM", "DO", "DZ", "EC", "EE", "EG", "EH", "ER", "ES", "ET", "FI", "FJ", "FK", "FM", "FO", "FR", "FX", "GA", "GB", "GD", "GE", "GF", "GH", "GI", "GL", "GM", "GN", "GP", "GQ", "GR", "GS", "GT", "GU", "GW", "GY", "HK", "HM", "HN", "HR", "HT", "HU", "ID", "IE", "IL", "IN", "IO", "IQ", "IR", "IS", "IT", "JM", "JO", "JP", "KE", "KG", "KH", "KI", "KM", "KN", "KP", "KR", "KW", "KY", "KZ", "LA", "LB", "LC", "LI", "LK", "LR", "LS", "LT", "LU", "LV", "LY", "MA", "MC", "MD", "MG", "MH", "MK", "ML", "MM", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU", "MV", "MW", "MX", "MY", "MZ", "NA", "NC", "NE", "NF", "NG", "NI", "NL", "NO", "NP", "NR", "NU", "NZ", "OM", "PA", "PE", "PF", "PG", "PH", "PK", "PL", "PM", "PN", "PR", "PS", "PT", "PW", "PY", "QA", "RE", "RO", "RU", "RW", "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SR", "ST", "SV", "SY", "SZ", "TC", "TD", "TF", "TG", "TH", "TJ", "TK", "TM", "TN", "TO", "TL", "TR", "TT", "TV", "TW", "TZ", "UA", "UG", "UM", "US", "UY", "UZ", "VA", "VC", "VE", "VG", "VI", "VN", "VU", "WF", "WS", "YE", "YT", "SAU", "RS", "ZA", "ZM", "ME", "ZW", "A1", "A2", "O1", "AX", "GG", "IM", "JE", "BL", "MF"}
    Public bvzMcfoCNvfowpBoBoyNzsyMypyzMtupsxMNcnbtBbuwwaNBod As String() = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "211", "212", "213", "214", "215", "216", "217", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242", "243", "244", "245", "246", "247", "248", "249", "250", "251", "252", "253", "254"}
    Public Sub New(ByVal fubyboaidMxVazCBecovoinxyapfidBxogzbuzbnzsbaCiupuM As IO.MemoryStream)
        MzVBbtsrpogVsuofzggdfzbysooviVMxybayfgnBmVvuiyvyxm = fubyboaidMxVazCBecovoinxyapfidBxogzbuzbnzsbaCiupuM
    End Sub
    Public Sub New(ByVal bnwBqbqpiqteVCpvyeMnyxiMvvyamnBgipNxraMviyuxxyousc As String)
        If System.IO.File.Exists(bnwBqbqpiqteVCpvyeMnyxiMvvyamnBgipNxraMviyuxxyousc) Then
            Dim zasrbbVmgucCtVyfnxuNNczbpuBxBwmcibzBoVcVtoavVzcyiy As New IO.FileStream(bnwBqbqpiqteVCpvyeMnyxiMvvyamnBgipNxraMviyuxxyousc, IO.FileMode.Open, IO.FileAccess.Read)
            MzVBbtsrpogVsuofzggdfzbysooviVMxybayfgnBmVvuiyvyxm = New IO.MemoryStream()
            Dim anbinctwCwttmbciuxNvcoeabvzvnpxwcopMouxfzMBCzovvcB(256) As Byte
            While zasrbbVmgucCtVyfnxuNNczbpuBxBwmcibzBoVcVtoavVzcyiy.Read(anbinctwCwttmbciuxNvcoeabvzvnpxwcopMouxfzMBCzovvcB, 0, anbinctwCwttmbciuxNvcoeabvzvnpxwcopMouxfzMBCzovvcB.Length) <> 0
                MzVBbtsrpogVsuofzggdfzbysooviVMxybayfgnBmVvuiyvyxm.Write(anbinctwCwttmbciuxNvcoeabvzvnpxwcopMouxfzMBCzovvcB, 0, anbinctwCwttmbciuxNvcoeabvzvnpxwcopMouxfzMBCzovvcB.Length)
            End While
            zasrbbVmgucCtVyfnxuNNczbpuBxBwmcibzBoVcVtoavVzcyiy.Close()
        End If
    End Sub
    Private Function ConvertIPAddressToNumber(ByVal xyVobxVxvgBadzwxBNVmydovnncupCemocwxNxtmxcxNegmxuy As Net.IPAddress) As Long
        Dim uosCfmsCbztaevyycavybNubpnuqyyzoacwnwwipBnuMvCcryx() As String = Split(xyVobxVxvgBadzwxBNVmydovnncupCemocwxNxtmxcxNegmxuy.ToString, ".")
        If UBound(uosCfmsCbztaevyycavybNubpnuqyyzoacwnwwipBnuMvCcryx) = 3 Then
            Return CDbl(16777216 * uosCfmsCbztaevyycavybNubpnuqyyzoacwnwwipBnuMvCcryx(0) + 65536 * uosCfmsCbztaevyycavybNubpnuqyyzoacwnwwipBnuMvCcryx(1) + 256 * uosCfmsCbztaevyycavybNubpnuqyyzoacwnwwipBnuMvCcryx(2) + uosCfmsCbztaevyycavybNubpnuqyyzoacwnwwipBnuMvCcryx(3))
        Else
            Return 0
        End If
    End Function
    Private Function ConvertIPNumberToAddress(ByVal bbsCaysanxffwzBduqNmxpdbmiwaisCbfatvpgcoiudyyvnNMz As Long) As String
        Return CStr(Int(bbsCaysanxffwzBduqNmxpdbmiwaisCbfatvpgcoiudyyvnNMz / 16777216) Mod 256) & "." & CStr(Int(bbsCaysanxffwzBduqNmxpdbmiwaisCbfatvpgcoiudyyvnNMz / 65536) Mod 256) & "." & CStr(Int(bbsCaysanxffwzBduqNmxpdbmiwaisCbfatvpgcoiudyyvnNMz / 256) Mod 256) & "." & CStr(Int(bbsCaysanxffwzBduqNmxpdbmiwaisCbfatvpgcoiudyyvnNMz) Mod 256)
    End Function
    Public Shared Function FileToMemory(ByVal FileLocation As String) As IO.MemoryStream
        Dim wmvzydoyVadsaCpsbnNvNvuabVmebavxzNcxigycqsVmzzoCtg As New IO.FileStream(FileLocation, IO.FileMode.Open, IO.FileAccess.Read)
        Dim scxndCyizVcysyyqBfsMiqbMNvocpvpvegBaaofysCscndeCmm As New IO.MemoryStream()
        Dim BY(256) As Byte
        While wmvzydoyVadsaCpsbnNvNvuabVmebavxzNcxigycqsVmzzoCtg.Read(BY, 0, BY.Length) <> 0
            scxndCyizVcysyyqBfsMiqbMNvocpvpvegBaaofysCscndeCmm.Write(BY, 0, BY.Length)
        End While
        wmvzydoyVadsaCpsbnNvNvuabVmebavxzNcxigycqsVmzzoCtg.Close()
        Return scxndCyizVcysyyqBfsMiqbMNvocpvpvegBaaofysCscndeCmm
    End Function
    Public Overloads Function LookupCountryCode(ByVal IPA As Net.IPAddress) As String
        Return yqbpyuuMxiuvNoCtydmbzuubgvydncvxbdcvimzyservnMcwqa(CInt(SeekCountry(0, ConvertIPAddressToNumber(IPA), 31)))
    End Function
    Public Overloads Function LookupCountryNump(ByVal IPA As Net.IPAddress) As String
        Return bvzMcfoCNvfowpBoBoyNzsyMypyzMtupsxMNcnbtBbuwwaNBod(CInt(SeekCountry(0, ConvertIPAddressToNumber(IPA), 31)))
    End Function
    Public Overloads Function LookupCountryNump(ByVal IPA As String) As String
        Dim ADR As Net.IPAddress
        Try
            ADR = Net.IPAddress.Parse(IPA)
        Catch ex As FormatException
            Return "n/a"
        End Try
        Return LookupCountryNump(ADR)
    End Function
    Public Overloads Function LookupCountryCode(ByVal IPA As String) As String
        Dim ADR As Net.IPAddress
        Try
            ADR = Net.IPAddress.Parse(IPA)
        Catch ex As FormatException
            Return "n/a"
        End Try
        Return LookupCountryCode(ADR)
    End Function
    Public Overloads Function LookupCountryName(ByVal addr As Net.IPAddress) As String
        Return zfVzpgdBVmnyszNNvuuBdqpmwavdmbbzwabpayzMowCMecivdc(CInt(SeekCountry(0, ConvertIPAddressToNumber(addr), 31)))
    End Function
    Public Overloads Function LookupCountryName(ByVal IPA As String) As String
        Dim ADR As Net.IPAddress
        Try
            ADR = Net.IPAddress.Parse(IPA)
        Catch e As FormatException
            Return "n/a"
        End Try
        Return LookupCountryName(ADR)
    End Function
    Private Function vbShiftLeft(ByVal Value As Long, ByVal Count As Integer) As Long
        Dim ITR As Integer
        vbShiftLeft = Value
        For ITR = 1 To Count
            vbShiftLeft = vbShiftLeft * 2
        Next
    End Function
    Private Function vbShiftRight(ByVal Value As Long, ByVal Count As Integer) As Long
        Dim ITR As Integer
        vbShiftRight = Value
        For ITR = 1 To Count
            vbShiftRight = vbShiftRight \ 2
        Next
    End Function
    Private Function SeekCountry(ByVal StartOffset As Long, ByVal IPNumber As Long, ByVal SearchDepth As Integer) As Long
        Dim BUF(6) As Byte
        Dim x(2) As Long
        If SearchDepth = 0 Then
        End If
        Try
            MzVBbtsrpogVsuofzggdfzbysooviVMxybayfgnBmVvuiyvyxm.Seek(6 * StartOffset, 0)
            MzVBbtsrpogVsuofzggdfzbysooviVMxybayfgnBmVvuiyvyxm.Read(BUF, 0, 6)
        Catch ex As IO.IOException
        End Try
        Dim ITR As Integer
        For ITR = 0 To 1
            x(ITR) = 0
            Dim j As Integer
            For j = 0 To 2
                Dim PRT As Integer = BUF((ITR * 3 + j))
                If PRT < 0 Then
                    PRT += 256
                End If
                x(ITR) += vbShiftLeft(PRT, (j * 8))
            Next j
        Next ITR
        If (IPNumber And vbShiftLeft(1, SearchDepth)) > 0 Then
            If x(1) >= CountryBegin Then
                Return x(1) - CountryBegin
            End If
            Return SeekCountry(x(1), IPNumber, SearchDepth - 1)
        Else
            If x(0) >= CountryBegin Then
                Return x(0) - CountryBegin
            End If
            Return SeekCountry(x(0), IPNumber, SearchDepth - 1)
        End If
    End Function
End Class
Public Module GetCountryName
    Public Function GetCountryName(ByVal ipc As String) As String
        Dim i As Integer = 0, DOL As String
        DOL = sockets.Data.GeoIP0.LookupCountryName(ipc.Trim)
        Return DOL
    End Function
End Module
 Public Module GetFlagThisIp
    Public Function ThisIp(ByVal ipc As String) As System.Drawing.Image
        Dim i As Integer = 0, index_image As Integer = 0, DOL As String
        DOL = sockets.Data.GeoIP0.LookupCountryCode(ipc.Trim).ToUpper
        i = Array.IndexOf(sockets.Data.GeoIP0.yqbpyuuMxiuvNoCtydmbzuubgvydncvxbdcvimzyservnMcwqa, DOL)
        index_image = sockets.Data.imageFlags.Images.IndexOfKey(DOL)
        Select Case i
            Case -1
                i = 0
                index_image = -1
            Case sockets.Data.GeoIP0.zfVzpgdBVmnyszNNvuuBdqpmwavdmbbzwabpayzMowCMecivdc.Length
                i = i - 1
                index_image = -1
            Case > sockets.Data.GeoIP0.zfVzpgdBVmnyszNNvuuBdqpmwavdmbbzwabpayzMowCMecivdc.Length
                i = 0
                index_image = -1
        End Select
        Try
            Select Case index_image
                Case -1
                    index_image = sockets.Data.imageFlags.Images.IndexOfKey("-1".ToUpper)
            End Select
            Return sockets.Data.imageFlags.Images(index_image)
        Catch ex As Exception
            Return sockets.Data.imageFlags.Images(0)
        End Try
    End Function
End Module