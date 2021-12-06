using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    class Resolved:ITaskState
    {
        public void Start(Task task)
        {
            Console.WriteLine("Уведомление разработчиков и менеджеров");
        }
        public void Update(Task task)
        {
            Console.WriteLine("Уведомление менеджеров");
        }
        public void NextState(Task task)
        {   
            Console.WriteLine("Choose: InProcess = 1;Closed = 2 ");
            int choosedir = Convert.ToInt32(Console.ReadLine());
            
            if (choosedir == 1)
            {
                task.State = new InProcess();
            }
            else if (choosedir == 2)
            {
                task.State = new Closed();
            }
        }
    }
}
