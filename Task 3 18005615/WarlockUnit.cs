using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_18005615
{
    [Serializable]
    class WarlockUnit : Unit
    {
        public int PosX
        {
            get { return posX; }
            set { posX = value; }
        }

        public int PosY
        {
            get { return posY; }
            set { posY = value; }
        }

        public int health
        {
            get { return Health; }
            set { Health = value; }
        }

        public int speed
        {
            get { return Speed; }
            set { Speed = value; }
        }

        public int attack
        {
            get { return Attack; }
            set { Attack = value; }
        }

        public int attackRange
        {
            get { return AttackRange; }
            set { AttackRange = value; }
        }

        public int faction
        {
            get { return Faction; }
            set { Faction = value; }
        }

        public string symbol
        {
            get { return Symbol; }
            set { Symbol = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public WarlockUnit(int X_position, int Y_position, int Health, int Attack, int Speed, int Attack_range, int Faction1, string Symbol1, string name1)// warlock unit constructor
        {
            PosX = X_position;
            PosY = Y_position;
            health = Health;
            attack = Attack;
            speed = Speed;
            attackRange = Attack_range;
            faction = Faction1;
            symbol = Symbol1;
            name = name1;
        }

        public override bool withinRange(Unit u) 
        {
            if (u.GetType() == typeof(WarlockUnit))
            {
                WarlockUnit W = (WarlockUnit)u;
                if (DistanceTo(u) <= attackRange)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public override void NewPos(Direction direction) // this will get the new position for the unit to move to 
        {
            switch (direction)
            {
                case Direction.North:
                    {
                        PosY -= Speed;
                        break;
                    }
                case Direction.East:
                    {
                        PosX += Speed;
                        break;
                    }
                case Direction.South:
                    {
                        PosY += Speed;
                        break;
                    }
                case Direction.West:
                    {
                        PosX -= Speed;
                        break;
                    }
            }
        }

        public override void combat(Unit u) 
        {
            if (u.GetType() == typeof(MeeleeUnit))
            {
                ((MeeleeUnit)u).health -= ((MeeleeUnit)u).attack;
            }
            else if (u.GetType() == typeof(RangedUnit))
            {
                ((RangedUnit)u).health -= ((RangedUnit)u).attack;
            }
            else if (u.GetType() == typeof(WarlockUnit))
            {
                ((WarlockUnit)u).health -= ((WarlockUnit)u).attack;
            }
        }
        public override bool isDead() 
        {
            if (Health < 1)
            {
                return true;
            }
            else

                return false;
        }

        public override Unit distance(Unit[] units) 
        {
            Unit closest = this;
            int closestDist = 50;
            foreach (Unit u in units)
            {
                if (((MeeleeUnit)u).faction != faction)
                {
                    if (DistanceTo((MeeleeUnit)u) < closestDist)
                    {
                        closest = u;
                        closestDist = DistanceTo((MeeleeUnit)u);
                    }
                }
                if (u.GetType() == typeof(MeeleeUnit))
                {
                    if (DistanceTo((MeeleeUnit)u) < closestDist)
                    {
                        closest = u;
                        closestDist = DistanceTo(u);
                    }
                }
                else if (u.GetType() == typeof(RangedUnit))
                {
                    if (DistanceTo((RangedUnit)u) < closestDist)
                    {
                        closest = u;
                        closestDist = DistanceTo(u);
                    }
                }
                else if (u.GetType() == typeof(WarlockUnit))
                {
                    if (DistanceTo((WarlockUnit)u) < closestDist)
                    {
                        closest = u;
                        closestDist = DistanceTo(u);
                    }
                }
            }

            return closest;

        }

        public override string toString()
        {
            return "Name: " + name + "\r\nFaction: " + faction + "\r\nSymbol: " + Symbol + "\r\nRange: " + attackRange + "\r\nAttack Damage: " + attack + "\r\nHealth: " + health + "\r\nSpeed: " + speed + "\r\nY Postion: " + PosX + "\r\nX Postion: " + PosY;
        }

        public Direction Directionto(Unit u) 
        {
            if (u.GetType() == typeof(WarlockUnit))
            {
                WarlockUnit m = (WarlockUnit)u;
                if (m.PosX < PosX)
                {
                    return Direction.North;
                }
                else if (m.PosX > PosX)
                {
                    return Direction.South;
                }
                else if (m.PosY < PosY)
                {
                    return Direction.West;
                }
                else
                {
                    return Direction.East;
                }
            }
            else
            {
                return Direction.North;
            }

        }

        private int DistanceTo(Unit u) 
        {
            if (u.GetType() == typeof(WarlockUnit))
            {
                WarlockUnit w = (WarlockUnit)u;
                int d = Math.Abs(PosX- w.PosX) + Math.Abs(PosY - w.PosY);
                return d;
            }
            else
            {
                return 0;
            }
        }
    }
}
