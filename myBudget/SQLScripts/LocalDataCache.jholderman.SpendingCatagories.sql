IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[jholderman].[SpendingCatagories]')) 
   ALTER TABLE [jholderman].[SpendingCatagories] 
   ENABLE  CHANGE_TRACKING
GO
