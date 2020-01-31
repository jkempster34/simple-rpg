using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class Weapon : GameItem
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public Weapon(int itemTypeID, string name, int price, int minDamage, int maxDamaage) : base(itemTypeID, name, price)
        {
            MinimumDamage = minDamage;
            MaximumDamage = maxDamaage;
        }
    }
}
