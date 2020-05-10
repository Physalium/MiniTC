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
        private readonly Model.MiniTC miniTC = new Model.MiniTC();

        private TCPanelViewModel leftPanel = new TCPanelViewModel();
        private TCPanelViewModel rightPanel = new TCPanelViewModel();

        public TCPanelViewModel LeftPanel
        {
            get { return leftPanel; }
            set
            {
                leftPanel = value;
                onPropertyChanged(nameof(LeftPanel));
            }
        }
        public TCPanelViewModel RightPanel
        {
            get { return rightPanel; }
            set
            {
                rightPanel = value;
                onPropertyChanged(nameof(RightPanel));
            }
        }


        #endregion
    }
}
