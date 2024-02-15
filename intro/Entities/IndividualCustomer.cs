﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro.Entities;

//BaseCustomer Individual'in referansiini tutuyor
internal class IndividualCustomer : BaseCustomer
{
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalIdentity { get; set; }
}