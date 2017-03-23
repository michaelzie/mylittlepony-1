using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittlePony
{
    class Property
    {
        private int _value;
        private string _unit;
        private bool _higherValueWins;

        public Property(int value, string unit, bool higherValueWins)
        {
            this.setValue(value);
            this.setUnit(unit);
            this.setHigherValueWins(higherValueWins);
        }

        public int getValue()
        {
            return this._value;
        }

        public void setValue(int value)
        {
            this._value = value;
        }

        public string getUnit()
        {
            return this._unit;
        }

        public void setUnit(string unit)
        {
            this._unit = unit;
        }

        public bool getHigherValueWins()
        {
            return this._higherValueWins;
        }

        public void setHigherValueWins(bool higherValueWins)
        {
            this._higherValueWins = higherValueWins;
        }
    }
}
