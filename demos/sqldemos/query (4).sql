-- create a procedure that will return all the parents and childrens names
CREATE PROCEDURE GetChildrenAndParentsOuterJoin
AS 
SELECT m1.Fname as childFname, m1.lname as childLname, m2.Fname as parentFname, m2.lname as ParentLname
FROM _Members m1 
Full OUTER JOIN _MembersParentJunction ON m1.MemberIdId = ChildMemberId
Full OUTER JOIN _Members m2 ON ParentMemberId = m2.MemberIdId;

EXEC GetChildrenAndParentsOuterJoin

-- get all the childrens ages
CREATE PROCEDURE GetAllChildrensAges
AS
	SELECT Fname, lname, Age, ChildMemberId
	FROM [dbo].[_MembersParentJunction]
	LEFT JOIN [dbo].[_Members]
	ON ChildMemberId = MemberIdId;

EXEC GetAllChildrensAges;

	SELECT COUNT(*)
	FROM [dbo].[_MembersParentJunction]
	LEFT JOIN [dbo].[_Members]
	ON ChildMemberId = MemberIdId;

--get how many maximoffs there are
SELECT * FROM _Members WHERE lname = 'Maximoff';
SELECT * FROM _Members

--Procedure with Parameters
--user args to get how many of a certain family there is.

select * from _Families


