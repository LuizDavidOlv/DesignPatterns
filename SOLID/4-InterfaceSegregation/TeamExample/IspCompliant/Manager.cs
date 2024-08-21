using src.SOLID._4_InterfaceSegregation.TeamExample.IspCompliant.Interfaces;

namespace src.SOLID._4_InterfaceSegregation.TeamExample.IspCompliant
{
    //All of the classes are now with separated responsibilities/purposes, distributed them on multiple interfaces, and provided good abstraction.
    public class Manager : ILead
    {
        public void AssignTask()
        {
            //Code to assign a Task
        }
        public void CreateSubTask()
        {
            //Code to create a sub taks from a task.
        }
    }
}
