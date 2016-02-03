using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MetadataRename {
    class FileHandler {
        public static bool ApplyTags(List<FileInfo> files) {
            try {
                if (files != null && files.Count > 0) {
                    foreach (FileInfo file in files) {
                        TagLib.File tagFile = TagLib.File.Create(file.FullName);
                        tagFile.Tag.Title = Util.FileName(file.Name);
                        tagFile.Save();
                    }
                }
                return true;
            } catch (Exception ex) {
                ErrorHandler.LogError(ex.GetType() + ":\n" + ex.Message, false);
            }
            return false;
        }
    }
}
