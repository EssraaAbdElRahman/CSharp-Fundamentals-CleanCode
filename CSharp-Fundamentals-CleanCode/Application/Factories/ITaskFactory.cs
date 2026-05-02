using CSharp_Fundamentals_CleanCode.Core.Abstractions;
namespace CSharp_Fundamentals_CleanCode.Application.Factories
{
    public interface ITaskFactory
    {
        ITask Create(string key);
        void Register(string key, Func<ITask> creator);
    }
}
