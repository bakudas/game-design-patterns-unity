using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Factory
{
    public class LiuKang : IPersonagem
    {
        public void Escolhido()
        {
            Debug.Log("Liu Kang foi o personagem escolhido!");
        }
    }
    
}
