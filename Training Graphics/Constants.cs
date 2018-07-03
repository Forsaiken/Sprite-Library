using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Training_Graphics {
    public static class Constants {
        public static String ImagePath(String file) {
            return Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),"Images", file);
        }
    }
}
           
