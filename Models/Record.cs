using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFS.NET_Test.Models
{
    public class Record
    {
        public int Id { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
