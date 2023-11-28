using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniProject
{
    public class Phone_StoreInformation : Devices
    {
        private string address;
        private int contactNumber;

        public string Address { get => address; set => address = value; }
        public int ContactNumber { get => contactNumber; set => contactNumber = value; }

        public Phone_StoreInformation() { }
        public Phone_StoreInformation(string name, DateTime dTProducted, string color, int serieID, string producer, float price, string address, int contactNumber) : base(name, dTProducted, color, serieID, producer, price)
        {
            this.address = address;
            this.contactNumber = contactNumber;
        }
        public override void Input()
        {
            throw new NotImplementedException();
        }
        public override string Display()
        {
            throw new NotImplementedException();
        }
    }
}