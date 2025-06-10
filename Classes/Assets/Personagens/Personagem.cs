using UnityEngine;

public class Personagem : MonoBehaviour
{
    // Atributos básicos detodo personagem
    public string nome;
    public int vidaMaxima;
    public int vidaAtual;
    public int defesa;
    public int ataque;

    // Método para receber dano
    public void ReceberDano(int dano)
    {
        int danoReal = Mathf.Max(dano - defesa, 0);
        vidaAtual -= danoReal;
        vidaAtual = Mathf.Max(vidaAtual, 0);
        Debug.Log($"{nome} recebeu {danoReal} de dano. Vida restante: {vidaAtual}");
    }

    // Método para atacar outro personagem
    public void Atacar(Personagem inimigo)
    {
        Debug.Log($"{nome} ataca {inimigo.nome}!");
        inimigo.ReceberDano(ataque);
    }
}
