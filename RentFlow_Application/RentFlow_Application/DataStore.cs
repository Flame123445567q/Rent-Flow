using RentFlow_Application.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using RentFlow_Application.Classes;

namespace RentFlow_Application
{
    public static class DataStore
    {
        public static string LoggedInEmail = "";
        public static string LoggedInRole = "";
        public static string LoggedInName = "";

        public static List<User> Users = new List<User>();
        public static List<Property> Properties = new List<Property>();
        public static List<RentalUnits> RentalUnitslist = new List<RentalUnits>();
        public static List<Lease> theLeases = new List<Lease>();
        public static List<MaintenanceRequest> theMaintenance = new List<MaintenanceRequest>();

        public static void LoadAll()
        {
            LoadUsers();
            LoadProperties();
            LoadLeases();

            // We will add LoadProperties(), LoadUnits(), LoadLeases() same way

            if (Properties.Count == 0)
            {
                // We can't create real Property objects without your class,
                // so we'll just test the ComboBox directly in the form
            }
        }

        private static void LoadUsers()
        {
            Users.Clear();
            if (!File.Exists("Users.txt")) return;
            foreach (var line in File.ReadAllLines("Users.txt"))
            {
                var p = line.Split('|'); // adjust if your split is different
                if (p.Length >= 7)
                    Users.Add(new User(p[0], p[1], p[2], p[3], p[4], p[5], p[6]));
            }
        }


        public static void LoadLeases()
        {
            theLeases.Clear();
            if (!File.Exists("Leases.txt")) return;

            foreach (var line in File.ReadAllLines("Leases.txt"))
            {
                var parts = line.Split('|');
                if (parts.Length != 7) continue;

                theLeases.Add(new Lease
                {
                    Tenant = parts[0],
                    Property = parts[1],
                    RentalUnit = parts[2],
                    StartDate = DateTime.Parse(parts[3]),
                    EndDate = DateTime.Parse(parts[4]),
                    MonthlyRent = decimal.Parse(parts[5]),
                    Status = parts[6]
                });
            }
        }

        public static void SaveLeases()
        {
            using (StreamWriter sw = new StreamWriter("Leases.txt"))
            {
                foreach (var lease in theLeases)
                {
                    sw.WriteLine($"{lease.Tenant}|{lease.Property}|{lease.RentalUnit}|{lease.StartDate}|{lease.EndDate}|{lease.MonthlyRent}|{lease.Status}");
                }
            }
        }

        private static void LoadProperties()
        {
            Properties.Clear();
            if (!File.Exists("Properties.txt")) return;

            foreach (var line in File.ReadAllLines("Properties.txt"))
            {
                // split by space OR | to handle your old file and new files
                var parts = line.Split(new char[] { '|', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length != 6) continue;

                Property p = new Property();
                p.SetPropertyID(int.Parse(parts[0]));
                p.SetPropertyName(parts[1]);
                p.SetAddress(parts[2]);
                p.SetPropertyType(parts[3]);
                p.SetRentalAmount(decimal.Parse(parts[4]));
                p.SetStatus(parts[5]);

                Properties.Add(p);
            }
        }

        public static void SaveProperties()
        {
            var lines = new List<string>();
            foreach (var p in Properties)
            {
                // If your Get names are different, fix them here
                lines.Add($"{p.GetPropertyID()}|{p.GetPropertyName()}|{p.GetAddress()}|{p.GetPropertyType()}|{p.GetRentalAmount()}|{p.GetStatus()}");
            }
            File.WriteAllLines("Properties.txt", lines);
        }






    }
}
