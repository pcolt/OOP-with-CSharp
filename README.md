# .NET

### create new solution for multiple projects
dotnet new sln -n <nome-solution>
 
dotnet sln add <path-to-project>

dotnet build

### create a new project
dotnet new console -n <nome-del-progetto>

### run tests
dotnet test --logger "console;verbosity=detailed"

### debugging with .net
- create launch.json
ctrl+alt+p
.NET generate assets for build and debug

## MIGRATIONS
### add migration
dotnet ef migrations add migratioinName

### see list of migrations
dotnet ef migrations list

### update database if application does not do it by default
dotnet ef database update
