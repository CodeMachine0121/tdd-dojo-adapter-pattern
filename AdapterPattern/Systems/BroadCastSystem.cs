using AdapterPattern.Models;
using AdapterPattern.SpearkAdapter;

namespace AdapterPattern.Systems;

public class BroadCastSystem(SpeakerAdapter speaker, List<Student> students)
{
    public void BroadCast()
    {
        speaker.Speak(students);
    }
}