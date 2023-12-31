﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12
{
    internal class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public Device()
        {
            this.Id = 0;
            this.Name = "";
            this.Quantity = 0;
        }
        public Device(int Id, string Name, int Quantity)
        {
            this.Id = Id;
            this.Name = Name;
            this.Quantity = Quantity;
        }
        public override string ToString()
        {
            return Id + "," + Name + "," + Quantity;
        }
    }
}
