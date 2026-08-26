using KitchenShared.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Xunit;

namespace KitchenMessaging.Tests;

/// <summary>
/// A test class that verifies the loading of Kafka settings from the appsettings.Kitchen.json configuration file.
/// </summary>
public class KafkaSettingsTests : IClassFixture<TestFixture>
{
    /// <summary>
    /// Gets the Kafka settings loaded from the configuration for testing purposes.
    /// </summary>
    private readonly KafkaSettings _settings;
    /// <summary>
    /// Initializes a new instance of the <see cref="KafkaSettingsTests"/> class, using the provided <see cref="TestFixture"/> to access the service provider and retrieve the Kafka settings for testing.
    /// </summary>
    /// <param name="fixture">The test fixture that provides access to the service provider and configuration.</param>
    public KafkaSettingsTests(TestFixture fixture)
    {
        _settings = fixture.ServiceProvider.GetRequiredService<IOptions<KafkaSettings>>().Value;
    }
    /// <summary>
    /// Tests that the Kafka settings are correctly loaded from the appsettings.Kitchen.json configuration file, ensuring that the BootstrapServers, SaslUsername, and SaslPassword properties are not null or empty.
    /// </summary>
    [Fact]
    public void KafkaSettings_ShouldLoadFromAppSettings()
    {
        Assert.False(string.IsNullOrEmpty(_settings.BootstrapServers));
        Assert.False(string.IsNullOrEmpty(_settings.SaslUsername));
        Assert.False(string.IsNullOrEmpty(_settings.SaslPassword));
    }
}