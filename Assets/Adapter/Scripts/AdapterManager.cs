using System.Collections;
using System.Collections.Generic;
using Adapter.Scripts;
using UnityEngine;

namespace Adapter.Scripts
{
    public class AdapterManager : MonoBehaviour
    {
        private Player _player = new Player();
        private Plane _plane = new Plane();
        
        // Start is called before the first frame update
        void Start()
        {
            IAcao adapter = new AdapterPlane(_plane);

            Debug.Log("--- HUMAN FORM ---");
            _player.Walk("Bakudas");
            _player.Fire();

            Debug.Log("--- PLANE/FLY MECHANICS ---");
            adapter.Walk("Bakudas");
            adapter.Fire();
        }

    }
}
