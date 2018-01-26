using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorPicker
{
    class ColorTile
    {
        private string colorName;


        #region Accessors
        public string ColorName
        {
            get
            {
                return colorName;
            }

            set
            {
                colorName = value;
            }
        }

        #endregion
        public ColorTile(string n)
        {
            ColorName = n;
        }


    }
}
