﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Domain.Aggregates.ProfileInfo
{
    public class Student
    {
        public Guid StudentId { get; set; }
        public BasicInfo BasicInfo { get; set; }
        public string IdentityId { get; private set; }


        public List<Discipline> Diciplinas { get; set; }

    }
}