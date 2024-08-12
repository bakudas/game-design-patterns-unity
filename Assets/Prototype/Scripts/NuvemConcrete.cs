using UnityEngine;

namespace Prototype.Scripts
{
    public class NuvemConcrete : NuvemPrototype
    {
        private string corPreenchimento;
        private string corContorno;

        public NuvemConcrete(string preenchimento, string contorno)
        {
            this.corContorno = contorno;
            this.corPreenchimento = preenchimento;
        }

        public override NuvemPrototype Clone()
        {
            Debug.Log("A nuvem clonada tem contorno " + this.corContorno + " e preenchimento " + this.corPreenchimento);
            return this.MemberwiseClone() as NuvemPrototype;
        }
    }
}