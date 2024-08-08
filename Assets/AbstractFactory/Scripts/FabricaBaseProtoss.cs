using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactory
{
    public class FabricaBaseProtoss : IFabricaBases
    {
        public FabricaBaseProtoss()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            IRevestimento revestimentoBaseProtoss = new RevestimentoBaseProtoss();
            revestimentoBaseProtoss.Composicao();

            IEnergia energiaBaseProtoss = new EnegiaBaseProtoss();
            energiaBaseProtoss.Composicao();
            
            Debug.Log("Base Protoss criada com sucesso!");
        }
    }
}