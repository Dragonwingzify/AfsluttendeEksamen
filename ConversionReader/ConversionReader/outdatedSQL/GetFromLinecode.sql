/****** Object:  StoredProcedure [dbo].[GetFromLineCode]    Script Date: 27-11-2018 10:39:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:      jdaProject
-- Create Date: 12-11-2018
-- Description: Selects terminal by line code and listid
-- =============================================
ALTER PROCEDURE [dbo].[GetFromLineCode]
(
    -- Add the parameters for the stored procedure here
    @ListId nvarchar(100) = "DEFAULT",
    @Linecode nvarchar(100) = "0000"
)
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Insert statements for procedure here
    SELECT c.[output]
	FROM [dbo].convert_platform as c
	join dbo.[type] as t on t.convert_platform=c.[type]
	WHERE c.list_id = @ListId and c.input1 = @Linecode and t.type_value='linecode'
END
