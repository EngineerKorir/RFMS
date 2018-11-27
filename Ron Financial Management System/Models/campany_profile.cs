using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace Ron_Financial_Management_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Campany_profile
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public virtual Gender Address { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public string userid { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string shortname { get; set; }
        public byte[] logo { get; set; }

        
    }
    public enum Gender
    {
        Male,
        Female
    }
}
