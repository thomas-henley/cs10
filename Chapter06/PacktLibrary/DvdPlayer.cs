using static System.Console;

namespace PacktLibrary;

public class DvdPlayer : IPlayable
{
    public void Pause()
    {
        WriteLine("DVD Player is pausing.");
    }

    public void Play()
    {
        WriteLine("DVD player is playing.");
    }
}