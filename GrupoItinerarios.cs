namespace GestorDeItinerario {
    public class GrupoItinerarios {
        public List<Itinerario> Itinerarios;

        public GrupoItinerarios () {
            Itinerarios = new List<Itinerario>();
        }

        public void AdicionaItinerarioNaLista(Itinerario itinerario) {
            Itinerarios.Add(itinerario);
        }

        public void MostraItinerarios(){
            for (int i = 0; i < Itinerarios.Count; i++) {
                Console.WriteLine($"Itinerário {i+1}: ");
                Itinerarios[i].MostraItinerario();
            }
        }
    }
}