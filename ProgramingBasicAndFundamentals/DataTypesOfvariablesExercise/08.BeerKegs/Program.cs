            internal class Program
        {
            static void Main(string[] args)
            {
                byte n = byte.Parse(Console.ReadLine());

                double volumeOfBiggestKen = 0.0d;
                string modelOfBiggestKen = string.Empty;

                for (int i = 1; i <= n; i++)
                {
                    string modelOfKen = Console.ReadLine();
                    float radiusOfKen = float.Parse(Console.ReadLine());
                    int heightOfKen = int.Parse(Console.ReadLine());

                    volumeOfBiggestKen = (double)(Math.PI * radiusOfKen * radiusOfKen * heightOfKen);

                    if (true)
                    {

                    }
                }
            }
    }
