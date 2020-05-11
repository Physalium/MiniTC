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
    class Directory : ListItemBase
    {
       

        private ICommand open;
        internal override ICommand Open
        {
            get
            {
                return open ?? (open = new Model.Commands.Open());
            }
        }

        public override string ToString()
        {
            return $"<D> {Name}";
        }
    }
}
