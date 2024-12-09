namespace Swapping2Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value for a : ");
            int a = Convert.ToInt32(Console.ReadLine());
           
            Console.Write("Enter value for b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("valuse of a before swapping :{0}", a);
            Console.WriteLine("valuse of b before swapping :{0}", b);
            a = a + b; //4 + 10 = 14
            b = a - b; //14-10 =4
            a = a - b; //14-4 =10
            Console.WriteLine("valuse of a after swapping :{0}", a);
            Console.WriteLine("valuse of b after swapping :{0}", b);
            Console.ReadKey();
        }
    }
}
