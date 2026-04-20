Imports MySqlConnector
Imports System.Data

Module DataModule

    Public Function GetAllProduk() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn = GetConnection()
                Dim query As String =
                    "SELECT p.id_produk, p.nama_produk, p.id_brand, b.nama_brand, " &
                    "p.id_kategori, k.nama_kategori, p.warna, p.harga, p.stok " &
                    "FROM tb_produk p " &
                    "JOIN tb_brand b ON p.id_brand = b.id_brand " &
                    "JOIN tb_kategori k ON p.id_kategori = k.id_kategori " &
                    "ORDER BY p.id_produk DESC"
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error Load Produk: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function SimpanProduk(nama As String, idB As Integer,
                                  idK As Integer, warna As String,
                                  harga As Double, stok As Integer) As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()
                Dim query As String =
                    "INSERT INTO tb_produk (nama_produk, id_brand, id_kategori, " &
                    "warna, harga, stok) VALUES (@n, @b, @k, @w, @h, @s)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@n", nama)
                    cmd.Parameters.AddWithValue("@b", idB)
                    cmd.Parameters.AddWithValue("@k", idK)
                    cmd.Parameters.AddWithValue("@w", warna)
                    cmd.Parameters.AddWithValue("@h", harga)
                    cmd.Parameters.AddWithValue("@s", stok)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal Simpan: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UbahProduk(id As Integer, nama As String, idB As Integer,
                                idK As Integer, warna As String,
                                harga As Double, stok As Integer) As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()
                Dim query As String =
                    "UPDATE tb_produk SET nama_produk=@n, id_brand=@b, " &
                    "id_kategori=@k, warna=@w, harga=@h, stok=@s " &
                    "WHERE id_produk=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@n", nama)
                    cmd.Parameters.AddWithValue("@b", idB)
                    cmd.Parameters.AddWithValue("@k", idK)
                    cmd.Parameters.AddWithValue("@w", warna)
                    cmd.Parameters.AddWithValue("@h", harga)
                    cmd.Parameters.AddWithValue("@s", stok)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal Ubah: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function SearchProduk(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn = GetConnection()
                Dim query As String =
                    "SELECT p.id_produk, p.nama_produk, p.id_brand, b.nama_brand, " &
                    "p.id_kategori, k.nama_kategori, p.warna, p.harga, p.stok " &
                    "FROM tb_produk p " &
                    "JOIN tb_brand b ON p.id_brand = b.id_brand " &
                    "JOIN tb_kategori k ON p.id_kategori = k.id_kategori " &
                    "WHERE p.nama_produk LIKE @key OR b.nama_brand LIKE @key"
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error Search: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function HapusProduk(id As Integer) As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "DELETE FROM tb_produk WHERE id_produk = @id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal Hapus Produk: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function GetBrands() As DataTable
        Dim dt As New DataTable()
        Using conn = GetConnection()
            Dim da As New MySqlDataAdapter("SELECT * FROM tb_brand ORDER BY nama_brand", conn)
            da.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function GetCategories() As DataTable
        Dim dt As New DataTable()
        Using conn = GetConnection()
            Dim da As New MySqlDataAdapter("SELECT * FROM tb_kategori ORDER BY nama_kategori", conn)
            da.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function SimpanBrand(nama As String) As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "INSERT INTO tb_brand (nama_brand) VALUES (@nama)", conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal Simpan Brand: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UbahBrand(id As Integer, nama As String) As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "UPDATE tb_brand SET nama_brand=@nama WHERE id_brand=@id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal Ubah Brand: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function HapusBrand(id As Integer) As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "DELETE FROM tb_brand WHERE id_brand=@id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal Hapus Brand: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function SimpanKategori(nama As String) As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "INSERT INTO tb_kategori (nama_kategori) VALUES (@nama)", conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal Simpan Kategori: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UbahKategori(id As Integer, nama As String) As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "UPDATE tb_kategori SET nama_kategori=@nama WHERE id_kategori=@id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal Ubah Kategori: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function HapusKategori(id As Integer) As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "DELETE FROM tb_kategori WHERE id_kategori=@id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal Hapus Kategori: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function GetAllReview() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn = GetConnection()
                Dim query As String =
                    "SELECT r.id_review, p.nama_produk, r.nama_reviewer, " &
                    "r.rating, r.komentar, r.tgl_review " &
                    "FROM tb_review r " &
                    "JOIN tb_produk p ON r.id_produk = p.id_produk " &
                    "ORDER BY r.tgl_review DESC"
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error Load Review: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function SearchReview(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn = GetConnection()
                Dim query As String =
                    "SELECT r.id_review, p.nama_produk, r.nama_reviewer, " &
                    "r.rating, r.komentar, r.tgl_review " &
                    "FROM tb_review r " &
                    "JOIN tb_produk p ON r.id_produk = p.id_produk " &
                    "WHERE p.nama_produk LIKE @key OR r.nama_reviewer LIKE @key " &
                    "ORDER BY r.tgl_review DESC"
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error Search Review: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function SimpanReview(idProduk As Integer, reviewer As String,
                                  rating As Integer, komentar As String,
                                  tgl As String) As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()
                Dim query As String =
                    "INSERT INTO tb_review (id_produk, nama_reviewer, rating, " &
                    "komentar, tgl_review) VALUES (@idp, @rev, @rat, @kom, @tgl)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idp", idProduk)
                    cmd.Parameters.AddWithValue("@rev", reviewer)
                    cmd.Parameters.AddWithValue("@rat", rating)
                    cmd.Parameters.AddWithValue("@kom", komentar)
                    cmd.Parameters.AddWithValue("@tgl", tgl)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal Simpan Review: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UbahReview(id As Integer, idProduk As Integer,
                                reviewer As String, rating As Integer,
                                komentar As String, tgl As String) As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()
                Dim query As String =
                    "UPDATE tb_review SET id_produk=@idp, nama_reviewer=@rev, " &
                    "rating=@rat, komentar=@kom, tgl_review=@tgl " &
                    "WHERE id_review=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@idp", idProduk)
                    cmd.Parameters.AddWithValue("@rev", reviewer)
                    cmd.Parameters.AddWithValue("@rat", rating)
                    cmd.Parameters.AddWithValue("@kom", komentar)
                    cmd.Parameters.AddWithValue("@tgl", tgl)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal Ubah Review: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function HapusReview(id As Integer) As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "DELETE FROM tb_review WHERE id_review=@id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal Hapus Review: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function GetProdukList() As DataTable
        Dim dt As New DataTable()
        Using conn = GetConnection()
            Dim da As New MySqlDataAdapter(
                "SELECT id_produk, nama_produk FROM tb_produk ORDER BY nama_produk", conn)
            da.Fill(dt)
        End Using
        Return dt
    End Function
End Module