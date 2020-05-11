using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniTC.Properties;
using MiniTC.ViewModel.Base;
using MiniTC.ViewModel.FileInfo;

namespace MiniTC.ViewModel
{
    using R = Properties.Resources;
    internal class TCPanelViewModel : BaseViewModel
    {
        private readonly Model.FileTreeService fileTreeService;
        #region Properties
        private string path;

        public string Path
        {
            get { return path; }
            set
            {
                path = value;
                onPropertyChanged(nameof(Path));
            }
        }

        private string selectedDrive;

        public string SelectedDrive
        {
            get { return selectedDrive; }
            set { selectedDrive = value;
                onPropertyChanged(nameof(SelectedDrive));
            }
        }


        private BindingList<String> drives;

        public BindingList<String> Drives
        {
            get { return drives; }
            set
            {
                drives = value;
                onPropertyChanged(nameof(Drives));
            }
        }

        private BindingList<ListItemBase> contents;

        public BindingList<ListItemBase> Contents
        {
            get { return contents; }
            set
            {
                contents = value;
                onPropertyChanged(nameof(Contents));
            }
        }
        private ListItemBase selectedItem;

        public ListItemBase SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                onPropertyChanged(nameof(SelectedItem));
            }
        }
        #region Labels
        private String pathLabel;

        public String PathLabel
        {
            get { return pathLabel; }
            set
            {
                pathLabel = value;
            }
        }
        private String driveLabel;

        public String DriveLabel
        {
            get { return driveLabel; }
            set
            {
                driveLabel = value;
            }
        }
        #endregion

        #endregion
        #region Constructor
        internal TCPanelViewModel(Model.FileTreeService modelInstance)
        {
            fileTreeService = modelInstance;
            DriveLabel = R.DriveLabel;
            PathLabel = R.PathLabel;
            Drives = new BindingList<string>(fileTreeService.GetDrives());
            RefreshPanel(Drives[0]);
        }
        #endregion

        #region Methods
        public void RefreshPanel(string currentPath)
        {
            SelectedDrive = Drives[0]; // do implementacji
            Path = currentPath;
            Contents = BuildFileTree();
        }

        public BindingList<ListItemBase> BuildFileTree()
        {
            var temp = new BindingList<ListItemBase>();
            foreach(var dir in fileTreeService.GetDirectories(Path))
            {
                temp.Add(new Directory { Name = dir ,Path=Path+dir});
            }
            return temp;
        }
        #endregion

    }
}
