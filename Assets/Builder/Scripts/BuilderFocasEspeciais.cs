namespace Builder.Scripts
{
    public class BuilderFocasEspeciais : BuilderSoldado
    {
        public BuilderFocasEspeciais()
        {
            _soldado = new SoldadoForcasEspeciais();
        }

        public override void Arma()
        {
            _soldado.EscolherArma("Fuzil");
        }

        public override void Transporte()
        {
            _soldado.EscolherTransporte("Carro de operações Especiais");
        }

        public override void Foco()
        {
            _soldado.DefinirFoco("Combate em Solo");
        }
    }
    
}