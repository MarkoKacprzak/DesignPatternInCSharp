using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.Implementation.Commands
{
    internal class DoNothingCommand: ICommand
    {
        public void Execute()
        {
        }
    }
}
