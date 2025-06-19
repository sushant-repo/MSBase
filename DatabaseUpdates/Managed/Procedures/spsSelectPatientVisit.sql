CREATE PROCEDURE spsSelectPatientVisit (
	@PatientId INT
)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT PatientVisits.VisitId,
		PatientVisits.PatientId,
		PatientVisits.EDSSScore,
		PatientVisits.DiseaseCourse,
		Patients.FirstName,
		Patients.LastName,
		Patients.DateOfBirth,
		Patients.Gender
	FROM dbo.PatientVisits
	INNER JOIN dbo.Patients
		ON Patients.PatientId = PatientVisits.PatientId
	WHERE Patients.PatientId = @PatientId;
END