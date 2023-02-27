# Middlewares , HTTP status codes , Products practice

*Create a http service application that recieves requests to perform CRUD operations on products collection

1. The service will handle requests sended to https://localhost:6666/products
2. When the client uses get request - the service should return the products in a json format
3. When the client uses post request :
	* without paramters - the service should return badrequest status code
	* with existing id paramter - the service should return badrequest status code
	* with id,name,price paramters - the service should return created status code
4. When the client uses put request :
	* without paramters - the service should return badrequest status code
	* with non existing id paramter - the service should return notfound status code
	* with existing id,name,price paramters - the service should return nocontent status code
5. When the client uses delete request :
	* without paramter - the service should return badrequest status code
	* with non existing id paramter - the service should return notfound status code
	* with existing id price paramter - the service should return nocontent status code
6. For requests sended to route other than https://localhost:6666/products - the service should return notfound status code
7. In case of exception - the service should return ServerError status code