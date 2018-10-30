using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_18005615
{
    [Serializable]
    public abstract class Building
    {
        protected int posX;
        protected int posY;
        protected int Health;
        protected int Faction;
        protected string Symbol;

        public Building() { }
        abstract public bool isDead();
        abstract public string toString();
    }
}
