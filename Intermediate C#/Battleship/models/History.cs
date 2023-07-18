namespace Battleship.Models;

class History
{
    private readonly List<Entry> _entries = new ();

    public History() {}

    public void Add(Entry entry) => _entries.Add(entry);

    public void ViewEntries()
    {
        for (int i = 0; i < _entries.Count; i++)
        {
            Console.WriteLine(i + 1 + ". " + _entries[i]);
        }
    }
}