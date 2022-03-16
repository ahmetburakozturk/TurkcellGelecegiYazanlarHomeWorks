using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    public class Soldier
    {
        public string Country { get; set; }
        public Weapon SoldierWeapon { get;  set; }
        public bool IsAlive { get; set; } = true;
        public int HitPoint { get; private set; }
        public int Health { get; private set; } = 100;

        public int DamageGiven { get; set; } = 0;
        public void Equip()
        {
            HitPoint = 0;
            HitPoint = SoldierWeapon.Damage(SoldierWeapon.Level);
        }

        public void Attack(Soldier enemySoldier)
        {
            if (enemySoldier.IsAlive != false)
            {
                enemySoldier.Health -= HitPoint;
                DamageGiven += HitPoint;
                if (enemySoldier.Health <= 0)
                {
                    enemySoldier.IsAlive = false;
                }
            }
        }
    }
}
