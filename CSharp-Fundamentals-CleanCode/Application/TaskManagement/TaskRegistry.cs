using CSharp_Fundamentals_CleanCode.Application.Tasks.Basics;
using CSharp_Fundamentals_CleanCode.Application.Tasks.Loops;
using CSharp_Fundamentals_CleanCode.Core.Enums;
using CSharp_Fundamentals_CleanCode.Infrastructure.Services;
namespace CSharp_Fundamentals_CleanCode.Application.TaskManagement
{
    public class TaskRegistry
    {
        public List<TaskDefinition> GetTasks(InputService input, OutputService output)
        {
            return new List<TaskDefinition>
            {
                new TaskDefinition(
                    MenuOption.EvenOdd,
                    "EvenOdd",
                    "Even or Odd",
                    () => new EvenOddTask(input, output)
                ),

                new TaskDefinition(
                    MenuOption.CheckNumberSign,
                    "CheckNumberSign",
                    "Check Number Sign",
                    () => new CheckNumberSignTask(input, output)
                ),             
                new TaskDefinition(
                        MenuOption.PrintEvenNumbers,
                        "PrintEvenNumbers",
                        "Print Even Numbers",
                        () => new PrintEvenNumbersTask(input, output)
                    ),
                    new TaskDefinition(
                        MenuOption.PrintOddNumbers,
                        "PrintOddNumbers",
                        "Print Odd Numbers",
                        () => new PrintOddNumbersTask(input, output)
                    ),
                    new TaskDefinition(
                        MenuOption.SumOfNumbers,
                        "SumOfNumbers",
                        "Sum of Numbers",
                        () => new SumOfNumbersTask(input, output)
                    ),
                    new TaskDefinition(
                        MenuOption.SumOfEvenNumbers,
                        "SumOfEvenNumbers",
                        "Sum of Even Numbers",
                        () => new SumOfEvenNumbersTask(input, output)
                    )
            };
        }
    }
}