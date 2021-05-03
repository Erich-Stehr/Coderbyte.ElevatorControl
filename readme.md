# Coderbyte Assessment: Elevator Control

## Scenario

Supply API over http used by multiple teams to control an elevator:

- user request to current floor
- user request to stop at specified floor
- car request for all current floor requests
- car request for next floor to be serviced

## Build/run

- From the root, `dotnet run --project .\ElevatorControl\ElevatorControl.csproj` will run at port 8080 through the appsettings.json configuration.
Adding the standard switch  `--URLs=http://localhost:3000` will switch to the specified port.

Accepted calls:
- PUT http://localhost:8080/Elevator/put?floor={N}&dir={1,-1}
- PUT http://localhost:8080/Elevator/put?floor={N}
- GET http://localhost:8080/Elevator/all
- POST http://localhost:8080/Elevator/next

From PowerShell, `Invoke-WebRequest "http://localhost:8080/elevator/put?floor=2&dir=-1" -method PUT` or a similar call from another web service caller works.

# Questions and Assumptions

- http, so no authentication? really?
- Which environment? Assuming Visual Studio, C#, .NET Core
    - .NET Core 3.1 as the LTS will be supported longer than .NET Core 5.0
- Assuming multiple elevators in API, will restrict to 1 in code
- Requirements change, so conceptual room for expansion provided by naming the controller instead of using the root API
- assuming that requesting the next floor removes that floor from service (otherwise another call will be needed to remove), change requires POST
- How is the number of floors being specified? (hard-coding to 3 for the first cut)
- 
- .

## 