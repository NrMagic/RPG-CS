namespace ChaosCityRPG.Assets;

/// <summary>
/// Classe maga branca. Especialista em cura, suporte e proteção.
/// </summary>
public class Enfermeira
{
    public string Name { get; set; } = "Enfermeira";
    public int Level { get; set; } = 1;
    public int HealthPoints { get; set; } = 95;
    public int ManaPoints { get; set; } = 90;
    public int HealingPower { get; set; } = 30;
    public int DefensePower { get; set; } = 10;

    /// <summary>
    /// Cura um aliado ferido.
    /// </summary>
    public void Heal()
    {
        // TODO: Restaurar pontos de vida de um aliado.
    }

    /// <summary>
    /// Remove efeitos negativos causados pelos entorpecentes.
    /// </summary>
    public void Cleanse()
    {
        // TODO: Remover status negativo do personagem.
    }
}
