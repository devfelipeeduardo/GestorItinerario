namespace GestorDeItinerario
{
    public class GrupoItinerarios
    {
        public List<Itinerario> Itinerarios;

        public GrupoItinerarios()
        {
            Itinerarios = new List<Itinerario>();
        }

        public void CriaItinerario()
        {
            Console.Write("Deseja criar quantos itinerários?: ");
            int quantidadeItinerarios = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadeItinerarios; i++)
            {
                Console.Clear();
                Console.WriteLine((i + 1) + "° Itinerário:");
                Console.WriteLine("Digite o nome do MOTORISTA ");
                string motorista = Console.ReadLine();
                Console.WriteLine("Digite o nome do LOMBADOR ");
                string lombador = Console.ReadLine();
                Console.Clear();

                Itinerario itinerario = new Itinerario(motorista, lombador);
                itinerario.AdicionarListaDeMarcas();
                Itinerarios.Add(itinerario);
            }
        }

        public void AdicionaItinerarioNaLista(Itinerario itinerario)
        {
            Itinerarios.Add(itinerario);
        }

        public void MostraItinerarios()
        {
            Console.Clear();
            for (int i = 0; i < Itinerarios.Count; i++)
            {
                Console.WriteLine($"Itinerário {i + 1}: ");
                Itinerarios[i].MostraItinerario();
            }
        }

        public void AdicionarNovaMarca()
        {

            Console.WriteLine("Escolha um dos itinerários para adicionar uma marca: ");

            for (int i = 0; i < Itinerarios.Count; i++)
            {
                Console.WriteLine($"Itinerário {i + 1}: ");
            }

            int itinerarioSelecionado = int.Parse(Console.ReadLine());

            Console.Write("Digite uma marca: ");

            string marca = Console.ReadLine();

            Itinerarios[itinerarioSelecionado - 1].AdicionaMarca(marca);

        }

        public void RemoverMarcas()
        {
            Console.WriteLine("Escolha um dos itinerários para remover uma marca: ");

            for (int i = 0; i < Itinerarios.Count; i++)
            {
                Console.WriteLine($"Itinerário {i + 1}: ");
            }

            int itinerarioSelecionado = int.Parse(Console.ReadLine());

            Console.Write("Digite uma marca: ");

            string marca = Console.ReadLine();

            Itinerarios[itinerarioSelecionado - 1].RemoverMarca(marca);

        }

    }
}
