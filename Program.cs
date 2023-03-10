//using RezLiveApis.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();
//builder.Services.AddControllers().AddXmlDataContractSerializerFormatters();
builder.Services.AddControllers().AddXmlSerializerFormatters();
//builder.Services.AddSingleton<IHolidaysApiService, HolidaysApiService>();
//builder.Services.AddHttpClient("PublicHolidaysApi", c => c.BaseAddress = new Uri("https://date.nager.at"));


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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
