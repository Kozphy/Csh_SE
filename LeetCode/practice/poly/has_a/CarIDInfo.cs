using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.poly.has_a
{
    internal class CarIDInfo
    {
        private int idNum { get; set; } = 0;
        private string owner { get; set; } = "No owner";

        public int IDNum
        {
            get { return idNum; }
            set { idNum = value; }
        }

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public CarIDInfo() { }
        public CarIDInfo(int idNum, string owner)
        {
            IDNum = idNum;
            Owner = owner;
        }
    }
}
