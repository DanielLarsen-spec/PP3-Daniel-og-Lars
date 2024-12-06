using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_03_bilsjappe_Lars_og_Daniel
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int KmLength { get; set; }
        public string RegNo { get; set; }

        public Car(string brand, string model, int year, int kmLength, string regNo)
        {
            Brand = brand;
            Model = model;
            Year = year;
            KmLength = kmLength;
            RegNo = regNo;
        }
    }
}




