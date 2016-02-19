namespace Sistemciyiznet
{
    class SistemciyiznetApp
    {
        public static void Main()
        {
            System.Console.Write("Gün : ");
            int g = int.Parse(System.Console.ReadLine());
            System.Console.Write("Ay : ");
            int a = int.Parse(System.Console.ReadLine());
            System.Console.Write("Yıl : ");
            int y = int.Parse(System.Console.ReadLine());
            if (g == 0 || a == 0 || y == 0)
            {
                System.Console.WriteLine("Tarihi Geçersiz.");
            }
            else
            {
                var d = new System.DateTime(y, a, g);
                System.Console.WriteLine("");
                System.Console.WriteLine("Day Of Year : {0} ", d.DayOfYear);
                System.Console.WriteLine("");

                System.Console.ReadLine();
            }
        }
    }
}