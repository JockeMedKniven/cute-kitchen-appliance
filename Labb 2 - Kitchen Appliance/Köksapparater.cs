using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb2;

namespace Labb_2___Kitchen_Appliance
{
    public class Köksapparater : IKitchenAppliance
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public bool IsFunctioning { get; set; }
        public Köksapparater(string type, string brand, bool isFunctioning)
        {
            Type = type;
            Brand = brand;
            IsFunctioning = isFunctioning;
        }
    }
}