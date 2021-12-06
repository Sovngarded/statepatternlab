using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    class Closed :ITaskState
    {
        public void Start(Task task)
        {
            Console.WriteLine("Уведомление менеджеров");
        }
        public void Update(Task task)
        {
            Console.WriteLine("Уведомление менеджеров");
        }
        public void NextState(Task task) 
        {
          
        }
    }
}
