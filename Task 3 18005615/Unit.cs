﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_18005615
{
    public enum Direction { North, East, South, West }
    [Serializable]
    public abstract class Unit
    {
        protected int posX;
        protected int posY;
        protected int Health;
        protected int Speed;
        protected int Attack;
        protected int AttackRange;
        protected int Faction;
        protected string Symbol;
        protected string name;

        public Unit() { }
        abstract public void NewPos(Direction direction);
        abstract public void combat(Unit u);
        abstract public bool withinRange(Unit u);
        abstract public Unit distance(Unit[] units);
        abstract public bool isDead();
        abstract public string toString();
    }
}
