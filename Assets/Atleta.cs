namespace ChaosCityRPG.Assets;

/// <summary>
/// Classe monge/ninja. Especialista em velocidade, golpes críticos e esquiva.
/// </summary>
public class Atleta
{
    public string Name { get; set; } = "Atleta";
    public int Level { get; set; } = 1;
    public int HealthPoints { get; set; } = 110;
    public int ManaPoints { get; set; } = 25;
    public int AttackPower { get; set; } = 18;
    public int Speed { get; set; } = 30;

    /// <summary>
    /// Executa sequência rápida de golpes.
    /// </summary>
    public void ComboAttack()
    {
        // TODO: Implementar múltiplos ataques leves.
    }

    /// <summary>
    /// Aumenta chance de esquivar no próximo turno.
    /// </summary>
    public void DodgeStance()
    {
        // TODO: Aplicar bônus temporário de esquiva.
    }
}
