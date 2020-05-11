using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniTC.Properties;
using MiniTC.ViewModel.Base;

namespace MiniTC.ViewModel
{
    using R = Properties.Resources;
    internal class TCPanelViewModel : BaseViewModel
    {
        private readonly Model.MiniTC miniTC;
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
            set { selectedDrive = value; }
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

        private BindingList<String> contents;

        public BindingList<String> Contents
        {
            get { return contents; }
            set
            {
                contents = value;
                onPropertyChanged(nameof(Contents));
            }
        }
        private String selectedItem;

        public String SelectedItem
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
        internal TCPanelViewModel(Model.MiniTC modelInstance)
        {
            miniTC = modelInstance;
            DriveLabel = R.DriveLabel;
            PathLabel = R.PathLabel;
            Drives = new BindingList<string>(miniTC.GetDrives());
        }
        #endregion

    }
}
