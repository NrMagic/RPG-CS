using ChaosCityRPG.Systems;

namespace ChaosCityRPG.Scenes;

/// <summary>
/// Cena da cidade natal em estilo RPG 2D no console.
/// </summary>
public class TownScene
{
    private readonly GameData _gameData;
    private readonly Inventory _inventory;
    private readonly QuestManager _questManager;
    private readonly ConsoleRenderer _renderer;

    private bool _running = true;

    private char[,] _map =
    {
        { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
        { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#' },
        { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'N', '.', '.', '.', '.', '.', '.', '.', '#' },
        { '#', '.', '.', '.', '#', '#', '#', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#' },
        { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'E', '.', '.', '.', '#' },
        { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#' },
        { '#', '.', '.', '.', '.', '.', '.', '#', '#', '#', '#', '#', '.', '.', '.', '.', '.', '.', '.', '#' },
        { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'L', '.', '#' },
        { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#' },
        { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
    };

    public TownScene(GameData gameData, Inventory inventory, QuestManager questManager)
    {
        _gameData = gameData;
        _inventory = inventory;
        _questManager = questManager;
        _renderer = new ConsoleRenderer();
    }

    /// <summary>
    /// Inicia a exploração da cidade.
    /// </summary>
    public void Enter()
    {
        _questManager.AddQuest("Investigar a origem dos entorpecentes na cidade.");

        while (_running)
        {
            DrawScene();
            ReadInput();
        }
    }

    /// <summary>
    /// Desenha a cena atual no console.
    /// </summary>
    private void DrawScene()
    {
        char[,] tempMap = CopyMap();

        tempMap[_gameData.PlayerY, _gameData.PlayerX] = '@';

        _renderer.Clear();
        Console.WriteLine("=== ChaosCityRPG - Cidade Natal ===");
        Console.WriteLine();

        _renderer.DrawMap(tempMap);

        _renderer.DrawHud(
            _gameData.PlayerName,
            _gameData.PlayerHp,
            _gameData.PlayerLevel,
            _gameData.CurrentChapter
        );

        Console.WriteLine();
        Console.WriteLine("Legenda:");
        Console.WriteLine("@ = Você | N = NPC | E = Inimigo | L = Laboratório | # = Parede");
    }

    /// <summary>
    /// Lê o comando do jogador.
    /// </summary>
    private void ReadInput()
    {
        ConsoleKeyInfo key = Console.ReadKey(true);

        switch (key.Key)
        {
            case ConsoleKey.W:
                MovePlayer(0, -1);
                break;

            case ConsoleKey.S:
                MovePlayer(0, 1);
                break;

            case ConsoleKey.A:
                MovePlayer(-1, 0);
                break;

            case ConsoleKey.D:
                MovePlayer(1, 0);
                break;

            case ConsoleKey.Q:
                _running = false;
                break;
        }
    }

    /// <summary>
    /// Move o jogador pelo mapa se o destino for válido.
    /// </summary>
    private void MovePlayer(int dx, int dy)
    {
        int newX = _gameData.PlayerX + dx;
        int newY = _gameData.PlayerY + dy;

        char nextTile = _map[newY, newX];

        if (nextTile == '#')
        {
            return;
        }

        if (nextTile == 'N')
        {
            TalkToNpc();
            return;
        }

        if (nextTile == 'E')
        {
            StartBattle();
            return;
        }

        if (nextTile == 'L')
        {
            EnterDrugLab();
            return;
        }

        _gameData.PlayerX = newX;
        _gameData.PlayerY = newY;
    }

    /// <summary>
    /// Conversa com um NPC da cidade.
    /// </summary>
    private void TalkToNpc()
    {
        _renderer.Clear();

        Console.WriteLine("Morador:");
        Console.WriteLine("\"A cidade não era assim nos anos 90...\"");
        Console.WriteLine("\"A facção tomou o laboratório abandonado ao leste.\"");
        Console.WriteLine();

        Console.WriteLine("Pressione qualquer tecla para continuar.");
        Console.ReadKey(true);
    }

    /// <summary>
    /// Inicia uma batalha ao encostar em um inimigo.
    /// </summary>
    private void StartBattle()
    {
        BattleScene battleScene = new BattleScene();
        battleScene.EnterBattle();

        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para voltar à cidade.");
        Console.ReadKey(true);
    }

    /// <summary>
    /// Entra na base inimiga.
    /// </summary>
    private void EnterDrugLab()
    {
        DrugLabScene drugLabScene = new DrugLabScene();
        drugLabScene.Enter();

        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para voltar à cidade.");
        Console.ReadKey(true);
    }

    /// <summary>
    /// Copia o mapa original para evitar sobrescrever posições fixas.
    /// </summary>
    private char[,] CopyMap()
    {
        char[,] copy = new char[_map.GetLength(0), _map.GetLength(1)];

        for (int y = 0; y < _map.GetLength(0); y++)
        {
            for (int x = 0; x < _map.GetLength(1); x++)
            {
                copy[y, x] = _map[y, x];
            }
        }

        return copy;
    }
}