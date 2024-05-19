using src.SOLID._4_InterfaceSegregation.TeamExample.IspViolation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.SOLID._4_InterfaceSegregation.TeamExample.IspViolation
{
    //In the current case, Manager should not work on Task, but still, it is forced to implement the WorkOnTask method.
    //This is a violation of the Interface Segregation Principle.
    public class Manager : ILead
    {
        public void AssignTask()
        {
            //Code to assign a task.
        }
        public void CreateSubTask()
        {
            //Code to create a sub task.
        }
        public void WorkOnTask()
        {
            throw new Exception("Manager can't work on Task");
        }
    }
}
