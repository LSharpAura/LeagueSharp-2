﻿using LeagueSharp.SDK.Core;

namespace Thresh___Soul_Hunter
{
    using LeagueSharp;
    class Program
    {
        static void Main(string[] args)
        {
            LeagueSharp.SDK.Core.Events.Load.OnLoad += (sender, eventArgs) =>
            {
                if (ObjectManager.Player.ChampionName.Equals("Thresh"))
                {
                    Bootstrap.Init(args);
                    Thresh.OnLoad();
                }
            };
        }
    }
}
