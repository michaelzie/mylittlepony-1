﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittlePony
{
    class Player
    {
        public int _id;
        public string _name;

        public Player(string name, int ID)
        {
            this.setName(name);
            this.setID(ID);
        }

        public string getName()
        {
            return this._name;
        }

        public void setName(string name)
        {
            this._name = name;
        }

        public int getID()
        {
            return this._id;
        }

        public void setID(int ID)
        {
            this._id = ID;
        }
    }
}

