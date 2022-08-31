<header>
<strong>
Polimorphism practice - Company employees salaries report
</strong>
</header>
<hr/>
Create a payrol application that enable to create a company with their employees data and outputs a detailed report for each of them and a salaries summery.
<br/>
<strong>
Use the following logic to create the needed classes :
</strong>
<ul>
<li>
Each user has a user name , role name[User||Employee||Manager], unique readonly numeric user ID.
</li>
<li>
Company has name and hourly rate
</li>
<li>
Employee salary is hourly rate* working hours.
</li>
<li>
Manager salary is employee salary * 1.2.
</li>
</ul>
<strong>
Use the following code to generate the salaries report:
</strong>
<hr/>
<code>
Company msft = new Company(){ Name = "MSFT", HourlyRate = 200 };
<br/>
msft.Employees = new Employee[]{
<br/>
new Employee("Jake",100),
<br/>
new Employee("Kelly",100),
<br/>
new Employee("Laureen",100),
<br/>
new Manager("Mark",100)
<br/>
};    
<br/>
Console.Clear();
<br/>
msft.PrintSalaries();
</code>
<hr/>
<strong>
The output should be like this:
</strong>
<br/>
<img src="./UI.png"/>
