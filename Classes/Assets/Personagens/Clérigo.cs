public class Clerigo : Personagem
{
    // Construtor do Clérigo
    public Clerigo()
    {
        nome = "Clérigo";
        vidaMaxima = 75;
        vidaAtual = vidaMaxima;
        defesa = 10;
        ataque = 15; 
        
    Debug.Log($"{nome} entrou no jogo com {vidaAtual} de vida.");
    }

    // Método especial de cura (exclusivo do Clérigo)
    public void Curar(Personagem alvo)
    {
        alvo.vidaAtual = Mathf.Min(alvo.vidaAtual + 20, alvo.vidaMaxima);
        Debug.Log($"{nome} curou {alvo.nome}! Vida agora: {alvo.vidaAtual}");
    }
}