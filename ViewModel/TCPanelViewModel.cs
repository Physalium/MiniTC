using System;
using System.ComponentModel;
using MiniTC.View;
using MiniTC.ViewModel.Base;
using MiniTC.ViewModel.FileInfo;
using MiniTC.ViewModel.FileTreeCommands;
using MiniTC.ViewModel.ListItems;

namespace MiniTC.ViewModel
{
    using R = Properties.Resources;

    internal class TCPanelViewModel : BaseViewModel
    {
        private readonly Model.FileTreeService fileTreeService;
        private readonly MainViewModel main;
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
            set
            {
                selectedDrive = value;
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

        #endregion Labels

        #endregion Properties

        #region Constructor

        internal TCPanelViewModel(Model.FileTreeService treeService, MainViewModel mainViewModel)
        {
            main = mainViewModel;
            fileTreeService = treeService;
            DriveLabel = R.DriveLabel;
            PathLabel = R.PathLabel;
            Drives = new BindingList<string>(fileTreeService.GetDrives());
            Path = Drives[0];
            RefreshPanel();
        }

        #endregion Constructor

        #region Methods
        public void switchActivePanel(object sender, System.EventArgs e)
        {
            main.ActivePanel = this;
        }

        public void FileEnter(object sender, System.EventArgs e)
        {
            SelectedItem.Command.Execute(this);
        }

        public void PathEnterPress(object sender, System.EventArgs e)
        {
            // walidacja tutaj
            RefreshPanel();
        }

        public void DriveChanged(object sender, System.EventArgs e)
        {
            Path = SelectedDrive;
            // walidacja tutaj
            RefreshPanel();
        }

        public void RefreshPanel()
        {
            SelectedDrive = Path.Substring(0, Path.IndexOf(System.IO.Path.DirectorySeparatorChar) + 1);
            Contents = BuildFileTree();
            SelectedItem = Contents[0];
        }

        public BindingList<ListItemBase> BuildFileTree()
        {
            var fileTree = new BindingList<ListItemBase>();
            if (SelectedDrive != Path)
            {
                var parentdir = fileTreeService.GetParentDir(this.Path);
                fileTree.Add(new ParentDirItem
                {
                    Name = R.ParentDir,
                    Path = parentdir,
                    Command = OpenDir.Open
                });
            }
            foreach (var dir in fileTreeService.GetDirectories(Path))
            {
                fileTree.Add(new DirItem
                {
                    Name = dir,
                    Path = Path + System.IO.Path.DirectorySeparatorChar + dir,
                    Command = OpenDir.Open
                });
            }
            foreach (var dir in fileTreeService.GetFiles(Path))
            {
                fileTree.Add(new FileItem
                {
                    Name = dir,
                    Path = Path + System.IO.Path.DirectorySeparatorChar + dir,
                    Command = RunFile.Run
                });
            }
            return fileTree;
        }

        #endregion Methods
    }
}