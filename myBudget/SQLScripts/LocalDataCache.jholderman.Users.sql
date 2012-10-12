IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[jholderman].[Users]')) 
   ALTER TABLE [jholderman].[Users] 
   ENABLE  CHANGE_TRACKING
GO
