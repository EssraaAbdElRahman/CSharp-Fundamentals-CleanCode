using CSharp_Fundamentals_CleanCode.Core;
using CSharp_Fundamentals_CleanCode.Services;
namespace CSharp_Fundamentals_CleanCode.Tasks.Basics
{
    public class EvenOddTask : ITask
    {
        private readonly InputService _input;
        private readonly OutputService _output;
        public EvenOddTask(InputService input, OutputService output)
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

                string result = num % 2 == 0 ? "Even" : "Odd";

                _output.Print($"Number is {result}");
                _output.Print("Try again? (y/n)");

                var answer = _input.ReadString().Trim();
                tryAgain = answer.Equals("y", StringComparison.OrdinalIgnoreCase);

            } while (tryAgain);
        }
    }
}