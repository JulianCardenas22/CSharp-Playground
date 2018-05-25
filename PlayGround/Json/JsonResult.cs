using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.Json
{
    class JsonResult
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String   LastName { get; set; }
        public IEnumerable<Stuff> ToDo { get; set; }

    }

}
