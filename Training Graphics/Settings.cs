using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Graphics {
    public static class Settings {

        public static Display window;
        public static String LANGUAGE = "en-us";
        public static int TWH;
        public static int widthMonitor;
        public static int heightMonitor;
        public static int widthResolution = 1920;
        public static int heightResolution = 1080;
        public static int WIDTH;
        public static int HEIGHT;
        public static bool FULL_SCREEN = true;
        public static bool SWITCH = false;
        public static bool SMOOTH = true;
        public static int FPS = 60;
        public static float FPS1000 = 16.66666666667f;

        public static int cvtFont(int size) {
            int converted = (int)(size * ((double)HEIGHT/(double)1080));
            return converted;
        }

        public static int cvtPosX(int posX) {
            int converted = (int)(posX * ((double)WIDTH/(double)1920));
            return converted;
        }

        public static int cvtPosY(int posY) {
            int converted = (int)(posY * ((double)HEIGHT/1080));
            return converted;
        }

        public static int cvtWidth(int width) {
            int converted = (int)(width * ((double)WIDTH/(double)1920));
            return converted;
        }

        public static int cvtHeight(int height) {
            int converted = (int)(height * ((float)HEIGHT/(float)1080));
            return converted;
        }

    }
}
