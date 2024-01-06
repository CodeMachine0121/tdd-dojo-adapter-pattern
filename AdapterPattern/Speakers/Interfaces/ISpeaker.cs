using AdapterPattern.Models;

namespace AdapterPattern.Speakers.Interfaces;

public interface ISpeaker
{
    void Speak(List<Student> studentsList);
}