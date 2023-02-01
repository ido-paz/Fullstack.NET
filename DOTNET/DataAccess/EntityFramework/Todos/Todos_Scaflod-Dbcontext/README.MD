# ADO.NET entity framework db first practice

* https://learn.microsoft.com/en-us/ef/core/cli/powershell

1. Install microsoft.entityframework.core
2. microsoft.entityframeworkcore.sqlserver
3. microsoft.entityframeworkcore.tools
4. use scafold-dbconext command in powershell to generate Todos DbContext , with Items DbSet
4. Create TodosDB class that enable CRUD operation on Items data 
	with GetAllItems,UpdateItem,InsertItem,DeleteItem methods , using the generated DbContext , DbSet.
5. Create UI that uses TodosDB CRUD methods to enable the user interacting with Items data collection 

* For example ,user interface:
<img src="./UI.png"/>

