using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Ravenhill;
using Ravenhill.Services;

// Create a new WebAssembly host builder
var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Register the root component of the application
builder.RootComponents.Add<App>("#app");

// Register the HeadOutlet component for managing the document head content
builder.RootComponents.Add<HeadOutlet>("head::after");

// Add a scoped HttpClient service with the base address of the host environment
builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Add a scoped ThemeService to manage the application's theme settings
builder.Services.AddScoped<ThemeService>();

// Build and run the WebAssembly application
await builder.Build().RunAsync();