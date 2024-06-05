using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using DamilahExercise.Data;
using DamilahExercise.Repository.RepositoryImplementation;
using DamilahExercise.Repository.RepositoryInterfaces;
using DamilahExercise.Service.ServiceImplementation;
using DamilahExercise.Service.ServiceInterfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ISubjectRepository, SubjectRepository>();
builder.Services.AddScoped<ILiteratureRepository, LiteratureRepository>();
builder.Services.AddScoped<ISubjectService, SubjectService>();
builder.Services.AddScoped<ILiteratureService, LiteratureService>();
builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();
builder.Services.AddScoped<ITeacherService, TeacherService>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
           options.UseSqlServer(builder.Configuration.GetConnectionString("Damilah_DB")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Subject}/{action=ListSubjects}/{id?}");

app.Run();
