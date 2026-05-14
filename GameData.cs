namespace ChaosCityRPG;

/// <summary>
/// Guarda dados persistentes da campanha, progresso, grupo e estado do mundo.
/// </summary>
public class GameData
{
    public string PlayerName { get; set; } = "Herói de 1990";
    public int CurrentChapter { get; set; } = 1;
    public bool CityCleaned { get; set; } = false;
    public bool DrugLabDiscovered { get; set; } = false;

    /// <summary>
    /// Atualiza o capítulo atual da história.
    /// </summary>
    public void SetChapter(int chapter)
    {
        CurrentChapter = chapter;
    }

    /// <summary>
    /// Marca a cidade como livre da influência da facção.
    /// </summary>
    public void MarkCityAsCleaned()
    {
        CityCleaned = true;
    }
}
