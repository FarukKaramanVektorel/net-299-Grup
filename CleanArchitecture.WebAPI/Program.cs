using CleanArchitecture.Application;
using CleanArchitecture.Application.Orders;
using CleanArchitecture.Infrastructure;
using CleanArchitecture.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
builder.Services.AddAplication();
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

using(var scope = app.Services.CreateScope())
{
    scope.ServiceProvider.GetRequiredService<AppDbContext>().Database.EnsureCreated();
}

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseDefaultFiles();
app.UseStaticFiles();
var api = app.MapGroup("/api/orders");

api.MapGet("/",async (OrderService svc) =>Results.Ok(await svc.GetAllAsync()));
api.MapPost("/", async (CreateOrderRequest req, OrderService svc)=>{
	try
	{
		var created = await svc.CreateAsync(req);
		return Results.Created($"/api/orders/{created.Id}", created);
	}
	catch (ArgumentException ex)
	{

		return Results.BadRequest(new {error=ex.Message});
	}
   
});

api.MapPost("/addall", async (List<CreateOrderRequest> req, OrderService svc) => {
    try
    {
        var created = await svc.CreateAsync(req);
        return Results.Ok(created);
    }
    catch (ArgumentException ex)
    {

        return Results.BadRequest(new { error = ex.Message });
    }

});


api.MapPost("/{id:int}/ship", async (int id, OrderService svc) =>
{
	try
	{
		var o=await svc.CancelAsync(id);
		return o is null?Results.NotFound():Results.Ok(o);
	}catch(InvalidOperationException ex)
	{
        return Results.BadRequest(new { error = ex.Message });
    }
});


api.MapPost("/{id:int}/cancel", async (int id, OrderService svc) =>
{
    try
    {
        var o = await svc.CancelAsync(id);
        return o is null ? Results.NotFound() : Results.Ok(o);
    }
    catch (InvalidOperationException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
});

app.Run();


