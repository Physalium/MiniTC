using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniTC.Model;
using MiniTC.Model.Commands;
using MiniTC.ViewModel.Base;

namespace MiniTC.ViewModel
{
    internal class MainViewModel : BaseViewModel
    {
        #region Properties
        private static readonly Model.FileOperationService fileOperationService = new Model.FileOperationService();
        private static readonly Model.FileTreeService fileTreeService = new Model.FileTreeService();

        private TCPanelViewModel leftPanel = new TCPanelViewModel(fileTreeService);
        private TCPanelViewModel rightPanel = new TCPanelViewModel(fileTreeService);

        public TCPanelViewModel LeftPanel
        {
            get { return leftPanel; }

        }
        public TCPanelViewModel RightPanel
        {
            get { return rightPanel; }

        }

        public MainViewModel()
        {
            fileOperationService.AddCommand(new Copy());
        }


        #endregion
    }
}
