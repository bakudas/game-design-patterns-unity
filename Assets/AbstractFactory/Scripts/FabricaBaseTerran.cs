using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactory
{
    public class FabricaBaseTerran : IFabricaBases
    {
        public FabricaBaseTerran()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            RevestimentoBaseTerran revestimentoBaseTerran = new RevestimentoBaseTerran();
            revestimentoBaseTerran.Composicao();
            
            EnegiaBaseTerran enegiaBaseTerran = new EnegiaBaseTerran();
            enegiaBaseTerran.Composicao();
            
            Debug.Log("Base Terran criada com sucesso!");
        }
    }
}