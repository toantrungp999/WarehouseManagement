using System;
using System.IO;

public static class MyConsole
{
    public static void Start(string filename)
    {
        using (TextWriter writer = File.CreateText(filename))
        {
            Console.SetOut(writer);
            Console.WriteLine("***** Start Program *****");
        }
    }
}
