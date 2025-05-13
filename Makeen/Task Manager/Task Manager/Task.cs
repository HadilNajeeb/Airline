using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{

    
    public enum TaskManager
    {
Low,
        Medium,
        High
    }
    public class Task
    {
        public string Title {  get; set; }  
        public string Priority {  get; set; }   
        public bool Completed {  get; set; }    
        public Task(string Title, string Priority)
        {
           this.Title = Title;
            this.Priority = Priority;
            this.Completed = false;
        }
        public void Complete()
        {
            Completed = true;   

        }

        public delegate void TaskCompleted(Task task);
        public event TaskCompleted OnCompleted;

    }

    public class Manager
    {
        private List<Task> task = new List<Task>();
        public Task this[int index]
        {
            get {  return task[index]; }    
        }
        public static Manager operator +(Manager a, Manager b)
        {
            Manager.task.add(Task);
            return Manager;
        }
        public void Display()
        {
            for (int i = 0; i < task.Count; i++) {

                Console.WriteLine($"{i + 1}.{task[i].Task}-{task[i].priority} {("completed " : "pending")});
        }
        }
    }
}
