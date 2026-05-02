using CSharp_Fundamentals_CleanCode.Core.Abstractions;
using CSharp_Fundamentals_CleanCode.Infrastructure.Services;

namespace CSharp_Fundamentals_CleanCode.Application.Tasks.Basics
{
    public class CheckNumberSignTask : BaseTask
    {
        public CheckNumberSignTask(InputService input, OutputService output) : base(input, output) { }
        protected override void Run()
        {
            int num = input.ReadInt();
            var result = GetSign(num);
            output.Print($"Number is {result}");
        }   
        private string GetSign(int number)
        {
            if (number < 0) return "Negative";
            if (number > 0) return "Positive";
            return "Zero";
        }
    }
}
