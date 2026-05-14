namespace ChaosCityRPG.Systems;

/// <summary>
/// Sistema de batalha por turnos inspirado em Final Fantasy clássico.
/// </summary>
public class BattleSystem
{
    private int _turnCounter = 1;
    private bool _battleIsActive = false;

    /// <summary>
    /// Inicia o combate.
    /// </summary>
    public void StartBattle()
    {
        _battleIsActive = true;
        Console.WriteLine("Sistema de batalha iniciado.");
        Console.WriteLine("Turno " + _turnCounter);
        Console.WriteLine();

        // TODO: Carregar grupo de heróis.
        // TODO: Carregar inimigos.
        // TODO: Iniciar loop de turnos.
    }

    /// <summary>
    /// Executa o turno do jogador.
    /// </summary>
    public void PlayerTurn()
    {
        // TODO: Exibir opções: atacar, magia, item, defender, fugir.
    }

    /// <summary>
    /// Executa o turno dos inimigos.
    /// </summary>
    public void EnemyTurn()
    {
        // TODO: Criar IA simples para inimigos.
    }

    /// <summary>
    /// Calcula dano físico ou mágico.
    /// </summary>
    public int CalculateDamage(int attackPower, int defensePower)
    {
        int damage = attackPower - defensePower;

        if (damage < 1)
        {
            damage = 1;
        }

        return damage;
    }

    /// <summary>
    /// Avança para o próximo turno.
    /// </summary>
    public void NextTurn()
    {
        _turnCounter++;
    }

    /// <summary>
    /// Finaliza o combate.
    /// </summary>
    public void EndBattle()
    {
        _battleIsActive = false;
        Console.WriteLine("Batalha finalizada.");

        // TODO: Verificar vitória, derrota e recompensas.
    }
}
