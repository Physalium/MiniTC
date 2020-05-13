namespace MiniTC.ViewModel.FileInfo
{
    internal class DirItem : ListItemBase
    {
        public override string ToString()
        {
            return MiniTC.Properties.Resources.DirPrefix + $" {Name}";
        }
    }
}