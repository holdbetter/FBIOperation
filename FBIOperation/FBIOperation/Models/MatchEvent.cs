using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FBIOperation.Models
{
    public class MatchEvent
    {
        public Team HomeTeam { get; set; }
        public Team GuestTeam { get; set; }
        public int HomeTeamScore { get; set; }
        public int GuestTeamScore { get; set; }
        public List<Stats> Stats { get; set; }
        public League League { get; set; }
        public SportEnum SportType { get; set; } = SportEnum.Empty;

        public Color SportTypeColor
        {
            get
            {
                switch (SportType)
                {
                    case SportEnum.Football:
                        return Color.FromHex("#9CD4AC");
                    case SportEnum.Hockey:
                        return Color.FromHex("#4AA2BD");
                    case SportEnum.Basketball:
                        return Color.FromHex("#F59965");
                    default:
                        return Color.FromHex("#000000");
                }
            }
        }
        public string Score => string.Format("{0} : {1}", HomeTeamScore, GuestTeamScore);
    }
}
