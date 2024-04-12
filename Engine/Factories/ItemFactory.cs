using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static List<GameItem> _standardGameItems;
        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();
            _standardGameItems.Add(new Weapon(100, "Basic Sword", 0, 3, 5));
            _standardGameItems.Add(new Weapon(101, "Astral Slicer", 0, 20, 25));
            _standardGameItems.Add(new Weapon(102, "Celestial Blade", 30, 35, 40));
            _standardGameItems.Add(new Weapon(103, "Swiftshot", 15, 0, 0));
        }
        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);
            if (standardItem != null)
            {
                return standardItem.Clone();
            }
            return null;
        }
    }
}