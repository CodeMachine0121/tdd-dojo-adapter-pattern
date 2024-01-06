using AdapterPattern.Models;
using AdapterPattern.Speakers;
using AdapterPattern.SpearkAdapter;
using AdapterPattern.Systems;
using FluentAssertions;

namespace AdapterPattern;

[TestFixture]
public class BroadCasstServiceTests
{
    [Test]
    public void should_be_notice()
    {
        var microPhone = new MicroPhone();
        var students = new List<Student>();
        microPhone.Speak(students);

        foreach (var student in students)
        {
            student.Notice.Should().BeTrue();
        }
    }

    [Test]
    public void should_use_broadcast_system()
    {
        var students = CreateStudents();

        var speakerAdapter = new SpeakerAdapter(new MicroPhone());
        var broadCastSystem = new BroadCastSystem(speakerAdapter, students);
        broadCastSystem.BroadCast();

        Assert(students);
    }

    private static void Assert(List<Student> students)
    {
        foreach (var student in students)
        {
            student.Notice.Should().BeTrue();
        }
    }

    private static List<Student> CreateStudents()
    {
        return new List<Student>()
        {
            new(),
            new()
        };
    }

    [Test]
    public void should_use_broadcast_system_with_new_Speaker()
    {
        var students = CreateStudents();
        var newSpeaker = new NewSpeaker();
        var speakerAdapter = new SpeakerAdapter(newSpeaker);
        var broadCastSystem = new BroadCastSystem(speakerAdapter, students);
        broadCastSystem.BroadCast();

        Assert(students);
    }
}