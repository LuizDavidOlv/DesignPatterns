using src.SOLID._4_InterfaceSegregation.TeamExample.IspCompliant.Interfaces;

namespace src.SOLID._4_InterfaceSegregation.TeamExample.IspCompliant
{
    //All of the classes are now with separated responsibilities/purposes, distributed them on multiple interfaces, and provided good abstraction.
    public class TeamLead : IProgrammer, ILead
    {
        public void AssignTask()
        {
            //Code to assign a Task
        }
        public void CreateSubTask()
        {
            //Code to create a sub task from a task.
        }
        public void WorkOnTask()
        {
            //code to implement to work on the Task.
        }
    }
}
