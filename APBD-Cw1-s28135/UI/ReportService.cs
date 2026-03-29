using APBD_Cw1_s28135.Repositories;

namespace APBD_Cw1_s28135.UI;

public class ReportService(StoreRepository repository)
{
    public void PrintStatusReport()
    {
        Console.WriteLine("\n--- RAPORT KONCOWY STANU SYSTEMU ---");
        
        Console.WriteLine("\nUzytkownicy:");
        repository.Users.ForEach(Console.WriteLine);

        Console.WriteLine("\nSprzet:");
        repository.EquipmentList.ForEach(Console.WriteLine);

        Console.WriteLine("\nAktywne Wypozyczenia:");
        var active = repository.Rentals.Where(r => r.ReturnDate == null).ToList();
        if (active.Count == 0) Console.WriteLine("Brak.");
        else active.ForEach(Console.WriteLine);
        
        Console.WriteLine("------------------------------------\n");
    }
}