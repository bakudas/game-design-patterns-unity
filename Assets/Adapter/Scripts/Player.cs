using UnityEngine;

namespace Adapter.Scripts
{
    public class Player : IAcao
    {
        public void Fire()
        {
            Debug.Log("Atirou!");
        }

        public void Walk(string player)
        {
            Debug.Log(player + " Andou para frente!");
        }
    }
}