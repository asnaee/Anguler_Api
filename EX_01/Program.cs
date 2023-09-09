using EX_01;
using EX_01.ANG;
using EX_01.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<EMPDB>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("ASK")));
builder.Services.AddDbContext<appdb>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("Identity")));
builder.Services.AddDbContext<ApContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("AP")));
builder.Services.AddControllers(); 
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddCors((setup) =>
//{
//    setup.AddPolicy("default", (op) =>
//    {
//        op.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
//    });
//});
//builder.Services.AddCors((g) =>
//{
//    g.AddPolicy("NA", (p) =>
//    {
//        p.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
//    });
//});
builder.Services.AddCors(x => x.AddPolicy("df", p => p.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin()));
//builder.Services.AddCors(x => x.AddPolicy("df", p => p.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin()));

var app = builder.Build(); 

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("df");
//app.UseCors("NA");
//app.UseCors("default");
app.UseAuthorization();

app.MapControllers();

app.Run();
