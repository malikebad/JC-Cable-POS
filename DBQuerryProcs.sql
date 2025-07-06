CREATE TRIGGER tr_Employee_ForInsert
ON EMPLOYEE
FOR INSERT
AS
BEGIN
    DECLARE @Id VARCHAR(6)
    SELECT @Id = EMP_ID FROM inserted

    INSERT INTO Employee_History 
    VALUES('New employee with Id = ' + CAST(@Id AS VARCHAR(6)) + ' is added at ' + CAST(GETDATE() AS VARCHAR(20)))
END


create table Employee_History(
EMP_History_Id int IDENTITY(1,1) PRIMARY KEY,
EMP_History_Details varchar (1000) NOT NULL
);

select * from Employee_History

create TRIGGER tr_Employee_ForDelete
ON EMPLOYEE
FOR delete
AS
BEGIN
 Declare @Id varchar(6)
 Select @Id = EMP_ID from deleted
 
 insert into Employee_History 
 values('An existing employee with Id  = ' + Cast(@Id as varchar(6)) + ' is deleted at ' + cast(Getdate() as varchar(20)))
END

create trigger tr_Employee_ForUpdate
on EMPLOYEE
for Update
as
Begin
      -- Declare variables to hold old and updated data
      Declare @Id varchar(6)
      Declare @OldName varchar(30), @NewName varchar(30)
	  Declare @OldBirthday Date, @NewBirthday Date
      Declare @OldCity varchar(30), @NewCity varchar(30)
      Declare @OldLogin varchar(20), @NewLogin varchar(20)
	  Declare @OldPassword varchar(20), @NewPassword varchar(20)
      Declare @OldSalary int, @NewSalary int
     
      -- Variable to build the history string
      Declare @HistoryString varchar(1000)
      
      -- Load the updated records into temporary table
      Select *
      into #TempTable
      from inserted
     
      -- Loop thru the records in temp table
      While(Exists(Select EMP_ID from #TempTable))
      Begin
            --Initialize the History string to empty string
            Set @HistoryString = ''
           
            -- Select first row data from temp table
            Select Top 1 @Id = EMP_ID, @NewName = EMP_Name,
			@NewBirthday = EMP_BirthDay,  
            @NewCity = EMP_City, @NewLogin = EMP_Login,
			@NewPassword = EMP_Password,
			@NewSalary = EMP_Salary
            from #TempTable
           
            -- Select the corresponding row from deleted table
            Select @OldName = EMP_Name, @OldBirthday = EMP_BirthDay,  
            @OldCity = EMP_City, @OldLogin = EMP_Login,
			@OldPassword = EMP_Password,
			@OldSalary = EMP_Salary
            from deleted where EMP_ID = @Id
   
     -- Build the audit string dynamically           
            Set @HistoryString = 'Employee with Id = ' + Cast(@Id as varchar(4)) + ' changed'
            if(@OldName <> @NewName)
                  Set @HistoryString = @HistoryString + ' NAME from ' + @OldName + ' to ' + @NewName
                 
            if(@OldBirthday <> @NewBirthday)
                  Set @HistoryString = @HistoryString + ' Birth Date from ' + Cast(@OldBirthday as varchar(10)) + ' to ' + Cast(@NewBirthday as varchar(10))
                 
            if(@OldCity <> @NewCity)
                  Set @HistoryString = @HistoryString + ' City from ' + @OldCity + ' to ' + @NewCity

			if(@OldLogin <> @NewLogin)
                  Set @HistoryString = @HistoryString + ' Login from ' + @OldLogin + ' to ' + @NewLogin

			if(@OldPassword <> @NewPassword)
                  Set @HistoryString = @HistoryString + ' Password from ' + @OldPassword + ' to ' + @NewPassword

            if(@OldSalary <> @NewSalary)
                  Set @HistoryString = @HistoryString + ' SALARY from ' + Cast(@OldSalary as varchar(10))+ ' to ' + Cast(@NewSalary as varchar(10))
           
            insert into Employee_History values(@HistoryString)
            
            -- Delete the row from temp table, so we can move to the next row
            Delete from #TempTable where EMP_ID = @Id
      End
End

create TRIGGER tr_Customer_ForDelete
ON CUSTOMER
FOR delete
AS
BEGIN
 Declare @Id varchar(6)
 Select @Id = CUST_ID from deleted
 
 insert into Customer_History
 values('An existing customer with Id  = ' + @Id + ' is deleted at ' + cast(Getdate() as varchar(20)))
END


create trigger tr_Customer_ForUpdate
on CUSTOMER
for Update
as
Begin
      -- Declare variables to hold old and updated data
      Declare @Id varchar(6)
      Declare @OldName varchar(30), @NewName varchar(30)
	  Declare @OldRegdate Date, @NewRegdate Date
      Declare @OldCity varchar(30), @NewCity varchar(30)
      Declare @OldContact varchar(20), @NewContact varchar(20)
     
      -- Variable to build the history string
      Declare @HistoryString varchar(1000)
      
      -- Load the updated records into temporary table
      Select *
      into #TempTable1
      from inserted
     
      -- Loop thru the records in temp table
      While(Exists(Select CUST_ID from #TempTable1))
      Begin
            --Initialize the History string to empty string
            Set @HistoryString = ''
           
            -- Select first row data from temp table
            Select Top 1 @Id = CUST_ID, @NewName = CUST_Name,
			@NewRegdate = CUST_RegDate,  
            @NewCity = CUST_City, @NewContact = CUST_Contact
            from #TempTable1
           
            -- Select the corresponding row from deleted table
            Select @OldName = CUST_Name, @OldRegdate = CUST_RegDate,  
            @OldCity = CUST_City, @OldContact= CUST_Contact
            from deleted where CUST_ID = @Id
   
     -- Build the audit string dynamically           
            Set @HistoryString = 'Customer with Id = ' + @Id + ' changed'
            if(@OldName <> @NewName)
                  Set @HistoryString = @HistoryString + ' NAME from ' + @OldName + ' to ' + @NewName
                 
            if(@OldRegdate <> @NewRegdate)
                  Set @HistoryString = @HistoryString + ' Registration Date from ' + Cast(@OldRegdate as varchar(10)) + ' to ' + Cast(@NewRegdate as varchar(10))
                 
            if(@OldCity <> @NewCity)
                  Set @HistoryString = @HistoryString + ' City from ' + @OldCity + ' to ' + @NewCity

			if(@OldContact <> @NewContact)
                  Set @HistoryString = @HistoryString + ' Contact from ' + @OldContact + ' to ' + @NewContact

            insert into Employee_History values(@HistoryString)
            
            -- Delete the row from temp table, so we can move to the next row
            Delete from #TempTable1 where CUST_ID = @Id
      End
End


create TRIGGER tr_Supplier_ForInsert
ON SUPPLIER
FOR INSERT
AS
BEGIN
 Declare @Id varchar(6)
 Select @Id = SUPP_ID from inserted
 
 insert into Supplier_History
 values('New Supplier with Id  = ' + @Id + ' is added at ' + cast(Getdate() as varchar(20)))
END

create TRIGGER tr_Supplier_ForDelete
ON SUPPLIER
FOR delete
AS
BEGIN
 Declare @Id varchar(6)
 Select @Id = SUPP_ID from deleted
 
 insert into Supplier_History
 values('An existing supplier with Id  = ' + @Id + ' is deleted at ' + cast(Getdate() as varchar(20)))
END







create trigger tr_Supplier_ForUpdate
on SUPPLIER
for Update
as
Begin
      -- Declare variables to hold old and updated data
      Declare @Id varchar(6)
      Declare @OldName varchar(50), @NewName varchar(50)
	  Declare @OldAddress varchar(50), @NewAddress varchar(50)
      Declare @OldPhone varchar(13), @NewPhone varchar(13)
      Declare @OldEmail varchar(50), @NewEmail varchar(50)
     
      -- Variable to build the history string
      Declare @HistoryString varchar(1000)
      
      -- Load the updated records into temporary table
      Select *
      into #TempTable2
      from inserted
     
      -- Loop thru the records in temp table
      While(Exists(Select SUPP_ID from #TempTable2))
      Begin
            --Initialize the History string to empty string
            Set @HistoryString = ''
           
            -- Select first row data from temp table
            Select Top 1 @Id = SUPP_ID, @NewName = SUPP_Name,
			@NewAddress = SUPP_Address,  
            @NewPhone = SUPP_Phone, @NewEmail = SUPP_Email
            from #TempTable2
           
            -- Select the corresponding row from deleted table
            Select @OldName = SUPP_Name, @OldAddress = SUPP_Address,  
            @OldPhone = SUPP_Phone, @OldEmail= SUPP_Email
            from deleted where SUPP_ID = @Id
   
     -- Build the audit string dynamically           
            Set @HistoryString = 'Supplier with Id = ' + @Id + ' changed'
            if(@OldName <> @NewName)
                  Set @HistoryString = @HistoryString + ' NAME from ' + @OldName + ' to ' + @NewName
                 
            if(@OldAddress <> @NewAddress)
                  Set @HistoryString = @HistoryString + ' Address from ' + @OldAddress  + ' to ' + @NewAddress
                 
            if(@OldPhone <> @NewPhone)
                  Set @HistoryString = @HistoryString + ' Phone from ' + @OldPhone + ' to ' + @NewPhone

			if(@OldEmail <> @NewEmail)
                  Set @HistoryString = @HistoryString + ' Email from ' + @OldEmail + ' to ' + @NewEmail

            insert into Supplier_History values(@HistoryString)
            
            -- Delete the row from temp table, so we can move to the next row
            Delete from #TempTable2 where SUPP_ID = @Id
      End
End

create table ITEM_History(
ITEM_History_Id int IDENTITY(1,1) PRIMARY KEY,
ITEM_History_Details varchar (1000) NOT NULL
);

select * from ITEM_History

create TRIGGER tr_Item_ForInsert
ON ITEM
FOR INSERT
AS
BEGIN
 Declare @Id varchar(6)
 Select @Id = ITEM_ID from inserted
 
 insert into ITEM_History
 values('New Item with Id  = ' + @Id + ' is added at ' + cast(Getdate() as varchar(20)))
END

create TRIGGER tr_Item_ForDelete
ON ITEM
FOR delete
AS
BEGIN
 Declare @Id varchar(6)
 Select @Id = ITEM_ID from deleted
 
 insert into ITEM_History
 values('An existing Item with Id  = ' + @Id + ' is deleted at ' + cast(Getdate() as varchar(20)))
END











create trigger tr_Item_ForUpdate
on ITEM
for Update
as
Begin
      -- Declare variables to hold old and updated data
      Declare @Id varchar(6)
	  Declare @OldSUPP_Id varchar(6), @NewSUPP_Id varchar(6)
      Declare @OldName varchar(50), @NewName varchar(50)
	  Declare @OldPurchaseUP int, @NewPurchaseUP int
	  Declare @OldRetailUP int, @NewRetailUP int
      Declare @OldQty int, @NewQty int
	  Declare @OldBatchId varchar(6), @NewBatchId varchar(6)
     
      -- Variable to build the history string
      Declare @HistoryString varchar(1000)
      
      -- Load the updated records into temporary table
      Select *
      into #TempTable4
      from inserted
     
      -- Loop thru the records in temp table
      While(Exists(Select ITEM_ID from #TempTable4))
      Begin
            --Initialize the History string to empty string
            Set @HistoryString = ''
           
            -- Select first row data from temp table
            Select Top 1 @Id = ITEM_ID,@NewSUPP_Id = SUPP_ID, @NewName = ITEM_Name,
			@NewPurchaseUP = ITEM_PurchaseUnitPrice,@NewRetailUP = ITEM_RetailUnitPrice,  
            @NewQty = ITEM_Qty, @NewBatchId = ITEM_BatchID
            from #TempTable4
           
            -- Select the corresponding row from deleted table
            Select @OldName = ITEM_Name, @OldPurchaseUP = ITEM_PurchaseUnitPrice,  
            @OldRetailUP = ITEM_RetailUnitPrice, @OldQty= ITEM_Qty,
			@OldBatchId = ITEM_BatchID,@OldSUPP_Id = SUPP_ID
            from deleted where ITEM_ID = @Id
   
     -- Build the audit string dynamically           
            Set @HistoryString = 'Item with Id = ' + @Id + ' changed'
            if(@OldName <> @NewName)
                  Set @HistoryString = @HistoryString + ' NAME from ' + @OldName + ' to ' + @NewName
                 
            if(@OldPurchaseUP <> @NewPurchaseUP)
                  Set @HistoryString = @HistoryString + ' Purchase Unit Price from ' + @OldPurchaseUP  + ' to ' + @NewPurchaseUP
                 
            if(@OldRetailUP <> @NewRetailUP)
                  Set @HistoryString = @HistoryString + ' Retail Unit Price from ' + @OldRetailUP + ' to ' + @NewRetailUP

			if(@OldQty <> @NewQty)
                  Set @HistoryString = @HistoryString + ' Quantity from ' + @OldQty + ' to ' + @NewQty
			
			if(@OldBatchId <> @NewBatchId)
                  Set @HistoryString = @HistoryString + ' Batch Id from ' + @OldBatchId + ' to ' + @NewBatchId
			
			if(@OldSUPP_Id <> @NewSUPP_Id)
                  Set @HistoryString = @HistoryString + ' Supplier Id from ' + @OldSUPP_Id + ' to ' + @NewSUPP_Id

            insert into Supplier_History values(@HistoryString)
            
            -- Delete the row from temp table, so we can move to the next row
            Delete from #TempTable4 where ITEM_ID = @Id
      End
End

create trigger tr_insteadOfDelete_Item
on ITEM
instead of delete
as 
begin
	declare @itemId varchar(6) 
	select @itemId =  ITEM_ID from deleted
delete from ORDER_DETAILS where ITEM_ID = @itemId
delete from ITEM where ITEM_ID = @itemId
END


select count(CUST_ID) from CUSTOMER

drop Procedure Update_Qty

CREATE PROCEDURE Update_Qty
@qty INT, @key VARCHAR(6)
AS
BEGIN
    UPDATE ITEM 
    SET ITEM_QTY = ITEM_QTY - @qty 
    WHERE ITEM_ID = @key
END

Select ITEM_QTY from ITEM as int where ITEM_ID = 'I001' 

CREATE PROCEDURE PLACE_ORDER
@ORDER_ID VARCHAR(6), 
@ORDER_DATE DATE, 
@CUST_ID VARCHAR(6), 
@EMP_ID VARCHAR(6), 
@ORDER_TOTAL INT,
@BILL INT
AS
BEGIN
    INSERT INTO ORDERS (ORDER_ID, CUST_ID, EMP_ID, ORDER_DATE, ORDER_TOTAL, BILL)  
    VALUES (@ORDER_ID, @CUST_ID, @EMP_ID, @ORDER_DATE, @ORDER_TOTAL, @BILL);
END;



SELECT * FROM sys.objects WHERE type = 'P' AND name = 'PLACE_ORDER';






ALTER TABLE ORDERS  
ADD ORDER_Time TIME NOT NULL DEFAULT '00:00:00';


