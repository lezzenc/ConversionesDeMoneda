namespace ConversionesDeMoneda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                MostrarMenu();

                string respuestaUsuario = Console.ReadLine();

                switch (respuestaUsuario)
                {
                    case "1":
                        ConvertirPesosADolares();
                        break;
                    case "2":
                        ConvertirDolaresAPesos();
                        break;
                    case "3":
                        ConvertirPesosAEuros();
                        break;
                    case "4":
                        ConvertirEurosAPesos();
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta");
                        break;
                }
                Console.ReadLine();
            }

        }
        static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("Conversiones");
            Console.WriteLine("1) Pesos a Dolares");
            Console.WriteLine("2) Dolares a Pesos");
            Console.WriteLine("3) Pesos a Euros");
            Console.WriteLine("4) Euros a Pesos");
        }
        static void ConvertirPesosADolares()
        {
            Console.WriteLine("Pesos a dolares");
            Console.WriteLine("Introducir tipo de cambio");

            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoDeCambio);


            Console.WriteLine("Introducir la cantidad en pesos");
            respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal pesos);

            decimal dolares = PesosADolares(tipoDeCambio, pesos);
            Console.WriteLine($"Cantidad en dolares: {dolares.ToString("N2")}");
        }
        static void ConvertirDolaresAPesos()
        {
            Console.WriteLine("Dolares a Pesos");
            Console.WriteLine("Introducir tipo de cambio");

            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoDeCambio);

            Console.WriteLine("introducir la cantidad en dolares");
            respuestaUsuario = Console.ReadLine();

            decimal.TryParse(respuestaUsuario, out decimal dolares);

            decimal pesos = DolaresAPesos(tipoDeCambio, dolares);
            Console.WriteLine($"La cantidad en pesos es {pesos.ToString("N2")}");

        }
        static void ConvertirPesosAEuros()
        {
            Console.WriteLine("Pesos a Euros");
            Console.WriteLine("Introducir tipo de cambio");

            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoDeCambio);

            Console.WriteLine("Introducir la cantidad de pesos");
            respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal euros);

            decimal pesos = PesosAEuros(tipoDeCambio, euros);
            Console.WriteLine($"Cantidad de pesos en euros: {pesos.ToString("N2")}");
        }

        static void ConvertirEurosAPesos()
        {
            Console.WriteLine("Euros a Pesos");
            Console.WriteLine("Introducir tipo de cambio");

            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoDeCambio);

            Console.WriteLine("Introducir la cantidad de Euros");
            respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal pesos);

            decimal euros = EurosAPesos(tipoDeCambio, pesos);
            Console.WriteLine($"Cantidad de euros en pesos es {euros.ToString("N2")}");
        }


        static decimal EurosAPesos(decimal tipoCambio, decimal euros)
        {
            decimal pesos = 0.0m;
            pesos = euros / tipoCambio;
            return pesos;
        }
        static decimal PesosAEuros(decimal tipoCambio, decimal pesos)
        {
            decimal euros = 0.0m;
            euros = pesos * tipoCambio;
            return euros;
        }
        static decimal PesosADolares(decimal tipoCambio, decimal pesos)
        {
            decimal dolares = 0.0m;

            dolares = pesos / tipoCambio;
            return dolares;

        }

        static decimal DolaresAPesos(decimal tipoCambio, decimal dolares)
        {
            decimal pesos = 0.0m;
            pesos = tipoCambio * dolares;
            return pesos;
        }
    }
}
