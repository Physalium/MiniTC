using System.Windows;
using System.Windows.Input;
using MiniTC.Model.Commands;
using MiniTC.View;
using MiniTC.ViewModel.Base;

namespace MiniTC.ViewModel
{
    internal class MainViewModel : BaseViewModel
    {
        #region Properties

        internal static readonly Model.FileOperationService fileOperationService = new Model.FileOperationService();
        internal static readonly Model.FileTreeService fileTreeService = new Model.FileTreeService();

        private TCPanelViewModel leftPanel;
        private TCPanelViewModel rightPanel;

        public TCPanelViewModel LeftPanel
        {
            get { return leftPanel; }
        }

        private TCPanelViewModel activePanel;
        internal TCPanelViewModel ActivePanel
        {
            get => activePanel; set
            {
                activePanel = value;
                onPropertyChanged(nameof(ActivePanel));
                if (leftPanel==activePanel)
                {
                    NotActivePanel = rightPanel;
                }
                if (rightPanel == activePanel)
                {
                    NotActivePanel = leftPanel;
                }

            }
        }

        private TCPanelViewModel notActivePanel;
        internal TCPanelViewModel NotActivePanel
        {
            get => notActivePanel; set
            {
                notActivePanel = value;
                onPropertyChanged(nameof(NotActivePanel));
               

            }
        }
        public TCPanelViewModel RightPanel
        {
            get { return rightPanel; }
        }

        private ICommand copy;
        public ICommand Copy
        {

            get
            {
                
                if (copy == null)
                {
                    copy = new RelayCommand(
                        execute =>
                        {
                            System.Console.WriteLine(ActivePanel.Path);
                            fileOperationService.ExecuteOperationByName("Copy",
                            ActivePanel.SelectedItem.Path, NotActivePanel.Path);
                            LeftPanel.RefreshPanel();
                            RightPanel.RefreshPanel();
                        },
                        canExecute =>
                        {
                            if (ActivePanel.SelectedItem is null) return false;
                            return fileOperationService.canExecuteOperationByName("Copy",
                                ActivePanel.SelectedItem.Path, NotActivePanel.Path);
                        });
                }
                return copy;
            }
            set => copy = value;

        }






        #endregion Properties
        #region Constructor

        public MainViewModel()
        {
            fileOperationService.AddCommand(new Copy());
            leftPanel = new TCPanelViewModel(fileTreeService, this);
            rightPanel = new TCPanelViewModel(fileTreeService, this);
            ActivePanel = leftPanel;
            NotActivePanel = rightPanel;
        }
        #endregion




    }
}