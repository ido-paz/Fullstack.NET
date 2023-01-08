# Relationship summery practice - Shop
1. Create a script that will create Shop database that stores users ,orders , products data.
2. input validation: 
product must be above 0.1 price
order must have a product with quantity above 0
3. Data relationships:
<br/>
1 user can have  0 or multiple orders 
<br/>
1 order can have 1 user 
<br/>
1 order can have 0 or multiple products 
<br/>
1 product can have 0 or multiple orders
<br/>
4. Create a script to Insert some users , products, orders data to the tables , all the insert should be wrapped in a try catch , transaction.
5. Create a stored procedure that will select all users with orders that have products.
6. Create a stored procedure that will select all users orders with order summery value.
7. Create a stored procedure that will select all users orders that do not have products.
8. Create a stored procedure that will select the product that has been ordered that most.
