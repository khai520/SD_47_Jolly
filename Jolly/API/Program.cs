using API.Data;
using API.HeThong;
using API.Models.DTO;
using API.Repository;
using API.Repository.IRepository;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.WebHost.UseUrls("https://localhost:7118", "http://localhost:5078");
var app = builder.Build();
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();
app.Run();