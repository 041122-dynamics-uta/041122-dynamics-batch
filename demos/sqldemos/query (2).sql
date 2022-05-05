

SELECT TOP (1000) * FROM [dbo].[_Members]
SELECT TOP (1000) * FROM [dbo].[_MembersParentJunction]
SELECT TOP (1000) * FROM [dbo].[_Families]
SELECT TOP (1000) * FROM [dbo].[_Origins]

--Joins
-- GEt the origins of all the families
SELECT FamilyName, OriginName 
FROM _Families JOIN _Origins
ON Origin = OriginId;

--List all the members and the family they belong to.
SELECT Fname, lname,FamilyName 
FROM _Members JOIN _Families
ON Family = FamilyId;

SELECT m1.Fname as childFname, m1.lname as childLname, m2.Fname as parentFname, m2.lname as ParentLname
FROM _Members m1 
Full OUTER JOIN _MembersParentJunction ON m1.MemberIdId = ChildMemberId
Full OUTER JOIN _Members m2 ON ParentMemberId = m2.MemberIdId;

--left join
SELECT m1.Fname as childFname, m1.lname as childLname, m2.Fname as parentFname, m2.lname as ParentLname
FROM _Members m1 
LEFT JOIN _MembersParentJunction ON m1.MemberIdId = ChildMemberId
LEFT JOIN _Members m2 ON ParentMemberId = m2.MemberIdId;

--Right JOIN
SELECT m1.Fname as childFname, m1.lname as childLname, m2.Fname as parentFname, m2.lname as ParentLname
FROM _Members m1 
RIGHT JOIN _MembersParentJunction ON m1.MemberIdId = ChildMemberId
RIGHT JOIN _Members m2 ON ParentMemberId = m2.MemberIdId;

--Cross JOIN
SELECT m1.Fname as childFname, m1.lname as childLname, m2.Fname as parentFname, m2.lname as ParentLname
FROM _Members m1 
CROSS JOIN _Members m2;


UPDATE _Members SET Family = 13 Where lname = 'Maximoff';