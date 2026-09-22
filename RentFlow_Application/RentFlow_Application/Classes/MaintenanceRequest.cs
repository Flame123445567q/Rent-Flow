using System;
using System.Collections.Generic;
using System.Text;

namespace RentFlow_Application.Classes
{
    
        public class MaintenanceRequest
        {
            public string RequestId { get; set; }
            public string TenantName { get; set; }
            public string PropertyUnit { get; set; }
            public string IssueCategory { get; set; }
            public string IssueDescription { get; set; }
            public string IssuePriority { get; set; }
            public string Status { get; set; }
            public string Date { get; set; }

            public MaintenanceRequest(string requestId, string tenantName, string propertyUnit,string category, string description, string priority,string status, string date)
            {
                RequestId = requestId;
                TenantName = tenantName;
                PropertyUnit = propertyUnit;
                IssueCategory = category;
                IssueDescription = description;
                IssuePriority = priority;
                Status = status;
                Date = date;
            }
        }
    
}
