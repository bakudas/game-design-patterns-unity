using UnityEngine;

namespace Singleton.Scripts
{
    public sealed class Singleton
    {
        private static Singleton _instancia = null;

        public static Singleton GetInstancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Singleton();
                    Debug.Log("A Bola está em jogo");
                }
                
                return _instancia;
            }
        }

        public void Mensagem(string msg)
        {
            Debug.Log(msg);
        }
    }
}