--IF (NOT EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE ('[' + name + ']' = 'RModDB' OR name = 'RModDB'))) CREATE DATABASE RModDB;
--GO

--ALTER DATABASE [RModDB]
--SET ONLINE; 
--GO

USE [RModDB];

CREATE TABLE Worker (
WorkerID int NOT NULL PRIMARY KEY,
Name nvarchar(40),
ObjectUID bigint
);

CREATE TABLE EventType (
TypeID int NOT NULL PRIMARY KEY,
Name nvarchar(40)
);

CREATE TABLE Event (
EventID bigint NOT NULL PRIMARY KEY,
TypeID int, --FK EventType.TypeID
ClockTick bigint --time when this event was executed
);

CREATE TABLE EventFields (
EventFieldID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
EventTypeID int, --FK EventType.TypeID
FieldName nvarchar(40)
);

CREATE TABLE EventData (
EventID bigint, --FK
FieldID int, --FK
FieldValue nvarchar(4000), --SQLServer supports XML data type. We may use this feature later on and change DB Schema to allow easier interoperability with user-defined event types...
PRIMARY KEY (EventID, FieldID)
);

CREATE TABLE EventApplications (
EventID bigint, --FK
WorkerID int, --FK
PRIMARY KEY (EventID, WorkerID)
);

ALTER TABLE Event ADD CONSTRAINT FK_Event_EventType
FOREIGN KEY(TypeID) REFERENCES EventType(TypeID)
ON UPDATE CASCADE ON DELETE CASCADE;

ALTER TABLE EventFields ADD CONSTRAINT FK_EventFields_EventType
FOREIGN KEY(EventTypeID) REFERENCES EventType(TypeID)
ON UPDATE CASCADE ON DELETE CASCADE;


ALTER TABLE EventData ADD CONSTRAINT FK_EventData_EventID
FOREIGN KEY(EventID) REFERENCES Event(EventID)
ON UPDATE CASCADE ON DELETE CASCADE;


ALTER TABLE EventData ADD CONSTRAINT FK_EventData_FieldID
FOREIGN KEY(FieldID) REFERENCES EventFields(EventFieldID)
ON UPDATE NO ACTION ON DELETE NO ACTION;


ALTER TABLE EventApplications ADD CONSTRAINT FK_EventApplications_EventID
FOREIGN KEY(EventID) REFERENCES Event(EventID)
ON UPDATE CASCADE ON DELETE CASCADE;


ALTER TABLE EventApplications ADD CONSTRAINT FK_EventApplications_WorkerID
FOREIGN KEY(WorkerID) REFERENCES Worker(WorkerID)
ON UPDATE CASCADE ON DELETE CASCADE;

