using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pintApp2
{
    public class Player
    {
        private int     _ID;
        private string  _name;
        private int     _bullets;
        private bool    _isRed;
        private bool    _enabaled;

        public Player(int Id=0, string name="", int bullets=0, bool isRed=false, bool isEnabaled=false)
        {
            _ID = Id;
            _name = name;
            _bullets = bullets;
            _isRed = isRed;
            _enabaled = isEnabaled;
        }

        public override string ToString()
        {
            return (_enabaled?"+ ":"  ") + _ID.ToString() + ") " + _name + " - " + (_isRed ? "Red" : "Blue") + " :: " + _bullets.ToString();
        }

        public bool Enabaled
        {
            get { return _enabaled; }
            set { _enabaled = value; }
        }

        public bool IsRed
        {
            get { return _isRed; }
            set { _isRed = value; }
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public int Bullets
        {
            get { return _bullets; }
            set { _bullets = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
