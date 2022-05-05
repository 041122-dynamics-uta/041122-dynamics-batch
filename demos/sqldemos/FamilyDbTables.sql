CREATE DATABASE FamilyTree;


CREATE TABLE _Origins(
OriginId int IDENTITY(10, 4) Primary Key,
OriginName nvarchar(40) not null,
DateCreated DATETIME2 not null DEFAULT(GETDATE())
);

INSERT INTO _Origins (OriginName) VALUES('Nordic');

CREATE TABLE _Families(
FamilyId int IDENTITY(10, 3) Primary Key,
FamilyName nvarchar(40) not null,
Origin int not null FOREIGN KEY REFERENCES _Origins(OriginId),
DateCreated DATETIME2 not null DEFAULT(GETDATE())
);

INSERT INTO _Families (FamilyName, Origin) VALUES('GeraltsDotter',10);

CREATE TABLE _Members(
MemberIdId int IDENTITY(10, 2) Primary Key,
Fname nvarchar(30) not null,
lname nvarchar(30) not null,
Age TINYINT null Default 0,
DateCreated DATETIME2 not null DEFAULT(GETDATE()),
Family int not null FOREIGN KEY REFERENCES _Families(FamilyId)
);

INSERT INTO _Members (Fname, lname, Age, Family) VALUES('Aelfric','GeraltsDotter',19,10);
INSERT INTO _Members (Fname, lname, Age, Family) VALUES('Geralt','GeraltsDotter',19,10);

CREATE TABLE _MembersParentJunction(
JunctionId int IDENTITY(10, 5) Primary Key,
ChildMemberId int not null FOREIGN KEY REFERENCES _Members(MemberIdId),
ParentMemberId int not null FOREIGN KEY REFERENCES _Members(MemberIdId),
DateCreated DATETIME2 not null DEFAULT(GETDATE())
);

INSERT INTO _MembersParentJunction (ChildMemberId, ParentMemberId) VALUES(10,12);