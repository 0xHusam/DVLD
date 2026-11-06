using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class clsDriver : clsPerson
    {
        public int DriverID { get; set; }
        public clsDriver(int DriverID, clsPerson person)
            : base(person)
        {
            this.DriverID = DriverID;
        }
    }
}
