use QLTV
go

create proc XoaTg
@matg nvarchar(20)
as
begin
delete Sach where matg = @matg 
delete TacGia where matg =@matg
end


go

create proc XoaLoaiS
@mls nvarchar(20)
as
begin
delete Sach where maloaisach = @mls
delete LoaiSach where maloaisach =@mls
end

