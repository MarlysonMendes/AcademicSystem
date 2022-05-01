using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Domain.Aggregates.ProfileInfo
{
    public class Coordinator 
    {
        private Coordinator () { }

        public Guid CoordinatorId { get; private set; }
        public BasicInfo BasicInfo { get; private set; }
        public string IdentityId { get; private set; }


        public Course Course { get; private set; }


    }
}
