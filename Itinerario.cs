using System.Text.RegularExpressions;

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
            Lombador = lombador;
        }

        public void AdicionarListaDeMarcas()
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
                    AdicionaMarca(marca);
                }
                Console.Clear();
            }
        }

        public void AdicionaMarca(string marca)
        {
            MarcasItinerario.Add(marca);
        }

        public void RemoverMarca(string marca)
        {
            MarcasItinerario.Remove(marca);
        }

        public void MostraItinerario()
        {
            Console.WriteLine( "|----------------------|");
            Console.WriteLine($"|Motorista: {Motorista}");
            Console.WriteLine($"|Lombador: {Lombador}  ");
            Console.WriteLine( "|----------------------|");
            for (int i = 0; i < MarcasItinerario.Count; i++)
            {
                Console.WriteLine($"|{i + 1}° {MarcasItinerario[i]}");
            }
            Console.WriteLine();
        }
    }
}
