using UnityEngine;

public class TestePersonagem : MonoBehaviour
{
    public Mago mago1;
    public Mago mago2;

    void Start()
    {
        // Inicializa valores (caso não preenchido no inspetor da Unity)
        if (mago1 != null && mago2 != null)
        {
            Debug.Log($"Mago 1: {mago1.Nome}, Nível: {mago1.Nivel}, Vida: {mago1.Vida}, Mana: {mago1.Mana}");
            Debug.Log($"Mago 2: {mago2.Nome}, Nível: {mago2.Nivel}, Vida: {mago2.Vida}, Mana: {mago2.Mana}");

            Debug.Log(mago1.CompararNivel(mago2));
        }
        else
        {
            Debug.LogWarning("Personagens não atribuídos no inspetor.");
        }
    }
}
