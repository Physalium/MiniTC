using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniTC.Model;
using MiniTC.ViewModel.Base;

namespace MiniTC.ViewModel
{
    internal class MainViewModel : BaseViewModel
    {
        #region Properties
        private static readonly Model.MiniTC miniTC = new Model.MiniTC();

        private TCPanelViewModel leftPanel = new TCPanelViewModel(miniTC);
        private TCPanelViewModel rightPanel = new TCPanelViewModel(miniTC);

        public TCPanelViewModel LeftPanel
        {
            get { return leftPanel; }

        }
        public TCPanelViewModel RightPanel
        {
            get { return rightPanel; }

        }


        #endregion
    }
}
