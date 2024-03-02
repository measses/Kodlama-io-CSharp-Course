
using Simulation-Kodlama-io.Entitites;

namespace Simulation-Kodlama-io.Entitites;

public class Instructor
{
    public int IntructorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Course> InstructorCourses { get; set; } = [];

}