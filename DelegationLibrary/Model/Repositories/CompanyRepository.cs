﻿using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    public class CompanyRepository
    {
        public List<ICompany> Companies { get; set; }
    }
}
