using System;
using System.Collections.Generic;
using System.Text;

namespace FBIOperation.Models
{
    public class Team
    {
        public string Name { get; set; }
        public string Icon { get; private set; }

        public Team(string name, string iconPath)
        {
            this.Name = name;
            this.Icon = iconPath;
        }
    }
}
