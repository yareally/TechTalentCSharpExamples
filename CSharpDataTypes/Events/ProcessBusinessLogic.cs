using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDataTypes.Events {
    //public delegate void Notify();  // delegate

    public class ProcessBusinessLogic
    {
        public event EventHandler<ProcessEventArgs> ProcessCompleted; // event

        public void StartProcess()
        {
            var data = new ProcessEventArgs();

            try {
                Console.WriteLine("Process Started!");
                data.IsSuccessful = true;
                data.CompletionTime = DateTime.Now;
                // some code here..
                // uncomment these 2 lines to trigger a failure
                //List<string> nullList = null;
                //nullList.Add("failllll");
                OnProcessCompleted(data);
 
            } catch (Exception e) {
                data.IsSuccessful = false;
                data.CompletionTime = DateTime.Now;
                OnProcessCompleted(data);
            }
        }

        protected virtual void OnProcessCompleted(ProcessEventArgs e) //protected virtual method
        {
            // if ProcessCompleted is not null then call delegate
            ProcessCompleted?.Invoke(this, e);
        }
    }

    public class ProcessEventArgs : EventArgs {
        public bool IsSuccessful { get; set; }
        public DateTime CompletionTime { get; set; }
    }
}
