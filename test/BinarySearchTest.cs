﻿using System;
using System.IO;
using System.Text.Json;

public class BinarySearchTest
{
    public void Test1(string[] args)
    {
        if (args.Length <= 0
                || !File.Exists(args[0])
                )
        {
            Console.WriteLine("no data.json.");
            Console.ReadKey();
            return;
        }

        FileStream fileStream = new FileStream(args[0], FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        JsonDocument jsonDocument = JsonDocument.Parse(fileStream);

        JsonElement jsonElement = jsonDocument.RootElement.GetProperty(nameof(BinarySearch));
        int[] array1 = new int[jsonElement.GetArrayLength()];
        int index = 0;
        foreach (var item in jsonElement.EnumerateArray())
        {
            array1[index++] = item.GetInt32();
        }

        Console.WriteLine(BinarySearch.IndexOf(array1, 5)); //2
        Console.ReadKey();
    }
}