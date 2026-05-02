using CSharp_Fundamentals_CleanCode.Core.Abstractions;
namespace CSharp_Fundamentals_CleanCode.Application.Factories
{
    public class TaskFactory : ITaskFactory
    {
        private readonly Dictionary<string, Func<ITask>> _registry;

        public TaskFactory()
        {
            _registry = new Dictionary<string, Func<ITask>>(StringComparer.OrdinalIgnoreCase);
        }

        public void Register(string key, Func<ITask> creator)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException("Key cannot be null or empty.");

            if (creator is null)
                throw new ArgumentNullException(nameof(creator));

            if (_registry.ContainsKey(key))
                throw new InvalidOperationException($"Task '{key}' is already registered.");

            _registry.Add(key, creator);
        }

        public ITask Create(string key)
        {
            if (!_registry.TryGetValue(key, out var creator))
                throw new KeyNotFoundException($"Task '{key}' is not registered.");

            return creator();
        }
    }
}
