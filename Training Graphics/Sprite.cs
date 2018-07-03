using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Training_Graphics
{
    public class Sprite {

        public enum Align {
            CENTER,
            LEFT_TO_RIGHT,
            RIGHT_TO_LEFT
        };

        public enum Shape {
            RECT,
            POLYGON
        }

        // BASIC PROPERTIES

        public Point[] Location { set; get; } = { new Point(0, 0), new Point(0, 0), new Point(0, 0) };
        public Size[] Size { set; get; } = { new Size(0, 0), new Size(0, 0), new Size(0, 0) };
        public int[] Alpha { set; get; } = { 0, 255, 255 };

        // ANIMATION PROPERTIES

        public bool Animation { set; get; }
        private float spdX, spdY, spdWidth, spdHeight, spdAlpha;
        private int[] cX = {0,0}, cY = {0,0}, cW = {0,0}, cH = {0,0}, cA = {0,0};

        // GRAPHIC PROPERTIES

        private Graphics g2d;

        // IMAGE PROPERTIES

        private Graphics gImg;
        public Image Image { set; get; }



        // STRING PROPERTIES

        public Align StringFormat { set; get; }

        // COLOR PROPERTIES

        public Brush Gradient;
        public Color Color { set; get; }


        public void draw(PaintEventArgs e) {

            g2d = e.Graphics;

            if (Animation) {

                int ct = 0;

                if (this.cX[0] < this.cX[1]) {
                    Location[1].X = (int) (Location[0].X + (cX[0] + 1) * spdX);
                    cX[0]++;
                } else
                    ct += 1;

                if (this.cY[0] < this.cY[1]) {
                    Location[1].Y = (int) (Location[0].Y + (cY[0] + 1) * spdY);
                    cY[0]++;
                } else
                    ct += 1;

                if (this.cW[0] < this.cW[1]) {
                    Size[1].Width = (int) (Size[0].Width + (cW[0] + 1) * spdWidth);
                    cW[0]++;
                } else
                    ct += 1;

                if (this.cH[0] < this.cH[1]) {
                    Size[1].Height = (int) (Size[0].Height + (cH[0] + 1) * spdHeight);
                    cH[0]++;
                } else
                    ct += 1;

                if (this.cA[0] < this.cA[1]) {
                    if (this.Alpha[1] + spdAlpha > 0f && this.Alpha[1] + spdAlpha < 255)
                        this.Alpha[1] += (int) spdAlpha;
                    else
                        this.Alpha[1] = this.Alpha[2];
                    cA[0]++;
                } else
                    ct += 1;

                if (ct == 5) {
                    Animation = false;
                    this.resetCountAnimation();

                }
            }

            if (Image != null) {
                g2d.DrawImage(Image, Location[1].X, Location[1].Y);
            }

                g2d.FillRectangle(new SolidBrush(Color), new Rectangle(Location[1].X, Location[1].Y, Size[1].Width, Size[1].Height));
        }

        // SETS - IMAGE

        public void setImage(String path) {

        }

        // SETS - COLORS

        public void setRadialGradient() {

        }

        // SETS - ANIMATION

        public void setMotionAnimation(float posX, float posY, float width, float height, float alpha) {
            if (posX != 0) {
                spdX = (Location[2].X - Location[0].X) / (posX * Settings.FPS);
                cX[1] = (int) (Settings.FPS * posX);
            } else {
                cX[1] = 0;
            }
            if (posY != 0) {
                spdY = (Location[2].Y - Location[0].Y) / (posY * Settings.FPS);
                cY[1] = (int) (Settings.FPS * posY);
            } else {
                cY[1] = 0;
            }
            if (width != 0) {
                spdWidth = (Size[2].Width - Size[0].Width) / (width * Settings.FPS);
                cW[1] = (int) (Settings.FPS * width);
            } else {
                cW[1] = 0;
            }
            if (height != 0) {
                spdHeight = (Size[2].Height - Size[0].Height) / (height * Settings.FPS);
                cH[1] = (int) (Settings.FPS * height);
            } else {
                cH[1] = 0;
            }
            if (alpha != 0) {
                spdAlpha = (Alpha[2] - this.Alpha[0]) / (alpha * Settings.FPS);
                cA[1] = (int) (Settings.FPS * alpha);
            } else {
                cA[1] = 0;
            }
        }

        public void resetCountAnimation() {
            this.cX[0] = 0;
            this.cY[0] = 0;
            this.cW[0] = 0;
            this.cH[0] = 0;
            this.cA[0] = 0;
        }



    }
}
