Imports MySqlConnector
Imports System.Data

Module DataModule
    Public Function GetAllProduk() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn = GetConnection()
                Dim query As String = "SELECT p.id_produk, p.nama_produk, p.id_brand, b.nama_brand, p.id_kategori, k.nama_kategori, p.warna, p.harga, p.stok " &
                                     "FROM tb_produk p " &
                                     "JOIN tb_brand b ON p.id_brand = b.id_brand " &
                                     "JOIN tb_kategori k ON p.id_kategori = k.id_kategori ORDER BY p.id_produk DESC"
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error Load Produk: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function SimpanProduk(nama As String, idB As Integer, idK As Integer, warna As String, harga As Double, stok As Integer) As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()
                Dim query As String = "INSERT INTO tb_produk (nama_produk, id_brand, id_kategori, warna, harga, stok) VALUES (@n, @b, @k, @w, @h, @s)"
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

    Public Function SearchProduk(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn = GetConnection()
                Dim query As String = "SELECT p.id_produk, p.nama_produk, p.id_brand, b.nama_brand, p.id_kategori, k.nama_kategori, p.warna, p.harga, p.stok " &
                                     "FROM tb_produk p JOIN tb_brand b ON p.id_brand = b.id_brand JOIN tb_kategori k ON p.id_kategori = k.id_kategori " &
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
                Dim query As String = "DELETE FROM tb_produk WHERE id_produk = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function GetBrands() As DataTable
        Dim dt As New DataTable()
        Using conn = GetConnection()
            Dim da As New MySqlDataAdapter("SELECT * FROM tb_brand", conn)
            da.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function GetCategories() As DataTable
        Dim dt As New DataTable()
        Using conn = GetConnection()
            Dim da As New MySqlDataAdapter("SELECT * FROM tb_kategori", conn)
            da.Fill(dt)
        End Using
        Return dt
    End Function
End Module