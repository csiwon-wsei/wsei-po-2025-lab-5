namespace Lab05.Task02;

public partial class Parking
{
    private string?[] _places = new string[100];
    private int _freePlacesCount;
    public string? this[int i] => _places[i - 1] == null ? "Wolne miejsce" : _places[i - 1];

    public Parking()
    {
        _freePlacesCount = _places.Length;
    }

    public bool Park(string plateNumber)
    {
        int i = FindFreePlace();
        if (i >= 0)
        {
            _places[i] = plateNumber;
            _freePlacesCount++;
            return true;
        }
        return false;
    }

    public bool UnPark(int position)
    {
        throw new NotImplementedException();
    }

    private int FindFreePlace()
    {
        for (int i = 0; i < _places.Length; i++)
        {
            if (_places[i] == null)
            {
                return i;
            }
        }
        return -1;
    }
}