using System;
using System.Collections.Generic;
using System.Text;

namespace FBIOperation.Models
{
    public class Stats
    {
        string statsName;
        int homeValue;
        int guestValue;

        public int HomeValue => homeValue;
        public int GuestValue => guestValue;
        public string StatsName => statsName;

        public float HomeProgress => HomeValue / 100f;

        public Stats(string statsName, int homeValue, int guestValue)
        {
            this.statsName = statsName;
            this.homeValue = homeValue;
            this.guestValue = guestValue;
        }
    }
}
