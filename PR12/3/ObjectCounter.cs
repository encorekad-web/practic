using System;

public class ObjectCounter
{
    private static int objectCount = 0;
    public ObjectCounter()
    {
        objectCount++;
    }
    public static void PrintObjectCount()
    {
        Console.WriteLine($"Количество созданных объектов: {objectCount}");
    }
}