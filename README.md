# Asp.Net Core extensions
Custom Asp.Net Core extensions, initially just adding Clacks middleware (http://www.gnuterrypratchett.com/).

## Clacks middleware
A very simple implementation that adds a custom header in adherence to http://www.gnuterrypratchett.com/.

> "A man is not dead while his name is still spoken."
> -- _Going Postal, Chapter 4 prologue_

### Package
To add the _X-Clacks-Overhead_ header in your response reference `Aschan.AspNetCore.Http`.

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
