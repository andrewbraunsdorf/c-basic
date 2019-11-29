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

    public class WorkFlow : IWorkflow
    {
        private readonly List<ITask> _tasks;

        public WorkFlow()
        {
            _tasks = new List<ITask>();
        }


        public void Add(ITask task)
        {
            _tasks.Add(task);
        }

        public void Remove(ITask task)
        {
            _tasks.Remove(task);
        }

        public IEnumerable<ITask> GetTasks()
        {
            return _tasks;
        }
    }

    class VideoUploader : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video");
        }
    }

    class CallWebService : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Calling web service");
        }
    }

    class SendEmail : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending an email");
        }
    }

    class ChangeStatus : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Status changed");
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
}