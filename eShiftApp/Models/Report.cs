using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShiftApp.Models
{
    public class Report
    {
        public int ReportId { get; set; }
        public int AdminId { get; set; }
        public string ReportType { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
    }
}
