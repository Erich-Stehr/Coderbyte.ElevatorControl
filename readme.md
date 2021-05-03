# Coderbyte Assessment: Elevator Control

## Scenario

Supply API over http used by multiple teams to control an elevator:

- user request to current floor
- user request to stop at specified floor
- car request for all current floor requests
- car request for next floor to be serviced

## Build/run

- <single command to build/run service>

Accepted calls:
- POST http://localhost:8080/{carNumber}?floor={N}&dir=
- POST http://localhost:8080/{carNumber}?floor={N}
- GET http://localhost:8080/{carNumber}?all
- GET http://localhost:8080/{carNumber}?next

# Assumptions

- http, so no authentication? really?
- Which environment? Assuming Visual Studio, C#, .NET Core
    - .NET Core 3.1 as the LTS will be supported longer than .NET Core 5.0
- Assuming multiple elevators in API, will restrict to 1 in code
- 

## 