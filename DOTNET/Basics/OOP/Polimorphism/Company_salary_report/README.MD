# Polimorphism practice - Company employees salaries report
<hr/>

* Create a payrol application that enable to create a company with their employees data and outputs a detailed report for each of them and a salaries summery.
* Use the following logic to create the needed classes :
1. Each user has a user name , role name[User||Employee||Manager], unique readonly numeric user ID.
2. Company has name and hourly rate
3. Employee salary is hourly rate* working hours.
4. Manager salary is employee salary * 1.2.

* Use the following code to generate the salaries report:

<pre>
Company msft = new Company(){ Name = "MSFT", HourlyRate = 200 };
msft.Employees = new Employee[]
{
    new Employee("Jake",100),
    new Employee("Kelly",100),
    new Employee("Laureen",100),
    new Manager("Mark",100)
};    
Console.Clear();
msft.PrintSalaries();
</pre>

* The output should be like this:
<img src="./UI.png"/>
