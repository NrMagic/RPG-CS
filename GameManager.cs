using System.Text.Json;
using ChaosCityRPG.Scenes;
using ChaosCityRPG.Systems;

namespace ChaosCityRPG;

/// <summary>
/// Controla o fluxo geral do jogo, cenas, dados e sistemas principais.
/// </summary>
public class GameManager
{
    private GameData _gameData;
    private readonly Inventory _inventory;
    private readonly QuestManager _questManager;

    private const string SaveFilePath = "savegame.json";

    public GameManager()
    {
        _gameData = new GameData();
        _inventory = new Inventory();
        _questManager = new QuestManager();
    }

    /// <summary>
    /// Inicia o jogo no console em estilo RPG 2D.
    /// </summary>
    public void StartGame()
    {
        Console.Title = "ChaosCityRPG";

        Console.WriteLine("=== ChaosCityRPG ===");
        Console.WriteLine("1 - Novo Jogo");
        Console.WriteLine("2 - Carregar Jogo");
        Console.WriteLine();

        Console.Write("Escolha uma opção: ");
        string? option = Console.ReadLine();

        if (option == "2")
        {
            LoadGame();
        }
        else
        {
            NewGame();
        }

        TownScene townScene = new TownScene(_gameData, _inventory, _questManager);
        townScene.Enter();

        SaveGame();

        Console.WriteLine("Jogo encerrado.");
    }

    /// <summary>
    /// Cria um novo jogo do zero.
    /// </summary>
    public void NewGame()
    {
        _gameData = new GameData();

        Console.WriteLine();
        Console.WriteLine("Novo jogo iniciado.");
        Console.Write("Digite o nome do protagonista: ");

        string? name = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(name))
        {
            _gameData.PlayerName = name;
        }
    }

    /// <summary>
    /// Salva o progresso atual do jogador em JSON.
    /// </summary>
    public void SaveGame()
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string json = JsonSerializer.Serialize(_gameData, options);

        File.WriteAllText(SaveFilePath, json);
    }

    /// <summary>
    /// Carrega o progresso salvo anteriormente.
    /// </summary>
    public void LoadGame()
    {
        if (!File.Exists(SaveFilePath))
        {
            Console.WriteLine();
            Console.WriteLine("Nenhum save encontrado. Um novo jogo será iniciado.");
            _gameData = new GameData();
            return;
        }

        string json = File.ReadAllText(SaveFilePath);

        GameData? loadedData = JsonSerializer.Deserialize<GameData>(json);

        if (loadedData == null)
        {
            Console.WriteLine("Erro ao carregar o save. Um novo jogo será iniciado.");
            _gameData = new GameData();
            return;
        }

        _gameData = loadedData;

        Console.WriteLine();
        Console.WriteLine("Jogo carregado com sucesso!");
        Console.WriteLine($"Bem-vindo de volta, {_gameData.PlayerName}.");
        Console.WriteLine("Pressione qualquer tecla para continuar.");
        Console.ReadKey(true);
    }
}