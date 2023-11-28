using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniProject
{
    public abstract class Devices : IGSM
    {
        private string Name;
        private System.DateTime DTProducted;
        private string Color;
        private int SerieID;
        private string Producer;
        private float Price;
        /// <summary></summary>
        public Devices() { }
        protected Devices(string name, DateTime dTProducted, string color, int serieID, string producer, float price)
        {
            Name = name;
            DTProducted = dTProducted;
            Color = color;
            SerieID = serieID;
            Producer = producer;
            Price = price;
        }

        public string Name1 { get => Name; set => Name = value; }
        public DateTime DTProducted1 { get => DTProducted; set => DTProducted = value; }
        public string Color1 { get => Color; set => Color = value; }
        public int SerieID1 { get => SerieID; set => SerieID = value; }
        public string Producer1 { get => Producer; set => Producer = value; }
        public float Price1 { get => Price; set => Price = value; }
        public void Active()
        {

        }
        virtual public void UsingGSM()
        { }
        public abstract void Input();
        public abstract string Display();
    }
}