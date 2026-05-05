using CSharp_Fundamentals_CleanCode.Core.Abstractions;
using CSharp_Fundamentals_CleanCode.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Fundamentals_CleanCode.Application.Tasks.Loops
{
    public class MultiplicationTableTask : BaseTask
    {
        public MultiplicationTableTask(InputService input, OutputService output) : base(input, output)
        {
        }

        protected override void Run()
        {
            int number = input.ReadInt();
            output.Print($"Multiplication Table for {number}:");
            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                output.Print($"{number} x {i} = {result}");
            }
        }
    }
}
