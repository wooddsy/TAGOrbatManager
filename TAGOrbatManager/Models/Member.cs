using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAGOrbatManager.Models
{
    public class Member
    {
        public Guid Guid { get; set; }
        public string Name {  get; set; }
        public string DiscordUsername { get; set; }
        public string Role { get; set; }
        public DateTime JoinDate { get; set; }

        public void setJoinDate()
        {
            JoinDate = DateTime.Now;
        }
    }

}
