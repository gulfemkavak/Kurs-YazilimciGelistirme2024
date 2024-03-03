using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{
    //constructor
 
    Courses[] courses=new Courses[3];
    public CourseManager()
    {
        Courses course1 = new Courses();
        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = ".NET 8 vs.";
        course1.Price = 100;
        Courses course2 = new Courses();
        course2.Id = 2;
        course2.Name = "Java";
        course2.Price = 100;
        Courses course3 = new Courses();
        course3.Id = 3;
        course3.Name = "Python";
        course3.Description = "Python 3.12";
        course3.Price = 150;
        courses[0]=course1;
        courses[1]=course2;
        courses[2]=course3;

    }

    public Courses[] GetAll()
    {

      return courses;


    }
}
