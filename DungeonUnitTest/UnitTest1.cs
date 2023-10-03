using Xunit.Sdk;
using DungeonLibrary;
namespace DungeonUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestCalcHit()
        {
            Weapon wep = new("Axe", 5, 9, 10, false, WeaponType.Axe, 45);
            Player p1 = new("Scott", 50, 50, 100, wep, CharacterClass.Amazon, 0, 10, 20);
            decimal expected = 60;
            decimal actual = p1.CalcHitChance();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCalcCrit()
        {
            Weapon wep = new("Axe", 1, 2, 10, false, WeaponType.Axe, 100);
            Player p1 = new("Scott", 50, 50, 100, wep, CharacterClass.Amazon, 0, 17, 18);
            bool expected = true;
            bool actual = p1.ShouldCrit();
            Assert.Equal(expected, actual);
        }
    }
}