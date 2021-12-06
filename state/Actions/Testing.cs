using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    class Testing:ITaskState
    {
        public void Start(Task task)
        {
            Console.WriteLine("Уведомление тестеров");
        }
        public void Update(Task task)
        {
            Console.WriteLine("Уведомление тестеров и менеджеров");
        }
        public void NextState(Task task)
        {   
            Console.WriteLine("Choose: InProcess = 1;Resolved = 2 ");
            int choosedir = Convert.ToInt32(Console.ReadLine());
            
            if (choosedir == 1)
            {
                task.State = new InProcess();
            }
            else if (choosedir == 2)
            {
                task.State = new Resolved();
            }
        }
    }
}
