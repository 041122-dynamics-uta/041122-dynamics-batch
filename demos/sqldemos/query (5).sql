SELECT TOP (1000) * FROM [dbo].[_Members]

-- get how many members are < 40 yoa.

--create a variable to hold how many there are.


--query to get all members <40yoa
SELECT COUNT(*) FROM _Members WHERE Age <40;

--procedure creation syntaX
CREATE PROCEDURE MembersUnder40
AS
SELECT COUNT(*) FROM _Members WHERE Age <40;

EXEC MembersUnder40

--procedure creation syntax WITH PARAMETERS
CREATE PROCEDURE MembersUnder40_2 (
	@maxage INT,
    @quantityundertheage INT OUTPUT
) AS
	SELECT * FROM _Members WHERE Age < @maxage;
	SELECT @quantityundertheage = @@ROWCOUNT; --ROWCOUNT is a system variable

DECLARE @maxAge INT;
EXEC MembersUnder40_2 40, @maxAge OUTPUT; 
SELECT @maxAge AS 'The number of members under the age';

DROP PROCEDURE MembersUnder40_2;
