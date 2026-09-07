using System;
using System.Collections.Generic;
using System.Text;

namespace RentFlow_Application.Classes
{
    public class Property
    {
        private int propertyID;
        private string propertyName;
        private string address;
        private string propertyType;
        private decimal rentalAmount;
        private string status;

        public void SetPropertyID(int propertyID)
        {
            this.propertyID = propertyID;
        }

        public void SetPropertyName(string propertyName)
        {
            this.propertyName = propertyName;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public void SetPropertyType(string propertyType)
        {
            this.propertyType = propertyType;
        }

        public bool SetRentalAmount(decimal rentalAmount)
        {
            if (rentalAmount >= 0)
            {
                this.rentalAmount = rentalAmount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SetStatus(string status)
        {
            this.status = status;
        }

        public int GetPropertyID()
        {
            return propertyID;
        }

        public string GetPropertyName()
        {
            return propertyName;
        }

        public string GetAddress()
        {
            return address;
        }

        public string GetPropertyType()
        {
            return propertyType;
        }

        public decimal GetRentalAmount()
        {
            return rentalAmount;
        }

        public string GetStatus()
        {
            return status;
        }
    }
}
