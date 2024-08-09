using UnityEngine;

namespace Singleton.Scripts
{
    public class Manager : MonoBehaviour
    {
        private Singleton _jogador1 = Singleton.GetInstancia;
        private Singleton _jogador2 = Singleton.GetInstancia;
        private Singleton _jogador3 = Singleton.GetInstancia;

        // Start is called before the first frame update
        void Start()
        {
            _jogador1.Mensagem("Jogador 1: A bola está comigo");
            _jogador2.Mensagem("Jogador 2: Recebeu a bola no meio de campo.");
            _jogador3.Mensagem("Jogador 3: Recebeu o lançamento na linha de fundo");
        }
    }
}