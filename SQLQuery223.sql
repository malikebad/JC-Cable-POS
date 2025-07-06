CREATE TABLE [dbo].[GUESTS_ORDERS] (
    [GUEST_ORDER_ID] VARCHAR(6) NOT NULL,  -- Unique ID for guest order
    [ORDER_ID] VARCHAR(6) NOT NULL,        -- Link to ORDERS table
    [GUEST_SESSION_ID] VARCHAR(50) NULL,   -- For tracking the guest session
    [GUEST_NAME] VARCHAR(30) NULL,         -- Optional: Guest's name if available
    [GUEST_PHONE] VARCHAR(20) NULL,        -- Optional: Guest's contact info
    PRIMARY KEY ([GUEST_ORDER_ID]),
    FOREIGN KEY ([ORDER_ID]) REFERENCES [dbo].[ORDERS] ([ORDER_ID])
);
