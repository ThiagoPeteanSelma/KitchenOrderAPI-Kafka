using KitchenShared.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace KitchenMessaging.Tests;
/// <summary>
/// A test fixture that sets up the necessary services and configuration for testing Kafka messaging in the KitchenMessaging project.
/// </summary>
public class TestFixture
{
    /// <summary>
    /// Gets the service provider that can be used to resolve services and options for testing.
    /// </summary>
    public ServiceProvider ServiceProvider { get; }
    /// <summary>
    /// Initializes a new instance of the <see cref="TestFixture"/> class, setting up the configuration and services required for testing Kafka messaging.
    /// </summary>
    public TestFixture()
    {
        /// BaseDirectory aponta para bin/Debug/netX.X durante os testes
        var basePath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", ".."));

        /// Log para verificar o caminho durante execução
        Console.WriteLine($"[TestFixture] BasePath: {basePath}");

        /// Builds the configuration by loading the appsettings.Kitchen.json file from the src directory.
        var configuration = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.Kitchen.json", optional: false, reloadOnChange: true)
            .Build();
        /// Creates a new service collection and configures the KafkaSettings options using the loaded configuration.
        var services = new ServiceCollection();
        services.Configure<KafkaSettings>(configuration.GetSection("Kafka"));
        /// Builds the service provider from the configured services, allowing for dependency injection and service resolution in tests.
        ServiceProvider = services.BuildServiceProvider();
    }
}
