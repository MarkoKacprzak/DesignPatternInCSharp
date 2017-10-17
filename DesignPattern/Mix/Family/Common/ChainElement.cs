namespace DesignPattern.Mix.Family.Common
{
    public class ChainElement
    {

        protected readonly ChainElement next;

        private static ChainElement nullValue;

        public ChainElement(ChainElement next)
        {
            this.next = next;
        }

        protected ChainElement() { }

        public virtual T As<T>(T defaultValue) where T : class
        {
            if (this is T)
                return this as T;
            return this.next.As<T>(defaultValue);
        }

        public static ChainElement NullValue
        {
            get
            {
                if (nullValue == null)
                    nullValue = new NullChainElement();
                return nullValue;
            }
        }

        public T Forward<T>(T defaultValue) where T : class
        {
            return this.next.As<T>(defaultValue);
        }
    }

}
    //public class ChainElement
    //{

    //    protected readonly ChainElement next;


    //}

//}
