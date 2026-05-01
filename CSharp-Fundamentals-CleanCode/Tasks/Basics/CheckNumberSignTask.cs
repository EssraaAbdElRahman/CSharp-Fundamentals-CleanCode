using CSharp_Fundamentals_CleanCode.Core;
using CSharp_Fundamentals_CleanCode.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Fundamentals_CleanCode.Tasks.Basics
{
    public class CheckNumberSignTask : ITask
    {
        private readonly InputService _input;
        private readonly OutputService _output;
        public CheckNumberSignTask(InputService input, OutputService output)
        {
            _input = input ?? throw new ArgumentNullException(nameof(input));
            _output = output ?? throw new ArgumentNullException(nameof(output));
        }
        public void Execute()
        {

            bool tryAgain;
            do
            {
                int num = _input.ReadInt();
                 var result = GetSign(num);
                _output.Print($"Number is {result}");
                _output.Print("Try again? (y/n)");

                var answer = _input.ReadString().Trim();
                tryAgain = answer.Equals("y", StringComparison.OrdinalIgnoreCase);

            } while (tryAgain);
        }
        private string GetSign(int number)
        {
            if (number < 0) return "Negative";
            if (number > 0) return "Positive";
            return "Zero";
        }
    }
}
