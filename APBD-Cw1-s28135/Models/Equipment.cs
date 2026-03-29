namespace APBD_Cw1_s28135.Models;

public abstract class Equipment(int id, string name)
{
    public int Id { get; } = id;
    public string Name { get; } = name;
    
    // Status dostepnosci sprzetu w wypozyczalni
    public bool IsAvailable { get; set; } = true;

    public override string ToString() => $"[{Id}] {Name} (Dostępny: {IsAvailable})";
}