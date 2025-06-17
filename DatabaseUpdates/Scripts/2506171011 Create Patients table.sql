CREATE TABLE Patients (
    PatientId INT NOT NULL IDENTITY(1,1),
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100) NOT NULL,
    Gender NVARCHAR(10) NOT NULL,
    DateOfBirth DATE,
    CreatedDateTime DATETIME2 NOT NULL CONSTRAINT DF_Patients_CreatedDateTime DEFAULT GETDATE(),
    ModifiedDateTime DATETIME2 NULL,

    CONSTRAINT PK_Patients PRIMARY KEY (PatientId)
);

SET IDENTITY_INSERT dbo.Patients ON;

INSERT INTO Patients (PatientId, FirstName, LastName, Gender, DateOfBirth)
VALUES
    (1, 'Alice', 'Gray', 'Female', '1989-07-15'),
    (2, 'John', 'Smith', 'Male', '1982-02-22'),
    (3, 'Lina', 'Khan', 'Female', '1993-11-03');

SET IDENTITY_INSERT dbo.Patients OFF;
