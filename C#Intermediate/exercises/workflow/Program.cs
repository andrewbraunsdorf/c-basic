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
    public interface ITask
    {
        void Execute();
    }

    public interface IWorkflow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTasks();
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




public class WorkFlowEngine
    {

        public void Run(IWorkflow workflow)
        {
            foreach (ITask I in workflow.GetTasks())
            {

                I.Execute();
                
            }
        }
    }
