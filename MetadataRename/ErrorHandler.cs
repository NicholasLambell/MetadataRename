using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetadataRename {
    class ErrorHandler {
        public static void LogError(string error, bool showDialog) {
            //Log to file code here

            if (showDialog) {
                MessageBox.Show(error, "Error!");
            }
        }
    }
}
