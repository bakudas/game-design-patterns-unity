namespace Builder.Scripts
{
    public class BuilderInfantariaLeve : BuilderSoldado
    {
        public BuilderInfantariaLeve()
        {
            _soldado = new SoldadoInfantariaLeve();
        }

        public override void Arma()
        {
            _soldado.EscolherArma("Ataque Áereo");
        }

        public override void Transporte()
        {
            _soldado.EscolherTransporte("Helicóptero de Ataque do Exército");
        }

        public override void Foco()
        {
            _soldado.DefinirFoco("Resposta rápida Áerea");
        }
    }

}