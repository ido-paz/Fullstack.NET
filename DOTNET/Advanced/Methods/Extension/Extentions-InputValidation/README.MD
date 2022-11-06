Extention methods practice
<hr/>
1. Create int Between extention method that return true|false if the number is between.
for example:
<br/>
<code>
int a =4;
<br/>
System.Console.WriteLine("Between");
<br/>
System.Console.WriteLine($"{a} ,{1} , {9} : {a.Between(1,9)}");//true
<br/>
System.Console.WriteLine($"{b} ,{1} , {9} : {Extentions.Between(a,1,9)}");//true
<br/>
</code>
2. Create string HasNumber extention method that return true|false if the text contains a number
for example:
<code>
<br/>
string greatings = "Good evening";
<br/>
System.Console.WriteLine("HasNumber");
<br/>
System.Console.WriteLine($"{greatings} : {greatings.HasNumber()}");//false
<br/>
System.Console.WriteLine($"{password} : {password.HasNumber()}");//true
</code>