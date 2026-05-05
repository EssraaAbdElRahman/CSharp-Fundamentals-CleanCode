using CSharp_Fundamentals_CleanCode.Core.Abstractions;
using CSharp_Fundamentals_CleanCode.Infrastructure.Services;

namespace CSharp_Fundamentals_CleanCode.Application.Tasks.Basics
{
    public class MaxOfThreeTask : BaseTask
    {
        public MaxOfThreeTask(InputService input, OutputService output) : base(input, output)
        {
        }
        protected override void Run()
        {
            int number1 = input.ReadInt();
            int number2 = input.ReadInt();
            int number3 = input.ReadInt();
            int maxNumber = GetMaxNumber(number1, number2, number3);
            ;
            output.Print($"The maximum number is: {maxNumber}");
        }
        private int GetMaxNumber(int num1, int num2, int num3)
        {
            return num1 > num2 ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);
        }
    }
}
