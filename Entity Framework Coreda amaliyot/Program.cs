using Entity_Framework_Coreda_amaliyot.Model;

namespace Entity_Framework_Coreda_amaliyot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Query();
        }
        public static void Query()
        {
            EkundalikContext context = new EkundalikContext();
        }
    }
}
