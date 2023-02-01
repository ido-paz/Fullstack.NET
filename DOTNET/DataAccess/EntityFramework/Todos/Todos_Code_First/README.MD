# ADO.NET entity framework code first practice

* https://learn.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/new-database

1. Install microsoft.entityframework.core
2. microsoft.entityframeworkcore.sqlserver
3. microsoft.entityframeworkcore.tools
4. Create Item class 
5. Create TodosDB class that inharites from DbContext for enabling 	CRUD operation on Items data with GetAllItems,UpdateItem,InsertItem,DeleteItem methods , using the generated DbContext , DbSet.
6. Use add-migration , update-databases commands in powershell to create Todos Database , Items Table
7. Create UI that uses TodosDB CRUD methods to enable the user interacting with Items data collection 

* For example ,user interface:
<img src="./UI.png"/>

