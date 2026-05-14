namespace ChaosCityRPG.Scenes;

/// <summary>
/// Cena da base inimiga onde a facção produz o entorpecente.
/// </summary>
public class DrugLabScene
{
    /// <summary>
    /// Entrada da base inimiga.
    /// </summary>
    public void Enter()
    {
        Console.WriteLine("Cena: Laboratório da Facção");
        Console.WriteLine("Máquinas antigas, barris tóxicos e guardas corrompidos protegem o local.");
        Console.WriteLine();

        // TODO: Criar exploração da base.
        // TODO: Adicionar inimigos humanos e animais corrompidos.
        // TODO: Preparar batalha contra o chefe da facção.
    }

    /// <summary>
    /// Desativa os equipamentos da facção.
    /// </summary>
    public void DestroyProduction()
    {
        // TODO: Alterar estado do mundo e reduzir influência inimiga.
    }

    /// <summary>
    /// Inicia a batalha final contra o líder da facção.
    /// </summary>
    public void StartBossBattle()
    {
        // TODO: Integrar com BattleScene e BattleSystem.
    }
}
