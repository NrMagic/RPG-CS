using ChaosCityRPG.Systems;

namespace ChaosCityRPG.Scenes;

/// <summary>
/// Cena da cidade natal, ponto inicial da jornada.
/// </summary>
public class TownScene
{
    private readonly GameData _gameData;
    private readonly Inventory _inventory;
    private readonly QuestManager _questManager;

    public TownScene(GameData gameData, Inventory inventory, QuestManager questManager)
    {
        _gameData = gameData;
        _inventory = inventory;
        _questManager = questManager;
    }

    /// <summary>
    /// Entrada principal da cidade.
    /// </summary>
    public void Enter()
    {
        Console.WriteLine("Cena: Cidade Natal");
        Console.WriteLine("Ruas antigas, postes fracos e sinais de uma cidade dominada pelo medo.");
        Console.WriteLine();

        _questManager.AddQuest("Investigar a origem dos entorpecentes na cidade.");

        // TODO: Criar menu de exploração da cidade.
        // TODO: Conversar com NPCs.
        // TODO: Liberar acesso à batalha inicial.
    }

    /// <summary>
    /// Permite conversar com moradores da cidade.
    /// </summary>
    public void TalkToCitizens()
    {
        // TODO: Implementar diálogos com NPCs.
    }

    /// <summary>
    /// Leva o jogador para a primeira batalha.
    /// </summary>
    public void StartFirstBattle()
    {
        BattleScene battleScene = new BattleScene();
        battleScene.EnterBattle();
    }
}
