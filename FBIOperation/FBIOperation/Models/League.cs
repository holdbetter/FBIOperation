using System;
using System.Collections.Generic;
using System.Text;

namespace FBIOperation.Models
{
    public class League
    {
        public string FullName { get; private set; } 
        public string ShortName { get; private set; }

        public League(string fullLeagueName, string shortLeagueName)
        {
            this.FullName = fullLeagueName;
            this.ShortName = shortLeagueName;
        }
    }
}
