using System.Collections;

namespace Lab05.Task01;

public class Team
{
    public string? Leader { get; set; }
    public string? Manager { get; set; }
    public List<string> Testers { get; set; } = new();
    public List<string> Developers { get; set; } = new();

    public IEnumerable<string> AllMembers()
    {

        throw new NotImplementedException();
    }
}