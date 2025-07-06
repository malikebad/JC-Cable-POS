ALTER PROCEDURE Update_Qty
    @Quantity INT,
    @ItemID NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- Ensure the update only affects valid items and handles type conversion properly
    UPDATE ITEM
    SET ITEM_Qty = CAST(ITEM_Qty AS INT) - @Quantity
    WHERE ITEM_ID = @ItemID;
END

ALTER PROCEDURE Update_Qty
    @Quantity INT,
    @ItemID NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- Ensure the ITEM_Qty is updated correctly
    UPDATE ITEM
    SET ITEM_Qty = CAST(ITEM_Qty AS INT) - @Quantity
    WHERE ITEM_ID = @ItemID;
    
    -- Remove PRINT statements that return non-integer values



    EXEC sp_helptext 'PLACE_ORDER';


