using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Training_Graphics
{
    public class App
    {



        static Display Window = new Display("Sprite Avaliation", 800, 600);
        static TestPanel testPanel;

        public App() {

        }

        [STAThread]
        public static void Main()
        {

            Settings.WIDTH = Window.ClientSize.Width;
            Settings.HEIGHT = Window.ClientSize.Height;

            Application.EnableVisualStyles();
            Window.BackColor = Color.White;
            testPanel = new TestPanel();
            Window.Controls.Add(testPanel);
            testPanel.Visible = true;
            Application.Run(Window);



        }
    }
}
