namespace SharpFTC.Tool;

static class DefaultProject
{
	public static readonly string DefaultJavaCompileTarget = """
	
	<Target Name="PrepareJavaFiles" BeforeTargets="Build">
		<Exec Command="javac -d GeneratedJavaClasses GeneratedJavaSources/*.java" />
		<Exec Command="jar cf GeneratedLibrary.jar -C GeneratedJavaClasses ." />
	</Target>
	""";

	public static string SharpFTCOpModeGeneratorAnalyzer(string version)
	{
		return $"""
		<ItemGroup>
			<Analyzer Include="$(NuGetPackageRoot)SharpFTC.OpModeGenerator\{version}\lib\netstandard2.0\SharpFTC.OpModeGenerator.dll" />
		</ItemGroup>
		""";
	}

	public static string SharpFTCInclude(string moduleName, string version)
	{
		return $"""
		<ItemGroup>
			<PackageReference Include="SharpFTC.{moduleName}" Version="{version}"/>
		</ItemGroup>
		""";
	}

	public static string ProjectConfig(
		string targetFramework,
		string sharpFTCVersion
	)
	{
		return $"""
		<Project Sdk="Microsoft.NET.Sdk">
			<PropertyGroup>
				<TargetFramework>{targetFramework}</TargetFramework>
				<ImplicitUsings>enable</ImplicitUsings>
				<Nullable>enable</Nullable>
			</PropertyGroup>

			{SharpFTCInclude("Core", sharpFTCVersion)}
			{SharpFTCInclude("OpModeGenerator", sharpFTCVersion)}

			{SharpFTCOpModeGeneratorAnalyzer(sharpFTCVersion)}

			{DefaultJavaCompileTarget}
		</Project>
		""";
	}
}