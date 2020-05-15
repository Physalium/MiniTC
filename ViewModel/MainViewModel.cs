using System.Windows.Input;
using MiniTC.Model.Commands;
using MiniTC.View;
using MiniTC.ViewModel.Base;

namespace MiniTC.ViewModel
{
    internal class MainViewModel : BaseViewModel
    {
        #region Properties

        private static readonly Model.FileOperationService fileOperationService = new Model.FileOperationService();
        private static readonly Model.FileTreeService fileTreeService = new Model.FileTreeService();

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
                TCPanelViewModel nonActive = (LeftPanel == ActivePanel) ? RightPanel : LeftPanel;
                nonActive.SelectedItem = null;

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
                    TCPanelViewModel nonActive = (LeftPanel == ActivePanel) ? RightPanel : LeftPanel;
                    copy = new RelayCommand(
                        execute =>
                        {
                            System.Console.WriteLine(ActivePanel.Path);
                            fileOperationService.ExecuteOperationByName("Copy",
                            ActivePanel.SelectedItem.Path, nonActive.Path);
                            LeftPanel.RefreshPanel();
                            RightPanel.RefreshPanel();
                        },
                        canExecute =>
                        {
                            return fileOperationService.canExecuteOperationByName("Copy",
                                ActivePanel.SelectedItem.Path, nonActive.Path);
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
            activePanel = leftPanel;
        }
        #endregion




    }
}