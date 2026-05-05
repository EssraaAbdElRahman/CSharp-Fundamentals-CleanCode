using CSharp_Fundamentals_CleanCode.Core.Abstractions;
using CSharp_Fundamentals_CleanCode.Infrastructure.Services;

namespace CSharp_Fundamentals_CleanCode.Application.Tasks.Basics
{
    public class LeapYearTask : BaseTask
    {
        public LeapYearTask(InputService input, OutputService output) : base(input, output)
        {
        }

        protected override void Run()
        {
            int year = input.ReadInt();
            if (IsLeapYear(year))
            {
                output.Print($"{year} is a leap year.");
            }
            else
            {
                output.Print($"{year} is not a leap year.");
            }
        }
        /// <summary>
        /// Determines whether a given year is a leap year.
        /// Instead of using DateTime.IsLeapYear(), the logic is implemented manually
        /// to demonstrate understanding of the underlying rule:
        /// - Divisible by 4 → leap year
        /// - EXCEPT if divisible by 100 → not a leap year
        /// - UNLESS also divisible by 400 → leap year
        /// </summary>
        private bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
         }
    }
}
