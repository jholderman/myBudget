IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[jholderman].[Users]')) 
   ALTER TABLE [jholderman].[Users] 
   DISABLE  CHANGE_TRACKING
GO
