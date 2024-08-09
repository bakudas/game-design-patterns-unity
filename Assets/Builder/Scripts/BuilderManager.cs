using UnityEngine;

namespace Builder.Scripts
{
    public class BuilderManager : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            var exercito = new Exercito();
            BuilderSoldado builderSoldado;
            Soldado soldado;
            
            // Criando um soldado das Forças Especiais
            builderSoldado = new BuilderFocasEspeciais();
            exercito.BuildSoldado(builderSoldado);
            soldado = builderSoldado.GetSoldado();
            Debug.Log("Soldado criado com as caracteristicas: " + soldado.Arma + ", " + soldado.Transporte + ", " +
                      soldado.Foco);
            
            // Criando um soldade de Infantaria Leve
            builderSoldado = new BuilderInfantariaLeve();
            exercito.BuildSoldado(builderSoldado);
            soldado = builderSoldado.GetSoldado();
            Debug.Log("Soldado criado com as caracteristicas: " + soldado.Arma + ", " + soldado.Transporte + ", " +
                      soldado.Foco);
        }
    }

}