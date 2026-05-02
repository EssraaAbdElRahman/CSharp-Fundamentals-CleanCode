using CSharp_Fundamentals_CleanCode.Core.Abstractions;
using CSharp_Fundamentals_CleanCode.Infrastructure.Services;

namespace CSharp_Fundamentals_CleanCode.Application.Tasks.Basics
{
    public class EvenOddTask : BaseTask
    {
       
        public EvenOddTask(InputService input, OutputService output):base(input, output) { }
        protected override void Run()
        {
            int num = input.ReadInt();
            string result = num % 2 == 0 ? "Even" : "Odd";

            output.Print($"Number is {result}");
        }
    }
}