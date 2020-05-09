using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniTC.Model;
using MiniTC.ViewModel.Base;

namespace MiniTC.ViewModel
{
    class MainViewModel : BaseViewModel
    {
        #region Properties
        private readonly Model.MiniTC miniTC = new Model.MiniTC();

        private TCPanelViewModel leftPanel;
        private TCPanelViewModel rightPanel;

        internal TCPanelViewModel LeftPanel { get => leftPanel; set => leftPanel = value; }
        internal TCPanelViewModel RightPanel { get => rightPanel; set => rightPanel = value; }


        #endregion
    }
}
