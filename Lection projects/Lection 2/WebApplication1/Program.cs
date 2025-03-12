using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebApplication1.Data;
using WebApplication1.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();/*(options =>*/
//{
//    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
//    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
//    options.IncludeXmlComments(xmlPath);
//});

builder.Services.AddDbContext<GameContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/api/v1/categories/", async (GameContext context) =>
    await context.Categories.ToListAsync()
);

app.MapGet("/api/v1/filtered", (string? name, GameContext context, int page = 1, int pageSize = 5) =>
{
    var query = context.Categories.AsQueryable();

    if (!string.IsNullOrEmpty(name))
        query = query.Where(x => x.Name.Contains(name));

    var items = query.Skip((page - 1) * pageSize).Take(pageSize).ToList();
    return items;
});

app.MapPost("/api/v1/post", (Category category, GameContext context) =>
    {
        try
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return Results.Created($"/categories/{category.CategoryId}", category);
        }
        catch
        {
            return Results.BadRequest();
        }
    }
);

app.MapDelete("/api/v1/delete/{id:int}", (int id, GameContext context) =>
    {
        var category = context.Categories.Find(id);
        if (category == null)
            return Results.NotFound();
        try
        {
            context.Categories.Remove(category);
            context.SaveChanges();
            return Results.NoContent();
        }
        catch 
        {
            return Results.BadRequest();
        }
    }
);

app.MapPut("/api/v1/{id:int}", (int id, Category category, GameContext context) =>
{
    var existingCategory = context.Categories.Find(id);
    if (existingCategory == null)
        return Results.NotFound($"category id {id} not found");
    /*if (context.Categories.Count(c => c.CategoryId == id) == 0)
        return Results.NotFound();
    if (category.CategoryId != id)
        return Results.NotFound();*/

    try
    {
        existingCategory.Name = category.Name;
        //context.Categories.Update(category);
        //context.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        context.SaveChanges();
        return Results.NoContent();
    }
    catch
    {
        return Results.BadRequest();
    }
}
);







var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
