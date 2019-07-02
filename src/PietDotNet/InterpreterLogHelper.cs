using System;

namespace PietDotNet
{
    internal class InterpreterLogHelper
    {
        private readonly Interpreter _interpreter;

        public InterpreterLogHelper(Interpreter interpreter)
        {
            _interpreter = interpreter;
        }

        public string InvalidRollDepth(long depth)=> $"{this} The depth ({depth}) of  the Roll to perform is invalid.";
        public string InsufficientStackSize(string command, Stack stack) => $"{this} Could not perform {command} as the stack size of {stack.Count} is not sufficient.";
        public string DivideByZero() => $"{this} Could not perform Divide as is would divide by zero.";
        public string ModuloOnNotPositive(long value) => $"{this} Could not perform Mod on the value {value}.";
        public string InvalidInput() => $"{this} Received invalid input.";

        public string Executed(string command, object value) => $"{this} Executed {command}({value}).";
        public string Executed(string command, long first, long second, object result) => $"{this} Executed {command}({first}, {second}) => {result}.";

        public override string ToString() => $"{_interpreter.curr.RgbCode} ({_interpreter.currPoint.X,2}, {_interpreter.currPoint.Y,2})";

       
    }
}
