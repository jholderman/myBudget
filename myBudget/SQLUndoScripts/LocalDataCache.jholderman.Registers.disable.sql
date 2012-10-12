IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[jholderman].[Registers]')) 
   ALTER TABLE [jholderman].[Registers] 
   DISABLE  CHANGE_TRACKING
GO
