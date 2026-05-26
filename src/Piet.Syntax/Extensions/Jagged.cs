namespace Piet.Syntax;

public static class Jagged
{
    public static T[][] Array<T>(int width, int height)
    {
        var array = new T[width][];
        
        for (var index = 0; index < width; index++)
            array[index] = new T[height];

        return array;
    }
}
