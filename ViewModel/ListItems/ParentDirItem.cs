using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniTC.Model.Commands;
using MiniTC.ViewModel.FileInfo;

namespace MiniTC.ViewModel.ListItems
{
    class ParentDirItem : ListItemBase
    {

        public override string ToString()
        {
            return Name;
        }
    }
}
