﻿using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    public class ProjectRepository
    {
        public List<IProject> Projects { get; set; }
    }
}
