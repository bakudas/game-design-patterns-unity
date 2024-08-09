namespace Builder.Scripts
{
    public class SoldadoInfantariaLeve : Soldado
    {
        public override void EscolherArma(string arma)
        {
            Arma = arma;
        }

        public override void EscolherTransporte(string transporte)
        {
            Transporte = transporte;
        }

        public override void DefinirFoco(string foco)
        {
            Foco = foco;
        }
    }

}