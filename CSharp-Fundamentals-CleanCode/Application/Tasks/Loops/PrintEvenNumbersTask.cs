using CSharp_Fundamentals_CleanCode.Core.Abstractions;
using CSharp_Fundamentals_CleanCode.Infrastructure.Services;


namespace CSharp_Fundamentals_CleanCode.Application.Tasks.Loops
{
    public class PrintEvenNumbersTask : BaseTask
    {
        public PrintEvenNumbersTask(InputService input, OutputService output) : base(input, output)
        {
        }

        protected override void Run()
        {
            int number = input.ReadInt();
            for (int i = 2; i <= number; i += 2)
                output.Print($"{i}");
        }
    }
}
