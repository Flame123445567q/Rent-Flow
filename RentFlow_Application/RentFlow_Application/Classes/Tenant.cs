using System;
using System.Collections.Generic;
using System.Text;

namespace RentFlow_Application.Classes
{
    public class Tenant
    {
        private int tenantID;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string emailAddress;
        private string idNumber;
        private string assignedProperty;
        private string assignedUnit;

        
        public void SetTenantID(int id) { tenantID = id; }
        public void SetFirstName(string v) { firstName = v; }
        public void SetLastName(string v) { lastName = v; }
        public void SetPhoneNumber(string v) { phoneNumber = v; }
        public void SetEmailAddress(string v) { emailAddress = v; }
        public void SetIDNumber(string v) { idNumber = v; }
        public void SetAssignedProperty(string v) { assignedProperty = v; }
        public void SetAssignedUnit(string v) { assignedUnit = v; }

        public int GetTenantID() => tenantID;
        public string GetFirstName() => firstName;
        public string GetLastName() => lastName;
        public string GetPhoneNumber() => phoneNumber;
        public string GetEmailAddress() => emailAddress;
        public string GetIDNumber() => idNumber;
        public string GetAssignedProperty() => assignedProperty;
        public string GetAssignedUnit() => assignedUnit;

    }
}
