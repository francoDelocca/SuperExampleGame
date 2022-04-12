using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperExampleGame.Domain.Domain
{
    public class Warrior
    {
        private int _money;
        private Stat _strenght;
        private Stat _resistance;
        private Stat _speed;

        public Warrior(int money)
        {
            _money = money;
            _strenght = new Stat();
            _resistance = new Stat();
            _speed = new Stat();
        }

        public int GetMoney()
        {
            return _money;
        }

        public int GetStrenghtGrade()
        {
            return _strenght.GetGrade();
        }

        public int GetResistanceGrade()
        {
            return _resistance.GetGrade();
        }

        public int GetSpeedGrade()
        {
            return _speed.GetGrade();
        }

        public void Buy(Item item)
        {
            if (CanBuyItem(item))
            {
                _money -= item.GetCost();
            }
        }

        public void Equip(Item item)
        {
            ChangeStats(item);
        }

        private void ChangeStats(Item item)
        {
            if (item.GivesSpeed())
            {
                _strenght.UpgradeGrade();
            }

            if (item.GivesResistance())
            {
                _resistance.UpgradeGrade();
            }

            if (item.GivesSpeed())
            {
                _speed.UpgradeGrade();
            }
        }

        private bool CanBuyItem(Item item)
        {
            return _money >= 0 && item.GetCost() <= _money;
        }
    }
}
