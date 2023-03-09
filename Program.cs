using DepartmentApp.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSqlite<DepartmentsContext>("Data Source=DepartmentsContex.db");


var app = builder.Build();


app.MapGet("/", () => "Hello World!");

app.Run();
