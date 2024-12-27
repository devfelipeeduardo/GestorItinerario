namespace GestorDeItinerario{
    class Program {
        static void Main(string[]args) {

            GrupoItinerarios itinerarios = new GrupoItinerarios();

            Console.Write("Deseja criar quantos itinerários?: ");
            int quantidadeItinerarios = int.Parse(Console.ReadLine());

            for (int i=0; i < quantidadeItinerarios; i++) {
                Console.Clear();
                Console.WriteLine((i + 1) + "° Itinerário:");
                Console.WriteLine("Digite o nome do MOTORISTA ");
                string motorista = Console.ReadLine();
                Console.WriteLine("Digite o nome do LOMBADOR ");
                string lombador = Console.ReadLine();
                Itinerario itinerario = new Itinerario(motorista, lombador);
                itinerario.AdicionarMarca();
                itinerarios.AdicionaItinerarioNaLista(itinerario);
            }

            itinerarios.MostraItinerarios();
        }
    }
}