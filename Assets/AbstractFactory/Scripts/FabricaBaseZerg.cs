using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactory
{
    public class FabricaBaseZerg : IFabricaBases
    {
        public FabricaBaseZerg()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            IRevestimento revestimentoBaseZerg = new RevestimentoBaseZerg();
            revestimentoBaseZerg.Composicao();

            IEnergia energiaBaseZerg = new EnegiaBaseZerg();
            energiaBaseZerg.Composicao();
            
            Debug.Log("Base Zerg criada com sucesso!");
        }
    }
}