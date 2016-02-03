using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MetadataRename {
    class FilterFileHandler {
        //public static FilterList Load(string fileName) {
        //    try {
        //        List<DefaultFilters> defaultFilters = new List<DefaultFilters>();
        //        List<string[]> customFilters = new List<string[]>();

        //        //Load xml document
        //        XDocument document = XDocument.Load(fileName);

        //        //Populate defaultFilters list
        //        defaultFilters =
        //            (from filter in document.Root.Element("DefaultFilters").Elements("DFilter")
        //            select (DefaultFilters)((int)filter)).ToList();

        //        //Populate customFilters list
        //        customFilters =
        //            (from filter in document.Root.Element("CustomFilters").Elements("CFilter")
        //             select new string[] {
        //                (string)filter.Element("Input"),
        //                (string)filter.Element("Output")
        //            }).ToList();

        //        return new FilterList(defaultFilters, customFilters);
        //    } catch {
        //    }
        //    return null;
        //}

        //public static bool Save(FilterList filterList) {
        //    if (filterList != null) {
        //        try {
        //            //Show file dialog
        //            SaveFileDialog fileDialog = new SaveFileDialog();
        //            fileDialog.InitialDirectory = Util.GetPath();
        //            fileDialog.FileName = "Filters";
        //            fileDialog.DefaultExt = "xml";
        //            fileDialog.Filter = "XML Files (*.xml)|*.xml";
        //            fileDialog.FilterIndex = 0;

        //            if (fileDialog.ShowDialog() == DialogResult.OK) {
        //                XElement filterListEl = new XElement("FilterList");

        //                //Process Default Filters
        //                if (filterList.defaultFilters.Count > 0) {
        //                    XElement defaultFilters = new XElement("DefaultFilters");
        //                    foreach (DefaultFilters filter in filterList.defaultFilters) {
        //                        defaultFilters.Add(new XElement("DFilter", (int)filter));
        //                    }
        //                    filterListEl.Add(defaultFilters);
        //                }

        //                //Process Custom Filters
        //                if (filterList.customFilters.Count > 0) {
        //                    XElement customFilters = new XElement("CustomFilters");
        //                    foreach (string[] filter in filterList.customFilters) {
        //                        customFilters.Add(new XElement("CFilter",
        //                            new XElement("Input", filter[0]),
        //                            new XElement("Output", filter[1])
        //                        ));
        //                    }
        //                    filterListEl.Add(customFilters);
        //                }

        //                //Save document
        //                XDocument document = new XDocument(filterListEl);
        //                document.Save(fileDialog.FileName);
        //            }
        //            return true;
        //        } catch {
        //        }
        //    }
        //    return false;
        //}
    }
}
