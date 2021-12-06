using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    interface ITaskState
    {
        void Start(Task task);
        void Update(Task task);
        void NextState(Task task);
    }
}
