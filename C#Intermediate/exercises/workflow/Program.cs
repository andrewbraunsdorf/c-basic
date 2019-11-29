using System;
using System.Collections.Generic;


namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkFlowEngine workflow = new WorkFlowEngine();
            workflow.AddWorkFlowObject(new VideoUploader());
            workflow.AddWorkFlowObject(new CallWebService());
            workflow.AddWorkFlowObject(new SendEmail());
            workflow.AddWorkFlowObject(new ChangeStatus());

            workflow.Run();

            Console.ReadLine();
        }
    }
    interface IIWorkFlow
    {
        void Execute();
    }

    class VideoUploader : IIWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video");
        }
    }

    class CallWebService : IIWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Calling web service");
        }
    }

    class SendEmail : IIWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Sending an email");
        }
    }

    class ChangeStatus : IIWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("status changed");
        }
    }

    class WorkFlowEngine
    {
        private List<IIWorkFlow> Object;

        public WorkFlowEngine()
        {
            Object = new List<IIWorkFlow>();
        }
       public void AddWorkFlowObject(IIWorkFlow iObject)
        {
            Object.Add(iObject);
        }

        public void Run()
        {
            foreach (var eachObject in Object)
            {
                eachObject.Execute();
            }
        }
    }
}
