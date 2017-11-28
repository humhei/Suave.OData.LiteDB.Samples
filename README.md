  ## Run Sample
* cd GetStarted
* dotnet restore
* dotnet run
## CRUD Opreations
### GET
* request: 
  GET http://localhost:8080/odata/company(1)
* response:
    {"Id":1,"Name":"testCompany"}
* request: 
### POST
* request: 
  POST http://localhost:8080/odata/company {"Id":2,"Name":"AddCompany"}
* response:
  {"Id":2,"Name":"AddCompany"}
### DELETE
* request: 
  DEL http://localhost:8080/odata/company(2)
* response:
  {"Id":2,"Name":"AddCompany"}
### UPDATE
* request: 
  PUT http://localhost:8080/odata/company(1) {"Id":1,"Name":"UpdateCompany"}
* response:
  {"Id":1,"Name":"UpdateCompany"}  