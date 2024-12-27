using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalAppPROGPOE
{
    public class ServiceRequest
    {
        public ServiceRequest(string serviceRequestID, string dateIssued, string serviceTitle, string location, string responsibleDepartment, string status)
        {
            ServiceRequestID = serviceRequestID;
            DateIssued = dateIssued;
            ServiceTitle = serviceTitle;
            Location = location;
            ResponsibleDepartment = responsibleDepartment;
            Status = status;
        }

        public string ServiceRequestID { get; set; }
        public string DateIssued { get; set; }
        public string ServiceTitle { get; set; }
        public string Location { get; set; }
        public string ResponsibleDepartment { get; set; }
        public string Status { get; set; }
        public List<ServiceRequest> Dependencies = new List<ServiceRequest>();

        // Override Equals and GetHashCode
        public override bool Equals(object obj)
        {
            if (obj is ServiceRequest other)
            {
                return this.ServiceRequestID == other.ServiceRequestID;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return ServiceRequestID.GetHashCode();
        }
    }
}
