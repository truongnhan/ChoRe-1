using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoReApp.Component
{
    public class Account
    {
        public enum Label { Offical_User, VIP }
        private string _id;
        public string Id 
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private Label _label;
        public Label Level
        {
            get { return _label; }
            set { _label = value; }
        }
        private string _image;

        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
        public void motify()
        {

        }
        public void remove()
        {
        }
    }
}
