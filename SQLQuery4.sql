

IF (@OldQuantity IS NOT NULL AND @NewQuantity IS NOT NULL)
    SET @HistoryString = @HistoryString + ' Quantity from ' + CAST(@OldQuantity AS VARCHAR(10)) + ' to ' + CAST(@NewQuantity AS VARCHAR(10));
ELSE IF (@OldQuantity IS NULL)
    SET @HistoryString = @HistoryString + ' Quantity changed to ' + CAST(@NewQuantity AS VARCHAR(10));
ELSE IF (@NewQuantity IS NULL)
    SET @HistoryString = @HistoryString + ' Quantity changed from ' + CAST(@OldQuantity AS VARCHAR(10));


    SELECT max(RIGHT(Order_id, 3)) AS ExtractString
FROM ORDERS;

select count(*) from EMPLOYEE where EMP_ID='E001'



Select ITEM_QTY from ITEM where ITEM_ID = 'I001'

select count(CUST_ID) as general from CUSTOMER
select count(ORDER_ID) as general from ORDERS
SELECT SUM(ORDER_QTY) FROM ORDER_DETAILS
select sum(BILL) as general from ORDERS
select count(*) as general from ITEM where ITEM_Qty = 0



CREATE PROCEDURE PLACE_ORDER
@ORDER_ID varchar(6) ,@ORDER_DATE DATE, @ORDER_Time TIME, @CUST_ID varchar (6), @Bill int
AS
BEGIN
INSERT INTO ORDERS VALUES (@ORDER_ID,@ORDER_DATE, @ORDER_Time, @CUST_ID, @Bill);
END

EXEC PLACE_ORDER 'K001','2021-12-22', '03:12:01','C001',5000;

EXEC sp_help ORDERS;

DROP PROCEDURE IF EXISTS PLACE_ORDER;

CREATE PROCEDURE PLACE_ORDER
@ORDER_ID varchar(6), 
@ORDER_DATE DATE, 
@ORDER_Time TIME, 
@CUST_ID varchar(6), 
@EMP_ID varchar(6),  -- Added EMP_ID
@ORDER_TOTAL int,     -- Added ORDER_TOTAL
@Bill int
AS
BEGIN
    INSERT INTO ORDERS (ORDER_ID, ORDER_DATE, ORDER_TIME, CUST_ID, EMP_ID, ORDER_TOTAL, BILL) 
    VALUES (@ORDER_ID, @ORDER_DATE, @ORDER_Time, @CUST_ID, @EMP_ID, @ORDER_TOTAL, @Bill);
END;

SELECT name FROM sys.procedures WHERE name = 'PLACE_ORDER';

drop Procedure Update_Qty
create procedure Update_Qty
@qty int, @key varchar(6)
AS
Begin
update ITEM 
SET ITEM_QTY = ITEM_QTY - @qty 
where ITEM_ID = @key
END

exec Update_Qty 2,'I001'


create trigger tr_insteadOfDelete_Item
on ITEM
instead of delete
as 
begin
	declare @itemId varchar(6) 
	select @itemId =  ITEM_ID from deleted
delete from ORDER_DETAILS where ITEM_ID = @itemId
delete from ITEM where ITEM_ID = @itemId





















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

SELECT name, object_id, type_desc
FROM sys.triggers
WHERE parent_id = OBJECT_ID('dbo.items');
EXEC sp_helptext 'trigger_name';










SELECT name, object_id, type_desc
FROM sys.triggers
WHERE parent_id = OBJECT_ID('dbo.ITEM');

EXEC sp_helptext 'Update_Qty'
PRINT 'Item with Id = ' + @ItemID + ' changed Quantity from ' + @OldQty + ' to ' + @NewQty


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








SELECT name 
FROM sys.triggers 
WHERE parent_id = OBJECT_ID('ITEM');


DISABLE TRIGGER  ON ITEM;


SELECT OBJECT_DEFINITION(OBJECT_ID('tr_Item_ForInsert')) AS TriggerDefinition;
SELECT OBJECT_DEFINITION(OBJECT_ID('tr_Item_ForDelete')) AS TriggerDefinition;
SELECT OBJECT_DEFINITION(OBJECT_ID('tr_Item_ForUpdate')) AS TriggerDefinition;
SELECT OBJECT_DEFINITION(OBJECT_ID('tr_insteadOfDelete_Item')) AS TriggerDefinition;


DISABLE TRIGGER tr_Item_ForUpdate ON ITEM;

DISABLE TRIGGER tr_Item_ForInsert ON ITEM;
DISABLE TRIGGER tr_Item_ForDelete ON ITEM;
DISABLE TRIGGER tr_Item_ForUpdate ON ITEM;
DISABLE TRIGGER tr_insteadOfDelete_Item ON ITEM;

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


select * from ITEM_History


Set @HistoryString = @HistoryString + ' Quantity from ' + CAST(@OldQty AS VARCHAR(10)) + ' to ' + CAST(@NewQty AS VARCHAR(10))

create table ITEM (
ITEM_ID varchar(6) PRIMARY KEY,
SUPP_ID varchar(6) ,
ITEM_Name varchar(50),
ITEM_PurchaseUnitPrice INT,
ITEM_RetailUnitPrice INT,
ITEM_Qty INT,
ITEM_BatchID varchar(6),
ITEM_BatchDate DATE
);


SELECT * FROM ITEM




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




IF OBJECT_ID('tr_Item_ForInsert', 'TR') IS NOT NULL
    DROP TRIGGER tr_Item_ForInsert;


    CREATE TRIGGER tr_Item_ForInsert
ON ITEM
FOR INSERT
AS
BEGIN
    Declare @Id varchar(6)
    Select @Id = ITEM_ID from inserted

    INSERT INTO ITEM_History
    VALUES('New Item with Id = ' + @Id + ' is added at ' + CAST(GETDATE() AS varchar(20)))
END

IF OBJECT_ID('tr_Item_ForUpdate', 'TR') IS NOT NULL
    DROP TRIGGER tr_Item_ForUpdate;
CREATE TRIGGER tr_Item_ForDelete
ON ITEM
FOR DELETE
AS
BEGIN
    Declare @Id varchar(6)
    Select @Id = ITEM_ID from deleted

    INSERT INTO ITEM_History
    VALUES('An existing Item with Id = ' + @Id + ' is deleted at ' + CAST(GETDATE() AS varchar(20)))
END

CREATE TRIGGER tr_Item_ForUpdate
ON ITEM
FOR UPDATE
AS
BEGIN
    DECLARE @Id varchar(6), @OldName varchar(50), @NewName varchar(50)
    DECLARE @OldQty int, @NewQty int, @HistoryString varchar(1000)

    -- Iterate through updated rows
    DECLARE cursor_Update CURSOR FOR
    SELECT i.ITEM_ID, d.ITEM_Name, i.ITEM_Name, d.ITEM_Qty, i.ITEM_Qty
    FROM inserted i
    JOIN deleted d ON i.ITEM_ID = d.ITEM_ID

    OPEN cursor_Update
    FETCH NEXT FROM cursor_Update INTO @Id, @OldName, @NewName, @OldQty, @NewQty

    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @HistoryString = 'Item with Id = ' + @Id + ' changed'
        
        IF (@OldName <> @NewName)
            SET @HistoryString = @HistoryString + ' NAME from ' + @OldName + ' to ' + @NewName
        
        IF (@OldQty <> @NewQty)
            SET @HistoryString = @HistoryString + ' Quantity from ' + CAST(@OldQty AS varchar) + ' to ' + CAST(@NewQty AS varchar)

        INSERT INTO ITEM_History VALUES(@HistoryString)
        
        FETCH NEXT FROM cursor_Update INTO @Id, @OldName, @NewName, @OldQty, @NewQty
    END

    CLOSE cursor_Update
    DEALLOCATE cursor_Update
END




CREATE TRIGGER tr_Item_ForUpdate
ON ITEM
FOR UPDATE
AS
BEGIN
    DECLARE @Id varchar(6), @OldName varchar(50), @NewName varchar(50)
    DECLARE @OldQty int, @NewQty int, @HistoryString varchar(1000)

    -- Iterate through updated rows
    DECLARE cursor_Update CURSOR FOR
    SELECT i.ITEM_ID, d.ITEM_Name, i.ITEM_Name, d.ITEM_Qty, i.ITEM_Qty
    FROM inserted i
    JOIN deleted d ON i.ITEM_ID = d.ITEM_ID

    OPEN cursor_Update
    FETCH NEXT FROM cursor_Update INTO @Id, @OldName, @NewName, @OldQty, @NewQty

    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @HistoryString = 'Item with Id = ' + @Id + ' changed'
        
        IF (@OldName <> @NewName)
            SET @HistoryString = @HistoryString + ' NAME from ' + @OldName + ' to ' + @NewName
        
        IF (@OldQty <> @NewQty)
            SET @HistoryString = @HistoryString + ' Quantity from ' + CAST(@OldQty AS varchar) + ' to ' + CAST(@NewQty AS varchar)

        INSERT INTO ITEM_History VALUES(@HistoryString)
        
        FETCH NEXT FROM cursor_Update INTO @Id, @OldName, @NewName, @OldQty, @NewQty
    END

    CLOSE cursor_Update
    DEALLOCATE cursor_Update
END



EXEC sp_configure 'nested triggers', 0;
RECONFIGURE;

CREATE TRIGGER tr_Item_ForUpdate
ON ITEM
AFTER UPDATE
AS
BEGIN
    -- Prevent infinite loops by checking if relevant columns were updated
    IF EXISTS (
        SELECT 1 FROM inserted i
        JOIN deleted d ON i.ITEM_ID = d.ITEM_ID
        WHERE i.ITEM_Name <> d.ITEM_Name 
           OR i.ITEM_Qty <> d.ITEM_Qty
    )
    BEGIN
        -- Your trigger logic here
        PRINT 'Trigger executed: Changes detected in ITEM_Name or ITEM_Qty';
    END
END;


DROP TRIGGER IF EXISTS tr_Item_ForUpdate;
GO

CREATE TRIGGER tr_Item_ForUpdate
ON ITEM
AFTER UPDATE
AS
BEGIN
    -- Prevent infinite loops by checking if relevant columns were updated
    IF EXISTS (
        SELECT 1 FROM inserted i
        JOIN deleted d ON i.ITEM_ID = d.ITEM_ID
        WHERE i.ITEM_Name <> d.ITEM_Name 
           OR i.ITEM_Qty <> d.ITEM_Qty
    )
    BEGIN
        -- Your trigger logic here
        PRINT 'Trigger executed: Changes detected in ITEM_Name or ITEM_Qty';
    END
END;
GO


UPDATE ITEM 
SET ITEM_Name = 'New Name'
WHERE ITEM_ID = 'I003';

SELECT * FROM Supplier_History ORDER BY SUPP_History_Id DESC;

SELECT * FROM Supplier_History ORDER BY SUPP_History_Id DESC;


CREATE TRIGGER tr_Item_ForUpdate
ON ITEM
INSTEAD OF UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Log changes before applying update
    INSERT INTO ITEM_History (ITEM_ID, Old_Name, New_Name, Old_Qty, New_Qty, ChangeDate)
    SELECT i.ITEM_ID, i.ITEM_Name, u.ITEM_Name, i.ITEM_Qty, u.ITEM_Qty, GETDATE()
    FROM deleted i
    JOIN inserted u ON i.ITEM_ID = u.ITEM_ID
    WHERE i.ITEM_Name <> u.ITEM_Name OR i.ITEM_Qty <> u.ITEM_Qty;

    -- Perform the actual update
    UPDATE i
    SET 
        i.ITEM_Name = u.ITEM_Name, 
        i.ITEM_Qty = u.ITEM_Qty
    FROM ITEM i
    JOIN inserted u ON i.ITEM_ID = u.ITEM_ID;
END;
? Prevents infinite recursion
? Logs changes before updating the table

Option 2: Add a Condition to Prevent Recursive Updates
Modify your AFTER UPDATE trigger to check if values actually changed before executing another update.


CREATE TRIGGER tr_Item_ForUpdate
ON ITEM
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Check if the update actually changed values
    IF EXISTS (
        SELECT 1 FROM inserted i
        JOIN deleted d ON i.ITEM_ID = d.ITEM_ID
        WHERE i.ITEM_Name <> d.ITEM_Name OR i.ITEM_Qty <> d.ITEM_Qty
    )
    BEGIN
        INSERT INTO ITEM_History (ITEM_ID, Old_Name, New_Name, Old_Qty, New_Qty, ChangeDate)
        SELECT d.ITEM_ID, d.ITEM_Name, i.ITEM_Name, d.ITEM_Qty, i.ITEM_Qty, GETDATE()
        FROM deleted d
        JOIN inserted i ON d.ITEM_ID = i.ITEM_ID;
    END;
END;


DROP TRIGGER IF EXISTS tr_Item_ForInsert



