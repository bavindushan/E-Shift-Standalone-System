using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShiftApp.Models
{
    public class Load
    {
        public int LoadId { get; set; }
        public int JobId { get; set; }
        public int ProductId { get; set; }
        public float Weight { get; set; }
        public float Volume { get; set; }
    }
}
