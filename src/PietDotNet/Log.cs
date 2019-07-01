namespace PietDotNet
{
    public static class Log
    {
        public static string InsufficientStackSize(string command, Stack stack) => $"Could not perform {command} as the stack size of {stack.Count} is not sufficient.";
        public static string DivideByZero() => "Could not perform Divide as is would divide by zero.";
        public static string ModuloOnNotPositive(long value) => $"Could not perform Mod on the value {value}.";
        public static string InvalidInput() => "Received invalid input.";

        public static string Executed(string command, object value) => $"Executed {command}({value}).";
        public static string Executed(string command, long first, long second, object result) => $"Executed {command}({first}, {second}) => {result}.";
    }
}
