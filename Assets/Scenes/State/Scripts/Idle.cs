using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace State
{
    public class Idle : State
    {
        public override void Acao(Contexto contexto)
        {
            contexto.State = new Run();
        }
    }
}
