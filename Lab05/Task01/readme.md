# Zadanie 1
Zdefiniuj metodę `AllMembers`, która zwraca wszystkich członków zespołu, zgodnie
z kolejnością właściwości w klasie: `Leader`, `Manager`, `Testers`, `Developers`.
Skład zespołu może być dowolny np. może nie wystąpić `Leader`, `Manager` itd., w tym zespół może być też pusty.

### Przykład

```csharp
Team team = new Team()
{
    Developers = ["Karol", "Roman", "Ewa"],
    Leader = "Tomek",
    Manager = "Ewelina"
};

foreach (var member in team.AllMembers())
{
    Console.WriteLine(member);
}
```

Wyjście
```textmate
Tomek
Ewelina
Karol
Roman
Ewa

```

# Zadanie 2
Zmień definicję klasy, aby implementowała interfejs `IEnumerable` i możliwe było
zastosowanie obiektu tej klasy w pętli `foreach` jak w przykładzie poniżej.

```csharp
foreach (var member in team)
{
    Console.WriteLine(member);
}
```
