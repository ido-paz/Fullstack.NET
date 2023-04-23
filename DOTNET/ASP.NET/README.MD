# .NET terminology
1. CLR - Common Language Runtime - handles memory allocation and management. A CLR is also a virtual machine that not only executes apps but also generates and compiles code on-the-fly using a JIT compiler.
2. Cross platform - The ability to develop and execute an application that can be used on multiple different operating systems, such as Linux, Windows, and iOS, without having to rewrite specifically for each one. This enables code reuse and consistency between applications on different platforms.
3. Framework - Comprehensive collection of APIs that facilitates development and deployment of applications that are based on a particular technology. In this general sense, ASP.NET Core and Windows Forms are examples of application frameworks. 
4. NET Framework - Runs only on Windows. Includes the Common Language Runtime (CLR), the Base Class Library (BCL), latest (and maybe last) version is 4.8.
5. Net Core - a free and open-source, managed computer software framework for Windows, Linux, and macOS operating systems. It is a cross-platform successor to .NET Framework.
6. .NET 5 and later versions - A cross-platform, high-performance, open-source implementation of .NET, Includes a Common Language Runtime (CLR) , a Base Class Library (BCL), previously called .NET CORE.

# ASP.NET - active server pages

1. ASP.NET - extends the .NET platform with tools and libraries specifically for building web sites , services.
2. ASP.NET CORE - A cross-platform, higher-performance, open-source implementation of ASP.NET.
3. Web applications - server application that mostly used by humans, mostly returns UI data in HTML, CSS, JS , Images format, additionally can return any other type of data.
    * a. SPA – single page application, structured as a single HTML page that has basic structure that is received once from a server plus logic written in JS/TS to render UI based on users choices , when additional data is needed , the client do async calls to the server and receives data normally in XML/JSON format, then client uses its internal logic to render the UI.
    * b. SSR – server-side rendering , returns the complete web page and resources for each request. .

<img src="SSR_VS_SSG_VS_SPA.jpg" />


4. Web API - server application that mostly in used by other applications, mostly returns data in JSON, XML format.

# ASP.NET Core fundamentals:
https://docs.microsoft.com/en-us/aspnet/core/fundamentals
1. The Startup class - the class that contains "ConfigureServices" method to configure the application services, "Configure" method to create the app's request processing pipeline.
2. Middleware - The request handling pipeline is composed as a series of middleware components. 
Each component performs operations on an HttpContext and either invokes the next middleware in the pipeline or terminates the request.
https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware
* a. Use - Adds a middleware delegate defined in-line to the application's request pipeline.
* b. Run - Adds a terminal middleware delegate to the application's request pipeline.
* c. Map - Branches the request pipeline based on matches of the given request path. If the request path starts with the given path, the branch is executed. 
To add custom middleware , add a class , receive "RequestDelegate" parameter type in its constructor,  add "public async Task Invoke(HttpContext httpContext)" method that implements its own logic and calls the next handler with "requestDelegate(httpContext)"  
3. Routing - Is the process of matching an incoming request to an route handler. Is based on data in the URL path and headers, the route handler can be a middleware, an action method in an MVC controller or a file aspx/razor page . ASP.NET Core routing gives you control over the URLs used by your app.
 
https://learn.microsoft.com/en-us/aspnet/core/fundamentals/Routing?view=aspnetcore-6.0

4. API controller - class that contains HTTP requests handlers for CRUD operations that can return data.

https://www.tutorialsteacher.com/webapi/web-api-controller
 
5. Model binding - mapping the data received from the request to method handlers parameters.
* a. Get, Delete - will bind automatically from the route, if receiving from other ways like query string we need to explicitly mention [FromQuery]
* b. Post, Put - will bind automatically from request body, if receiving from other ways like form we need to explicitly mention [FromForm]
* When uploading file prefer using form due to performance and simplicity
Model Binding in ASP.NET Core | Microsoft Docs
6. Model validation - we should never trust the data that received from the client (due to security, integrity reasons), for these reasons we should validate the data.
* a. by default validation happens due to validation filter (that is enabled by adding ApiController to the class) that processing data annotation that was defined on the model.
* b. to suppress default model validation filter and do manual validation using ModelState class, add in conifgureServices: 
services.Configure<ApiBehaviorOptions>(options => {	options.SuppressModelStateInvalidFilter = true;});

https://docs.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-6.0

7. Action Return Type - 
* a. ActionResult is a base class that wraps any data that returns to the client ,the default ActionResult is a JSON result .
* b. if we want to return a file use FileContentResult
* c. when using ActionResult or FileContentResult we can control the httpStatusCode when returning data to the client. 
https://restfulapi.net/http-status-codes/

8. Controller filters - In Startup.Configure in the AddController middleware add the Logic that runs before and after every controller action  methods , available filters:
* a. result - executes only after controller method handler
* b. action - Inherit  IAsyncActionFilter
* c. exception - Inherit  IExceptionFilter , to return a result use httpContext.Result 
* d. service

https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/filters

9. App service - A reusable component that provides app functionality. Services are registered in ConfigureServices and consumed across the app via dependency injection (DI) or ApplicationServices.

10. Dependency injection - Software design pattern that is in use in ASP.NET CORE, that enable receiving an instance of a preconfigured class in a depended class constructor or function, the pre-configuration in the ConfigureServices method , enables control of the type, lifetime of the provided instance that can be:
* a. Transient - creates a new instance of the service, every time you request it.  
* b. Scoped: creates a new instance for every scope. (Each request is a Scope). Within the scope, it reuses the existing service.
* c. Singleton: Creates a new Service only once during the application lifetime and uses it everywhere.

https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-6.0

11. Configuration - ASP.NET Core provides a configuration framework that gets settings as name-value pairs from an ordered set of configuration providers. You can read threw [Web Application Instance].Configuration , GetConnectionString for reading "ConnectionString" key.
Built-in configuration providers are available for a variety of sources, such as .json files (default), .xml files, environment variables, and command-line arguments. 
The default host builder will bind the appsettings to Configuration class static instance, to use it in any class , inject it in the class constructor , using service.Configure adds the class as a singleton instance.

12. Environments - Execution environments are set from the files that exists in root folder with name appsetting.[enviromentName].json ,the specific settings overrides the default. there are 3 default environments:
	* a. Development - environment for the developers , designers.
    * b. Staging - a nearly exact replica of a production environment for software testing and quality assurance (QA) team.
	* c. Production - environment for the clients.

13. Logging – add logger service threw AddLogging  , configure it , Inject ILogger in the desired class constructor to use it.

14. API documentation – enables viewing the Web API controllers action methods, request & response data structures, Swagger - OpenAPI provides documentation / testing interface  , enables  generating client code  . You can enable it in most of the Web API templates when creating new project , or when after installing Swashbuckle.AspNetCore package and configuring it according its GitHub documentation.
https://swagger.io/ , https://github.com/RicoSuter/NSwag/wiki/NSwagStudio


# CORS - Cross-Origin Resource Sharing
* Cross-Origin Resource Sharing (CORS) is an HTTP-header based mechanism that allows a server to indicate any origins (domain, scheme, or port) other than its own from which a browser should permit loading resources. CORS also relies on a mechanism by which browsers make a "preflight" request to the server hosting the cross-origin resource, in order to check that the server will permit the actual request. In that preflight, the browser sends headers that indicate the HTTP method and headers that will be used in the actual request.

https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS

https://www.youtube.com/watch?v=4KHiSt0oLJ0


# Authentication with JWT
JSON Web Token (JWT) is an open standard (RFC 7519) that defines a compact and self-contained way for securely transmitting information between parties as a JSON object. This information can be verified and trusted because it is digitally signed. JWTs can be signed using a secret (with the HMAC algorithm) or a public/private key pair using RSA or ECDSA.

Although JWTs can be encrypted to also provide secrecy between parties, we will focus on signed tokens. Signed tokens can verify the integrity of the claims contained within it, while encrypted tokens hide those claims from other parties. When tokens are signed using public/private key pairs, the signature also certifies that only the party holding the private key is the one that signed it.

https://jwt.io/

https://www.youtube.com/watch?v=7Q17ubqLfaM

https://he.wikipedia.org/wiki/JWT

https://www.infoworld.com/article/3669188/how-to-implement-jwt-authentication-in-aspnet-core-6.html
