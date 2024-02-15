using intro.DataAccess.Concretes;
using intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using intro.DataAccess.Abstracts;

namespace intro.Business;

//Operasyon tutucu sinif
//reusablity. OOP sayesinde reusablity yapilar olur
public class CourseManager
{
    //global degisken
    // Course[] courses = new Course[3];

    //constructor
    //veri tabanında gelmis gibi kurs ekleyecegiz
    //class ismiyle ayni olur
    //new'i gordugu anda calisir

    public CourseManager()
    {
        //Course course1 = new Course();
        //course1.Id = 1;
        //course1.Name = "C#";
        //course1.Description = ".NET 8 vs ...";
        //course1.Price = 0;

        //Course course2 = new Course();
        //course2.Id = 2;
        //course2.Name = "Java";
        //course2.Description = "Java 17 vs ...";
        //course2.Price = 10;

        //Course course3 = new Course();
        //course3.Id = 3;
        //course3.Name = "Python";
        //course3.Description = "Python 3.12 ...";
        //course3.Price = 20;

        //courses[0] = course1;
        //courses[1] = course2;
        //courses[2] = course3;

    }
    //Metod-Fonksiyon
    //GetAll cagirildiginda Course datasini vermeye soz veriyorum
    //void kullanmadiysan ne dondurecegini return ile bildir.
    //public Course[] GetAll()
    //{
    //    return courses;
    //}


    //busines data accsessi newleyemez. sadece soyutlarindan calisabilir
    //dependency injection denir bu desene
    private readonly ICourseDal _courseDal;
    //eğer sen beni new lersen bana bir coursedal vermek zorundasın
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;

    }

    public List<Course> GetAll()
    {
        //business rules
        //oldugu gibi boyle kullanırsan butun projede artik buna bagimlisin. yontem degisirse bu patlar.
        //ornegin sanal posun bankasi degisirse patlar. 
        //burada new lemek dogru degil
        //CourseDal courseDal = new CourseDal();
        //return courseDal.GetAll();

        return _courseDal.GetAll();
    }


}

