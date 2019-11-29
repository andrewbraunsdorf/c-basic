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
            Console.ReadLine();
        }
    }
    interface IIWorkFlow
    {
        void Execute();
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
