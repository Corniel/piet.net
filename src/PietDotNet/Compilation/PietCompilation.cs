using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;

namespace PietDotNet.Compilation
{
    public static class PietCompilation
    {
        public static CSharpCompilation Create(Program program, string name)
        {
            Guard.NotNull(program, nameof(program));
            Guard.NotNullOrEmpty(name, nameof(name));

            var compilation = CSharpCompilation.Create
            (
                assemblyName: name,
                syntaxTrees: Array.Empty<CSharpSyntaxTree>(),
                references: new [] 
                {
                    MetadataReference.CreateFromFile(typeof(object).Assembly.Location)
                },
               options: new CSharpCompilationOptions(
                   outputKind: OutputKind.ConsoleApplication, 
                   optimizationLevel: OptimizationLevel.Release)
            );

            return compilation;
        }
    }
}
