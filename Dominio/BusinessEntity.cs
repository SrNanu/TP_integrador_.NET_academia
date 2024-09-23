using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class BusinessEntity
    {
        private int _id;
        private States _State;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int State
        {
            get { return _id; }
            set { _id = value; }
        }
        BusinessEntity() { }

    }
}
