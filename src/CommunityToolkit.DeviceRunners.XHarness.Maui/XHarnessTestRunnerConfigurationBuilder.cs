using System.Reflection;

namespace CommunityToolkit.DeviceRunners.XHarness;

public class XHarnessTestRunnerConfigurationBuilder : IXHarnessTestRunnerConfigurationBuilder
{
	readonly MauiAppBuilder _appHostBuilder;
	readonly List<Assembly> _testAssemblies = new();
	readonly List<string> _skipCategories = new();

	public XHarnessTestRunnerConfigurationBuilder(MauiAppBuilder appHostBuilder)
	{
		_appHostBuilder = appHostBuilder;
	}

	internal XHarnessTestRunnerUsage RunnerUsage { get; set; } = XHarnessTestRunnerUsage.Automatic;

	void IXHarnessTestRunnerConfigurationBuilder.AddTestAssembly(Assembly assembly) =>
		_testAssemblies.Add(assembly);

	void IXHarnessTestRunnerConfigurationBuilder.SkipCategory(string category, string skipValue) =>
		_skipCategories.Add($"{category}={skipValue}");

	void IXHarnessTestRunnerConfigurationBuilder.AddTestPlatform<TTestRunner>() =>
		_appHostBuilder.Services.AddSingleton<ITestRunner, TTestRunner>();

	IXHarnessTestRunnerConfiguration IXHarnessTestRunnerConfigurationBuilder.Build() =>
		Build();

	public XHarnessTestRunnerConfiguration Build() =>
		new(_testAssemblies, _skipCategories);
}
