namespace DesignPattern.Mix.Family.Common
{
    public class NullHairy : IHairy
    {

        private static IHairy instance;

        public static IHairy Instance
        {
            get
            {
                if (instance == null)
                    instance = new NullHairy();
                return instance;
            }
        }

        public void GrowHair() { }
        
        public void CutHair() { }
    
    }
}
