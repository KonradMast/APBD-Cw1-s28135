namespace APBD_Cw1_s28135.Models;

public class Rental(User user, Equipment equipment, DateTime rentDate, DateTime dueDate)
{
    public User User { get; } = user;
    public Equipment Equipment { get; } = equipment;
    public DateTime RentDate { get; } = rentDate;
    public DateTime DueDate { get; } = dueDate;
    
    public DateTime? ReturnDate { get; private set; }

    public void ReturnEquipment(DateTime date)
    {
        ReturnDate = date;
        Equipment.IsAvailable = true;
    }

    public override string ToString()
    {
        var status = ReturnDate.HasValue ? $"Zwrócono: {ReturnDate.Value.ToShortDateString()}" : "W trwaniu";
        return $"{Equipment.Name} -> {User.FirstName} {User.LastName} (Termin: {DueDate.ToShortDateString()}) [{status}]";
    }
}