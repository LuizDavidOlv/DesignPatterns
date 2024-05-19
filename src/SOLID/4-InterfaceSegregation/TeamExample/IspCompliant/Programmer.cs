using src.SOLID._4_InterfaceSegregation.TeamExample.IspCompliant.Interfaces;

namespace src.SOLID._4_InterfaceSegregation.TeamExample.IspCompliant
{
    //All of the classes are now with separated responsibilities/purposes, distributed them on multiple interfaces, and provided good abstraction.
    public class Programmer : IProgrammer
    {
        public void WorkOnTask()
        {
            //code to implement to work on the Task.
        }
    }
}
