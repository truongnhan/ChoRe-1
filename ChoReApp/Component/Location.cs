using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoReApp.Component
{
    public struct Location
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private double _x;

        public double X
        {
            get { return _x; }
            set { _x = value; }
        }
        private double _y;

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

    }
}
