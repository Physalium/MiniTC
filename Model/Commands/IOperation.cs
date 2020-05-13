namespace MiniTC.Model.Commands
{
    public interface IOperation
    {
        string Name { get; }

        bool Execute(string sourcePath, string targetPath);
    }
}