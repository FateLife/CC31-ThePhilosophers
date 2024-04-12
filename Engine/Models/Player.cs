using Engine.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public class Player :INotifyPropertyChanged
    {
        private int _experiencePoints;
        private int _hitPoints;
        private int _level;
        private int _gold;
        public string Name { get; set; }
        public string CharacterClass { get; set; }
        public int Hitpoints
        {
            get
            {
                return _hitPoints;
            }
            set
            {
                _hitPoints = value;
                OnPropertyChanged("HitPoints");
            }
        }
        public int Experiencepts
        {
            get
            {
                return _experiencePoints;
            }
            set
            {
                _experiencePoints = value;
                OnPropertyChanged("Experiencepts");
            }
        }
        public int level
        {
            get
            {
                return _level;
            }
            set
            {
                _level = value;
                OnPropertyChanged("Level");
            }
        }
        public int Gold
        {
            get
            {
                return _gold;
            }
            set
            {
                _gold = value;
                OnPropertyChanged("Gold");
            }
        }

        public ObservableCollection<GameItem> Inventory { get; set; }

        public Player()
        {
            Inventory = new ObservableCollection<GameItem>();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
