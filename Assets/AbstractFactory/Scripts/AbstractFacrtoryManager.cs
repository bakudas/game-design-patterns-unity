using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactory
{
    public class AbstractFacrtoryManager : MonoBehaviour
    {
        private IFabricaBases _fabrica;
        [SerializeField] private string _racaPersonagem;
        
        // Start is called before the first frame update
        void Start()
        {
            switch (_racaPersonagem)
            {
                case "Terran":
                    _fabrica = new FabricaBaseTerran();
                    break;
                case "Protoss":
                    _fabrica = new FabricaBaseProtoss();
                    break;
                case "Zerg":
                    _fabrica = new FabricaBaseZerg();
                    break;
            }    
        }

    }
}
