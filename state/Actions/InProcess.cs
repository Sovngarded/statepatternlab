using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    class InProcess:ITaskState
    {
        public void Start(Task task)
        {
            Console.WriteLine("Уведомление разработчиков и менеджеров");
        }
        public void Update(Task task)
        {
            Console.WriteLine("Уведомление разработчиков и менеджеров");
        }
        public void NextState(Task task)
        {   
            Console.WriteLine("Choose: Testing = 1;Closed = 2;Resolved = 3 ");
            int choosedir = Convert.ToInt32(Console.ReadLine());
            if (choosedir == 1)
            {
                task.State = new Testing();
            }
            else if (choosedir == 2)
            {
                task.State = new Closed();
            }
            else if (choosedir == 3)
            {
                task.State = new Resolved();
            }
        }
    }
}
