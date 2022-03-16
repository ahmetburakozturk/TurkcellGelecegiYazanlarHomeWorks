using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    public class Army
    {
        public List<Soldier> Soldiers { get; set; }
        public string ArmyName { get; set; }
        public int ArmyPower { get; set; }
        public int ArmyHealth { get; set; }
        public bool IsDestroyed { get; set; } = false;
        public int DamageTaken { get; set; } = 0;

        public void CalculateArmyPower()
        {
            foreach (var soldier in Soldiers)
            {
                ArmyPower += soldier.HitPoint;
            }
        }

        public void CalculateArmyHealth()
        {
            foreach (var soldier in Soldiers)
            {
                ArmyHealth += soldier.Health * 10;
            }
        }

        public void Attack(Army enemyArmy)
        {
            foreach (var soldier in Soldiers)
            {
                if (IsDestroyed != true && enemyArmy.IsDestroyed != true)
                {
                    enemyArmy.ArmyHealth -= soldier.HitPoint;
                    enemyArmy.DamageTaken += soldier.HitPoint;
                    if (enemyArmy.ArmyHealth <= 0)
                    {
                        enemyArmy.IsDestroyed = true;
                    }
                }
            }
        }
    }
}
