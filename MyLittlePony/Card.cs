using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittlePony
{
    class Card
    {
        private int _player;
        private string _name;
        private string _id;
        private List<Property> _properties = new List<Property>();

        public Card(int player, string name, string id, List<Property> property)
        {
            this.setPlayer(player);
            this.setName(name);
            this.setID(id);
            this.createProperties();

            this._properties = property;
        }

        private void createProperties(List<Property> properties)
        {
            throw new NotImplementedException();
        }

        public int getPlayer()
        {
            return this._player;
        }

        public void setPlayer(int player)
        {
            this._player = player;
        }

        public string getName()
        {
            return this._name;
        }

        public void setName(string name)
        {
            this._name = name;
        }

        public string getID()
        {
            return this._id;
        }

        public void setID(string ID)
        {
            this._id = ID;
        }

        public void createProperties()
        {
            _properties.Add(new Property(156, "cm", true));
            _properties.Add(new Property(2, "int", true));
            _properties.Add(new Property(70, "km/h", true));
            _properties.Add(new Property(10000, "Euro", true));
        }

        public List<Property> getProperties()
        {
            return _properties;
        }
    }
}
