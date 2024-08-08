using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace State
{
    public abstract class State
    {
        public abstract void Acao(Contexto contexto);
    }   
}

