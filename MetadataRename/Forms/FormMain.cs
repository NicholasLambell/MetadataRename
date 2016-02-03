using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MetadataRename {
    public partial class FormMain : Form {
        private string[] _args;
        private List<FileInfo> _files;
        //private FilterList _filterList;
        private ListViewColumnSorter lstSorter;


        public FormMain() {
            InitializeComponent();

            //Initialize files list
            _files = new List<FileInfo>();

            lstSorter = new ListViewColumnSorter();
            lstFiles.ListViewItemSorter = lstSorter;

            //Initialize list view with columns
            lstFiles.Columns.Add("File", -2);
            lstFiles.Columns.Add("Path", -2);

            //Get command line arguments and process them
            _args = Environment.GetCommandLineArgs();
            ProcessArgs();
        }

        #region Misc Methods
        private void ProcessArgs() {
            foreach (string arg in _args) {
                if (File.Exists(arg) && Util.FileName(arg) != Util.FileName(Util.GetExe())) {
                    _files.Add(new FileInfo(arg));
                }
            }
            //Refresh list view
            WriteList();
        }

        private void WriteList() {
            //Clear existing items
            lstFiles.Items.Clear();

            foreach (FileInfo file in _files) {
                //Create list view item
                ListViewItem item = new ListViewItem(file.Name);
                item.Checked = true;

                //Create list view sub item
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, file.DirectoryName);
                item.SubItems.Add(subItem);

                //Add item to list;
                lstFiles.Items.Add(item);
            }

            //Refresh column sizes
            lstFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //Sort items by file name column
            lstSorter.SortColumn = 0;
            lstSorter.Order = SortOrder.Ascending;
            lstFiles.Sort();
        }

        private bool AddToList(FileInfo file) {
            if (_files.FindIndex(item => item.FullName == file.FullName) < 0) {
                _files.Add(file);
                return true;
            }
            return false;
        }

        private void AddItem(string path) {
            if (!String.IsNullOrEmpty(path) && File.Exists(path)) {
                if (!AddToList(new FileInfo(path))) {
                    ErrorHandler.LogError("Failed to add file (is it already in the list?):\n" + path, true);
                    return;
                }
                WriteList();
            }
        }

        private void AddItems(List<string> paths) {
            if (paths != null && paths.Count > 0) {
                List<string> failPaths = new List<string>();

                //Add files to list and handle error returns
                foreach (string path in paths) {
                    if (!String.IsNullOrEmpty(path) && File.Exists(path)) {
                        if (!AddToList(new FileInfo(path))) {
                            failPaths.Add(path);
                        }
                    }
                }

                //Generate error message
                if (failPaths.Count > 0) {
                    ErrorHandler.LogError("Failed to add files (are they already in the list?):\n" + Util.MakeStringList(failPaths), true);

                    if (failPaths.Count == paths.Count) {
                        return;
                    }
                }

                WriteList();
            }
        }

        private void RefreshItems() {
            if (_files != null && _files.Count > 0) {
                foreach (FileInfo file in _files) {
                    file.Refresh();
                }
                WriteList();
            }
        }
        #endregion

        #region GUI Event Handlers
        private void btnApply_Click(object sender, EventArgs e) {
            if (_files.Count > 0) {
                List<FileInfo> fileList = new List<FileInfo>();

                //Add all checked items to file list
                for (int i = 0; i < lstFiles.Items.Count; i++) {
                    if (lstFiles.Items[i].Checked) {
                        fileList.Add(_files[i]);
                    }
                    
                    if (FileHandler.ApplyTags(fileList)) {
                        MessageBox.Show("All file metadata successfully applied");
                    } else {
                        MessageBox.Show("Oops! Something went wrong, some of the files may not have their tag set.\nSome of the files may be an invalid type.", "Error!");
                    }
                }
            } else {
                MessageBox.Show("Please select at least one file before applying changes", "Error!");
            }
        }

        #region list box
        private void lstFiles_DragDrop(object sender, DragEventArgs e) {
            //Get collection of files dropped to list
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            //Add files to file list
            AddItems(new List<string>(files));
        }

        private void lstFiles_DragEnter(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Copy;
        }

        private void lstFiles_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Delete) {
                foreach (ListViewItem item in lstFiles.Items) {
                    if (item.Selected) {
                        _files.RemoveAt(item.Index);
                        item.Remove();
                    }
                }
            }
            WriteList();
        }
        #endregion
        #region menu strip
        private void mnuFileOpen_Click(object sender, EventArgs e) {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "All Files (*.*)|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.Multiselect = true;

            if (fileDialog.ShowDialog() == DialogResult.OK) {
                AddItems(new List<string>(fileDialog.FileNames));
            }
        }

        private void mnuSelAll_Click(object sender, EventArgs e) {
            foreach (ListViewItem item in lstFiles.Items) {
                item.Checked = true;
            }
        }

        private void mnuDesel_Click(object sender, EventArgs e) {
            foreach (ListViewItem item in lstFiles.Items) {
                item.Checked = false;
            }
        }

        private void mnuInvSel_Click(object sender, EventArgs e) {
            foreach (ListViewItem item in lstFiles.Items) {
                item.Checked = !item.Checked;
            }
        }
        #endregion
        #endregion
    }
}
