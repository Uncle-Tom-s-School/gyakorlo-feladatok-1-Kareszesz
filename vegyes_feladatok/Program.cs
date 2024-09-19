namespace vegyes_feladatok
{
    internal class Program
    {
        static void feladat1() { 

        
           
                int nem, igen;

                // Bemenet: összes értékelés és pozitív értékelések száma
                Console.Write("Összes értékelés száma: ");
                nem = int.Parse(Console.ReadLine());
                Console.Write("Pozitív értékelések száma: ");
                igen = int.Parse(Console.ReadLine());

                // Százalékos érték kiszámítása és kerekítése
                int százalék = 0;
                if (nem > 0)
                {
                    százalék = (int)Math.Round((igen / (double)nem) * 100);
                }

                // Értékelés kiírása színkóddal
                if (százalék > 90)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nagyon pozitív");
                }
                else if (százalék >= 75)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Pozitív");
                }
                else if (százalék >= 55)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Többnyire pozitív");
                }
                else if (százalék >= 45)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Vegyes");
                }
                else if (százalék >= 25)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Többnyire negatív");
                }
                else if (százalék >= 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Negatív");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nagyon negatív");
                }

                // Szín visszaállítása
                Console.ResetColor();
            
        

    }

    static void feladat2() {

    static void feladat3() { }

        static void feladat4() { }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.ReadKey();
        }
    }
}
