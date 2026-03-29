using APBD_Cw1_s28135.Models;

namespace APBD_Cw1_s28135.Repositories;

public class StoreRepository
{
    public List<User> Users { get; } = new();
    public List<Equipment> EquipmentList { get; } = new();
    public List<Rental> Rentals { get; } = new();

    // metody do dodawania obiektow
    public void AddUser(User user) => Users.Add(user);
    public void AddEquipment(Equipment equipment) => EquipmentList.Add(equipment);
    public void AddRental(Rental rental) => Rentals.Add(rental);

    // wyszukiwanie
    public User? GetUserById(int id) => Users.FirstOrDefault(u => u.Id == id);
    public Equipment? GetEquipmentById(int id) => EquipmentList.FirstOrDefault(e => e.Id == id);
    
    // zwraca listę aktywnych wypozyczen danego uzytkownika
    public List<Rental> GetActiveRentalsForUser(int userId) 
        => Rentals.Where(r => r.User.Id == userId && r.ReturnDate == null).ToList();
}