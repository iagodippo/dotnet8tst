using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var options = new MyOptions();
// Configurar o provedor de configuração
IConfiguration configuration = new ConfigurationBuilder()
    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
    .AddJsonFile("appsettings.json")
    .Build();

configuration.GetSection("MyOptions").Bind(options);

// Configurar o serviço de injeção de dependência
var serviceProvider = new ServiceCollection()
    .AddOptions()
    .Configure<MyOptions>(configuration.GetSection("MyOptions"))
    .AddTransient<ITeste, Teste>()
    .BuildServiceProvider();

var testeService = serviceProvider.GetService<ITeste>();
testeService.Write();