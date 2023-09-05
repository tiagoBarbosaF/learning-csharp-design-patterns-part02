using DesignPatternsPart02.Classes.Piano.Interfaces;
using DesignPatternsPart02.Classes.Piano.Notes;

namespace DesignPatternsPart02.Classes.Piano;

public class MusicalNotes
{
    private static IDictionary<string, INote> _notes = new Dictionary<string, INote>()
    {
        { "do", new Do() },
        { "re", new Re() },
        { "mi", new Mi() },
        { "fa", new Fa() },
        { "sol", new Sol() },
        { "la", new La() },
        { "si", new Si() },
    };

    public INote Get(string name) => _notes[name];
}