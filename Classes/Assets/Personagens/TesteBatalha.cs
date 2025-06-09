using UnityEngine;

public class TesteBatalha : MonoBehaviour
{
    public Personagem heroi;
    public Personagem inimigo;

    void Start()
    {
        heroi.Atacar(inimigo);
        inimigo.Atacar(heroi);
    }
}