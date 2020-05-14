using MiniTC.ViewModel.Base;

namespace MiniTC.ViewModel.FileTreeCommands
{
    internal static class OpenDir
    {

        private static void open(object param)
        {
            TCPanelViewModel vm = param as TCPanelViewModel;
            vm.Path = vm.SelectedItem.Path;
            vm.RefreshPanel();
        }

        public static RelayCommand Open
        {
            get
            {
                return new RelayCommand(argument => { open(argument); }, argument => true);
            }
        }
    }
}