namespace Program
{
    public delegate void DelEve();
    class Program
    {
        public static void Main(string[] args)
        {
            dee aa = new dee();
            aa.ede += Caca;
            aa.Raise();
            Console.WriteLine("1212");
        }
        public static void Caca()
        {
            Console.WriteLine("Типо евент");
        }
    }
    class dee
    {
        public event DelEve ede;
        public void Raise()
        {
            Thread.Sleep(1000);
            Console.WriteLine("asdas");
            ede.Invoke();
        }
    }
}