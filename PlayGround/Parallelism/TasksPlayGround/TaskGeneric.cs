using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.Parallelism.TasksPlayGround
{
    class TaskGeneric
    {
      private Task<bool> DoTask()
        {
            while (true)
            {

            }
            TaskCompletionSource<bool> task = new TaskCompletionSource<bool>();

            return task.Task;
        }
        
    }
}
