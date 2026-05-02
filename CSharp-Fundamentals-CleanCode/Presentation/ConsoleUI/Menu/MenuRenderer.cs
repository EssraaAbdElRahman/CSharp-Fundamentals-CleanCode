using CSharp_Fundamentals_CleanCode.Application.TaskManagement;
using CSharp_Fundamentals_CleanCode.Core.Enums;
using CSharp_Fundamentals_CleanCode.Infrastructure.Services;
namespace CSharp_Fundamentals_CleanCode.Presentation.ConsoleUI.Menu
{
    public class MenuRenderer
    {
        private readonly InputService _input;
        private readonly List<TaskDefinition> _tasks;
        public MenuRenderer(InputService input, List<TaskDefinition> tasks)
        {
            _input = input;
            _tasks = tasks;
        }
        public MenuOption Show()
        {
            while (true)
            {
                Console.Clear();

                PrintHeader();
                PrintOptions();

                int value = ValidateValue();

                if (Enum.IsDefined(typeof(MenuOption), value))
                    return (MenuOption)value;

                PrintInvalid();
            }
        }
        private int ValidateValue()
        {
            return _input.ReadInt();
        }
        private void PrintHeader()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("  C# Fundamentals – Clean Code Practice");
            Console.WriteLine("========================================");
        }
        private void PrintOptions()
        {
            foreach (var task in _tasks)
            {
                Console.WriteLine($"  [{(int)task.Option}] {task.DisplayName}");
            }
            Console.WriteLine("========================================");
        }
        private void PrintInvalid()
        {
            Console.WriteLine("Invalid choice, try again...");
            Console.ReadKey();
        }
    }
}