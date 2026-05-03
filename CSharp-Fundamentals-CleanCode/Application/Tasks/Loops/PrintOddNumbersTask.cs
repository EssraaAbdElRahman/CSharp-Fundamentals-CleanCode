using CSharp_Fundamentals_CleanCode.Core.Abstractions;
using CSharp_Fundamentals_CleanCode.Infrastructure.Services;

namespace CSharp_Fundamentals_CleanCode.Application.Tasks.Loops
{
    public class PrintOddNumbersTask : BaseTask
    {
        public PrintOddNumbersTask(InputService input, OutputService output) : base(input, output)
        {
        }

        protected override void Run()
        {
            int number = input.ReadInt();
            for (int i = 1; i <= number; i += 2)
                output.Print($"{i}");
        }
    }
}
