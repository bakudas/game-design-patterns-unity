using UnityEngine;

namespace Adapter.Scripts
{
    public class Plane
    {
        public void Fly(string player)
        {
            Debug.Log(player + " Voou para frente!");
        }

        public void FireMissile()
        {
            Debug.Log("Soltou um míssil!");
        }
    }
}
