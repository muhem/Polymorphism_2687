using System;
public class PrinterWindows
{
    public string Name { get; set; }

    public virtual void show()
    {
        Console.WriteLine("Mulai");
    }

    public virtual void print()
    {
        Console.WriteLine("Mulai");
    }

}