using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Domain.Models.ProfileInfo
{
    public class UserProfile
    {
        public Guid UserProfileId { get; private set; }
        public string IdentityId { get; private set; }
    }
}
