namespace ChaosCityRPG.Systems;

/// <summary>
/// Sistema responsável por desenhar o jogo 2D no console.
/// Ele renderiza mapas, jogador, NPCs, inimigos e objetos usando caracteres.
/// </summary>
public class ConsoleRenderer
{
    /// <summary>
    /// Limpa a tela do console.
    /// </summary>
    public void Clear()
    {
        Console.Clear();
    }

    /// <summary>
    /// Desenha o mapa completo na tela.
    /// </summary>
    public void DrawMap(char[,] map)
    {
        for (int y = 0; y < map.GetLength(0); y++)
        {
            for (int x = 0; x < map.GetLength(1); x++)
            {
                Console.Write(map[y, x]);
            }

            Console.WriteLine();
        }
    }

    /// <summary>
    /// Mostra informações do jogador abaixo do mapa.
    /// </summary>
    public void DrawHud(string playerName, int hp, int level, int chapter)
    {
        Console.WriteLine();
        Console.WriteLine("================================");
        Console.WriteLine($"Jogador: {playerName}");
        Console.WriteLine($"HP: {hp}");
        Console.WriteLine($"Level: {level}");
        Console.WriteLine($"Capítulo: {chapter}");
        Console.WriteLine("================================");
        Console.WriteLine("Movimento: W A S D | Q para sair");
    }
}