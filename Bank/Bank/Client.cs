using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Client
    {
        private String _name, _surname;
        private int _id;

        public String Name {
            get => _name;
            set => _name=value;
        }
        public String Surname
        {
            get => _surname;
            set => _surname = value;
        }
        public int ID
        {
            get => _id;
            set => _id = value;
        }
        public Client(String Name, String Surname, int id)
        {
            _name = Name;
            _surname = Surname;
            _id = id;
        }
    }
}
