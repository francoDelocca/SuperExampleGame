using NUnit.Framework;
using System;
using SuperExampleGame.Domain.Domain;

namespace SuperExampleGameTest
{
    public class WarriorShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BuyItem()
        {
            Item item = new Item(100, true, true, true);
            Warrior warrior = new Warrior(150);

            warrior.Buy(item);

            Assert.AreEqual(50, warrior.GetMoney());
        }

        [Test]
        public void EquipItem()
        {
            Item item = new Item(100, true, true, true);
            Warrior warrior = new Warrior(150);

            warrior.Equip(item);

            Assert.AreEqual(2, warrior.GetResistanceGrade());
        }

    }


}