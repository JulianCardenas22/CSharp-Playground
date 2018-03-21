using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PlayGround.Helps;

namespace PlayGround.Parallelism.TasksPlayGround
{
    class TaskExamples
    {

        
        public void StopTask()
        {
            // Cancellation token
            var cts = new CancellationTokenSource();
            var token = cts.Token;

            //Task Create  with Infinite Loop
            var task = new Task(() => {
                int i = 0;
                while (true) {
                    token.ThrowIfCancellationRequested();

                    Console.WriteLine($"{i++}\t"); }
            }
            , token);


            task.Start();


            Task.Factory.StartNew(() =>
           {
               token.WaitHandle.WaitOne();
               Console.WriteLine("Wait Handle released , cancelation requested");
           });

            var planned = new CancellationTokenSource();
            var preventative = new CancellationTokenSource();
            var emergency = new CancellationTokenSource();

            var paranoid = CancellationTokenSource.CreateLinkedTokenSource(planned.Token, preventative.Token, emergency.Token);


            Console.WriteLine("Main program done.");
            Console.ReadKey();
            cts.Cancel();
        }

        public void CreationStartTasks()
        {
            //Task  Create and Start
            Task.Factory.StartNew(() => Help.WriteCharacter('j'));

            //Task  Create
            var task = new Task(() => Help.WriteCharacter('u'));
            //Start
            task.Start();

            // Task with Object   Create -Start 
            Task.Factory.StartNew(Help.WriteCharacter, "Hello");

            // Task with Object   Create
            var taskObject = new Task(Help.WriteCharacter, 123);

            //Generic Task
            var text1 = "testing";
            var text2 = "this";

            var taskGeneric = new Task<int>(Help.TextLength, text1);
            taskGeneric.Start();

            // Generic Task
            Task<int> taskGeneric2 = Task.Factory.StartNew(Help.TextLength, text2);


            Console.WriteLine($"Length of {text1} is {taskGeneric.Result}  id is {taskGeneric.Id}");
            Console.WriteLine($"Length of {text2} is {taskGeneric2.Result} id is {taskGeneric.Id}");
            //WriteCharacter('l');

            Console.WriteLine("Main program done.");
            Console.ReadKey();
        }


       

    }
}
