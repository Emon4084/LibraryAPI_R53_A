using LibraryAPI_R53_A.Core.Domain;
using LibraryAPI_R53_A.Core.Interfaces;
using LibraryAPI_R53_A.Core.Repositories;
using LibraryAPI_R53_A.Persistence;
using LibraryAPI_R53_A.Persistence.Repositories;
using LibraryAPI_R53_A.Persistence.services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddEndpointsApiExplorer();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Authentication", Version = "v1" });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT",
        Description = "JWT Authentication header using it",
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] { }
        }
    });
});
//CORS
builder.Services.AddCors(options =>
    options.AddPolicy(name: "AngularPolicy",
        cfg => {
            cfg.AllowAnyHeader();
            cfg.AllowAnyMethod();
            cfg.WithOrigins(builder.Configuration["AllowedCORS"]);
        }));


builder.Services.AddDbContext<ApplicationDbContext>(options =>

    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")
    )
);


#region Step 04
// able to Inject JWTService class inside my Controller
builder.Services.AddScoped<JWTService>();
#endregion 

#region setp 01
// --------------- 01 ----------------
// defining identityCOre Service
builder.Services.AddIdentityCore<ApplicationUser>(options =>
{
    // password Configuration
    options.SignIn.RequireConfirmedAccount = true;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 6;
})
    .AddRoles<IdentityRole>() //  able to add roles
    .AddRoleManager<RoleManager<IdentityRole>>() // able to make use of RoleManager
    .AddEntityFrameworkStores<ApplicationDbContext>() // my context
    .AddSignInManager<SignInManager<ApplicationUser>>() // make use of signIn manager
    .AddUserManager<UserManager<ApplicationUser>>() // make use of userManager to create users
    .AddDefaultTokenProviders(); // able to create tokens for email confimation
// ------------ End 01 -------------------
#endregion

#region Step 05
// Authenticate users using this JWT
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            // validate the token based on the key we have provided inside appsetting.deleopment.json JWT:Key
            ValidateIssuerSigningKey = true,
            // the issuer singing key based on JWT:Key
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"])),
            // the issuer which in here is the api project url we r using
            ValidIssuer = builder.Configuration["JWT:Issuer"],
            // validate the issuer (who ever is issiung the JWT) 
            ValidateIssuer = true,
            // (angular side )
            ValidateAudience = false
        };
    });
#endregion 

//DI
builder.Services.AddTransient<IPublisher, PublisherRepository>();
builder.Services.AddTransient<ISubscriptionPlan, SubsPlanRepository>();
builder.Services.AddTransient<ICategory, CategoryRepository>();
builder.Services.AddTransient<IRepository<BookFloor>, BookFloorRepository>();

// Add Authentication services & middlewares
//builder.Services.AddAuthentication(opt =>
//{
//    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//}).AddJwtBearer(options =>
//{
//    options.TokenValidationParameters = new TokenValidationParameters
//    {
//        RequireExpirationTime = true,
//        ValidateIssuer = true,
//        ValidateAudience = true,
//        ValidateLifetime = true,
//        ValidateIssuerSigningKey = true,
//        ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
//        ValidAudience = builder.Configuration["JwtSettings:Audience"],
//        IssuerSigningKey = new SymmetricSecurityKey(
//            System.Text.Encoding.UTF8.GetBytes(
//                builder.Configuration["JwtSettings:SecurityKey"]))
//    };
//});

//builder.Services.AddScoped<JwtHandler>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Step 06   -- app.UseAuthentication();
app.UseAuthentication();
app.UseAuthorization();
//Cors
app.UseCors("AngularPolicy");

app.MapControllers();

app.Run();
