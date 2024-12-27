namespace GestorDeItinerario
{
    public class Itinerario
    {
        public List<string> MarcasItinerario;
        public string Motorista;
        public string Lombador;

        public Itinerario(string motorista, string lombador)
        {
            MarcasItinerario = new List<string>();
            Motorista = motorista;
            Lombador= lombador;
        }

        public void AdicionarMarca()
        {
            while (true)
            {
                Console.WriteLine("Digite 'SAIR' se não deseja mais adicionar marcas.");
                Console.Write("Saia ou adicione uma marca: ");
                string marca = Console.ReadLine().ToLower();

                if (marca == "sair")
                {
                    break;
                }
                else
                {
                    MarcasItinerario.Add(marca);
                }
                Console.Clear();
            }
        }

        public void MostraItinerario()
        {
            Console.WriteLine($"Motorista: {Motorista}");
            Console.WriteLine($"Lombador: {Lombador}");
            Console.WriteLine();
            for (int i = 0; i < MarcasItinerario.Count; i++)
            {
                Console.WriteLine($"|{i + 1}° {MarcasItinerario[i]}|");
            }
        }
    }
}