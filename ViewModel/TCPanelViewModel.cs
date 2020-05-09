using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniTC.ViewModel.Base;

namespace MiniTC.ViewModel
{

    class TCPanelViewModel : BaseViewModel
    {
        #region Properties
        private string path;

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        private string drive;

        public string Drive
        {
            get { return drive; }
            set { drive = value; }
        }

        private BindingList<String> contents;

        public BindingList<String> Contents
        {
            get { return contents; }
            set { contents = value; }
        }


        #endregion


    }
}
