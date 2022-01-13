using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Configuração para remover retorno de erros padrão da microsoft  
builder.Services.AddControllers().ConfigureApiBehaviorOptions(
    options =>
    {
        options.SuppressModelStateInvalidFilter = true;
    }
  );
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    c =>
    {                 //Tecnica de reflexo onde a variavel pega o proprio nome
        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
        c.IncludeXmlComments(xmlPath);
    }
 );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => 
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api curso");
        //configuaração para quando abrir ele ir direto para o swagger
        c.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
