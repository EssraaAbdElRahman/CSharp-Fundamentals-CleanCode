using CSharp_Fundamentals_CleanCode.Core.Abstractions;
using CSharp_Fundamentals_CleanCode.Core.Enums;
namespace CSharp_Fundamentals_CleanCode.Application.TaskManagement
{
    public class TaskDefinition
    {
        public MenuOption Option { get; }
        public string Key { get; }
        public string DisplayName { get; }
        public Func<ITask> Creator { get; }

        public TaskDefinition(MenuOption option, string key, string displayName, Func<ITask> creator)
        {
            Option = option;
            Key = key;
            DisplayName = displayName;
            Creator = creator;
        }
    }
}
