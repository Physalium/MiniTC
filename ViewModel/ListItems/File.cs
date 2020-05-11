using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniTC.Model.Commands;
using MiniTC.ViewModel.Base;

namespace MiniTC.ViewModel.FileInfo
{
    class File : ListItemBase
    {
       
        private ICommand open;
        internal override ICommand Open
        {
            get
            {
                return open ?? (open = new Model.Commands.Run());
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
