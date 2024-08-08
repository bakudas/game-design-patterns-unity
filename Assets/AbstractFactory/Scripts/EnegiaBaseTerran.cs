using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactory
{
    public class EnegiaBaseTerran : IEnergia
    {
        public void Composicao()
        {
            Debug.Log("Energia de sustentação da base mecânica");
        }
    }
}
