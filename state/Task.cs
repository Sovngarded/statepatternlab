using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    class Task
    {
        public ITaskState State { get; set; }
        public Task(ITaskState ts)
        {
            State = ts;
        }
        public void Start() { State.Start(this); }
        public void Update() { State.Update(this); }
        public void NextState() { State.NextState(this); }
    }
}
