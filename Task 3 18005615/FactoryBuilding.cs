﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_18005615
{
    [Serializable]
    class FactoryBuilding : Building
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

        private int unitType;

        public int UnitType
        {
            get { return unitType; }
            set { unitType = value; }
        }

        private int gameTickPerProduction;

        public int GameTickPerProduction
        {
            get { return gameTickPerProduction; }
            set { gameTickPerProduction = value; }
        }

        private int spawnPointX;

        public int SpawnPointX
        {
            get { return spawnPointX; }
            set { spawnPointX = value; }
        }

        private int spawnPointY;

        public int SpawnPointY
        {
            get { return spawnPointY; }
            set { spawnPointY = value; }
        }
        public FactoryBuilding(int X_position, int Y_position, int Health, int Faction1, string Symbol1, int unitType1, int productionRate, int spawnX, int spawnY) 
        {
            PosX = X_position;
            PosY = Y_position;
            health = Health;
            faction = Faction1;
            symbol = Symbol1;
            UnitType = unitType1;
            GameTickPerProduction = productionRate;
            SpawnPointX = spawnX;
            spawnPointY = spawnY;
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
            return "Factory Building: " + "\r\nX Position: " + PosX + "\r\nY Position: " + PosY + "\r\nHealth: " + Health + "\r\nFaction " + Faction + "\r\nSymbol: " + Symbol + "\r\nUnit Type: " + UnitType + "\r\nGame Ticks per production: " + GameTickPerProduction + "\r\nSpawn point X: " + SpawnPointX + "\r\nSpawn point X: " + SpawnPointY;
        }

        public Unit Spawner(int maxX, int maxY, int faction) 
        {
            Random r = new Random();
            MeeleeUnit M = new MeeleeUnit(r.Next(0, maxX), r.Next(0, maxY), r.Next(5, 10) * 10, r.Next(5, 20), 1, 1, faction, "M", "Knight");
            return M;
        }
    }
}
