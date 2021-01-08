using FBIOperation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FBIOperation
{
    public class Match
    {
        private string homeTeamName;
        private string guestTeamName;
        Stats homeTeamStats;
        Stats guestTeamStats;

        public string HomeTeamName
        {
            get { return homeTeamName; }
            set { homeTeamName = value; }
        }

        public string GuestTeamName
        {
            get { return guestTeamName; }
            set { guestTeamName = value; }
        }

        public Stats HomeTeamStats => homeTeamStats;
        public Stats GuestTeamStats => guestTeamStats;

        public string ScoreText => "Давай по новой";

        public Match(string homeTeamName, string guestTeamName, 
            int homeTeamScore, int guestTeamScore)
        {
            this.homeTeamName = homeTeamName;
            this.guestTeamName = guestTeamName;
        }

    }
}
