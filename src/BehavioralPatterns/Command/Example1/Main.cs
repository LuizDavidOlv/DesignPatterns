using src.BehavioralPatterns.Command.Example1.Commands;

namespace src.BehavioralPatterns.Command.Example1
{
    public class CommandPattern
    {
        public static void Execute()
        {
            Invoker invoker = new();
            invoker.SetOnStart(new SimpleCommand("Say Hi"));
            Receiver receiver = new();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));
            invoker.DoSomethingImportant();
        }

    }
}
