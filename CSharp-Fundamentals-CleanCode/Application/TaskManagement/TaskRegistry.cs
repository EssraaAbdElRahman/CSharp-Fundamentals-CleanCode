using CSharp_Fundamentals_CleanCode.Application.Tasks.Basics;
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
                )
            };
        }
    }
}