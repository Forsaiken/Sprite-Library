using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace Training_Graphics {
    public class TestPanel : Panel {

        private Thread t;
        private static TestPanel selfPanel;
        private Sprite graphic, graphic2, graphic3;

        public TestPanel() {

            selfPanel = this;

            this.DoubleBuffered = true;
            this.Location = new Point(0, 0);
            this.Size = new Size(800, 600);
            this.BackColor = Color.Aqua;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TestPanel_Paint);

            graphic = new Sprite();
            graphic.Color = Color.BlueViolet;

            graphic2 = new Sprite();
            graphic2.Color = Color.ForestGreen;

            graphic3 = new Sprite();
            graphic3.Image = Image.FromFile(Constants.ImagePath("test.png"));

            t = new Thread(new ThreadStart(ActionListener));
            t.Start();

        }

        private void TestPanel_Paint(object sender, PaintEventArgs e) {
            graphic2.draw(e);
            graphic.draw(e);
            graphic3.draw(e);
            graphic.Size[1].Width++;
            graphic.Size[1].Height++;
            graphic2.Size[1].Width += 2;
            graphic2.Size[1].Height += 2;

        }

        public static void ActionListener() {
            while (true) {
                selfPanel.Invalidate();
                Thread.Sleep(16);
            }
        }

    }
}
