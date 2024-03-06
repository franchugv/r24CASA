namespace r24CASA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Cuenta> lista = new List<Cuenta>();

            CuentaJoven Cuenta1joven;

            Cuenta1joven = new CuentaJoven("Fran", 20);

            Cuenta1joven.FechaNac = new DateTime(2000, 7 ,23);

            Console.WriteLine($"{Cuenta1joven.ToString()}");
        }
    }
}
