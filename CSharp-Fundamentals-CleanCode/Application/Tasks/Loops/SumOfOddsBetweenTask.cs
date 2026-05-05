using CSharp_Fundamentals_CleanCode.Core.Abstractions;
using CSharp_Fundamentals_CleanCode.Infrastructure.Services;


namespace CSharp_Fundamentals_CleanCode.Application.Tasks.Loops
{
    public class SumOfOddsBetweenTask : BaseTask
    {
        public SumOfOddsBetweenTask(InputService input, OutputService output) : base(input, output)
        {
        }

        protected override void Run()
        {
            int start = input.ReadInt();
            int end = input.ReadInt();
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            output.Print($"The sum of odd numbers between {start} and {end} is: {sum}");
        }
    }
}
