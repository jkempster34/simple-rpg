using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(-2, -1, "Farmer's Field",
                "There are rows of corn growing here, with giant rats hiding between them",
                "C:/Users/jkempster/OneDrive - Department for Education/Desktop/SOSCSRPG/Engine/Images/Locations/FarmFields.png");

            newWorld.AddLocation(-1, -1, "Farmer's House",
               "This is the house of your neighbor, Farmer Ted.",
               "C:/Users/jkempster/OneDrive - Department for Education/Desktop/SOSCSRPG/Engine/Images/Locations/FarmHouse.png");

            newWorld.AddLocation(0, -1, "Home",
             "this is your home",
             "C:/Users/jkempster/OneDrive - Department for Education/Desktop/SOSCSRPG/Engine/Images/Locations/Home.png");

            return newWorld;
        }
    }
}
