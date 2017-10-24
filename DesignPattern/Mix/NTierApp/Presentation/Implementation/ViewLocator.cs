using DesignPattern.Mix.NTierApp.Common;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.Implementation
{
    public class ViewLocator: ServiceLocator<ICommandResult, IView>
    {

    }
}
