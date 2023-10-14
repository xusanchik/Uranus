using Microsoft.EntityFrameworkCore;
using Urans.Data;
using Urans.Interface;
using Urans.Repastory;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<ICourseRepastory, CoursRepastory>();
builder.Services.AddScoped<IUserRepastory, UserRepastory>();
builder.Services.AddScoped<ITeacherRepastory , TeacherRepastory>();
builder.Services.AddScoped<IHomworkRepastory, HomworkRepastory>();
builder.Services.AddScoped<ITaskRepastory, TaskRepastory>();
builder.Services.AddScoped<ICourseRepastory, CoursRepastory>();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
