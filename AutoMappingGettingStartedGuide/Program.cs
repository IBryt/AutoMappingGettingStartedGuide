using AutoMapper;
using AutoMappingGettingStartedGuide.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddAutoMapper(config =>
{
    config.AllowNullCollections = false; //default false
    // config.DisableConstructorMapping();
    //config.DestinationMemberNamingConvention = new ExactMatchNamingConvention();
}, typeof(OrganizationProfile).Assembly);

var app = builder.Build();

// Validate the mapping configuration
app.Services.GetRequiredService<IMapper>()
    .ConfigurationProvider.AssertConfigurationIsValid();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    // Add a specific route for the HelloWorld action as the root
    endpoints.MapControllerRoute(
        name: "helloWorldRoute",
        pattern: "",
        defaults: new { controller = "Test", action = "HelloWorld" });
});

app.Run();
