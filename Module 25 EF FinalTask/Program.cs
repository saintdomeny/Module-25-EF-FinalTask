using Module_25_EF_FinalTask.Repositories;

namespace Module_25_EF_FinalTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppContext())
            {
                Console.WriteLine("Hello, World!");
            }
        }
    }
}