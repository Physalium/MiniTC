using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using MiniTC.Model.Commands;
using MiniTC.ViewModel.Base;

namespace MiniTC.ViewModel.FileInfo
{
    class DirItem : ListItemBase
    {

        public override string ToString()
        {
            return MiniTC.Properties.Resources.DirPrefix+$" {Name}";
        }
    }
}
