namespace DesignPattern.Mix.Family.Common
{
    class NullChainElement : ChainElement
    {
        public override T As<T>(T defaultValue)
        {
            return defaultValue;
        }
    }

}
