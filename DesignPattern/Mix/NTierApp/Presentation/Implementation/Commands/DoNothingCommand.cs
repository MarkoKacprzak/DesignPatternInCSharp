using DesignPattern.Mix.NTierApp.Presentation.Implementation.CommandResults;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.Implementation.Commands
{
    internal class DoNothingCommand : ICommand
    {
        public ICommandResult Execute()
            => new NoResult();
    }
}
