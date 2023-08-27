
using Contracts;
using Entity;
using Microsoft.EntityFrameworkCore;
using Repository;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
// to add connection with database
builder.Services.AddDbContext<EmpoyeeDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// AddScopped, singleten and Transite to allow visiblity o fthe access and most of the time we use AddScopped
// AddScopped accept 2 parameters which are generic
builder.Services.AddScoped(typeof(DbContext), typeof(EmpoyeeDbContext));
builder.Services.AddScoped(typeof(IEmployees), typeof(EmployeeRepository));
builder.Services.AddScoped(typeof(IDepartements), typeof(DepartmentRepository));

builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}




app.UseAuthorization();

app.MapControllers();

app.Run();

// we use add-migration to convert the classes into real tables
// we always create the migration file inside the file the dbcontext is found
//2 TYPES OF CODE 
// first code- from classes generate database tables and second is the vice versal
// Architecture types - MVC,N-tier(we use in this project)
