using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace MetadataRename {
    class Util {
        #region File Related Methods
        public static string GetPath() {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        public static string GetExe() {
            return System.Reflection.Assembly.GetExecutingAssembly().Location;
        }

        public static string FileName(string input) {
            if (!String.IsNullOrEmpty(input)) {
                string output = Path.GetFileNameWithoutExtension(new FileInfo(input).Name);
                return System.Diagnostics.Debugger.IsAttached ? output.Replace(".vshost", "") : output;
            }
            return input;
        }
        #endregion

        public static string[] SplitWords(string input) {
            if (!String.IsNullOrEmpty(input)) {
                return Regex.Split(input, " ");
            }
            return null;
        }

        public static string Capitalize(string input) {
            if (!String.IsNullOrEmpty(input)) {
                return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input);
            }
            return input;
        }

        public static string MakeStringList(List<string> input) {
            if (input != null && input.Count > 0) {
                return String.Join("\n", input);
            }
            return null;
        }
    }
}
