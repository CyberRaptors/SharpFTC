using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpFTC.OpModeGenerator;
[Generator(LanguageNames.CSharp)]
public class Generator : IIncrementalGenerator
{
	const string JavaSourceOutputDirectory = "GeneratedJavaSource/";
	const string JavaClassOutputDirectory = "GeneratedJavaClasses/";
	const string JarOutputDirectory = "Jar/";

	public void Initialize(IncrementalGeneratorInitializationContext context)
	{
		var syntaxProvider = context.SyntaxProvider.CreateSyntaxProvider(
			predicate: (node, cancellationToken) => node is ClassDeclarationSyntax syntax && syntax.BaseList is not null,
			transform: (ctx, cancellationToken) => ctx
		);

		var incrementalValues = syntaxProvider
			.Combine(context.CompilationProvider)
			.Select((combined, cancellationToken) => {
				var ctx = combined.Left;

				if (ctx.SemanticModel.GetDeclaredSymbol(ctx.Node) is not INamedTypeSymbol classSymbol) return (null!, null!);

				return (null!, null!, null!);
			});
	}
}