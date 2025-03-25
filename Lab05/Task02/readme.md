# Zadanie 3
Zdefiniuj w klasie `Parking` indekser, który zwróci na podstawie numerur miejsca parkinkowego
numer rejestracyjny zaparkowanego auta. 
Numery miejsc parkinowych zaczynąją się od 1 (miejsce numer jeden to komórka `_places[0]`) do 100.
Jeśli miejsce parkinowe jest puste (w komórce _places[n] znajduje się null) to zwróć napis
"Miejsce wolne". Zaindeksowanie numerem spoza zakresu od 1 do 100 powinno zwrócić łańcuch "Nie ma takiego miejsca!". 

Przykład
```csharp
Parking parking = new Parking();
parking.Park("TKL 89087S");
parking.Park("WAW 67898S");
Console.WriteLine(parking[1]);
Console.WriteLine(parking[2]);
Console.WriteLine(parking[3]);
Console.WriteLine(parking[300]);
```

### Wyjście
```csharp
TKL 89087S
WAW 67898S
Wolne miejsce
Nie ma takiego miejsca!
```

# Zadanie 4
Zdefniuj metodę `UnPark(int n)`, która na podstawie nr miejsca parkingowego zwolni go, 
jeśli jest zajętę (metoda wtedy zwraca `true`). Próba wyparkowania z miejsca pustego lub nieistniejącego 
powoduje zwrócenie z metody `false`.
