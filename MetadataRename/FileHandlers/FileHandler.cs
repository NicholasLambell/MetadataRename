using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MetadataRename {
    class FileHandler {
        //public static bool Rename(FileInfo file, string rename) {
        //    if (file != null && file.Exists && !String.IsNullOrEmpty(rename)) {
        //        int iteration = 1;
        //        string fileName = Util.FileName(file.Name);

        //        //Try to get iteration from file name if it's at least 4 chars long
        //        if (fileName != null && fileName.Length >= 4) {
        //            int iterationGet = GetIteration(fileName);
        //            iteration = (iterationGet > iteration) ? iterationGet : iteration;
        //        }

        //        //If the rename string contains the iteration patern eg " (2)" remove it.
        //        if (iteration >= 2) {
        //            Regex regex = new Regex(@" \(\d+\)$");
        //            if (regex.IsMatch(rename)) {
        //                rename = regex.Replace(rename, "");
        //            }
        //        }

        //        //Loop through iterations trying to rename until a value one is found
        //        while (!ApplyRename(file, rename, iteration)) {
        //            iteration++;
        //        }
        //        return true;
        //    }
        //    return false;
        //}
        
        //private static bool ApplyRename(FileInfo file, string rename, int iteration) {
        //    if (file != null && file.Exists && !String.IsNullOrEmpty(rename)) {
        //        try {
        //            //Check iteration and form iteration string
        //            string sIteration = (iteration >= 2) ? String.Format(" ({0})", iteration) : "";
                    
        //            //Try to rename the file
        //            file.MoveTo(file.Directory.FullName + @"\" + rename + sIteration + file.Extension);
        //            return true;

        //        } catch (IOException) { //Triggered if file exists, goes back to while loop above
        //        } catch (Exception ex) {
        //            ErrorHandler.LogError(ex.GetType() + ": " + ex.Message, true);
        //        }
        //    }
        //    return false;
        //}

        //private static int GetIteration(string fileName) {
        //    //If the last characters of the string are "(number)" extract the number
        //    Regex regex = new Regex(@"(?<=\()\d+(?=\)$)");
        //    Match match = regex.Match(fileName);

        //    //Return the extracted number or if empty or not a number return 0
        //    int output;
        //    return (match.Groups[0].Value != String.Empty && Int32.TryParse(match.Groups[0].Value, out output)) ? output : 0;
        //}
    }
}
