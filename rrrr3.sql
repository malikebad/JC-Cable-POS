EXEC sp_helptext 'PLACE_ORDER'


ALTER PROCEDURE PLACE_ORDER  
@ORDER_ID varchar(6),  
@ORDER_DATE DATE,  
@ORDER_Time TIME,  
@CUST_ID varchar(6),  
@Bill int,  
@ExtraParam1 INT = NULL,  -- Dummy Parameter
@ExtraParam2 NVARCHAR(50) = NULL  -- Dummy Parameter
AS  
BEGIN  
    INSERT INTO ORDERS (ORDER_ID, ORDER_DATE, ORDER_Time, CUST_ID, Bill)  
    VALUES (@ORDER_ID, @ORDER_DATE, @ORDER_Time, @CUST_ID, @Bill);  
END


