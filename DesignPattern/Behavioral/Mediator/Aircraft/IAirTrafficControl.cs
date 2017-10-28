namespace DesignPattern.Behavioral.Mediator.Aircraft
{
    public interface IAirTrafficControl
    {
        void ReceiveAircraftLocation(Aircraft location);
        void RegisterAircraftUnderGuidance(Aircraft aircraft);
    }
}