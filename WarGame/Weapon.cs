using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    public abstract class Weapon
    {
        public int Level { get; set; }
        public abstract int Damage(int weaponLevel);
    }

    public class Knife : Weapon
    {
        public override int Damage(int weaponLevel)
        {
            switch (weaponLevel)
            {
                case 2:
                    return 10;
                 case 3:
                    return 15;
                default:
                    return 5;
            }
        }
    }

    public class Glock : Weapon
    {
        public override int Damage(int weaponLevel)
        {
            switch (weaponLevel)
            {
                case 2:
                    return 13;
                case 3:
                    return 18;
                default:
                    return 8;
            }
        }
    }

    public class Riffle : Weapon
    {
        public override int Damage(int weaponLevel)
        {
            switch (weaponLevel)
            {
                case 2:
                    return 19;
                case 3:
                    return 24;
                default:
                    return 13;
            }
        }
    }

    public class Shotgun : Weapon
    {
        public override int Damage(int weaponLevel)
        {
            switch (weaponLevel)
            {
                case 2:
                    return 26;
                case 3:
                    return 32;
                default:
                    return 18;
            }
        }
    }

    public class Sniper : Weapon
    {
        public override int Damage(int weaponLevel)
        {
            switch (weaponLevel)
            {
                case 2:
                    return 65;
                case 3:
                    return 100;
                default:
                    return 38;
            }
        }
    }
}
