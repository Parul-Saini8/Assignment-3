var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

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

app.MapRazorPages();

// Custom configuration
app.Run(async (context) =>
{
    var themeName = "Fitness Tracker";
    var yourName = "Parul Saini";
    var currentTime = DateTime.Now;

    await context.Response.WriteAsync($"Theme: {themeName}<br />");
    await context.Response.WriteAsync($"Name: {yourName}<br />");
    await context.Response.WriteAsync($"Current Date and Time: {currentTime}<br />");
});

app.Run();

