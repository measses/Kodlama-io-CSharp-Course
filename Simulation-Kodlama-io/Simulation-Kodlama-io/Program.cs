using HW3.Business.Concrete;
using HW3.DataAccess.Concrete;
using HW3.Entitites;


// FOR CATEGORY ARCHITECT
CategoryService categoryService = new CategoryService(new CategoryDal());
List<Category> categories = categoryService.GetCategories();
categoryService.Add(new Category
{
    CategoryName = "YENİİİİİİİİİİ",
    CategoryId = 333333333
});
foreach (var course in categories)
{
    Console.WriteLine("Category Name: " + course.CategoryName);
    Console.WriteLine("Category ID: " + course.CategoryId);
    Console.WriteLine("************************************");
}


// FOR COURSE ARCHITECT
CourseService courseService = new CourseService(new CourseDal());
List<Course> courses = courseService.GetCourseList();

// It deletes the first course from the list
//courseService.Delete(courses[0]); 


// It adds new course to your list
//courseService.Add(new Course
//{
//    CourseName = "Yeni Kurs",
//    CourseCategory = "Yeni Kategori",
//    CourseId = 35,
//    CourseInstructor ="Yeni Hoca",
//    CoursePercentage = 35
//});


// It updates the course with the given id
//courseService.Update(new Course
//{
//    CourseId = 1,
//    CourseName = "GÜĞNCELLENDİii"
//});

foreach (var course in courses)
{
    Console.WriteLine("Course Id: " + course.CourseId);
    Console.WriteLine("Course Name: " + course.CourseName);
    Console.WriteLine("Course Category: " + course.CourseCategory);
    Console.WriteLine("Course Instructor: " + course.CourseInstructor);
    Console.WriteLine("Course Percentage: " + course.CoursePercentage);
    Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%");
}


