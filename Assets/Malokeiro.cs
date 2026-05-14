namespace ChaosCityRPG.Assets;

/// <summary>
/// Classe guerreiro. Especialista em ataques físicos e resistência.
/// </summary>
public class Malokeiro
{
    public string Name { get; set; } = "Malokeiro";
    public int Level { get; set; } = 1;
    public int HealthPoints { get; set; } = 140;
    public int ManaPoints { get; set; } = 10;
    public int AttackPower { get; set; } = 22;
    public int DefensePower { get; set; } = 16;

    /// <summary>
    /// Ataque físico básico com alto impacto.
    /// </summary>
    public void Attack()
    {
        // TODO: Implementar cálculo de dano físico.
    }

    /// <summary>
    /// Habilidade defensiva para proteger aliados.
    /// </summary>
    public void Guard()
    {
        // TODO: Reduzir dano recebido durante o turno inimigo.
    }
}
