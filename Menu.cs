namespace GestorDeItinerario
{
    public class Menu
    {
        private GrupoItinerarios Itinerarios;

        public Menu()
        {
            Itinerarios = new GrupoItinerarios();
        }

        public void MostraMenu()
        {
            while (true)
            {

            Console.WriteLine("|--------------------------------------|");
            Console.WriteLine("|Bem vindo ao seu Gestor de Itinerário!|");
            Console.WriteLine("|         Escolha uma opção:           |");
            Console.WriteLine("|         [1] Criar Itinerário         |");
            Console.WriteLine("|         [2] Adicionar Nova Marca     |");
            Console.WriteLine("|         [3] Remover Marcas           |");
            Console.WriteLine("|         [4] Mostrar Itinerários      |");
            Console.WriteLine("|--------------------------------------|");
            Console.Write("Opção: ");

            string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Itinerarios.CriaItinerario();
                        break;

                    case "2":
                        Itinerarios.AdicionarNovaMarca();
                        break;

                    case "3":
                        Itinerarios.RemoverMarcas();
                        break;
                    case "4":
                        Itinerarios.MostraItinerarios();
                        break;
                }
            }
        }
    }
}
