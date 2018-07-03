using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace Training_Graphics
{
    public class Display : Form {

        public Display(string name, int width, int height)
        {
            this.MaximizeBox = false;
            this.Text = name;
            this.ClientSize = new Size(width, height);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }



    }
}
