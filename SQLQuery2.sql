create table Customer_History(
CUST_History_Id int IDENTITY(1,1) PRIMARY KEY,
CUST_History_Details varchar (1000) NOT NULL
);

create TRIGGER tr_Customer_ForInsert
ON CUSTOMER
FOR INSERT
AS
BEGIN
 Declare @Id varchar(6)
 Select @Id = CUST_ID from inserted
 
 insert into Customer_History
 values('New Customer with Id  = ' + @Id + ' is added at ' + cast(Getdate() as varchar(20)))
END


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


