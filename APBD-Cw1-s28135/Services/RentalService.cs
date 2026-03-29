using APBD_Cw1_s28135.Models;
using APBD_Cw1_s28135.Repositories;

namespace APBD_Cw1_s28135.Services;

public class RentalService(StoreRepository repository)
{
    public string RentEquipment(int userId, int equipmentId)
    {
        var user = repository.GetUserById(userId);
        var equipment = repository.GetEquipmentById(equipmentId);

        if (user == null) return "Błąd: Nie znaleziono użytkownika.";
        if (equipment == null) return "Błąd: Nie znaleziono sprzętu.";
        if (!equipment.IsAvailable) return $"Błąd: {equipment.Name} jest już wypożyczony.";

        var activeRentals = repository.GetActiveRentalsForUser(userId);
        if (activeRentals.Count >= user.MaxRentals)
            return $"Błąd: {user.FirstName} przekroczył limit wypożyczeń ({user.MaxRentals}).";

        // jesli wszystko ok - wypozyczamy na 7 dni
        equipment.IsAvailable = false;
        var rental = new Rental(user, equipment, DateTime.Now, DateTime.Now.AddDays(7));
        repository.AddRental(rental);

        return $"Sukces: Wypożyczono {equipment.Name} użytkownikowi {user.LastName}.";
    }

    public string ReturnEquipment(int equipmentId)
    {
        var rental = repository.Rentals.FirstOrDefault(r => r.Equipment.Id == equipmentId && r.ReturnDate == null);
        
        if (rental == null) return "Błąd: Ten sprzęt nie jest aktualnie wypożyczony.";

        rental.ReturnEquipment(DateTime.Now);
        
        // sprawdzenie czy oddano po terminie
        if (DateTime.Now > rental.DueDate)
        {
            var delay = (DateTime.Now - rental.DueDate).Days;
            return $"Zwrot: {rental.Equipment.Name} oddany z opóźnieniem: {delay} dni. Naliczono karę.";
        }

        return $"Zwrot: {rental.Equipment.Name} oddany w terminie.";
    }
}