namespace APBD_Cw1_s28135.Models;

public class Student(int id, string firstName, string lastName) : User(id, firstName, lastName)
{
    public override int MaxRentals => 2; 

    public override string ToString() => $"Student: {base.ToString()}";
}