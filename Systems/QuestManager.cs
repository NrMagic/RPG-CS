namespace ChaosCityRPG.Systems;

/// <summary>
/// Controla missões principais, secundárias e objetivos ativos.
/// </summary>
public class QuestManager
{
    private readonly List<string> _activeQuests = new();
    private readonly List<string> _completedQuests = new();

    /// <summary>
    /// Adiciona uma nova missão ativa.
    /// </summary>
    public void AddQuest(string questDescription)
    {
        _activeQuests.Add(questDescription);
        Console.WriteLine("Nova missão: " + questDescription);
    }

    /// <summary>
    /// Marca uma missão como concluída.
    /// </summary>
    public void CompleteQuest(string questDescription)
    {
        if (_activeQuests.Remove(questDescription))
        {
            _completedQuests.Add(questDescription);
        }
    }

    /// <summary>
    /// Lista todas as missões ativas.
    /// </summary>
    public void ShowActiveQuests()
    {
        Console.WriteLine("Missões ativas:");

        foreach (string quest in _activeQuests)
        {
            Console.WriteLine("- " + quest);
        }
    }

    /// <summary>
    /// Verifica se uma missão já foi concluída.
    /// </summary>
    public bool IsQuestCompleted(string questDescription)
    {
        return _completedQuests.Contains(questDescription);
    }
}
