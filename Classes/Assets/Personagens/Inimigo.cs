using UnityEngine;

public class Inimigo : MonoBehaviour
{
    // Atributos privados do inimigo
    private string _nome;
    private int _ataque;
    private int _defesa;
    private int _dano;
    private int _vidaMaxima;
    private int _vidaAtual;

    // Construtor para inicializar o inimigo
    public Inimigo(string nome, int ataque, int defesa, int vidaMaxima)
    {
        _nome = nome;
        _ataque = ataque;
        _defesa = defesa;
        _vidaMaxima = vidaMaxima;
        _vidaAtual = _vidaMaxima;
        _dano = 0; // Inicializa sem dano acumulado
    }

    // Método para receber dano
    public void ReceberDano(int quantidade)
    {
        int danoReal = Mathf.Max(quantidade - _defesa, 0);
        _vidaAtual -= danoReal;
        _vidaAtual = Mathf.Max(_vidaAtual, 0);
        
        Debug.Log($"{_nome} recebeu {danoReal} de dano. Vida restante: {_vidaAtual}");
        
        if (_vidaAtual <= 0)
        {
            Morrer();
        }
    }

    // Método para atacar
    public void Atacar(Personagem alvo)
    {
        _dano = _ataque;
        Debug.Log($"{_nome} atacou causando {_dano} de dano!");
        alvo.ReceberDano(_dano);
    }

    // Método para cura divina
    public void UsarCuraDivina()
    {
        _vidaAtual = Mathf.Min(_vidaAtual + _curaDivina, _vidaMaxima);
        Debug.Log($"{_nome} usou cura divina! Vida atual: {_vidaAtual}");
    }

    // Método chamado quando o inimigo morre
    private void Morrer()
    {
        Debug.Log($"{_nome} foi derrotado!");
        Destroy(gameObject); // Remove o objeto do jogo
    }
}