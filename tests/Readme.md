1. create class library in CsharpAutomaticTest  
`dotnet new classlib`
2. create test project into CsharpAutomaticTests.Test folder  
`dotnet new mstest`
3. create a solution for the two projects  
`dotnet new sln -n CsharpAutomaticTest`  
`dotnet sln add <path-to-projects>`
4. modify test project .csproj file  
```
<ItemGroup>
    <ProjectReference Include="..\CsharpAutomaticTests\CsharpAutomaticTests.csproj" />
</ItemGroup>
```
5. run tests
`dotnet test`
