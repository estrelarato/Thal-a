using UnityEngine;

public class Personagem : MonoBehaviour
{
    [SerializeField] private string nome;
    [SerializeField] private int nivel;
    [SerializeField] private float vida;
    [SerializeField] private float ataque;

    // Getters e Setters
    public string Nome { get => nome; set => nome = value; }
    public int Nivel { get => nivel; set => nivel = value; }
    public float Vida { get => vida; set => vida = value; }
    public float Ataque { get => ataque; set => ataque = value; }

    // Método de comparação
    public string CompararNivel(Personagem outro)
    {
        if (this.nivel > outro.nivel)
            return $"{nome} é de nível mais alto que {outro.nome}.";
        else if (this.nivel < outro.nivel)
            return $"{nome} é de nível mais baixo que {outro.nome}.";
        else
            return $"{nome} e {outro.nome} estão no mesmo nível.";
    }
}
