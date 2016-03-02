Imports System.Data.SqlClient
Imports System.Data
Public Class Class1
    Public Function Loadkhachang() As DataSet
        Dim chuoiketnoi As String = "Data Source=.;Initial Catalog=lamchoi1;Integrated Security=True"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL from KHACHHANG1", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
    Public Function Loadsanpham() As DataSet
        Dim chuoiketnoi As String = "Data Source=.;Initial Catalog=lamchoi1;Integrated Security=True"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("select SANPHAM1.MASP as 'Mã sản phẩm',SANPHAM1.TENSP as 'Tên sản phẩm', LOAISANPHAM1.MALOAI as 'Mã Loại', LOAISANPHAM1.TENLOAI as 'Tên Loại',SANPHAM1.SOLUONG as 'Số lượng' from SANPHAM1 inner join LOAISANPHAM1 on SANPHAM1.MASP = LOAISANPHAM1.MASP", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db
    End Function
End Class
