# MSBase-Inspired Full-Stack Demo (Vue + ASP.NET Core)

This project is a full-stack demonstration simulating clinical data management for multiple sclerosis (MS) patients. It is designed primarily for technical interview purposes and showcases modern web development techniques with a Microsoft technology stack.

## Purpose
-   Simulate realistic patient and visit records related to MS clinical data
-   Demonstrate API development and front-end integration
-   Showcase the use of both Entity Framework Core and Dapper for data access
-   Provide a ready-to-code environment for interview discussions and technical evaluation
## Tech Stack

-   **Frontend:**  Vue.js 3, Vite, Axios, Vue Router
-   **Backend:**  ASP.NET Core Web API
-   **Database:**  SQL Server (LocalDB or Express)
-   **ORMs:**  Entity Framework Core & Dapper
-   **Migration Tool:**  DbUp


## Getting Started

### Run the API
```bash
cd WebAPI
dotnet run
```
### Run the Front End
```bash
cd MsBase.Web
npm  install
npm run dev
```
## API Endpoints
-   `GET /api/patients`
-   `GET /api/patientvisits`
-   `POST /api/patientvisits`
-   `GET /api/patientvisits?patientId=101`

## Sample Entities

**Patient**

 ```json
{
  "patientId": 101,
  "firstName": "Alice",
  "lastName": "Gray",
  "gender": "Female",
  "dateOfBirth": "1989-07-15"
}
```

**PatientVisit**
```json
{  
"visitId": 1,  
"patientId": 101,  
"visitDate": "2025-06-01",  
"edssScore": 3.5,  
"diseaseCourse": "RRMS",  
"relapseReported": true  
}
```
## Manual ID Insert Example
If your `Patients` table uses `IDENTITY`, and you want to insert specific IDs manually, use:
```bash
SET IDENTITY_INSERT Patients ON;

INSERT INTO Patients (PatientId, FirstName, LastName, Gender, DateOfBirth)  
VALUES (101, 'Alice', 'Gray', 'Female', '1989-07-15');

SET IDENTITY_INSERT Patients OFF;
```
## Notes -
- All data is mock and safe for demonstration use only.
- No database authentication or sensitive information is required.
- Designed for fast, code-ready technical interviews.
## License
This project is intended for demonstration and interview use only. Do **not** use it in production environments or for real patient data.
