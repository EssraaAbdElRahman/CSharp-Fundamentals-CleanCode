using CSharp_Fundamentals_CleanCode.Core.Abstractions;
using CSharp_Fundamentals_CleanCode.Infrastructure.Services;

namespace CSharp_Fundamentals_CleanCode.Application.Tasks.Basics
{
    public class DivisibleByThreeAndFiveTask : BaseTask
    {
        public DivisibleByThreeAndFiveTask(InputService input, OutputService output) : base(input, output)
        {
        }
        protected override void Run()
        {
            int number =input.ReadInt();
            if (number % 3 == 0 && number % 5 == 0)
            {
                output.Print($"{number} is divisible by both 3 and 5.");
            }
            else
            {
                output.Print($"{number} is not divisible by both 3 and 5.");
            }
        }
    }
}
