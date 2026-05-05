using CSharp_Fundamentals_CleanCode.Core.Abstractions;
using CSharp_Fundamentals_CleanCode.Infrastructure.Services;

namespace CSharp_Fundamentals_CleanCode.Application.Tasks.Basics
{
    public class ReverseNumberTask : BaseTask
    {
        public ReverseNumberTask(InputService input, OutputService output) : base(input, output)
        {
        }

        protected override void Run()
        {
            int num = input.ReadInt();
            int reverse = 0;
            int originalNumber = num;
            while (num > 0)
            {
                int digit = num % 10;
                reverse = (reverse * 10) + digit;
                num /= 10;
            }
            output.Print($"The reverse of the number is: {reverse}");

        }
    }
}
