using CSharp_Fundamentals_CleanCode.Core.Abstractions;
using CSharp_Fundamentals_CleanCode.Infrastructure.Services;
namespace CSharp_Fundamentals_CleanCode.Application.Tasks.Loops
{
    public class SumOfEvenNumbersTask : BaseTask
    {
        public SumOfEvenNumbersTask(InputService input, OutputService output) : base(input, output)
        {
        }
        protected override void Run()
        {
            int max = input.ReadInt();
            int sum = 0;
            for (int i = 2; i <= max; i += 2)
                sum += i;
            output.Print($"Sum of even numbers from 1 to {max} is {sum}");
        }
    }
}
