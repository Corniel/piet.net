namespace Piet.Syntax.Compilation;

public static class Compiler
{
    extension(Program program)
    {
        public CompilationResult Compile(string name, string @namespace)
        {
            var compilation = new CompilationResult(name, @namespace);
            program.Walk(compilation);

            while (compilation.Methods.Values.FirstOrDefault(m => m.ExitOnly)?.Block is { } exitOnly)
            {
                foreach(var method in compilation.Methods.Values)
                {
                    if (method.Block == exitOnly) continue;

                    foreach (var exp in method.Active.Where(e => e.Next == exitOnly))
                    {
                        method.Expressions[exp.Key] = new(exp.Key, exp.PT, exp.Command, exp.Value, Block.Black);
                    }
                }
                compilation.Methods.Remove(exitOnly);
            }

            return compilation;
        }
    
        private void Walk(CompilationResult compilation)
        {
            var start = program[Codel.EntryPoint];
            compilation.Methods[start] = new BlockMethod(start);

            var done = new HashSet<Path>();
            var loop = new HashSet<Path>();

            var q = new Queue<Path>();

            q.Enqueue(new Path(start, CC_DP.LR));
            done.Add(new Path(start, CC_DP.LR));

            while (q.TryDequeue(out var path))
            {
                Enqueue(path);
            }

            void Enqueue(Path path)
            {
                var (curr, pt) = path;

                loop.Clear();

                var method = compilation.Methods[curr];
                var next = curr.Neighbours[pt];

                while (next is { Reset: true, Block.Colour.HasColour: true })
                {
                    curr = next.Block;
                    next = curr.Neighbours[next.PT];

                    // Loop detected
                    if (!loop.Add(new(next.Block, next.PT)))
                    {
                        method.Expressions[pt] = new ExitExpression(pt);
                        return;
                    }
                }

                if (!curr.HasColour || !next.Block.HasColour)
                {
                    method.Expressions[pt] = new ExitExpression(pt);
                    return;
                }

                var expression = new Expression(
                    pt,
                    next.PT == pt ? null : next.PT,
                    next.Block.Colour - curr.Colour,
                    curr.Value,
                    next.Block);

                method.Expressions[pt] = expression;

                compilation.Methods.TryAdd(next.Block, new(next.Block));

                foreach (var todo in Pts(expression.Command, next.PT)
                    .Select(x => new Path(next.Block, x))
                    .Where(done.Add))
                    q.Enqueue(todo);
            }

            IEnumerable<CC_DP> Pts(Command cmd, CC_DP pt) => cmd switch
            {
                _ when cmd.Equals(Command.Switch) => [pt, pt.Switch()],
                _ when cmd.Equals(Command.Rotate) => [pt, pt.Rotate(1), pt.Rotate(2), pt.Rotate(3)],
                _ => [pt],
            };
        }
    }

    private readonly record struct Path(Block Block, CC_DP PT)
    {
        public override string ToString() => $"{PT} => {BlockMethod.Name(Block)}";
    }
}
