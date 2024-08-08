using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace State
{
    public class Run : State
    {
        public override void Acao(Contexto contexto)
        {
            contexto.State = new Idle();
        }
    }
}