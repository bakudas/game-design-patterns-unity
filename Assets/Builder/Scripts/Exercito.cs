namespace Builder.Scripts
{
    public class Exercito
    {
        public void BuildSoldado(BuilderSoldado builderSoldado)
        {
            builderSoldado.Arma();
            builderSoldado.Transporte();
            builderSoldado.Foco();
        }
    }
}