﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class Player
    {
        public string Name { get; set; }
        public string CharaceterClass { get; set; }
        public int HitPoints { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public int Gold { get; set; }
    }
}
