namespace ChaosCityRPG.Assets;

/// <summary>
/// Classe mago negro. Especialista em dano mágico elemental.
/// </summary>
public class MrsM
{
    public string Name { get; set; } = "Mrs. M";
    public int Level { get; set; } = 1;
    public int HealthPoints { get; set; } = 85;
    public int ManaPoints { get; set; } = 80;
    public int MagicPower { get; set; } = 28;
    public int DefensePower { get; set; } = 8;

    /// <summary>
    /// Lança magia ofensiva contra um inimigo.
    /// </summary>
    public void CastBlackMagic()
    {
        // TODO: Implementar magia de dano.
    }

    /// <summary>
    /// Canaliza energia para aumentar o dano mágico.
    /// </summary>
    public void Focus()
    {
        // TODO: Aumentar temporariamente o poder mágico.
    }
}
