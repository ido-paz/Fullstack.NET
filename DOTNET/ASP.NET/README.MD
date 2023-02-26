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

 


