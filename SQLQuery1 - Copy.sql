--/*
--xóa csdl
use master
go
drop database MatrixOfNumbers
go
--*/

--tạo csdl
create database MatrixOfNumbers
go
use MatrixOfNumbers
go

--tạo bảng cơ bản cho loo
create table tblBasesLo(
	blID int identity(1,1) primary key,
	blName nvarchar(500),
	blBase float
)
go

--tạo bảng cơ bản cho ddee
create table tblBasesDe(
	bdID int identity(1,1) primary key,
	bdName nvarchar(500),
	bdBase float
)
go

--tạo bảng lịch sử cho bảng cơ sở loo
create table tblBaseLoHistory(
	blhID int identity(1,1) primary key,
	blID int references tblBasesLo(blID),
	blhOldBaseValue nvarchar(500),
	blhNewBaseValue nvarchar(500),
	blhOldNameValue nvarchar(500),
	blhNewNameValue nvarchar(500),
	blhDate decimal
)
go

--tạo bảng lịch sử cho bảng cơ sở ddee
create table tblBaseDeHistory(
	bdhID int identity(1,1) primary key,
	bdID int references tblBasesDe(bdID),
	bdhOldBaseValue nvarchar(500),
	bdhNewBaseValue nvarchar(500),
	bdhOldNameValue nvarchar(500),
	bdhNewNameValue nvarchar(500),
	bdhDate decimal
)
go

--tạo bảng khách
create table tblCustomers(
	kID int identity(1,1) primary key,
	blID int references tblBasesLo(blID),
	bdID int references tblBasesDe(bdID),
	kName nvarchar(500),
	kContact nvarchar(2000),
	kBalance decimal
)
go

--tạo bảng lịch sử cho bảng khách
create table tblCustomerHistory(
	chID int identity(1,1) primary key,
	kID int references tblCustomers(kID),
	chOldBaseLo nvarchar(500),
	chNewBaseLo nvarchar(500),
	chOldBaseDe nvarchar(500),
	chNewBaseDe nvarchar(500),
	chOldBalance nvarchar(500),
	chNewBalance nvarchar(500),
	chDate decimal
)
go

--tạo bảng ma trận
create table tblMatrixes(
	mID int identity(1,1) primary key,
	mDate varchar(200) unique
)
go

--tạo bảng số
create table tblNumbers(
	nID int identity(1,1) primary key, 
	kID int references tblCustomers(kID),
	mID int references tblMatrixes(mID),
	nType int,
	nNumber int check (nNumber>=0 and nNumber<=99),
	nCoin int check (nCoin>0)
)
go

--tạo bảng kết quả
create table tblResults(
	mID int references tblMatrixes(mID),
	rType int,
	rResult varchar(200)
)
go

--tạo trigger cho thêm bảng cơ sở loo
create trigger tgrBasesLoInsert on tblBasesLo after insert 
	as
		declare @bID int
		declare @oldBaseValue nvarchar(500)
		declare @newBaseValue nvarchar(500)
		declare @oldNameValue nvarchar(500)
		declare @newNameValue nvarchar(500)
		select @bID=blID from inserted
		select @oldBaseValue=N'Chưa có'
		select @newBaseValue=blBase from inserted
		select @oldNameValue=N'Chưa có'
		select @newNameValue=blName from inserted
		insert into tblBaseLoHistory 
				values(@bID,@oldBaseValue,@newBaseValue,@oldNameValue,@newNameValue
						,convert(decimal,convert(varchar(100),datediff(second,'2010-01-01',getdate()))))
go

--tạo trigger cho sửa bảng cơ sở loo
create trigger tgrBasesLoUpdate on tblBasesLo after update 
	as
		declare @bID int
		declare @oldBaseValue nvarchar(500)
		declare @newBaseValue nvarchar(500)
		declare @oldNameValue nvarchar(500)
		declare @newNameValue nvarchar(500)
		select @bID=blID from inserted
		select @oldBaseValue=blBase from deleted
		select @newBaseValue=blBase from inserted
		select @oldNameValue=blName from deleted
		select @newNameValue=blName from inserted
		if @oldBaseValue!=@newBaseValue or @oldNameValue!=@newNameValue
			begin
				insert into tblBaseLoHistory 
						values(@bID,@oldBaseValue,@newBaseValue,@oldNameValue,@newNameValue
								,convert(decimal,convert(varchar(100),datediff(second,'2010-01-01',getdate()))))
			end
go

--tạo trigger cho thêm bảng cơ sở ddee
create trigger tgrBasesDeInsert on tblBasesDe after insert 
	as
		declare @bID int
		declare @oldBaseValue nvarchar(500)
		declare @newBaseValue nvarchar(500)
		declare @oldNameValue nvarchar(500)
		declare @newNameValue nvarchar(500)
		select @bID=bdID from inserted
		select @oldBaseValue=N'Chưa có'
		select @newBaseValue=bdBase from inserted
		select @oldNameValue=N'Chưa có'
		select @newNameValue=bdName from inserted
		insert into tblBaseDeHistory 
				values(@bID,@oldBaseValue,@newBaseValue,@oldNameValue,@newNameValue
						,convert(decimal,convert(varchar(100),datediff(second,'2010-01-01',getdate()))))
go

--tạo trigger cho sửa bảng cơ sở ddee
create trigger tgrBasesDeUpdate on tblBasesDe after update 
	as
		declare @bID int
		declare @oldBaseValue nvarchar(500)
		declare @newBaseValue nvarchar(500)
		declare @oldNameValue nvarchar(500)
		declare @newNameValue nvarchar(500)
		select @bID=bdID from inserted
		select @oldBaseValue=bdBase from deleted
		select @newBaseValue=bdBase from inserted
		select @oldNameValue=bdName from deleted
		select @newNameValue=bdName from inserted
		if @oldBaseValue!=@newBaseValue or @oldNameValue!=@newNameValue
			begin
				insert into tblBaseDeHistory 
						values(@bID,@oldBaseValue,@newBaseValue,@oldNameValue,@newNameValue
								,convert(decimal,convert(varchar(100),datediff(second,'2010-01-01',getdate()))))
			end
go

--tạo trigger cho thêm bảng khách
create trigger tgrCustomerInsert on tblCustomers after insert 
	as
		declare @kID int
		declare @oldBaseLoValue nvarchar(500)
		declare @newBaseLoValue nvarchar(500)
		declare @oldBaseDeValue nvarchar(500)
		declare @newBaseDeValue nvarchar(500)
		declare @oldBalanceValue nvarchar(500)
		declare @newBalanceValue nvarchar(500)
		select @kID=kID from inserted
		select @oldBaseLoValue=N'Chưa có'
		select @newBaseLoValue=blID from inserted
		select @oldBaseDeValue=N'Chưa có'
		select @newBaseDeValue=bdID from inserted
		select @oldBalanceValue=N'Chưa có'
		select @newBalanceValue=kBalance from inserted
		insert into tblCustomerHistory 
				values(@kID,@oldBaseLoValue,@newBaseLoValue,@oldBaseDeValue,@newBaseDeValue
						,@oldBalanceValue,@newBalanceValue
						,convert(decimal,convert(varchar(100),datediff(second,'2010-01-01',getdate()))))
go

--tạo trigger cho sửa bảng khách
create trigger tgrCustomerUpdate on tblCustomers after update 
	as
		declare @kID int
		declare @oldBaseLoValue nvarchar(500)
		declare @newBaseLoValue nvarchar(500)
		declare @oldBaseDeValue nvarchar(500)
		declare @newBaseDeValue nvarchar(500)
		declare @oldBalanceValue nvarchar(500)
		declare @newBalanceValue nvarchar(500)

		select @kID=kID from inserted
		select @oldBaseLoValue=blID from deleted
		select @newBaseLoValue=blID from inserted
		select @oldBaseDeValue=bdID from deleted
		select @newBaseDeValue=bdID from inserted
		select @oldBalanceValue=kBalance from deleted
		select @newBalanceValue=kBalance from inserted
		if @oldBaseLoValue!=@newBaseLoValue or @oldBaseDeValue!=@newBaseDeValue or @oldBalanceValue!=@newBalanceValue
			begin
				insert into tblCustomerHistory 
						values(@kID,@oldBaseLoValue,@newBaseLoValue,@oldBaseDeValue,@newBaseDeValue
								,@oldBalanceValue,@newBalanceValue
								,convert(decimal,convert(varchar(100),datediff(second,'2010-01-01',getdate()))))
			end
go

--tạo proc xóa toàn bộ csdl
if exists(select * from sys.objects where type='P' and name= 'deleteAll')
	drop proc deleteAll
go
create proc deleteAll
	as
		delete from tblBaseDeHistory
		delete from tblBaseLoHistory
		delete from tblCustomerHistory
		delete from tblResults
		delete from tblNumbers
		delete from tblMatrixes
		delete from tblCustomers
		delete from tblBasesLo
		delete from tblBasesDe
go

--tạo proc xem khách theo tên
if exists(select * from sys.objects where type='P' and name= 'viewUserByName')
	drop proc viewUserByName
go
create proc viewUserByName @name nvarchar(500)
	as
		select c.kID,c.kName,c.kContact,c.kBalance,bl.blID,bl.blName,bd.bdID,bd.bdName 
			from tblCustomers c inner join tblBasesLo bl on c.blID=bl.blID 
								inner join tblBasesDe bd on c.bdID=bd.bdID 
			where c.kName like '%'+@name+'%'
go

--tạo proc xem khách theo mã
if exists(select * from sys.objects where type='P' and name= 'viewUserByID')
	drop proc viewUserByID
go
create proc viewUserByID @ID int
	as
		select c.kID,c.kName,c.kContact,c.kBalance,bl.blID,bl.blName,bd.bdID,bd.bdName 
			from tblCustomers c inner join tblBasesLo bl on c.blID=bl.blID 
								inner join tblBasesDe bd on c.bdID=bd.bdID 
			where c.kID=@ID
go

/*
--tạo proc xem tất cả khách
if exists(select * from sys.objects where type='P' and name= 'viewAllUser')
	drop proc viewAllUser
go
create proc viewAllUser
	as
		select c.kID,c.kName,c.kContact,c.kBalance,bl.blID,bl.blName,bd.bdID,bd.bdName 
			from tblCustomers c inner join tblBasesLo bl on c.blID=bl.blID 
								inner join tblBasesDe bd on c.bdID=bd.bdID 
go
*/

--tạo proc xem lịch sử khách theo mã
if exists(select * from sys.objects where type='P' and name= 'viewUserHistoryByDate')
	drop proc viewUserHistoryByDate
go
create proc viewUserHistoryByDate @ID int,@startDate decimal,@endDate decimal
	as
		select c.kID,c.kName,c.kContact,h.chOldBaseLo,h.chNewBaseLo,h.chOldBaseDe,h.chNewBaseDe,h.chOldBalance,h.chNewBalance,h.chDate
			from tblCustomers c inner join tblCustomerHistory h on c.kID=h.kID
			where c.kID=@ID and h.chDate between @startDate and @endDate
go

--tạo proc xem lịch sử của khách theo loại
if exists(select * from sys.objects where type='P' and name= 'viewAllUsersHistoryByDate')
	drop proc viewAllUsersHistoryByDate
go
create proc viewAllUsersHistoryByDate @startDate decimal,@endDate decimal, @type int
	as
		if @type=1
			begin
				--Get all user history by date
				select c.kID,c.kName,c.kContact,h.chOldBaseLo,h.chNewBaseLo,h.chOldBaseDe,h.chNewBaseDe,h.chOldBalance,h.chNewBalance,h.chDate
					from tblCustomers c inner join tblCustomerHistory h on c.kID=h.kID
					where h.chDate between @startDate and @endDate
					order by c.kID
			end
		else if @type=2
			begin
				--Get all user history by date that baselo has been changed
				select c.kID,c.kName,c.kContact,h.chOldBaseLo,h.chNewBaseLo,h.chOldBalance,h.chNewBalance,h.chDate
					from tblCustomers c inner join tblCustomerHistory h on c.kID=h.kID
					where (h.chDate between @startDate and @endDate) and (h.chOldBaseLo!=h.chNewBaseLo)
					order by c.kID
			end
		else if @type=3
			begin
				--Get all user history by date that basede has been changed
				select c.kID,c.kName,c.kContact,h.chOldBaseDe,h.chNewBaseDe,h.chOldBalance,h.chNewBalance,h.chDate
					from tblCustomers c inner join tblCustomerHistory h on c.kID=h.kID
					where (h.chDate between @startDate and @endDate) and (h.chOldBaseDe!=h.chNewBaseDe)
					order by c.kID
			end
		else if @type=4
			begin
				--Get all user history by date that balance has been changed
				select c.kID,c.kName,c.kContact,h.chOldBaseLo,h.chNewBaseLo,h.chOldBaseDe,h.chNewBaseDe,h.chOldBalance,h.chNewBalance,h.chDate
					from tblCustomers c inner join tblCustomerHistory h on c.kID=h.kID
					where (h.chDate between @startDate and @endDate) and (h.chOldBalance!=h.chNewBalance)
					order by c.kID
			end
		else if @type=5
			begin
				--Get all user history by date that baselo has been reduced
				select c.kID,c.kName,c.kContact,h.chOldBaseLo,h.chNewBaseLo,h.chOldBaseDe,h.chNewBaseDe,h.chOldBalance,h.chNewBalance,h.chDate
					from tblCustomers c inner join tblCustomerHistory h on c.kID=h.kID
					where (h.chDate between @startDate and @endDate) and (h.chOldBalance!=N'Chưa có') and (convert(decimal,h.chOldBalance)>convert(decimal,h.chNewBalance))	
					order by c.kID
			end
		else if @type=6
			begin
				--Get all user history by date that baselo has been increased
				select c.kID,c.kName,c.kContact,h.chOldBaseLo,h.chNewBaseLo,h.chOldBaseDe,h.chNewBaseDe,h.chOldBalance,h.chNewBalance,h.chDate
					from tblCustomers c inner join tblCustomerHistory h on c.kID=h.kID
					where ((h.chDate between @startDate and @endDate) and (h.chOldBalance!=N'Chưa có') and (convert(decimal,h.chOldBalance)<convert(decimal,h.chNewBalance)))	
					order by c.kID
			end
go

--tạo proc tạo mới khách
if exists(select * from sys.objects where type='P' and name= 'createNewCustomer')
	drop proc createNewCustomer
go
create proc createNewCustomer @blID int, @bdID int, @kName nvarchar(500), @kContact nvarchar(2000), @kBalance decimal
	as
		if @kName!='' and @kContact!='' and @blID>=0 and @bdID>=0 and @kBalance>=0
			begin
				insert into tblCustomers values(@blID,@bdID,@kName,@kContact,@kBalance)
			end
go

--tạo proc sửa khách
if exists(select * from sys.objects where type='P' and name= 'updateCustomer')
	drop proc updateCustomer
go
create proc updateCustomer @kID int
							, @kName nvarchar(500)
							, @kContact nvarchar(2000)
							, @blID int
							, @bdID int
							, @kBalance decimal
	as
		begin
			if (@bdID in (select bdID from tblBasesDe)) 
				and (@blID in (select blID from tblBasesLo)) 
				and @kContact!='' 
				and @kName!='' 
				and @kID>0
				begin
					update tblCustomers set kName=@kName
											, kContact=@kContact
											, blID=@blID
											, bdID=@bdID
											, kBalance=@kBalance 
										where kID=@kID
				end
		end
go

--tạo proc tạo mới cơ sở loo
if exists(select * from sys.objects where type='P' and name= 'createNewLoBase')
	drop proc createNewLoBase
go
create proc createNewLoBase @blName nvarchar(500), @blBase float
	as
		begin
			if @blName!='' and @blBase>0
				begin
					insert into tblBasesLo values (@blName,@blBase)
				end
		end
go

--tạo proc xem cơ sở loo
if exists(select * from sys.objects where type='P' and name= 'getAllLoBase')
	drop proc getAllLoBase
go
create proc getAllLoBase
	as
		begin
			select * from tblBasesLo			
		end
go

--tạo proc xem lịch sử cơ sở loo theo ngay
if exists(select * from sys.objects where type='P' and name= 'viewLoBaseHistoryByDate')
	drop proc viewLoBaseHistoryByDate
go
create proc viewLoBaseHistoryByDate @ID int,@startDate decimal,@endDate decimal
	as
		select h.blhID, h.blID, b.blName, b.blBase, h.blhOldNameValue, h.blhNewNameValue, h.blhOldBaseValue, h.blhNewBaseValue, h.blhDate
			from tblBasesLo b inner join tblBaseLoHistory h on b.blID=h.blID
			where h.blID=@ID and h.blhDate between @startDate and @endDate
go

--tạo proc tạo mới cơ sở ddee
if exists(select * from sys.objects where type='P' and name= 'createNewDeBase')
	drop proc createNewDeBase
go
create proc createNewDeBase @bdName nvarchar(500), @bdBase float
	as
		begin
			if @bdName!='' and @bdBase>0
				begin
					insert into tblBasesDe values (@bdName,@bdBase)
				end
		end
go

--tạo proc xem cơ sở ddee
if exists(select * from sys.objects where type='P' and name= 'getAllDeBase')
	drop proc getAllDeBase
go
create proc getAllDeBase
	as
		begin
			select * from tblBasesDe
		end
go

--tạo proc xem lịch sử cơ sở ddee theo ngay
if exists(select * from sys.objects where type='P' and name= 'viewDeBaseHistoryByDate')
	drop proc viewDeBaseHistoryByDate
go
create proc viewDeBaseHistoryByDate @ID int,@startDate decimal,@endDate decimal
	as
		select h.bdhID, h.bdID, b.bdName, b.bdBase, h.bdhOldNameValue, h.bdhNewNameValue, h.bdhOldBaseValue, h.bdhNewBaseValue, h.bdhDate
			from tblBasesDe b inner join tblBaseDeHistory h on b.bdID=h.bdID
			where h.bdID=@ID and h.bdhDate between @startDate and @endDate
go

--tạo proc sửa cơ sở ddee
if exists(select * from sys.objects where type='P' and name= 'updateDeBase')
	drop proc updateDeBase
go
create proc updateDeBase @bdBase float, @bdName nvarchar(500), @bdID int
	as
		begin
			if @bdBase>0 and @bdName!='' and @bdID>0
				begin
					update tblBasesDe set bdName=@bdName, bdBase=@bdBase where bdID=@bdID
				end
		end
go

/*--tạo proc sửa cơ sở của cơ sở ddee
if exists(select * from sys.objects where type='P' and name= 'updateDeBaseBase')
	drop proc updateDeBaseBase
go
create proc updateDeBaseBase @bdBase float, @bdID int
	as
		begin
			if @bdBase>0 and @bdID>0
				begin
					update tblBasesDe set bdBase=@bdBase where bdID=@bdID
				end
		end
go*/

--tạo proc sửa cơ sở loo
if exists(select * from sys.objects where type='P' and name= 'updateLoBase')
	drop proc updateLoBase
go
create proc updateLoBase @blBase float, @blName nvarchar(500), @blID int
	as
		begin
			if @blBase>0 and @blName!='' and @blID>0
				begin
					update tblBasesLo set blBase=@blBase, blName=@blName where blID=@blID
				end
		end
go

/*--tạo proc sửa cơ sở của cơ sở loo
if exists(select * from sys.objects where type='P' and name= 'updateLoBaseBase')
	drop proc updateLoBaseBase
go
create proc updateLoBaseBase @blBase float, @blID int
	as
		begin
			if @blBase>0 and @blID>0
				begin
					update tblBasesLo set blBase=@blBase where blID=@blID
				end
		end
go*/

--tạo proc tạo bảng
if exists(select * from sys.objects where type='P' and name= 'createMatrix')
	drop proc createMatrix
go
create proc createMatrix @date varchar(200)
	as
		begin
			if @date!='' and @date not in (select mDate from tblMatrixes)
				begin
					insert into tblMatrixes values(@date)
				end
		end
go

--tạo proc thêm số
if exists(select * from sys.objects where type='P' and name= 'createNumber')
	drop proc createNumber
go
create proc createNumber @kID int, @mID int, @nType int, @nNumber int, @nCoin int
	as
		begin
			if (@kID>0 and @mID>0 and @nType>=0 and @nNumber>=0 and @nCoin>0) 
				and @kID in (select kID from tblCustomers) and @mID in (select mID from tblMatrixes)
				begin
					insert into tblNumbers values(@kID,@mID,@nType,@nNumber,@nCoin)
				end
		end
go

--tạo proc xem số theo ngày
if exists(select * from sys.objects where type='P' and name= 'viewNumbersByDate')
	drop proc viewNumbersByDate
go
create proc viewNumbersByDate @date varchar(200)
	as
		begin
			if @date!=''
				begin
					select n.nID, n.mID, m.mDate, n.kID, k.kName, n.nType, n.nNumber, n.nCoin from tblCustomers k join tblNumbers n on k.kID=n.kID join tblMatrixes m on n.mID=m.mID where m.mDate=@date
				end
		end
go

--tạo proc tổng hợp số theo ngày
if exists(select * from sys.objects where type='P' and name= 'summarizeNumbersByDate')
	drop proc summarizeNumbersByDate
go
create proc summarizeNumbersByDate @date varchar(200)
	as
		begin
			if @date!=''
				begin
					select n.nID, n.mID, m.mDate, n.kID, k.kName, n.nType, n.nNumber, n.nCoin, bl.blName, bl.blBase, bd.bdName,bd.bdBase 
							from tblCustomers k join tblNumbers n on k.kID=n.kID 
									join tblMatrixes m on n.mID=m.mID 
									join tblBasesDe bd on k.bdID=bd.bdID
									join tblBasesLo bl on k.blID=bl.blID
							where m.mDate=@date
				end
		end
go

--tạo proc kiểm tra bảng tồn tại theo ngày
if exists(select * from sys.objects where type='P' and name= 'isMatrixExistedByDate')
	drop proc isMatrixExistedByDate
go
create proc isMatrixExistedByDate @date varchar(200)
	as
		begin
			if @date!=''
				begin
					select * from tblMatrixes where mDate=@date
				end
		end
go
--tạo proc kiểm tra bảng tồn tại theo ID
if exists(select * from sys.objects where type='P' and name= 'isMatrixExistedByID')
	drop proc isMatrixExistedByID
go
create proc isMatrixExistedByID @ID int
	as
		begin
			if @ID>0
				begin
					select * from tblMatrixes where mID=@ID
				end
		end
go
--tạo proc thêm bảng
if exists(select * from sys.objects where type='P' and name= 'addNewMatrix')
	drop proc addNewMatrix
go
create proc addNewMatrix @date varchar(200)
	as
		begin
			if @date!='' and @date not in (select mDate from tblMatrixes)
				begin
					insert into tblMatrixes values (@date)
				end
		end
go

--tạo proc thêm số vào bảng
if exists(select * from sys.objects where type='P' and name= 'addNewNumber')
	drop proc addNewNumber
go
create proc addNewNumber @date varchar(200), @kID int, @nType int, @nNumber int, @nCoin int
	as
		begin
			if @date!='' 
				and @date in (select mDate from tblMatrixes)
				and @kID in (select kID from tblCustomers)
				and @nType in (0,1)
				and (@nNumber between 0 and 99)
				and @nCoin>=0
				begin
					declare @mID int
					select @mID=mID from tblMatrixes where mDate=@date
						if (exists (select * from tblNumbers where kID=@kID and nNumber=@nNumber and mID=@mID and nType=@nType))
							begin
								update tblNumbers 
											set nCoin=((select nCoin from tblNumbers where kID=@kID and nNumber=@nNumber and mID=@mID and nType=@nType)+@nCoin) where kID=@kID and nNumber=@nNumber and mID=@mID and nType=@nType
							end
						else
							begin
								insert into tblNumbers values(@kID,@mID,@nType,@nNumber,@nCoin)
							end
				end
		end
go
--tạo proc sửa số trong bảng
if exists(select * from sys.objects where type='P' and name= 'editNumber')
	drop proc editNumber
go
create proc editNumber @nID int, @mID int, @kID int, @nType int, @nNumber int, @nCoin int
	as
		begin
			if @mID in (select mID from tblMatrixes)
				and @kID in (select kID from tblCustomers)
				and @nType in (0,1)
				and (@nNumber between 0 and 99)
				and @nCoin>0
				and @nID in (select nID from tblNumbers)
				begin
					if ((select count(nID) from tblNumbers where ((mID=@mID and kID=@kID and nType=@nType and nNumber=@nNumber)and nID!=@nID))>0)  --Cộng dồn
						begin								
							delete from tblNumbers where nID=@nID
							declare @target int
							select @target= nID from tblNumbers where (mID=@mID and kID=@kID and nType=@nType and nNumber=@nNumber)
							declare @originCoin int
							select @originCoin= nCoin from tblNumbers where (mID=@mID and kID=@kID and nType=@nType and nNumber=@nNumber)
							update tblNumbers 
										set nCoin=(@originCoin+@nCoin) where nID=@target
						end
					else
						begin
							update tblNumbers 
										set kID=@kID, nType=@nType, nNumber=@nNumber, nCoin=@nCoin where nID=@nID
						end					
				end
		end
go
--tạo proc kiểm tra số có tồn tại trong bảng
if exists(select * from sys.objects where type='P' and name= 'isNumberExisted')
	drop proc isNumberExisted
go
create proc isNumberExisted @mID int, @kID int, @nType int, @nNumber int
	as
		begin
			if @mID in (select mID from tblMatrixes)
				and @kID in (select kID from tblCustomers)
				and @nType in (0,1)
				and (@nNumber between 0 and 99)
				begin
						select * from tblNumbers where kID=@kID and nNumber=@nNumber and mID=@mID and nType=@nType
				end
		end
go

--tạo proc xem chi tiết số
if exists(select * from sys.objects where type='P' and name= 'viewNumberDetails')
	drop proc viewNumberDetails
go
create proc viewNumberDetails @date varchar(200), @nType int, @nNumber int
	as
		begin
			if @date!='' 
				and @date in (select mDate from tblMatrixes)
				and @nType in (0,1)
				and (@nNumber between 0 and 99)
				begin
					select n.nID, m.mDate, n.mID, n.kID, k.kName, n.nType, n.nNumber, n.nCoin 
								from tblMatrixes m join tblNumbers n on n.mID=m.mID 
													join tblCustomers k on k.kID=n.kID 
								where m.mDate=@date and n.nType=@nType and n.nNumber=@nNumber
				end
		end
go

-- tạo proc xem kết quả theo ngày
if exists(select * from sys.objects where type='P' and name= 'viewResultByDate')
	drop proc viewResultByDate
go
create proc viewResultByDate @date varchar(200)
	as
		begin
			select m.mDate, r.rType, r.rResult 
				from tblMatrixes m join tblResults r 
						on m.mID=r.mID 
				where m.mDate=@date
		end
go

--tạo proc thêm kết quả theo ngày
if exists(select * from sys.objects where type='P' and name= 'insertResultByDate')
	drop proc insertResultByDate
go
create proc insertResultByDate @date varchar(200), @type int, @result varchar(500)
	as
		begin
			if @date!='' 
				and @date in (select mDate from tblMatrixes)
				and @type in (0,1,2,3,4,5,6,7)
				and @result!=''
				begin
					declare @mID int
					select @mID=mID from tblMatrixes where mDate=@date
					insert into tblResults values(@mID,@type,@result)
				end
			end
go

exec createNewDeBase @bdName=N'Khách mới', @bdBase=72.5
go
exec createNewDeBase @bdName=N'Khách quen', @bdBase=75.7
go
exec createNewDeBase @bdName=N'Khách Vip', @bdBase=80.2
go
/*exec updateDeBaseName @bdName=N'Khách rách', @bdID=1
go
exec updateDeBaseBase @bdBase=70.2, @bdID=1
go*/
exec createNewLoBase @blName=N'Khách mới', @blBase=24.5
go
exec createNewLoBase @blName=N'Khách quen', @blBase=23.7
go
exec createNewLoBase @blName=N'Khách Vip', @blBase=22.2
go
/*
exec updateLoBaseName @blName=N'Khách rách', @blID=1
go
exec updateLoBaseBase @blBase=25.2, @blID=1
go
*/
exec viewUserByName @name=N''
go
exec viewUserByID @ID=2
go
exec viewUserHistoryByDate @ID=1, @startDate=125521124.283066, @endDate=126125924.283066
go
exec viewAllUsersHistoryByDate @startDate=124206988, @endDate=134643676, @type=4
go
exec createNewCustomer @blID=1, @bdID=1, @kName=N'Cá mắm', @kContact=N'Cầu Giấy', @kBalance=1000
go
exec updateCustomer @kID=1, @kName=N'Cá voi', @kContact=N'Thái Hà', @blID=2, @bdID=3, @kBalance=200
go
exec viewNumbersByDate @date='1-1-2014'
go
exec addNewNumber @date='1/1/2014',@kID=1,@nType=1,@nNumber=1,@nCoin=1
go

select * from tblBaseLoHistory
select * from tblBaseDeHistory
select * from tblCustomerHistory
select * from tblBasesLo
select * from tblBasesDe
select * from tblMatrixes
select * from tblNumbers
select * from tblResults
select * from tblCustomers
select * from sys.tables
go

select convert(decimal,convert(varchar(100),datediff(second,'2010-01-01',getdate())))
go


DECLARE @HashThis nvarchar(4000);
SELECT @HashThis = CONVERT(nvarchar(4000),'dslfdkjLK85kldhnv$n000#knf');
SELECT HASHBYTES('SHA1', @HashThis);
GO