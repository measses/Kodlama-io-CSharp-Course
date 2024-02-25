
using HW3.Entitites;

namespace HW3.Entitites;

public class Instructor
{
    public int IntructorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Course> InstructorCourses { get; set; } = [];

}