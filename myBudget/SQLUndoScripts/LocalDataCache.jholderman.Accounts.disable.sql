IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[jholderman].[Accounts]')) 
   ALTER TABLE [jholderman].[Accounts] 
   DISABLE  CHANGE_TRACKING
GO
