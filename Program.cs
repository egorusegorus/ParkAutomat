namespace ParkAutomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automat automat = new Automat();
            
                Console.WriteLine("Wie lange möchten Sie parken (X,00 ;X,25; X,50; X,75)? ");
                automat.ParkZeit = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Sie müssen " + Convert.ToString(automat.Pay().ToString("F2")) + "€ zahlen. Bitte werfen Sie die Münzen ein:");
                double Münze = Convert.ToDouble(Console.ReadLine());
                double Fee = automat.Pay();
                if (Münze < Fee)
                {
                    while (Münze < Fee)
                    {
                        Fee = Fee - Münze;
                        Console.WriteLine("Sie haben " + Münze.ToString("F2") + " Euro eingeworfen, es fehlt noch: " + Fee.ToString("F2") + " Euro.");
                        Console.WriteLine("Bitte weiteres Geld einwerfen: ");
                        Münze = Convert.ToDouble(Console.ReadLine());
                    }

                }
                if (Münze == automat.Pay())
                {

                    Console.WriteLine("Danke und ich wünsche Ihnen schönen Tag");
                }
                if (Münze > Fee)
                {
                    Münze = Münze - Fee;
                    Console.WriteLine("Ihr Rückgeld beträgt: " + Münze.ToString("F2") + " Euro.");
                }

            }
    }
    public class Automat
    {
        private const double GebührProStunde = 2.10;
        public double ParkZeit;
        public double Gebühr;

        public Automat()
        {

        }

        public double Pay()
        {
            Gebühr = ParkZeit * GebührProStunde;
            return Gebühr;
        }


    }
}
