using ChaosCityRPG.Systems;

namespace ChaosCityRPG.Scenes;

/// <summary>
/// Cena de batalha inspirada em RPGs clássicos por turnos.
/// </summary>
public class BattleScene
{
    private readonly BattleSystem _battleSystem;

    public BattleScene()
    {
        _battleSystem = new BattleSystem();
    }

    /// <summary>
    /// Inicia uma batalha contra inimigos corrompidos.
    /// </summary>
    public void EnterBattle()
    {
        Console.WriteLine("Cena: Batalha");
        Console.WriteLine("Um inimigo corrompido aparece!");
        Console.WriteLine();

        _battleSystem.StartBattle();
    }

    /// <summary>
    /// Finaliza a batalha e entrega recompensas.
    /// </summary>
    public void EndBattle()
    {
        // TODO: Calcular experiência, dinheiro e itens recebidos.
    }
}
