using APBD_Cw1_s28135.Models;
using APBD_Cw1_s28135.Repositories;
using APBD_Cw1_s28135.Services;
using APBD_Cw1_s28135.UI;

// inicjalizacja komponentow
var repository = new StoreRepository();
var rentalService = new RentalService(repository);
var reportService = new ReportService(repository);

// dodanie danych (uzytkownicy i sprzet
repository.AddUser(new Student(1, "Jan", "Kowalski"));
repository.AddUser(new Employee(2, "Anna", "Nowak"));

repository.AddEquipment(new Laptop(101, "Dell XPS", "Intel i7", 16));
repository.AddEquipment(new Laptop(102, "MacBook Pro", "M2", 32));
repository.AddEquipment(new Projector(201, "Epson EB", "4K"));

// scenariusz wypozyczen
Console.WriteLine("--- DEMONSTRACJA DZIALANIA ---");

// poprawne wypozyczenie
Console.WriteLine(rentalService.RentEquipment(1, 101)); 

// proba wypozyczenia tego samego sprzetu
Console.WriteLine(rentalService.RentEquipment(2, 101)); 

// przekroczenie limitu(max 2) przez studenta 
rentalService.RentEquipment(1, 102);
Console.WriteLine("Proba przekroczenia limitu przez studenta:");
Console.WriteLine(rentalService.RentEquipment(1, 201)); 

// zwrot sprzetu
Console.WriteLine("\n--- ZWROTY ---");
Console.WriteLine(rentalService.ReturnEquipment(101));

// raport
reportService.PrintStatusReport();