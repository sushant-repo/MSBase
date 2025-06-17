CREATE TABLE PatientVisits (
    VisitId INT IDENTITY(1,1),
    PatientId INT NOT NULL,
    VisitDate DATE NOT NULL,
    EDSSScore DECIMAL(3,1),
    DiseaseCourse NVARCHAR(20),
    CreatedDateTime DATETIME2 NOT NULL CONSTRAINT DF_PatientVisits_CreatedDateTime DEFAULT GETDATE(),
    ModifiedDateTime DATETIME2 NULL,

    CONSTRAINT PK_PatientVisits PRIMARY KEY (VisitID),
    CONSTRAINT FK_PatientVisits_Patients
        FOREIGN KEY (PatientId)
        REFERENCES Patients (PatientId)
);

INSERT INTO PatientVisits (PatientId, VisitDate, EDSSScore, DiseaseCourse)
VALUES 
(1, '2025-06-01', 3.5, 'RRMS'),
(2, '2025-06-10', 5.0, 'SPMS'),
(3, '2025-06-15', 2.0, 'PPMS');