namespace APBD_Cw1_s28135.Models;

public abstract class User(int id, string firstName, string lastName)
{
    public int Id { get; } = id;
    public string FirstName { get; } = firstName;
    public string LastName { get; } = lastName;
    
    public abstract int MaxRentals { get; }

    public override string ToString() => $"[{Id}] {FirstName} {LastName} (Limit: {MaxRentals})";
}