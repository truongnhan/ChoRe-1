using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoReApp.Component
{
    public class Item
    {
        public enum Rank {}
        private string _code;
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private int _price;

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        private Location _location;

        public Location Location
        {
            get { return _location; }
            set { _location = value; }
        }
        private string _image;

        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
        private DateTime _expiredTime;

        public DateTime ExpiredTime
        {
            get { return _expiredTime; }
            set { _expiredTime = value; }
        }
        private Rank _rank;

        public Rank Score
        {
            get { return _rank; }
            set { _rank = value; }
        }
        private Comment _com;

        public Comment CommentList
        {
            get { return _com; }
            set { _com = value; }
        }

    }
}
