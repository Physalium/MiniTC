using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniTC.Model.Commands;
using MiniTC.ViewModel.Base;

namespace MiniTC.ViewModel.FileInfo
{
    public abstract class ListItemBase : BaseViewModel
    {

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                onPropertyChanged(nameof(Name));
            }
        }

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

        abstract internal ICommand Open { get; }

    }
}
