using CSharp_Fundamentals_CleanCode.Core.Abstractions;
using CSharp_Fundamentals_CleanCode.Infrastructure.Services;
namespace CSharp_Fundamentals_CleanCode.Application.Tasks.Loops
{
    public class SumOfNumbersTask : BaseTask
    {
        public SumOfNumbersTask(InputService input, OutputService output) : base(input, output)
        {
        }


        protected override void Run()
        {
            int max = input.ReadInt();
            int sum = 0;
            for (int i = 1; i <= max; i++)
                sum += i;
            output.Print($"Sum from 1 to {max} is {sum}");
        }
    }
}