# APBD - Zadanie 1 - s28135

## opis systemu
Projekt to system do zarzadzania wypozyczalnia sprzetu. Obsluguje dwa typy uzytkownikow (student, pracownik) oraz dwa typy sprzetu (laptop, projektor). System pilnuje limitow wypozyczen i dostepnosci zasobow.

## uasadnienie podzialu klas 

1. **Models**:
    - Zastosowano dziedziczenie (user oraz equipment), aby uniknac powtarzania kodu.
    - klasy posiadaja wlasne limity dzieki polimorfizmowi, co ulatwia dodawanie nowych rol w przyszlosci.

2. **Repositories**:
    - klasa StoreRepository izoluje przechowywanie danych od reszty programu. dzieki temu Services nie musza wiedziec, jak dane sa skladowane.

3. **Services**:
    - RentalService odpowiada za "mozg" aplikacji. to tutaj sprawdzane sa reguly biznesowe (czy student moze wypozyczyc kolejny laptop).
    - dzieki wydzieleniu tej warstwy, kod jest latwiejszy do testowania i modyfikacji.

4. **UI**:
    - ReportService zajmuje sie tylko formatowaniem i wypisywaniem danych. oddzielenie widoku od logiki pozwala na zachowanie czystego kodu.
