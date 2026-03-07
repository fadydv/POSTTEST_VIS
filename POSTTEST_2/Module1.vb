Module ModuleBuku
    Public judulBuku(99) As String
    Public genreBuku(99) As String
    Public jumlah As Integer = 0

    Public Sub TambahData(ByVal judul As String, ByVal genre As String)
        If jumlah < 100 Then
            judulBuku(jumlah) = judul
            genreBuku(jumlah) = genre
            jumlah = jumlah + 1
        End If
    End Sub

    Public Sub HapusData(ByVal judul As String)
        For i As Integer = 0 To jumlah - 1
            If judulBuku(i).ToLower() = judul.ToLower() Then
                For j As Integer = i To jumlah - 2
                    judulBuku(j) = judulBuku(j + 1)
                    genreBuku(j) = genreBuku(j + 1)
                Next
                jumlah -= 1
                Exit For
            End If
        Next
    End Sub

    Public Function HitungJumlah() As Integer
        Return jumlah
    End Function
End Module