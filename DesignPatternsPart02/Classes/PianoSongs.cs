using DesignPatternsPart02.Classes.Piano.Interfaces;
using static System.Console;

namespace DesignPatternsPart02.Classes;

public class PianoSongs
{
    public void Play(IList<INote> notes)
    {
        foreach (var note in notes)
        {
            Beep(note.Frequency, 800);
        }
    }
}