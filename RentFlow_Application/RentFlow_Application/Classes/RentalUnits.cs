using System;
using System.Collections.Generic;
using System.Text;

namespace RentFlow_Application.Classes
{
    public class RentalUnits
    {
        private int unitID;
        private int propertyID;
        private string unitNumber;
        private decimal rentalAmount;
        private string availability;
        private string occupancy;

        public void SetUnitID(int unitID)
        {
            this.unitID = unitID;
        }

        public void SetPropertyID(int propertyID)
        {
            this.propertyID = propertyID;
        }

        public void SetUnitNumber(string unitNumber)
        {
            this.unitNumber = unitNumber;
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

        public void SetAvailability(string availability)
        {
            this.availability = availability;
        }

        public void SetOccupancy(string occupancy)
        {
            this.occupancy = occupancy;
        }

        public int GetUnitID()
        {
            return unitID;
        }

        public int GetPropertyID()
        {
            return propertyID;
        }

        public string GetUnitNumber()
        {
            return unitNumber;
        }

        public decimal GetRentalAmount()
        {
            return rentalAmount;
        }

        public string GetAvailability()
        {
            return availability;
        }

        public string GetOccupancy()
        {
            return occupancy;
        }


    }
}
