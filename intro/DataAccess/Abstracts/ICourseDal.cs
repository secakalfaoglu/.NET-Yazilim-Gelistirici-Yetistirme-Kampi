using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using intro.Entities;

namespace intro.DataAccess.Abstracts;
//bunu iimplemente eden sinif bu ikisini icermek zorunda
//metodların imzaları var sadece dikkat et
public interface ICourseDal
{
    List<Course> GetAll();

    void Add(Course course);

}