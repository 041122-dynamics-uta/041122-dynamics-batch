--Jasiel Group3
INSERT INTO _Origins (OriginName, DateCreated) VALUES('Stark Lab', '2009-1-1');
INSERT INTO _Origins (OriginName) VALUES('Earth');
INSERT INTO _Families (FamilyName, Origin) VALUES('Maximoff',10);
INSERT INTO _Members (Fname, lname, Age, Family) VALUES('Vision','Maximoff',30,10);--Mark
INSERT INTO _Members (Fname, lname, Age, Family) VALUES('Wanda','Maximoff',29,10);--Garen
INSERT INTO _Members (Fname, lname, Age, Family) VALUES('Billy','Maximoff',12,10);--Wint
INSERT INTO _Members (Fname, lname, Age, Family) VALUES('Tommy','Maximoff',12,10);--Angel
INSERT INTO _MembersParentJunction (ChildMemberId, ParentMemberId) VALUES(10,12);
INSERT INTO _Members (Fname, lname, Family) VALUES('unknown','unknown',28);
INSERT INTO _Families (FamilyName, Origin) VALUES('unknown',50);
INSERT INTO _Origins (OriginName) VALUES('unknown');
INSERT INTO _MembersParentJunction (ChildMemberId, ParentMemberId) 
	VALUES (
		(SELECT TOP 1 MemberIdId FROM _Members WHERE Fname = 'Vision'), 
		(SELECT TOP 1 MemberIdId FROM _Members WHERE Fname = 'unknown')
);

UPDATE _Families SET Origin = 50 Where FamilyName = 'Maximoff';

DELETE FROM _Members WHERE MemberIdId >=38;
DELETE FROM _Origins WHERE OriginId >18;
DELETE FROM _Families WHERE FamilyId >13;
DELETE FROM _MembersParentJunction WHERE DateCreated = '2022-05-05T19:31:53.4700000';


SELECT TOP (1000) * FROM [dbo].[_Members]
SELECT TOP (1000) * FROM [dbo].[_MembersParentJunction]
SELECT TOP (1000) * FROM [dbo].[_Families]
SELECT TOP (1000) * FROM [dbo].[_Origins]

--Marcel Group 5
INSERT INTO _Origins (OriginName) VALUES('Verona');
INSERT INTO _Families (FamilyName, Origin) VALUES('Montagues',54); 
INSERT INTO _Families (FamilyName, Origin) VALUES('Capulets',54);
INSERT INTO _Members (Fname, lname, Age, Family) VALUES('Lady','Montague',32,31);
INSERT INTO _Members (Fname, lname, Age, Family) VALUES('Donny','Montague',40,31);
INSERT INTO _Members (Fname, lname, Age, Family) VALUES('Juliet','Montague',13,31);
INSERT INTO _Members (Fname, lname, Age, Family) VALUES('Lady','Capulet',34,34);
INSERT INTO _Members (Fname, lname, Age, Family) VALUES('Don','Capulet',42,34);
INSERT INTO _Members (Fname, lname, Age, Family) VALUES('Romeo','Capulet',16,34);
INSERT INTO _MembersParentJunction (ChildMemberId, ParentMemberId) VALUES(10,12);
INSERT INTO _MembersParentJunction (ChildMemberId, ParentMemberId) VALUES(10,12);

INSERT INTO _MembersParentJunction (ChildMemberId, ParentMemberId) 
	VALUES (
		(SELECT TOP 1 MemberIdId FROM _Members WHERE Fname = 'Romeo'), 
		(SELECT TOP 1 MemberIdId FROM _Members WHERE Fname = 'Don')
);


--Tim G4
--Create >0 new family groups.
INSERT INTO _Families (FamilyName, Origin) VALUES('Zelensky',58);
--Create >3 INSERT statements that can create new members in the _Members Table.
INSERT INTO _Members (Fname, lname, Age, Family) VALUES ('Beeglebard', 'Blartar', 44,37);
INSERT INTO _Members (Fname, lname, Age, Family) VALUES ('Karen', 'Siznoski', 52,37);
INSERT INTO _Members (Fname, lname, Age, Family) VALUES ('Frank', 'Zelensky', 52,37);
--Add atleast 2 origins to the origins table:
INSERT INTO _Origins (OriginName) VALUES ('Dothraki'), ('Wildling');
INSERT INTO _MembersParentJunction (ChildMemberId, ParentMemberId) VALUES(74,58);
INSERT INTO _MembersParentJunction (ChildMemberId, ParentMemberId) VALUES(76,58);



--Tariq G1
INSERT INTO _Origins (OriginName) VALUES('Jamaican');
INSERT INTO _Families (FamilyName, Origin) VALUES('Saddler',66);
INSERT INTO _Members (Fname, lname, Age, Family) VALUES('Tariq','Saddler',24,40);
INSERT INTO _Members (Fname, lname, Age, Family) VALUES('Cecil','Saddler',66,40);
INSERT INTO _MembersParentJunction (ChildMemberId, ParentMemberId) VALUES(78,80);


SELECT TOP (1000) * FROM [dbo].[_Members]
SELECT TOP (1000) * FROM [dbo].[_MembersParentJunction]
SELECT TOP (1000) * FROM [dbo].[_Families]
SELECT TOP (1000) * FROM [dbo].[_Origins]
--Cory G2
INSERT INTO _Origins(OriginName) VALUES('Keyan');
INSERT INTO _Origins(OriginName) VALUES('Abo');
INSERT INTO _Families (FamilyName, Origin) VALUES('Abdalah',70);
INSERT INTO _Members (Fname, lname, Age, Family) VALUES('Abdu','Abdalah',69,43);
INSERT INTO _Members (Fname, lname, Age, Family) VALUES('Abdulsaboor','Abdalah',39,43);
INSERT INTO _Members (Fname, lname, Age, Family) VALUES('Absko','Abdalah',25,43);
INSERT INTO _Members (Fname, lname, Age, Family) VALUES('Ahanti','Abdalah',25,43);
INSERT INTO _MembersParentJunction (ChildMemberId, ParentMemberId) VALUES(88,82);
