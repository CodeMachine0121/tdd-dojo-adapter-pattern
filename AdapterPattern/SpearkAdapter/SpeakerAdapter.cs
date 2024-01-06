using AdapterPattern.Models;
using AdapterPattern.Speakers.Interfaces;

namespace AdapterPattern.SpearkAdapter;

public class SpeakerAdapter : ISpeaker
{
    private readonly ISpeaker _speaker;

    public SpeakerAdapter(ISpeaker speaker)
    {
        _speaker = speaker;
    }

    public void Speak(List<Student> studentsList)
    {
        _speaker.Speak(studentsList);
    }
}