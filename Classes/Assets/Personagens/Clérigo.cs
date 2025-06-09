using UnityEngine;


public class Personagem

{

    public class Clérigo
    {

        private string _nome;
        private int _ataque;
        private int _defesa;
        private int _dano;
        private int _curaDivina;
        private int _vidaMaxima;
        private int _vidaMinima;
        private int _vidaAtual;

        void Start()
        {
            _vidaAtual = _vidaMaxima;
            Debug.Log($"{_nome} entrou no jogo com {_vidaAtual} de vida.");
        }

        public void ReceberDano(int dano)
        {
            int danoReal = Mathf.Max(dano - _defesa, 0);
            _vidaAtual -= danoReal;
            _vidaAtual = Mathf.Max(_vidaAtual, 0);
            Debug.Log($"{_nome} recebeu {danoReal} de dano. Vida restante: {_vidaAtual}");
        }

        public void Atacar(Personagem inimigo)
        {
            Debug.Log($"{_nome} ataca {Inimigo._nome}!");
            inimigo.ReceberDano(_ataque);
        }
    }
}