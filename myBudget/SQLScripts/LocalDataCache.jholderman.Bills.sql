IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[jholderman].[Bills]')) 
   ALTER TABLE [jholderman].[Bills] 
   ENABLE  CHANGE_TRACKING
GO
