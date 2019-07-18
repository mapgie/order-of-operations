using System;

namespace FirstCmdLineApp.MovingParts
{
    public class Person
    {
        public string Name;

        public void Introduce()
        {
            Console.WriteLine("Hi, " + Name);
        }

        public void Present()
        {
            Console.WriteLine("I am " + Name);
        }

    }
}