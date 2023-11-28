using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniProject
{
    public class Iphone : Devices, I3G, IWifi, IGPRS
    {
        public Iphone(string name, DateTime dTProducted, string color, int serieID, string producer, float price) : base(name, dTProducted, color, serieID, producer, price)
        {
        }
        public Iphone() { }
        public void Using3G()
        {

        }
        public void UsingWifi() { }
        public void UsingGPRS() { }
        public override void UsingGSM()
        {
            //base.UsingGSM();
        }
        public override string Display()
        {
            return "Name: " + Name1 + "\nPrice: " + Price1 + "\nProducer: " + Producer1 + "\nColor: " +
                    Color1 + "\nDate producted: " + DTProducted1 + "\nSell ID: " + SerieID1 + "\n";
        }
        public override void Input()
        {
            throw new NotImplementedException();
        }
    }
}