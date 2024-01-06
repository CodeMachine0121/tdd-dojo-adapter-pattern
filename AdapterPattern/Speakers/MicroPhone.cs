using AdapterPattern.Models;
using AdapterPattern.Speakers.Interfaces;

namespace AdapterPattern.Speakers;

public class MicroPhone : ISpeaker
{
    public void Speak(List<Student> studentsList)
    {
        foreach (var student in studentsList)
        {
            student.Notice = true;
        }
    }
}