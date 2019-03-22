# Asp.Net Core Extensions
Custom Asp.Net Core extensions, initially just adding Clacks middleware (http://www.gnuterrypratchett.com/)

## Clacks   Middleware
A very simple implementation that adds a custom header in adherence to http://www.gnuterrypratchett.com/.

### Package
To add the X-Clacks-Overhead header in your response reference `Aschan.AspNetCore.Http`.

### Configure
In `Startup.Configure`, add the middleware to the service connection.

```
public void Configure(IApplicationBuilder app)
{
    if (env.IsDevelopment())
        app.UseDeveloperExceptionPage();
    else
        app.UseHsts();

    app.UseClacks();
    app.UseMvc();
}
```
