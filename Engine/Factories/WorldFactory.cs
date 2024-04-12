using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        public World CreateWorld()
        {
            World newWorld = new World();
            newWorld.AddLocation(0, -1, "Home",
                "This is your home",
                "pack://application:,,,/Engine;component/Images/Locations/Home.png");
            newWorld.AddLocation(0, 0, "Town Plaza",
                "It is a place where the left and right wing of the world connects",
                "pack://application:,,,/Engine;component/Images/Locations/TownP.png");
            newWorld.AddLocation(0, 1, "Town Hall",
                "Meet the mayor!",
                "pack://application:,,,/Engine;component/Images/Locations/TownH.png");
            newWorld.AddLocation(-1, 0, "Maple Grove Park",
                "A park that you can pass your time by.",
                "pack://application:,,,/Engine;component/Images/Locations/Maple.png");
            newWorld.AddLocation(-1, -1, "Mystic Market",
                "Buy all you want.",
                "pack://application:,,,/Engine;component/Images/Locations/Mystic.png");
            newWorld.AddLocation(-1, 1, "Fadewood",
                "Meet an NPC. Maybe you can game something",
                "pack://application:,,,/Engine;component/Images/Locations/Fadewood.png");
            newWorld.AddLocation(-2, 0, "Everclear Mountain",
                "A place where some things might end. You or the boss.",
                "pack://application:,,,/Engine;component/Images/Locations/Mountain.png");
            newWorld.AddLocation(-2, -1, "Dark Lair",
                "A dark place with a bright mission.",
                "pack://application:,,,/Engine;component/Images/Locations/DarkLair.png");
            newWorld.AddLocation(1, 0, "Station",
                "Connects three location that you can go to.",
                "pack://application:,,,/Engine;component/Images/Locations/Station.png");
            newWorld.AddLocation(1, -1, "Murkwood",
                "Mushroom Houses!",
                "pack://application:,,,/Engine;component/Images/Locations/Murkwood.png");
            newWorld.AddLocation(1, 1, "Abbysal Sanctum",
                "Meet and greet in the unknown.",
                "pack://application:,,,/Engine;component/Images/Locations/Sanctum.png");
            newWorld.AddLocation(-1, 2, "Twilight Citadel",
                "Yellow flowers everywhere.",
                "pack://application:,,,/Engine;component/Images/Locations/Citadel.png");
            newWorld.AddLocation(2, 0, "Crimson Ridge",
                "A village with elves.",
                "pack://application:,,,/Engine;component/Images/Locations/Ridge.png");
            newWorld.AddLocation(2, 1, "Crimson Crest",
                "Nymphs everywhere!",
                "pack://application:,,,/Engine;component/Images/Locations/Crest.png");
            return newWorld;
        }
    }
}
