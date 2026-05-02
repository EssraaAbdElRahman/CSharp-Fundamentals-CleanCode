 using CSharp_Fundamentals_CleanCode.Application.TaskManagement;
using CSharp_Fundamentals_CleanCode.Application.Tasks.Basics;
using CSharp_Fundamentals_CleanCode.Core.Enums;
using CSharp_Fundamentals_CleanCode.Infrastructure.Services;
using CSharp_Fundamentals_CleanCode.Presentation.ConsoleUI.Menu;
using TaskFactory = CSharp_Fundamentals_CleanCode.Application.Factories.TaskFactory;

var input = new InputService();
var output = new OutputService();
var registry = new TaskRegistry();
var tasks = registry.GetTasks(input, output);

var factory = new TaskFactory(); 
foreach (var task in tasks)
{
    factory.Register(task.Key, task.Creator);
}

var menuMap = tasks.ToDictionary(t => t.Option, t => t.Key);


var menu = new MenuRenderer(input, tasks);


while (true)
{
    var option = menu.Show();

    if (option == MenuOption.Exit)
        break;

    if (menuMap.TryGetValue(option, out var key))
    {
        var task = factory.Create(key);

        Console.Clear();
        task.Execute();

        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }
}