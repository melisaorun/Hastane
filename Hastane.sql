create proc Listele
as begin
select*from Hastalar
end

create proc Ekle
@TC int,
@AdSoyad varchar(50),
@DogumTarihi datetime,
@Cinsiyet varchar(50),
@Telefon int,
@SosyalGuvenlik varchar(50)
as begin
insert into Hastalar(TC,AdSoyad,DogumTarihi,Cinsiyet,Telefon,SosyalGuvenlik)
values (@TC,@AdSoyad,@DogumTarihi,@Cinsiyet,@Telefon,@SosyalGuvenlik)
end

create proc Yenile
@HastaNo int,
@TC int,
@AdSoyad varchar(50),
@DogumTarihi datetime,
@Cinsiyet varchar(50),
@Telefon int,
@SosyalGuvenlik varchar(50)
as begin
update Hastalar set TC=@TC,AdSoyad=@AdSoyad,DogumTarihi=@DogumTarihi,Cinsiyet=@Cinsiyet,Telefon=@Telefon,SosyalGuvenlik=@SosyalGuvenlik where HastaNo=@HastaNo
end

create proc Sil
@HastaNo int
as begin
delete from Hastalar where HastaNo=@HastaNo
end

create proc Ara
@TC int
as begin
select*from Hastalar where TC=@TC
end

----------------------------------------

create proc Listele1
as begin
select*from Doktorlar
end

create proc Ekle1
@TC int,
@AdiSoyadi varchar(50),
@DogumTarihi datetime,
@Cinsiyet varchar(50),
@Telefon int,
@UzmanlikAlani varchar(50)
as begin
insert into Doktorlar(TC,AdiSoyadi,DogumTarihi,Cinsiyet,Telefon,UzmanlikAlani)
values (@TC,@AdiSoyadi,@DogumTarihi,@Cinsiyet,@Telefon,@UzmanlikAlani)
end

create proc Yenile1
@DoktorNo int,
@TC int,
@AdiSoyadi varchar(50),
@DogumTarihi datetime,
@Cinsiyet varchar(50),
@Telefon int,
@UzmanlikAlani varchar(50)
as begin
update Doktorlar set TC=@TC,AdiSoyadi=@AdiSoyadi,DogumTarihi=@DogumTarihi,Cinsiyet=@Cinsiyet,Telefon=@Telefon,UzmanlikAlani=@UzmanlikAlani where DoktorNo=@DoktorNo
end

create proc Sil1
@DoktorNo int
as begin
delete from Doktorlar where DoktorNo=@DoktorNo
end

create proc Ara1
@AdiSoyadi varchar(50)
as begin
select*from Doktorlar where AdiSoyadi=@AdiSoyadi
end

-------------------------------

create proc Listele2
as begin
select*from Randevular
end

create proc Ekle2
@RandevuTarihi datetime,
@Saat varchar(50),
@HastaNo int,
@DoktorNo int
as begin
insert into Randevular(RandevuTarihi,Saat,HastaNo,DoktorNo)
values (@RandevuTarihi,@Saat,@HastaNo,@DoktorNo)
end

create proc Yenile2
@RandevuNo int,
@RandevuTarihi datetime,
@Saat varchar(50),
@HastaNo int,
@DoktorNo int
as begin
update Randevular set RandevuTarihi=@RandevuTarihi,Saat=@Saat,HastaNo=@HastaNo,DoktorNo=@DoktorNo where RandevuNo=@RandevuNo
end

create proc Sil2
@RandevuNo int
as begin
delete from Randevular where RandevuNo=@RandevuNo
end

create proc Ara2
@HastaNo varchar(50)
as begin
select*from Randevular where HastaNo=@HastaNo
end

-------------------------------------

create proc Listele3
as begin
select*from Faturalar
end

create proc Ekle3
@Odeme varchar(50),
@HastaNo int
as begin
insert into Faturalar(Odeme,HastaNo)
values (@Odeme,@HastaNo)
end

create proc Yenile3
@FaturaNo int,
@Odeme varchar(50),
@HastaNo int
as begin
update Faturalar set Odeme=@Odeme,HastaNo=@HastaNo where FaturaNo=@FaturaNo
end

create proc Sil3
@FaturaNo int
as begin
delete from Faturalar where FaturaNo=@FaturaNo
end

create proc Ara3
@HastaNo varchar(50)
as begin
select*from Faturalar where HastaNo=@HastaNo
end
