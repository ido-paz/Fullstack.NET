# CORS - Cross-Origin Resource Sharing
* Cross-Origin Resource Sharing (CORS) is an HTTP-header based mechanism that allows a server to indicate any origins (domain, scheme, or port) other than its own from which a browser should permit loading resources. CORS also relies on a mechanism by which browsers make a "preflight" request to the server hosting the cross-origin resource, in order to check that the server will permit the actual request. In that preflight, the browser sends headers that indicate the HTTP method and headers that will be used in the actual request.

https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS

https://www.youtube.com/watch?v=4KHiSt0oLJ0

# Web application | web app
Is application software that is accessed using a web browser. Web applications are delivered on the World Wide Web to users with an active network connection


# ASP.NET Core Razor Pages
Razor Pages is a page-based model. UI and business logic concerns are kept separate, but within the page. Razor Pages is the recommended way to create new page-based or form-based apps for developers new to ASP.NET Core. Razor Pages provides an easier starting point than ASP.NET Core 

https://www.learnrazorpages.com/

https://learn.microsoft.com/en-us/aspnet/core/razor-pages

# Razor 
Razor is a markup syntax for embedding .NET based code into webpages. The Razor syntax consists of Razor markup, C#, and HTML. Files containing Razor generally have a .cshtml file extension. Razor is also found in Razor component files (.razor). Razor syntax is similar to the templating engines of various JavaScript single-page application (SPA) frameworks, such as Angular, React, VueJs, and Svelte

https://www.w3schools.com/asp/razor_intro.asp

https://learn.microsoft.com/en-us/aspnet/core/mvc/views/razor

# ASP.NET Core MVC
ASP.NET Core MVC is a rich framework for building web apps and APIs using the Model-View-Controller design pattern.

The Model-View-Controller (MVC) architectural pattern separates an application into three main groups of components: 
Models, Views, and Controllers. 
This pattern helps to achieve separation of concerns. Using this pattern, user requests are routed to a Controller which is responsible for working with the Model to perform user actions and/or retrieve results of queries. The Controller chooses the View to display to the user, and provides it with any Model data it requires.
The following diagram shows the three main components and which ones reference the others:
 
https://learn.microsoft.com/en-us/aspnet/core/mvc/

# SignalR
* SignalR is a library for ASP.NET that enables real-time communication between web servers and clients. It uses various techniques to establish a persistent connection, such as WebSockets, Server-Sent Events, or Long Polling. With SignalR, you can create applications that support scenarios such as chat, gaming, dashboards, or notifications.

# Blazor
* Blazor is a framework for building interactive web applications using C# and .NET. Blazor can run on the browser using WebAssembly (Blazor WebAssembly) or on the server using SignalR (Blazor Server). The main difference between them is where the application logic runs. In Blazor WebAssembly, the application logic runs on the client-side in a sandboxed environment, while in Blazor Server, the application logic runs on the server-side and the UI updates are sent to the client over a real-time connection.
Some of the advantages of using Blazor include:
1. Offline capabilities: Apps powered by Blazor can run offline once downloaded from the internet.
2. Reuse of C# skills ,Running .NET code in browsers: Blazor allows you to run .NET code in browsers, which was previously only possible with JavaScript.
3. Code sharing: Blazor enables sharing code across client- and server-side processes.
4. Choice between one or multiple applications: Blazor comes with two hosting models - Blazor Server and Blazor WebAssembly - which allow for flexibility in how you want to execute your application.
5. Performance: Blazor WebAssembly has near-native performance.

# WASM - WebAssembly
* WASM is a low-level assembly-like language with a compact binary format that runs with near-native performance. There are around 40 programming languages reported to support WebAssembly as a compilation target, including C/C++, C#/.NET, Rust, Java, Python, Elixir, and Go. 
Blazor WASM download size  can vary depending on several factors such as the size of the app’s dependencies and whether or not certain features like tree shaking are enabled. It is about 17- 7 MB (when gzip is used) 

https://learn.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-7.0

https://blazor-university.com/

