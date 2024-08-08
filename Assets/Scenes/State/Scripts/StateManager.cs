using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace State
{
    public class StateManager : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Contexto contexto = new Contexto(new Idle());
            
            contexto.Troca();
            contexto.Troca();
            contexto.Troca();
            contexto.Troca();
        }
    }
}
