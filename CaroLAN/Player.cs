using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaroLAN
{
    public class Player
    {
        #region Properties

        public Image Mark { get => mark; set => mark = value; }
        public string Name { get => name; set => name = value; }

        private Image mark;
        private string name;

        #endregion

        #region Initialize

        public Player (string name, Image mark)
        {
            Name = name;
            Mark = mark;
        }

        #endregion

        #region Methods
        #endregion
    }
}
