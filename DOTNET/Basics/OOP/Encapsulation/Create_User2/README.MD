# Classes practice
* Create User class that holds UserName,Password string fields ,its constructors (overloading) can recieve :
1. No arguments
2. One string CSV argument in the format [userName],[password] (for example "ido,1234")
3. Two string arguments 
4. Add Created datetime field and initialze it to the date time of the user creation.
5. Add Count field that holds the number of users created
6. Add ID int field that holds the unique id of the created user
7. Add GetCount method that returns the number of users created
8. Create GetDetails method that returns all the instance fields in CSV format.
9. Throw exception is user name or password are empty or password exceeds 8 characters
10. add Age private field and public property , throw exception if age is smaller than 1 and bigger than 120.
* avoid code repitition