using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    class New:ITaskState
    {
        public void Start(Task task)
        {
            Console.WriteLine("Уведомление менеджеров" );
        }
        public void Update(Task task)
        {
            Console.WriteLine("Уведомление менеджеров");
        }
        public void NextState(Task task)
        {
            Console.WriteLine("Choose: Confirmed = 1;Closed = 2 ");
            
            int choosedir = Convert.ToInt32(Console.ReadLine());

            if (choosedir == 1)
            {
                task.State = new Confirmed();
            }else if (choosedir == 2)
            {
                task.State = new Closed();
            }
        }
    }
}
