namespace System;

public static class Jagged
{
    public static T[][] Array<T>(int first, int second)
    {
        var array = new T[first][];
        
        for (var index = 0; index < first; index++)
        {
            array[index] = new T[second];
        }
        return array;
    }
}
