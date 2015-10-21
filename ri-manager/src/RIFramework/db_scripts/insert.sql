USE [RModDB];

INSERT INTO EventType(TypeID,Name) VALUES (100, 'Iteration');
INSERT INTO EventType(TypeID,Name) VALUES (101, 'IterationStart');
INSERT INTO EventType(TypeID,Name) VALUES (102, 'IterationEnd');
INSERT INTO EventType(TypeID,Name) VALUES (202, 'EvtEntryApproved');
GO

INSERT INTO Worker(WorkerID, Name, ObjectUID) VALUES (1, 'John Smith', 1);
INSERT INTO Worker(WorkerID, Name, ObjectUID) VALUES (2, 'Jane Doe', 2);
INSERT INTO Worker(WorkerID, Name, ObjectUID) VALUES (3, 'Max Mustermann', 3);
GO

SET IDENTITY_INSERT EventFields ON
GO

INSERT INTO EventFields(EventFieldID, EventTypeID, FieldName) VALUES (10001, 100, 'IterationName');
INSERT INTO EventFields(EventFieldID, EventTypeID, FieldName) VALUES (10101, 101, 'IterationName');
INSERT INTO EventFields(EventFieldID, EventTypeID, FieldName) VALUES (10102, 101, 'StartTick');
INSERT INTO EventFields(EventFieldID, EventTypeID, FieldName) VALUES (10201, 102, 'IterationName');
INSERT INTO EventFields(EventFieldID, EventTypeID, FieldName) VALUES (10202, 102, 'EndTick');
INSERT INTO EventFields(EventFieldID, EventTypeID, FieldName) VALUES (20202, 202, 'ProfileID');
GO

INSERT INTO Event(EventID, TypeID, ClockTick) VALUES (30001, 202, 1);
INSERT INTO Event(EventID, TypeID, ClockTick) VALUES (30002, 202, 2);
INSERT INTO Event(EventID, TypeID, ClockTick) VALUES (30003, 202, 3);
INSERT INTO Event(EventID, TypeID, ClockTick) VALUES (30004, 202, 4);
INSERT INTO Event(EventID, TypeID, ClockTick) VALUES (30005, 202, 7);
GO

INSERT INTO EventData(EventID, FieldID, FieldValue) VALUES (30001, 20202, '1');
INSERT INTO EventData(EventID, FieldID, FieldValue) VALUES (30002, 20202, '2');
INSERT INTO EventData(EventID, FieldID, FieldValue) VALUES (30003, 20202, '3');
INSERT INTO EventData(EventID, FieldID, FieldValue) VALUES (30004, 20202, '1');
INSERT INTO EventData(EventID, FieldID, FieldValue) VALUES (30005, 20202, '1');
GO

INSERT INTO EventApplications(EventID, WorkerID) VALUES (30001, 1);
INSERT INTO EventApplications(EventID, WorkerID) VALUES (30001, 2);
INSERT INTO EventApplications(EventID, WorkerID) VALUES (30002, 2);
INSERT INTO EventApplications(EventID, WorkerID) VALUES (30002, 3);
INSERT INTO EventApplications(EventID, WorkerID) VALUES (30003, 1);
INSERT INTO EventApplications(EventID, WorkerID) VALUES (30004, 1);
INSERT INTO EventApplications(EventID, WorkerID) VALUES (30005, 1);
GO

































GO