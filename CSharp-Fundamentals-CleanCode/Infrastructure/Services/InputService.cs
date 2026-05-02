namespace CSharp_Fundamentals_CleanCode.Infrastructure.Services
{
    public class InputService
    {
        public int ReadInt()
        {
            while (true)
            {
                Console.Write("Enter number: ");
                if (int.TryParse(Console.ReadLine(), out int num))
                    return num;

                Console.WriteLine("Invalid input, try again.");
            }
        }

        public string ReadString()
        {
            return Console.ReadLine() ?? string.Empty;
        }
    }
}
