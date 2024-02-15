using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro.Entities;

public class Course
{
    //Properties
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    //prop yaz tab'a bas
    public double Price { get; set; }
}

