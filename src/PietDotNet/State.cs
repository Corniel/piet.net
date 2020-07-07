using System;
using System.Drawing;
using System.Text;

namespace PietDotNet
{
    public class State
    {
        public static State Intial(Program program)
        {
            Guard.NotNull(program, nameof(program));
            return new State(Pointer.Initial, Stack.Empty, program.SelectBlock((Point)default));
        }

        private State(Pointer pointer, Stack stack, ColourBlock block)
        {
            Pointer = pointer;
            Stack = stack;
            Block = block;
        }

        public Pointer Pointer { get; }
        public Stack Stack { get; }
        public ColourBlock Block { get; }
        public Point Position => Pointer.Position;
        public Codel Codel => Block.Codel;
        public long Value => Block.Value;

        public State SelectBlock(ColourBlock block) => new State(
             Pointer,
             Stack,
             block);

        public State PointerLeaves(ColourBlock block) => With(block.Leave(Pointer));
        public State SingleStep() => With(Pointer.SingleStep());
        public State Rotate() => With(Pointer.Rotate(1));
        public State Switch() => With(Pointer.Switch(1));
        
        internal State With(Pointer pointer, Stack stack) => new State(
            pointer,
            stack,
            Block);
      
        private State With(Pointer pointer) => new State(
            pointer,
            Stack,
            Block);

        internal State With(Stack stack) => new State(
            Pointer,
            stack,
            Block);

        /// <inheritdoc />
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append($"Cursor: {Pointer}, ");
            sb.Append($"Block: {Block.Codel.Colour.Debug()}, ");
            sb.Append($"Value: {Value}, ");
            sb.Append($"Stack: {{ {string.Join(", ", Stack)} }}");

            return sb.ToString();
        }
    }
}
