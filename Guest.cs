using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    [Serializable ]
    public class Guest
    {
        public int GuestID { get; set; }
        public string GuestName { get; set; }
        public string GuestContactNumber { get; set; }
    }
}
