# The_Dot_Net_Repo

### 1. What is ApiController attribute?
The [ApiController] attribute applies inference rules for the default data sources of action parameters. These rules save you from having to identify binding sources manually by applying attributes to the action parameters.

### 2.Square brackets?
It's a placeholder (called token replacement) for the controller's name without the suffix Controller . 	

### 3.What is Addcontrollers?
The AddController method Registers everything that is needed for Web API Development. The services include Support for Controllers, Model Binding, API Explorer, Authorization, CORS, Validations, Formatter Mapping, etc.

### 4.Add Transient ?
objects are always different; a new instance is provided to every controller and every service.
Transient lifetime services are created each time they are requested. This lifetime works best for lightweight, stateless services.
since they are created every time they will use more memory & Resources and can have the negative impact on performance

### 5.Add Scoped ?
Scoped objects are the same within a request, but different across different requests.
Scoped lifetime services are created once per request within the scope. It is equivalent to a singleton in the current scope. For example, in MVC it creates one instance for each HTTP request, but it uses the same instance in the other calls within the same web request.
better option when you want to maintain state within a request



### 6.Singleton ?
Singleton objects are the same for every object and every request.
Singleton which creates a single instance throughout the application. It creates the instance for the first time and reuses the same object in the all calls.memory leaks in these services will build up over time. also memory efficient as they are created once reused everywhere.


**Never inject Scoped & Transient services into Singleton service.(This effectively converts the transient or scoped service into the singleton.))

**Never inject Transient services into scoped service ( This converts the transient service into the scoped.)


### 9. UseHttpsRedirection  ?
UseHttpsRedirection causes an automatic redirection to HTTPS URL when an HTTP URL is received, in a way that forces a secure connection.
The HTTPS Redirection Middleware (UseHttpsRedirection) to redirect all HTTP requests to HTTPS.

### 10. UseHsts
UseHsts, HTTP Strict Transport Security Protocol (HSTS).
UseHsts adds the Strict-Transport-Security header to the response, which informs the browser that the application must only be accessed with HTTPS. After this declaration, compliant browsers should automatically convert any http request of the application into an HTTPS request.

**Once the first HTTPS secure connection is established, the strict-security header prevents future redirections that might be used to perform man-in-the-middle attacks.


###  11. app.UseRouting();
UseRouting adds route matching to the middleware pipeline. This middleware looks at the set of endpoints defined in the app, and selects the best match based on the request. UseEndpoints adds endpoint execution to the middleware pipeline. It runs the delegate associated with the selected endpoint


### 12.app.UseAuthorization();
UseAuthorization to ensure that authentication and authorization are used by your web app



### 13.Authorization
Authorization defines what a given user can do within the app. It's separate from authentication, which is concerned merely with identifying who the user is. ASP.NET Core provides a simple, declarative role and a rich, policy-based model for authorization. Specifying that a resource requires authorization is often as simple as adding the [Authorize] attribute to the action or controller.




