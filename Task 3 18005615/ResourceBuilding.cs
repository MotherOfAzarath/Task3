using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_18005615
{
    [Serializable]
    class ResourceBuilding : Building
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

        private string resourceType;

        public string ResourceType
        {
            get { return resourceType; }
            set { resourceType = value; }
        }

        private int resourcePerTick;

        public int ResourcePerTick
        {
            get { return resourcePerTick; }
            set { resourcePerTick = value; }
        }

        private int resourcesRemaining;

        public int ResourcesRemaining
        {
            get { return resourcesRemaining; }
            set { resourcesRemaining = value; }
        }

        public ResourceBuilding(int X_position, int Y_position, int Health, int Faction1, string Symbol1, string resource, int productionRate, int remaining) 
        {
            PosX = X_position;
            PosY = Y_position;
            health = Health;
            faction = Faction1;
            symbol = Symbol1;
            ResourceType = resource;
            ResourcePerTick = productionRate;
            ResourcesRemaining = remaining;
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

        public override string toString()
        {
            return "Resource Building: " + "\r\nX Position: " + PosX + "\r\nY Position: " + PosY + "\r\nHealth: " + Health + "\r\nFaction " + Faction + "\r\nSymbol: " + Symbol + "\r\nResource Type: " + ResourceType + "\r\nResource Per Game Tick: " + ResourcePerTick + "\r\nResources Remaining: " + ResourcesRemaining;
        }

        public void ResourceGenerate() 
        {
            ResourcesRemaining = ResourcesRemaining - resourcePerTick;
        }

    }
}
