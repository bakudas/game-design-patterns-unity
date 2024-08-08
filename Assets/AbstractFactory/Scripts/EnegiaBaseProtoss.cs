using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactory
{
    public class EnegiaBaseProtoss : IEnergia
    {
        public void Composicao()
        {
            Debug.Log("Energia de sustentação da base com cristais");
        }
    }
}
