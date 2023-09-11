using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace cheat_sheet
{
    public class tryout
    {
        private string brand;
        private string coloer;
        private int cost;
        private int NOseats;
        private int NOwheels;
        private double topSpeed;
        private bool isCarFamily;

        public tryout(string brand, string coloer, int cost, int nOseats, int nOwheels, double topSpeed, bool isCarFamily)
        {
            this.brand = brand;
            this.coloer = coloer;
            this.cost = cost;
            NOseats = nOseats;
            NOwheels = nOwheels;
            this.topSpeed = topSpeed;
            this.isCarFamily = isCarFamily;
        }
    }
}
