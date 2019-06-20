using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Transaction
    {
        private int _id, _accnum, _accnum2;
        private float _transamount;

        public int ID
        {
            get => _id;
            set => _id = value;
        }
        public int Accnum
        {
            get => _accnum;
            set => _accnum = value;
        }
        public int Accnum2
        {
            get => _accnum2;
            set => _accnum2 = value;
        }
        public float Transamount
        {
            get => _transamount;
            set => _transamount = value;
        }
        public Transaction(int id , int accnum, int accnum2, float transamount)
        {
            _id = id;
            _accnum = accnum;
            _accnum2 = accnum2;
            _transamount = transamount;
        }
    }
}
