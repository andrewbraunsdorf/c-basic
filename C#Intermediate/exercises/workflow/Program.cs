using System;
using System.Collections.Generic;


namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkFlowEngine workflow = new WorkFlowEngine();

            Console.ReadLine();
        }
    }

    class WorkFlowEngine
    {
        private List<IIWorkFlow> Object;

        public WorkFlowEngine()
        {
            Object = new List<IIWorkFlow>();
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
