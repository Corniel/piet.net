using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using PietDotNet.IO;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PietDotNet.Compilation
{
    public static class PietCompilation
    {
        public static EmitResult Compile(this Program program, string name, DirectoryInfo location)
        {
            Guard.NotNull(program, nameof(program));
            Guard.NotNullOrEmpty(name, nameof(name));

            var trees = ParseFiles().ToArray();

            var compilation = CSharpCompilation.Create
            (
                assemblyName: name,
                syntaxTrees: trees,
                references: new [] 
                {
                    
                    MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
                    MetadataReference.CreateFromFile(typeof(System.AppContext).Assembly.Location),
                    MetadataReference.CreateFromFile(typeof(System.Runtime.ProfileOptimization).Assembly.Location),
                    MetadataReference.CreateFromFile(typeof(System.Console).Assembly.Location),
                    MetadataReference.CreateFromFile(typeof(System.Linq.Enumerable).Assembly.Location),
                    MetadataReference.CreateFromFile(typeof(System.Collections.Generic.HashSet<int>).Assembly.Location),
                    MetadataReference.CreateFromFile(typeof(System.Collections.Generic.ISet<int>).Assembly.Location),
                },
               options: new CSharpCompilationOptions(
                   outputKind: OutputKind.ConsoleApplication, 
                   optimizationLevel: OptimizationLevel.Release)
            );

            var binary = new[]
            {
                new ResourceDescription("binary.piet", () =>
                {
                    var stream = new MemoryStream();
                    program.Save(stream);
                    stream.Position = 0;
                    return stream;
                },
                true),
            };

            return compilation
                .Emit(
                    Path.Combine(location.FullName, compilation.AssemblyName + ".exe"), 
                    manifestResources: binary);
        }
    
        private static IEnumerable<SyntaxTree> ParseFiles()
        {
            return typeof(Program).Assembly.GetManifestResourceNames()
                .Where(name => Path.GetExtension(name) == ".cs")
                .Select(name =>
                {
                    using var stream = typeof(Program).Assembly.GetManifestResourceStream(name);
                    var reader = new StreamReader(stream);
                    return CSharpSyntaxTree.ParseText(reader.ReadToEnd());
                });
        }
    }
}
