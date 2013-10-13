using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoReApp.Component
{
    public struct Comment
    {
        private string _idUser;

        public string IdUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }
        private string _content;

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
    }
}
