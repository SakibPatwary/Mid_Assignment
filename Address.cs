using System;
using System.Collections.Generic;
using System.Text;

namespace MidAssignment1
{
    public class Address
    {
        private string roadNo;
        private string houseNo;
        private string city;
        private string country;

        public Address(string roadNo, string houseNo, string city, string country)
        {
            this.roadNo = roadNo;
            this.houseNo = houseNo;
            this.city = city;
            this.country = country;
        }
        public string RoadNo
        {
            set { this.roadNo = value; }
            get { return this.roadNo; }
        }
        public string HouseNo
        {
            set { this.houseNo = value; }
            get { return this.houseNo; }
        }
        public string City
        {
            set { this.city = value; }
            get { return this.city; }
        }
        public string Country
        {
            set { this.country = value; }
            get { return this.country; }
        }

        public string getAddress()
        {
            return ("\nRoad No: " + roadNo + "\nHouse No: " + houseNo + "\nCity: " + city + "\nCountry: " + country);
        }

    }
}
