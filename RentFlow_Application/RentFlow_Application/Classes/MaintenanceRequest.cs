using System;
using System.Collections.Generic;
using System.Text;

namespace RentFlow_Application.Classes
{
    public class MaintenanceRequest
    {
        public string Category { get; set; }
        public string Property { get; set; }
        public string Issue { get; set; }
        public string Status { get; set; }
        public string TenantName { get; set; }
        public DateTime DateReported { get; set; }
    }
}
