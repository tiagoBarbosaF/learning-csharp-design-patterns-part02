using DesignPatternsPart02.Classes;
using DesignPatternsPart02.Classes.Piano;
using DesignPatternsPart02.Classes.Piano.Interfaces;

internal class Program
{
    public static void Main(string[] args)
    {
        var notes = new MusicalNotes();

        var music = new List<INote>()
        {
            notes.Get("do"),
            notes.Get("re"),
            notes.Get("mi"),
            notes.Get("fa"),
            notes.Get("fa"),
            notes.Get("fa")
        };

        var piano = new PianoSongs();
        
        piano.Play(music);
    }
}