using System.Collections.Generic;

namespace Prototype.Scripts
{
    public class NuvemManager
    {
        private Dictionary<string, NuvemPrototype> nuvens = new Dictionary<string, NuvemPrototype>();

        public NuvemPrototype this[string key]
        {
            get { return nuvens[key]; }
            set { nuvens.Add(key, value);}
        }
    }
}