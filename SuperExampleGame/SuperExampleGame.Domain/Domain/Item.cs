using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperExampleGame.Domain.Domain
{
    public class Item
    {
        private int _cost;
        private bool _resistance;
        private bool _speed;
        private bool _strength;

        public Item(int cost, bool resistance, bool speed, bool strength)
        {
            _cost = cost;
            _resistance = resistance;
            _speed = speed;
            _strength = strength;
        }

        public int GetCost()
        {
            return _cost;
        }

        public bool GivesResistance()
        {
            return _resistance;
        }

        public bool GivesSpeed()
        {
            return _speed;
        }

        public bool GivesStrenght()
        {
            return _strength;
        }
    }
}
