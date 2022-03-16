using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Weapon Types(each weapon has different damage points)
            //- Knife
            //- Glock
            //- Riffle
            //- Shotgun
            //- Sniper

            //Weapon Levels(each level has different damages)
            //- Default("")
            //- 2
            //- 3

            Game game = new Game();

            game.soldier1 = CreateSoldier("Turkey", new Sniper(), 3);
            game.soldier2 = CreateSoldier("Greek", new Riffle(), 2);

            SoldierBattleInfo(game.soldier1, game.soldier2);

            game.StartSoldierFight();

            game.SoldierFightResult();

            game.army1 = CreateArmy("The Power Of Fire", 20, new Shotgun(), 3);
            game.army2 = CreateArmy("Expandables", 20, new Riffle(), 2);

            game.PrepareArmy();

            game.StartArmyBattle();

            ArmyBattleInfo(game.army1, game.army2);

            game.ResultArmyBattle();

            Console.ReadKey();
        }

        private static void ArmyBattleInfo(Army army1, Army army2)
        {
            Console.WriteLine("\n\n\n Battle of armys\n");
            Console.WriteLine($" Army 1 : {army1.ArmyName}\n Army Count : {army1.Soldiers.Count} \n Army Power :{army1.ArmyPower}");
            Console.WriteLine($" Army 2 : {army2.ArmyName}\n Army Count : {army2.Soldiers.Count} \n Army Power :{army2.ArmyPower} \n");
        }

        private static void SoldierBattleInfo(Soldier soldier1, Soldier soldier2)
        {
            Console.WriteLine("\n\n\n Battle of 2 soldier \n");
            Console.WriteLine($" Soldier 1 : {soldier1.Country} \n Weapon : {soldier1.SoldierWeapon} \n Weapon Level : {soldier1.SoldierWeapon.Level}");
            Console.WriteLine($" Soldier 2 : {soldier2.Country} \n Weapon : {soldier2.SoldierWeapon} \n Weapon Level : {soldier2.SoldierWeapon.Level}\n");
        }

        private static Army CreateArmy(string armyName, int soldierNumber, Weapon weapon, int weaponLevel)
        {
            Army army = new Army();
            army.ArmyName = armyName;
            army.Soldiers = new List<Soldier>();
            for (int i = 0; i < soldierNumber; i++)
            {
                Soldier soldier = new Soldier();
                soldier.SoldierWeapon = weapon;
                soldier.SoldierWeapon.Level = weaponLevel;
                army.Soldiers.Add(soldier);
            }
            return army;
        }

        private static Soldier CreateSoldier(string v, Weapon weapon, int weaponLevel)
        {
            Soldier soldier = new Soldier();
            soldier.Country = v;
            soldier.SoldierWeapon = weapon;
            soldier.SoldierWeapon.Level = weaponLevel;
            return soldier;
        }
    }
}
