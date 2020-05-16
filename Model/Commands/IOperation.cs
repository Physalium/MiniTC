namespace MiniTC.Model.Commands
{
    public interface IOperation
    {
        string Name { get; }

        void Execute(string sourcePath, string targetPath);

        bool canExecute(string sourcePath, string targetPath);
    }
}