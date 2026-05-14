namespace ChaosCityRPG.Systems;

/// <summary>
/// Gerencia itens, equipamentos, consumíveis e dinheiro.
/// </summary>
public class Inventory
{
    private readonly List<string> _items = new();
    private readonly List<string> _equipments = new();

    public int Money { get; private set; } = 0;

    /// <summary>
    /// Adiciona um item ao inventário.
    /// </summary>
    public void AddItem(string itemName)
    {
        _items.Add(itemName);
    }

    /// <summary>
    /// Remove um item do inventário.
    /// </summary>
    public void RemoveItem(string itemName)
    {
        _items.Remove(itemName);
    }

    /// <summary>
    /// Usa um item durante exploração ou batalha.
    /// </summary>
    public void UseItem(string itemName)
    {
        // TODO: Aplicar efeito do item.
    }

    /// <summary>
    /// Adiciona equipamento ao inventário.
    /// </summary>
    public void AddEquipment(string equipmentName)
    {
        _equipments.Add(equipmentName);
    }

    /// <summary>
    /// Adiciona dinheiro ao jogador.
    /// </summary>
    public void AddMoney(int amount)
    {
        Money += amount;
    }
}
