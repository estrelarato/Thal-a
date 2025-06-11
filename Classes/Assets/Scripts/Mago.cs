using UnityEngine;

public class Mago : Personagem
{
    [SerializeField] private float mana;
    [SerializeField] private string habilidadeEspecial = "Bola de Fogo";

    public float Mana { get => mana; set => mana = value; }
    public string HabilidadeEspecial { get => habilidadeEspecial; }
}
