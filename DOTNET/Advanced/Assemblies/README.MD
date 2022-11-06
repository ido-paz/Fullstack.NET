# Assemblies
* Assemblies form the fundamental units of deployment, version control, reuse, activation scoping, and security permissions for .NET-based applications. An assembly is a collection of types and resources that are built to work together and form a logical unit of functionality. Assemblies take the form of executable (.exe) or dynamic link library (.dll) files, and are the building blocks of .NET applications. They provide the common language runtime with the information it needs to be aware of type implementations.

* In .NET and .NET Framework, you can build an assembly from one or more source code files. In .NET Framework, assemblies can contain one or more modules. This allows larger projects to be planned so that several developers can work on separate source code files or modules, which are combined to create a single assembly. For more information about modules

https://docs.microsoft.com/en-us/dotnet/standard/assembly/

## Create and use dll assembly from another assembly using Visual studio code :

1. Create a solution.
"dotnet new sln"
2. Create a class library project
"dotnet new classlib -o X"
3. Add code and build the class library
in the project folder "dotnet build"
4. Add project to solution
"dotnet sln add X/X.csproj"
--
5. Create a console app
"dotnet new console -o Y"
6. Add project to solution
"dotnet sln add Y/Y.csproj"
7. Add reference in project Y to project X
"dotnet add Y/Y.csproj reference X/X.csproj"
8. Add code that uses X logic and build the console app
in the project folder "dotnet build"
--
9. Build the solution
in the solution folder "dotnet build"

https://docs.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio-code?pivots=dotnet-6-0