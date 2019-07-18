using System;

/// <summary>
/// Introduces person
/// </summary>
public class Person
{
    public string Name;
    public void Introduce()
    {
        Console.WriteLine("Hi, " + Name);
        System.Threading.Thread.Sleep(1000);
        
    }
    
    }
