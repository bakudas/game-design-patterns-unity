using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Factory
{
    public class FactoryMethod : MonoBehaviour
    {
        [SerializeField] private string _personagem;

        void Start()
        {
            IPersonagem p = EscolherPersonagem(_personagem);
            p.Escolhido();
        }

        public IPersonagem EscolherPersonagem(string personagem)
        {
            switch (personagem)
            {
                case "Liu Kang": return new LiuKang();
                default: return null;
            }
        }
    }
    
}
