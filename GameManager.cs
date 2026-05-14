using ChaosCityRPG.Scenes;
using ChaosCityRPG.Systems;

namespace ChaosCityRPG;

/// <summary>
/// Controla o fluxo geral do jogo, cenas, dados e sistemas principais.
/// </summary>
public class GameManager
{
    private readonly GameData _gameData;
    private readonly Inventory _inventory;
    private readonly QuestManager _questManager;

    public GameManager()
    {
        _gameData = new GameData();
        _inventory = new Inventory();
        _questManager = new QuestManager();
    }

    /// <summary>
    /// Inicia a aventura principal.
    /// </summary>
    public void StartGame()
    {
        Console.WriteLine("=== ChaosCityRPG ===");
        Console.WriteLine("Ano: 1990");
        Console.WriteLine("Uma cidade vive em caos por causa de uma facção que espalha entorpecentes.");
        Console.WriteLine();

        TownScene townScene = new TownScene(_gameData, _inventory, _questManager);
        townScene.Enter();
    }

    /// <summary>
    /// Salva o progresso atual do jogador.
    /// </summary>
    public void SaveGame()
    {
        // TODO: Implementar serialização dos dados persistentes.
    }

    /// <summary>
    /// Carrega um progresso salvo anteriormente.
    /// </summary>
    public void LoadGame()
    {
        // TODO: Implementar leitura dos dados persistentes.
    }
}
