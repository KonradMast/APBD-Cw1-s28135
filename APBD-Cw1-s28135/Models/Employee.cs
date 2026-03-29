namespace APBD_Cw1_s28135.Models;

public class Employee(int id, string firstName, string lastName) : User(id, firstName, lastName)
{
    public override int MaxRentals => 5;

    public override string ToString() => $"Pracownik: {base.ToString()}";
}