using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace State
{
    public class Contexto
    {
        private State _estado;

        public Contexto(State estado)
        {
            this._estado = estado;
        }

        public State State
        {
            get { return _estado;  }
            set
            {
                _estado = value;
                Debug.Log("Agora o comportamento é de: " + _estado.GetType().Name);
            }
        }

        public void Troca()
        {
            _estado.Acao(this);
        }
    }
}
