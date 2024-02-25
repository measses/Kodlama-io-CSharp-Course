using HW3.Entitites;
using System;

public interface ICourseDal
{
    List<Course> GetAllCourses();
    void Add(Course course);
    void Update(Course course);
    void Delete(Course course);
}
