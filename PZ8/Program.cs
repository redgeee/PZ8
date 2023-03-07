namespace PZ8
{
    class Program
    {
        static void Main(string[] args)
        {
            Mark mark1 = new(new Offset());
            Mark mark2 = new(new DifferentialOffset());
            Mark mark3 = new(new Exam());

            mark1.Rate(100);
            mark2.Rate(60);
            mark3.Rate(30);

            Console.WriteLine(mark1.GetResult());
            Console.WriteLine(mark2.GetResult());
            Console.WriteLine(mark3.GetResult());
        }
    }
}
