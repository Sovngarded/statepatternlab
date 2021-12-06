using System;

namespace state
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task(new New());
            
            for (; ;)
            {
            task.Start();
            task.Update();
            task.NextState();
                
            }
            



        }
    }
}
