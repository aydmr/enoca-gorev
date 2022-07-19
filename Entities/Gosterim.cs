using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnocaDemo.Entities
{
    public class Gosterim
    {
        public int gosterimID { get; set; }
        public int filmID { get; set; }
        public int salonID { get; set; }
        public int gosterimYil { get; set; }
    }
}