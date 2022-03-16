using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    public class Game
    {
        public Soldier soldier1 { get; set; }
        public Soldier soldier2 { get; set; }
        public Army army1 { get; set; }
        public Army army2 { get; set; }

        public void StartSoldierFight()
        {
            soldier1.Equip();
            soldier2.Equip();
            soldier1.Attack(soldier2);
            soldier2.Attack(soldier1);
        }

        public void PrepareArmy()
        {
            foreach (var soldier in army1.Soldiers)
            {
                soldier.Equip();
            }
            foreach (var soldier in army2.Soldiers)
            {
                soldier.Equip();
            }
            army1.CalculateArmyPower();
            army1.CalculateArmyHealth();
            army2.CalculateArmyPower();
            army2.CalculateArmyHealth();
        }

        public void StartArmyBattle()
        {
            army1.Attack(army2);
            army2.Attack(army1);
        }

        public void ShowDamagesArmy()
        {
            Console.WriteLine($" Damage given by {army1.ArmyName} army : {army2.DamageTaken}");
            Console.WriteLine($" Damage given by {army2.ArmyName} army : {army1.DamageTaken}");
        }

        private void ArmyWarEnd(Army army1, Army army2)
        {
            while (army1.IsDestroyed != true && army2.IsDestroyed != true)
            {
                StartArmyBattle();
            }
        }

        public void ResultArmyBattle()
        {
            ArmyWarEnd(army1, army2);
            if (army1.IsDestroyed == false && army2.IsDestroyed == true)
            {
                Console.WriteLine($"{army1.ArmyName} army win the fight, remaining healht : {army1.ArmyHealth}");
                ShowDamagesArmy();
            }
            else if (army2.IsDestroyed == false && army1.IsDestroyed == true)
            {
                Console.WriteLine($"{army2.ArmyName} army win the fight, remaining healht : {army2.ArmyHealth}");
                ShowDamagesArmy();
            }
            else
            {
                Console.WriteLine("This was a really bloody battle, all soldiers dead! <<< RIP >>>");
                ShowDamagesArmy();
            }
        }

        private void SoldierWarEnd(Soldier soldier1, Soldier soldier2) 
        {
            while (soldier2.IsAlive != false && soldier1.IsAlive != false)
            {
                StartSoldierFight();
            }
        }

        public void ShowSoldierDamages()
        {
            Console.WriteLine($" Damage given by {soldier1.Country} soldier : {soldier1.DamageGiven}");
            Console.WriteLine($" Damage given by {soldier2.Country} soldier : {soldier2.DamageGiven}");
        }

        public void SoldierFightResult()
        {
            SoldierWarEnd(soldier1,soldier2);
            if (soldier1.IsAlive == true && soldier2.IsAlive == false)
            {
                Console.WriteLine($"{soldier1.Country} soldier win the fight, remaining healht : {soldier1.Health}");
                ShowSoldierDamages();
            }
            else if (soldier2.IsAlive == true && soldier1.IsAlive == false)
            {
                Console.WriteLine($"{soldier2.Country} soldier win the fight, remaining healht : {soldier2.Health}");
                ShowSoldierDamages();
            }
            else
            {
                Console.WriteLine("This was a really bloody battle, all soldiers dead! <<< RIP >>>");
                ShowSoldierDamages();
            }
        }


    }
}
