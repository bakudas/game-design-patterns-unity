using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Prototype.Scripts
{
    public class PrototypeManager : MonoBehaviour
    {
        private NuvemManager _nuvemManager = new NuvemManager();
        
        // Start is called before the first frame update
        void Start()
        {
            _nuvemManager["default"] = new NuvemConcrete("branco", "preto");
            _nuvemManager["nublado"] = new NuvemConcrete("cinza", "preto");

            NuvemConcrete nuvemUm = (NuvemConcrete)_nuvemManager["default"].Clone();
            NuvemConcrete nuvemDois = (NuvemConcrete)_nuvemManager["nublado"].Clone();
            
            

        }
   }
}
