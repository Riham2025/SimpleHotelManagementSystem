using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHotelManagementSystem
{
    class Guest   // Represents a hotel guest
    {



        // Auto-implemented property for Guest Name with validation
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 3)
                    name = value;
                else
                    throw new ArgumentException("Name must be at least 3 characters.");
            }
        }

        // Auto-implemented property for National ID with validation
    private string nationalID;
    public string NationalID
    {
        get { return nationalID; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nationalID = value;
            else
                throw new ArgumentException("National ID cannot be empty.");
        }
    }

        // Private field for storing password (write-only)
        private string password;

        // Write-only property for Password (cannot read from outside)
        public string Password
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                    password = value;
                else
                    throw new ArgumentException("Password cannot be empty.");
            }
        }

        // Default constructor
        public Guest()
        {
            name = "Unknown";
            nationalID = "000000";
        }


    }



}
