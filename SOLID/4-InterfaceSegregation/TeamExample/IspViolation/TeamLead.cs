using src.SOLID._4_InterfaceSegregation.TeamExample.IspViolation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.SOLID._4_InterfaceSegregation.TeamExample.IspViolation
{
    public class TeamLead : ILead
    {
        public void AssignTask()
        {
            //Code to assign a task.
        }
        public void CreateSubTask()
        {
            //Code to create a sub task
        }
        public void WorkOnTask()
        {
            //Code to implement perform assigned task.
        }
    }
}
