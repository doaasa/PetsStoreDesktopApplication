
CREATE TRIGGER [ Trigger]   
 ON [dbo].[tbCash]
 FOR DELETE,INSERT,UPDATE
 AS
 BEGIN
   SET NOCOUNT ON
   UPDATE tbCash set Total= Quantity*Price
   END


