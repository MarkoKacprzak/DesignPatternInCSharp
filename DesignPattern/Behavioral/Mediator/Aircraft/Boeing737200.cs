namespace DesignPattern.Behavioral.Mediator.Aircraft
{
    public class Boeing737200 : Aircraft
    {
        public Boeing737200(string callSign, IAirTrafficControl atc) : base(callSign, atc)
        {
        }

        public override int Ceiling
        {
            get { return 35000; }
        }
    }
}