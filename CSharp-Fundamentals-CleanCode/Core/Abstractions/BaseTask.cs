using CSharp_Fundamentals_CleanCode.Infrastructure.Services;

namespace CSharp_Fundamentals_CleanCode.Core.Abstractions
{
    public abstract class BaseTask : ITask
    {
        protected readonly InputService input;
        protected readonly OutputService output;
        protected BaseTask(InputService input, OutputService output)
        {
            this.input = input;
            this.output = output;
        }
        public void Execute()
        {
            do 
            { 
                Run(); 
            }
            while (AskTryAgain());
        }
        protected abstract void Run();

        private bool AskTryAgain()
        {
            output.Print("Try again? (y/n)");
            return input.ReadString().Trim()
                         .Equals("y", StringComparison.OrdinalIgnoreCase);
        }
    }
}