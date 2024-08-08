using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactory
{
    public class RevestimentoBaseProtoss : IRevestimento
    {
        public void Composicao()
        {
            Debug.Log("Base revestida pela cor amarela");
        }
    }
}
